<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSaveConnect = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbcPort = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxAntennaPower = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.tbxIP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'cmdSaveConnect
        '
        Me.cmdSaveConnect.Location = New System.Drawing.Point(228, 124)
        Me.cmdSaveConnect.Name = "cmdSaveConnect"
        Me.cmdSaveConnect.Size = New System.Drawing.Size(100, 23)
        Me.cmdSaveConnect.TabIndex = 8
        Me.cmdSaveConnect.Text = "Save/Connect"
        Me.cmdSaveConnect.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(12, 124)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Antenna Power"
        '
        'tbcPort
        '
        Me.tbcPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FunRun2.My.MySettings.Default, "tcpport", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbcPort.Location = New System.Drawing.Point(57, 48)
        Me.tbcPort.Name = "tbcPort"
        Me.tbcPort.Size = New System.Drawing.Size(100, 20)
        Me.tbcPort.TabIndex = 3
        Me.tbcPort.Text = "23"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FunRun2.My.MySettings.Default, "scanInterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "120", "140", "160", "180", "200", "220", "240", "260", "280", "300", "320", "340", "360", "380", "400", "420", "440", "460", "480", "500", "520", "540", "560", "580", "600", "620", "640", "680", "700", "720", "740", "760", "780", "800", "820", "840", "860", "880", "900", "920", "940", "960", "980", "1000"})
        Me.ComboBox1.Location = New System.Drawing.Point(228, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Text = Global.FunRun2.My.MySettings.Default.scanInterval
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Scan Interval"
        '
        'tbxAntennaPower
        '
        Me.tbxAntennaPower.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FunRun2.My.MySettings.Default, "antennaPower", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxAntennaPower.Location = New System.Drawing.Point(98, 85)
        Me.tbxAntennaPower.Name = "tbxAntennaPower"
        Me.tbxAntennaPower.Size = New System.Drawing.Size(45, 20)
        Me.tbxAntennaPower.TabIndex = 11
        Me.tbxAntennaPower.Text = Global.FunRun2.My.MySettings.Default.antennaPower
        '
        'tbxPassword
        '
        Me.tbxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FunRun2.My.MySettings.Default, "password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxPassword.Location = New System.Drawing.Point(228, 48)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbxPassword.TabIndex = 7
        Me.tbxPassword.Text = Global.FunRun2.My.MySettings.Default.password
        '
        'tbxUsername
        '
        Me.tbxUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FunRun2.My.MySettings.Default, "username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxUsername.Location = New System.Drawing.Point(228, 20)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(100, 20)
        Me.tbxUsername.TabIndex = 5
        Me.tbxUsername.Text = Global.FunRun2.My.MySettings.Default.username
        '
        'tbxIP
        '
        Me.tbxIP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FunRun2.My.MySettings.Default, "ip", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbxIP.Location = New System.Drawing.Point(57, 20)
        Me.tbxIP.Name = "tbxIP"
        Me.tbxIP.Size = New System.Drawing.Size(100, 20)
        Me.tbxIP.TabIndex = 1
        Me.tbxIP.Text = Global.FunRun2.My.MySettings.Default.ip
        '
        'frmConnectSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 159)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tbxAntennaPower)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSaveConnect)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbcPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxIP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConnectSettings"
        Me.Text = "Connection Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxIP As System.Windows.Forms.TextBox
    Friend WithEvents tbcPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdSaveConnect As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbxAntennaPower As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
