Imports nsAlienRFID2
Imports System.ComponentModel
Public Class frmMain

    Private runnersDao As New RunnerDAO
    Private categoryDao As New CategoryDAO
    Private WithEvents reader As New clsReader
    Private WithEvents server As New CAlienServer
    Private runners As New Dictionary(Of String, Runner)
    Private categories As New Dictionary(Of String, Category)
    Private monitor As New clsReaderMonitor
    Private CUSTOM_FORMAT As String = "${TAGIDB}, ${TX}, ${DATE2} ${TIME2}, ${PCWORD}, ${SPEED}, ${RSSI}, ${G2DATA1}, ${FREQ}"
    Private unEnrolledCounter As Integer = 0
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure you want to close this window and stop the race?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            If reader.IsConnected Then
                reader.AutoMode = "OFF"
                reader.Disconnect()
            End If

            e.Cancel = False
            Exit Sub
        End If
        e.Cancel = True
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        runners = runnersDao.getRunnersList()
        categories = categoryDao.getCategoryList()
        refreshCategoryList()
        Me.lblRunnersCount.Text = "Total Runners:   " & runners.Count
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If reader.IsConnected Then
            Try
                Dim tagList As String = reader.TagList
                Dim tagInfos(20000) As TagInfo
                Me.lblTagDetected.Text = ""
                Me.rtbDetected.Clear()

                If tagList <> "Tag List has been cleared!" And tagList <> "(No Tags)" Then

                    Dim count As Int32 = AlienUtils.ParseTextTagList(tagList, tagInfos)
                    Me.lblTagDetected.Text = count & " detected"
                    If count = 1 Then
                        Me.lblTagDetected.Text &= "(" & tagInfos(0).TagID & ")"
                    End If
                    If count > 0 Then
                        For i As Integer = 0 To count - 1

                            Dim tagDisplay As String = tagInfos(i).TagID
                            If tagInfos(i).TagID.Length > 5 Then
                                tagDisplay = "..." & tagInfos(i).TagID.Substring(tagInfos(i).TagID.Length - 5)
                            End If
                            Me.rtbDetected.AppendText("Antenna_" & tagInfos(i).Antenna & ":" & tagDisplay & vbNewLine)
                            'check if the tagID is loaded from the RUNNERS table
                            'reject if not found
                            If runners.ContainsKey(tagInfos(i).TagID) Then
                                'check if the runner's category is properly configured
                                'reject if not found
                                If categories.ContainsKey(runners.Item(tagInfos(i).TagID).RUNNER_CATEGORY) Then
                                    'check if the category has ben started
                                    If categories.Item(runners.Item(tagInfos(i).TagID).RUNNER_CATEGORY).CATEGORY_START_TIME <> "" Then
                                        'if all passed, update the runner, further validation is on the way
                                        updateRunner(tagInfos(i).TagID, CDate(tagInfos(i).DiscoveryTime))
                                    End If
                                End If
                            Else
                                unEnrolledCounter += 1
                                Dim rnr As New Runner
                                rnr.RUNNER_NAME = "RUNNER_" & unEnrolledCounter
                                rnr.RUNNER_BIB_NUMBER = 10000 + unEnrolledCounter
                                rnr.RUNNER_RFID_NUMBER = tagInfos(i).TagID
                                rnr.RUNNER_CATEGORY = "DEFAULT"
                                runners.Add(tagInfos(i).TagID, rnr)
                                runnersDao.insert(rnr)
                                updateRunner(tagInfos(i).TagID, CDate(tagInfos(i).DiscoveryTime))
                                'Me.rtbxLogs.AppendText("DOES NOT EXISTS :" & stingTolen(tagInfos(i).TagID, 30) & tagInfos(i).DiscoveryTime & vbNewLine)
                            End If
                        Next
                    End If
                    reader.ClearTagList()
                End If
            Catch ex As Exception

            End Try
        End If
        Dim started As Integer = countStartedRunners()
        lblStartedRunners.Text = "Detected:        " & started
        Dim running As Integer = countRunningRunners()
        lblRemainingRunners.Text = "Running Runners: " & running
        Dim finised As Integer = countFinishedRunners()
        lblFinishedRunners.Text = "Finised Runners: " & finised

    End Sub
    Private Function formatFinisher(ByVal tagID As String)
        Return runners.Item(tagID).RUNNER_NAME
    End Function
    Private Function stingTolen(ByVal str As String, ByVal len As Integer)
        If str.Length < len Then
            While str.Length < len
                str &= " "
            End While
        End If
        Return str
    End Function
    Private Sub updateRunner(tagID As String, dateTime As DateTime)

        Dim runner As Runner = runners.Item(tagID)
        'reject if the runner stays at the finish line
        If runner.RUNNER_FINISH_TIME = "" And runner.RUNNER_START_TIME <> "" Then
            If dateTime.Subtract(CDate(runner.RUNNER_BIB_LAST_DETECTED)).TotalMinutes < categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_MIN_MINUTES Then
                runners.Item(tagID).RUNNER_BIB_LAST_DETECTED = Now
                Exit Sub
            End If
        ElseIf runner.RUNNER_FINISH_TIME <> "" And runner.RUNNER_START_TIME <> "" Then
            Return
        End If
        Dim tagDisplay As String = tagID
        If tagID.Length > 5 Then
            tagDisplay = "..." & tagID.Substring(tagID.Length - 5)
        End If
        'check if the runner was not detected from starting line
        'set the start time to category start time
        'set the finish time to current time
        If runner.RUNNER_START_TIME = "" And dateTime.Subtract(CDate(categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_START_TIME)).TotalMinutes > categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_MIN_MINUTES Then
            runner.RUNNER_START_TIME = categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_START_TIME
            Dim endTime As DateTime = dateTime
            Dim chipSpan As TimeSpan = endTime.Subtract(CDate(runner.RUNNER_START_TIME))
            Dim gunSpan As TimeSpan = endTime.Subtract(CDate(categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_START_TIME))
            With runner
                .RUNNER_START_TIME = categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_START_TIME
                .RUNNER_BIB_LAST_DETECTED = dateTime
                .RUNNER_FINISH_TIME = dateTime
                .RUNNER_CHIP_TIME = chipSpan.Hours & ":" & chipSpan.Minutes & ":" & chipSpan.Seconds & ":" & chipSpan.Milliseconds
                .RUNNER_GUN_TIME = gunSpan.Hours & ":" & gunSpan.Minutes & ":" & gunSpan.Seconds & ":" & gunSpan.Milliseconds
            End With
            runners.Item(tagID) = runner
            Me.rtbxLogs.AppendText("FINISHED_1 " & stingTolen(runners.Item(tagID).RUNNER_NAME, 30) & " : " & runners.Item(tagID).RUNNER_GUN_TIME & " : " & stingTolen(tagDisplay, 6) & vbNewLine)
            runnersDao.update(runner)
        ElseIf runner.RUNNER_START_TIME = "" Then
            'check if the runner was detected at starting line
            With runner
                .RUNNER_START_TIME = dateTime
                .RUNNER_BIB_LAST_DETECTED = dateTime
            End With
            runners.Item(tagID) = runner
            Me.rtbxLogs.AppendText("STARTED    " & stingTolen(runners.Item(tagID).RUNNER_NAME, 30) & " : " & runners.Item(tagID).RUNNER_START_TIME & " : " & stingTolen(tagDisplay, 6) & vbNewLine)
            runnersDao.update(runner)
        ElseIf runner.RUNNER_FINISH_TIME = "" Then
            'check if the runner was detected at finishing line
            Dim endTime As DateTime = dateTime
            Dim chipSpan As TimeSpan = endTime.Subtract(CDate(runner.RUNNER_START_TIME))
            Dim gunSpan As TimeSpan = endTime.Subtract(CDate(categories.Item(runners.Item(tagID).RUNNER_CATEGORY).CATEGORY_START_TIME))
            With runner
                .RUNNER_FINISH_TIME = endTime
                .RUNNER_BIB_LAST_DETECTED = endTime
                .RUNNER_CHIP_TIME = chipSpan.Hours & ":" & chipSpan.Minutes & ":" & chipSpan.Seconds & ":" & chipSpan.Milliseconds
                .RUNNER_GUN_TIME = gunSpan.Hours & ":" & gunSpan.Minutes & ":" & gunSpan.Seconds & ":" & gunSpan.Milliseconds
            End With
            runners.Item(tagID) = runner
            Me.rtbxLogs.AppendText("FINISHED_2 " & stingTolen(runners.Item(tagID).RUNNER_NAME, 30) & " : " & runners.Item(tagID).RUNNER_GUN_TIME & " : " & stingTolen(tagDisplay, 6) & vbNewLine)
            runnersDao.update(runner)
        End If
    End Sub
    Private Sub btnToggleConnection_Click(sender As System.Object, e As System.EventArgs) Handles btnToggleConnection.Click

        Dim antennaSequence As String = ""
        Dim antennaPower As Integer = My.Settings.antennaPower
        If Not reader.IsConnected Then
            'show the connection settings
            Dim result As Windows.Forms.DialogResult = frmConnectSettings.ShowDialog
            'exit when the user choose to cancel the connection
            If result = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            Try
                reader.ConnectAndLogin(My.Settings.ip, My.Settings.tcpport, My.Settings.username, My.Settings.password)
                reader.TagListFormat = "Text"
                reader.TagStreamCustomFormat = CUSTOM_FORMAT
                reader.TagStreamFormat = "Custom"
                reader.Connect()
                'reader.DateTime
                reader.PersistTime = 60
                reader.DateTime = Now.Year & "/" & Now.Month & "/" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                'auto-detect antenna sequence and its power once detected
                If reader.IsAntennaConnected("0") Then
                    antennaSequence = ",0"
                    reader.SetAntennaPower("0", antennaPower)
                End If

                If reader.IsAntennaConnected("1") Then
                    antennaSequence &= ",1"
                    reader.SetAntennaPower("1", antennaPower)
                End If

                If reader.IsAntennaConnected("2") Then
                    antennaSequence &= ",2"
                    reader.SetAntennaPower("2", antennaPower)
                End If

                If reader.IsAntennaConnected("3") Then
                    antennaSequence &= ",3"
                    reader.SetAntennaPower("3", antennaPower)
                End If

                reader.AntennaSequence = antennaSequence.Substring(1)
                reader.TagStreamAddress = server.NotificationHost
                server.MaxNotifications = 10000
                server.MaxQueuedMessages = 10000
                reader.AutoMode = "ON"
                server.StartListening()
                Timer1.Interval = My.Settings.scanInterval
                Timer1.Enabled = True
                Timer1.Start()
            Catch ex As Exception
                If ex.Message = "Connection failed." Then
                    MsgBox("Error in connecting to reader " & My.Settings.ip & "!", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Else
            If MsgBox("Are you sure you want to DISCONNECT?", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then
                reader.AutoMode = "OFF"
                reader.Disconnect()
            End If
        End If
    End Sub

    Private Sub reader_Connected() Handles reader.Connected
        Me.btnToggleConnection.BackColor = Color.MediumSeaGreen
        Me.btnToggleConnection.Text = "Disconnect"
    End Sub

    Private Sub reader_DataReceived(data As String) Handles reader.DataReceived
        'Me.rtbxLogs.AppendText(data & vbNewLine)
    End Sub

    Private Sub reader_Disconnected(data As String) Handles reader.Disconnected
        Me.btnToggleConnection.BackColor = Color.Maroon
        Me.btnToggleConnection.Text = "Connect"
    End Sub

    Private Sub reader_MessageReceived(data As String) Handles reader.MessageReceived
        MsgBox(data)
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click

        For Each item As String In Me.lbxCategories.SelectedItems
            Dim key As String = item.Split(":")(0)
            categories.Item(key).CATEGORY_START_TIME = Now
        Next
        refreshCategoryList()
    End Sub

    Private Function countStartedRunners()
        Dim count As Integer = 0
        For Each runner As KeyValuePair(Of String, Runner) In runners
            If Not runners.Item(runner.Key).RUNNER_START_TIME = "" Then
                count += 1
            End If
        Next
        Return count
    End Function


    Private Function countRunningRunners()
        Dim count As Integer = 0
        For Each runner As KeyValuePair(Of String, Runner) In runners
            If Not runners.Item(runner.Key).RUNNER_START_TIME = "" And runners.Item(runner.Key).RUNNER_FINISH_TIME = "" Then
                count += 1
            End If
        Next
        Return count
    End Function


    Private Function countFinishedRunners()
        Dim count As Integer = 0
        For Each runner As KeyValuePair(Of String, Runner) In runners
            If Not runners.Item(runner.Key).RUNNER_START_TIME = "" And Not runners.Item(runner.Key).RUNNER_FINISH_TIME = "" Then
                count += 1
            End If
        Next
        Return count
    End Function
    Private Sub cmdClearResults_Click(sender As System.Object, e As System.EventArgs) Handles cmdClearResults.Click
        If Not MsgBox("Are you sure you want to clear Results?", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then

            Return
        End If
        categoryDao.reset()
        runnersDao.resetRunners()
        Dim backRunner As New Dictionary(Of String, Runner)
        backRunner = runners
        For Each runner As KeyValuePair(Of String, Runner) In runners
            runners.Item(runner.Key).RUNNER_FINISH_TIME = ""
            runners.Item(runner.Key).RUNNER_START_TIME = ""
            runners.Item(runner.Key).RUNNER_RANK = ""
            runners.Item(runner.Key).RUNNER_GUN_TIME = ""
            runners.Item(runner.Key).RUNNER_CHIP_TIME = ""
        Next

        Dim backCategory As New Dictionary(Of String, Category)
        backCategory = categories
        For Each category As KeyValuePair(Of String, Category) In categories
            categories.Item(category.Key).CATEGORY_START_TIME = ""
        Next
        runners = runnersDao.getRunnersList()
        categories = categoryDao.getCategoryList()
        refreshCategoryList()
        Me.rtbxLogs.Clear()

    End Sub


    Private Sub cmdStop_Click(sender As System.Object, e As System.EventArgs) Handles cmdStop.Click
        If (MsgBox("Are you sure you want to stop the selected category?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No) Then
            Return
        End If

        For Each item As String In Me.lbxCategories.SelectedItems
            Dim key As String = item.Split(":")(0)
            categories.Item(key).CATEGORY_START_TIME = ""
        Next
        refreshCategoryList()
    End Sub
    Private Sub refreshCategoryList()

        Me.lbxCategories.Items.Clear()
        Dim i As Integer = 0
        For Each runner As KeyValuePair(Of String, Category) In categories
            If categories.Item(runner.Key).CATEGORY_START_TIME <> "" Then
                Me.lbxCategories.Items.Add(runner.Key & ":STARTED")
            Else
                Me.lbxCategories.Items.Add(runner.Key)
            End If
            categoryDao.update(categories.Item(runner.Key))
            i += 1
        Next
    End Sub

    Private Sub btnLoadRunnersData_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadRunnersData.Click
        runners = runnersDao.getRunnersList()
        categories = categoryDao.getCategoryList()
        refreshCategoryList()
        Me.lblRunnersCount.Text = "Total Runners:   " & runners.Count
    End Sub

    Private Sub doBeep()
        ' Dim I As Integer
        For I As Integer = 1 To 50   ' Loop 100 times.
            Beep()   ' Sound a tone.
            I += 1
        Next I
    End Sub
End Class