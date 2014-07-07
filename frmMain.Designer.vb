<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lbxCategories = New System.Windows.Forms.ListBox()
        Me.btnToggleConnection = New System.Windows.Forms.Button()
        Me.rtbxLogs = New System.Windows.Forms.RichTextBox()
        Me.cmdClearResults = New System.Windows.Forms.Button()
        Me.lblTagDetected = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.btnLoadRunnersData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(529, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(122, 52)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lbxCategories
        '
        Me.lbxCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxCategories.FormattingEnabled = True
        Me.lbxCategories.ItemHeight = 24
        Me.lbxCategories.Location = New System.Drawing.Point(159, 12)
        Me.lbxCategories.Name = "lbxCategories"
        Me.lbxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxCategories.Size = New System.Drawing.Size(364, 172)
        Me.lbxCategories.TabIndex = 2
        '
        'btnToggleConnection
        '
        Me.btnToggleConnection.BackColor = System.Drawing.Color.Maroon
        Me.btnToggleConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleConnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnToggleConnection.Location = New System.Drawing.Point(12, 61)
        Me.btnToggleConnection.Name = "btnToggleConnection"
        Me.btnToggleConnection.Size = New System.Drawing.Size(141, 123)
        Me.btnToggleConnection.TabIndex = 3
        Me.btnToggleConnection.Text = "Connect"
        Me.btnToggleConnection.UseVisualStyleBackColor = False
        '
        'rtbxLogs
        '
        Me.rtbxLogs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbxLogs.Location = New System.Drawing.Point(12, 192)
        Me.rtbxLogs.Name = "rtbxLogs"
        Me.rtbxLogs.Size = New System.Drawing.Size(640, 116)
        Me.rtbxLogs.TabIndex = 4
        Me.rtbxLogs.Text = ""
        '
        'cmdClearResults
        '
        Me.cmdClearResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearResults.Location = New System.Drawing.Point(530, 128)
        Me.cmdClearResults.Name = "cmdClearResults"
        Me.cmdClearResults.Size = New System.Drawing.Size(122, 52)
        Me.cmdClearResults.TabIndex = 5
        Me.cmdClearResults.Text = "Clear Results"
        Me.cmdClearResults.UseVisualStyleBackColor = True
        '
        'lblTagDetected
        '
        Me.lblTagDetected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTagDetected.Location = New System.Drawing.Point(18, 314)
        Me.lblTagDetected.Name = "lblTagDetected"
        Me.lblTagDetected.Size = New System.Drawing.Size(431, 23)
        Me.lblTagDetected.TabIndex = 6
        '
        'cmdStop
        '
        Me.cmdStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.Location = New System.Drawing.Point(530, 70)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(122, 52)
        Me.cmdStop.TabIndex = 7
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'btnLoadRunnersData
        '
        Me.btnLoadRunnersData.Location = New System.Drawing.Point(13, 12)
        Me.btnLoadRunnersData.Name = "btnLoadRunnersData"
        Me.btnLoadRunnersData.Size = New System.Drawing.Size(140, 34)
        Me.btnLoadRunnersData.TabIndex = 8
        Me.btnLoadRunnersData.Text = "Load Runner's Data"
        Me.btnLoadRunnersData.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 344)
        Me.Controls.Add(Me.btnLoadRunnersData)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.lblTagDetected)
        Me.Controls.Add(Me.cmdClearResults)
        Me.Controls.Add(Me.rtbxLogs)
        Me.Controls.Add(Me.btnToggleConnection)
        Me.Controls.Add(Me.lbxCategories)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmMain"
        Me.Text = "FunRun"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lbxCategories As System.Windows.Forms.ListBox
    Friend WithEvents btnToggleConnection As System.Windows.Forms.Button
    Friend WithEvents rtbxLogs As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdClearResults As System.Windows.Forms.Button
    Friend WithEvents lblTagDetected As System.Windows.Forms.Label
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents btnLoadRunnersData As System.Windows.Forms.Button
End Class
