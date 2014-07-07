Public Class frmConnectSettings

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click


        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdSaveConnect_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaveConnect.Click
        My.Settings.Save()
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class