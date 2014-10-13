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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.group1 = New System.Windows.Forms.GroupBox()
        Me.lblFinishedRunners = New System.Windows.Forms.Label()
        Me.lblRemainingRunners = New System.Windows.Forms.Label()
        Me.lblStartedRunners = New System.Windows.Forms.Label()
        Me.lblRunnersCount = New System.Windows.Forms.Label()
        Me.rtbDetected = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.group1.SuspendLayout()
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
        Me.rtbxLogs.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbxLogs.Location = New System.Drawing.Point(12, 220)
        Me.rtbxLogs.Name = "rtbxLogs"
        Me.rtbxLogs.ReadOnly = True
        Me.rtbxLogs.Size = New System.Drawing.Size(604, 206)
        Me.rtbxLogs.TabIndex = 4
        Me.rtbxLogs.Text = ""
        '
        'cmdClearResults
        '
        Me.cmdClearResults.BackColor = System.Drawing.Color.Maroon
        Me.cmdClearResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdClearResults.Location = New System.Drawing.Point(530, 128)
        Me.cmdClearResults.Name = "cmdClearResults"
        Me.cmdClearResults.Size = New System.Drawing.Size(122, 52)
        Me.cmdClearResults.TabIndex = 5
        Me.cmdClearResults.Text = "Clear Results"
        Me.cmdClearResults.UseVisualStyleBackColor = False
        '
        'lblTagDetected
        '
        Me.lblTagDetected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTagDetected.Location = New System.Drawing.Point(18, 432)
        Me.lblTagDetected.Name = "lblTagDetected"
        Me.lblTagDetected.Size = New System.Drawing.Size(910, 23)
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
        'BackgroundWorker1
        '
        '
        'group1
        '
        Me.group1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group1.Controls.Add(Me.lblFinishedRunners)
        Me.group1.Controls.Add(Me.lblRemainingRunners)
        Me.group1.Controls.Add(Me.lblStartedRunners)
        Me.group1.Controls.Add(Me.lblRunnersCount)
        Me.group1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group1.Location = New System.Drawing.Point(658, 13)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(270, 167)
        Me.group1.TabIndex = 9
        Me.group1.TabStop = False
        Me.group1.Text = "Stats"
        '
        'lblFinishedRunners
        '
        Me.lblFinishedRunners.AutoSize = True
        Me.lblFinishedRunners.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishedRunners.Location = New System.Drawing.Point(14, 89)
        Me.lblFinishedRunners.Name = "lblFinishedRunners"
        Me.lblFinishedRunners.Size = New System.Drawing.Size(0, 22)
        Me.lblFinishedRunners.TabIndex = 3
        '
        'lblRemainingRunners
        '
        Me.lblRemainingRunners.AutoSize = True
        Me.lblRemainingRunners.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingRunners.Location = New System.Drawing.Point(14, 67)
        Me.lblRemainingRunners.Name = "lblRemainingRunners"
        Me.lblRemainingRunners.Size = New System.Drawing.Size(0, 22)
        Me.lblRemainingRunners.TabIndex = 2
        '
        'lblStartedRunners
        '
        Me.lblStartedRunners.AutoSize = True
        Me.lblStartedRunners.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartedRunners.Location = New System.Drawing.Point(14, 45)
        Me.lblStartedRunners.Name = "lblStartedRunners"
        Me.lblStartedRunners.Size = New System.Drawing.Size(0, 22)
        Me.lblStartedRunners.TabIndex = 1
        '
        'lblRunnersCount
        '
        Me.lblRunnersCount.AutoSize = True
        Me.lblRunnersCount.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunnersCount.Location = New System.Drawing.Point(14, 23)
        Me.lblRunnersCount.Name = "lblRunnersCount"
        Me.lblRunnersCount.Size = New System.Drawing.Size(0, 22)
        Me.lblRunnersCount.TabIndex = 0
        '
        'rtbDetected
        '
        Me.rtbDetected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDetected.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDetected.Location = New System.Drawing.Point(622, 220)
        Me.rtbDetected.Name = "rtbDetected"
        Me.rtbDetected.ReadOnly = True
        Me.rtbDetected.Size = New System.Drawing.Size(312, 206)
        Me.rtbDetected.TabIndex = 10
        Me.rtbDetected.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Log Messages"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(619, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "IDs Detected"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 462)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbDetected)
        Me.Controls.Add(Me.group1)
        Me.Controls.Add(Me.btnLoadRunnersData)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.lblTagDetected)
        Me.Controls.Add(Me.cmdClearResults)
        Me.Controls.Add(Me.rtbxLogs)
        Me.Controls.Add(Me.btnToggleConnection)
        Me.Controls.Add(Me.lbxCategories)
        Me.Controls.Add(Me.btnStart)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "frmMain"
        Me.Text = "FunRun"
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents group1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRunnersCount As System.Windows.Forms.Label
    Friend WithEvents lblStartedRunners As System.Windows.Forms.Label
    Friend WithEvents lblRemainingRunners As System.Windows.Forms.Label
    Friend WithEvents lblFinishedRunners As System.Windows.Forms.Label
    Friend WithEvents rtbDetected As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
