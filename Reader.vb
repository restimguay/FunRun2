Imports nsAlienRFID2

Public Class Reader
    Private reader As New clsReader
    Private server As New CAlienServer

    Private CUSTOM_FORMAT As String = "${TAGIDB}, ${TX}, ${DATE2} ${TIME2}, ${PCWORD}, ${SPEED}, ${RSSI}, ${G2DATA1}, ${FREQ}"
    Public Sub New(ip As String, port As Integer, username As String, password As String)
        If Not reader.IsConnected Then
            reader.ConnectAndLogin(ip, port, username, password)
            reader.TagListFormat = "Text"
            reader.TagStreamCustomFormat = CUSTOM_FORMAT
            reader.TagStreamFormat = "Custom"
            reader.AutoMode = "ON"
            reader.SetAntennaPower("0", 100)
            reader.TagStreamAddress = server.NotificationHost
        End If
    End Sub

    Public Function getReader() As clsReader
        Return Me.reader
    End Function

    Public Function isConnected() As Boolean
        Return reader.IsConnected
    End Function

    Public Sub start()
        Dim antennaSequence As String = ""
        If Not reader.IsConnected Then
            reader.Connect()
        End If

        If reader.IsAntennaConnected("0") Then
            antennaSequence = ",0"
        End If

        If reader.IsAntennaConnected("1") Then
            antennaSequence &= ",1"
        End If

        If reader.IsAntennaConnected("2") Then
            antennaSequence &= ",2"
        End If

        If reader.IsAntennaConnected("3") Then
            antennaSequence &= ",3"
        End If

        reader.AntennaSequence = antennaSequence.Substring(1)
        server.MaxNotifications = 1000
        server.MaxQueuedMessages = 1000
        server.StartListening()
    End Sub

    Public Function getServer() As CAlienServer
        Return server
    End Function

    Public Function getTagList(ByRef count As Integer) As TagInfo()
        Dim tagInfos(20000) As TagInfo
        count = AlienUtils.ParseTextTagList(reader.TagList, tagInfos)
        Return tagInfos
    End Function

End Class
