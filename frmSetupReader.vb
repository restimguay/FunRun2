Public Class frmSetupReader
    Private reader As New Reader("192.168.1.100", 23, "alien", "password")
    Private tagCount As Integer
    Private tagList(10000) As nsAlienRFID2.TagInfo
    Private Sub frmSetupReader_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If reader.isConnected Then
            Timer1.Enabled = True
            reader.start()
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        SyncLock tagList
            For i As Integer = 0 To tagCount - 1
                Dim tag As nsAlienRFID2.TagInfo = tagList(i)
                Me.RichTextBox1.AppendText(tag.TagID & vbNewLine)
            Next
        End SyncLock
    End Sub
End Class
