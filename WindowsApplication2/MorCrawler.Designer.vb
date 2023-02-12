<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MorCrawler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MorCrawler))
        Me.GroupBoxOptions = New System.Windows.Forms.GroupBox()
        Me.ButtonEdit = New WindowsApplication2.FlatButton()
        Me.ButtonSaveDefaults = New WindowsApplication2.FlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearchSeed = New System.Windows.Forms.TextBox()
        Me.TextBoxURLFilter = New System.Windows.Forms.TextBox()
        Me.TextBoxLeechFilter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButtonProxies = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButtonOther = New System.Windows.Forms.RadioButton()
        Me.NumericUpDownThreads = New System.Windows.Forms.NumericUpDown()
        Me.GroupBoxProgress = New System.Windows.Forms.GroupBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ListBoxProgress = New System.Windows.Forms.ListBox()
        Me.ButtonPause = New WindowsApplication2.FlatButton()
        Me.ButtonSave = New WindowsApplication2.FlatButton()
        Me.ButtonStart = New WindowsApplication2.FlatButton()
        Me.ProcessEnginesFile = New System.Diagnostics.Process()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorkerEngines = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerCrawler = New System.ComponentModel.BackgroundWorker()
        Me.GroupBoxOptions.SuspendLayout()
        CType(Me.NumericUpDownThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxOptions
        '
        Me.GroupBoxOptions.BackColor = System.Drawing.Color.Black
        Me.GroupBoxOptions.Controls.Add(Me.ButtonEdit)
        Me.GroupBoxOptions.Controls.Add(Me.ButtonSaveDefaults)
        Me.GroupBoxOptions.Controls.Add(Me.Label5)
        Me.GroupBoxOptions.Controls.Add(Me.Label1)
        Me.GroupBoxOptions.Controls.Add(Me.TextBoxSearchSeed)
        Me.GroupBoxOptions.Controls.Add(Me.TextBoxURLFilter)
        Me.GroupBoxOptions.Controls.Add(Me.TextBoxLeechFilter)
        Me.GroupBoxOptions.Controls.Add(Me.Label7)
        Me.GroupBoxOptions.Controls.Add(Me.RadioButtonProxies)
        Me.GroupBoxOptions.Controls.Add(Me.Label2)
        Me.GroupBoxOptions.Controls.Add(Me.Label8)
        Me.GroupBoxOptions.Controls.Add(Me.RadioButtonOther)
        Me.GroupBoxOptions.Controls.Add(Me.NumericUpDownThreads)
        Me.GroupBoxOptions.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBoxOptions.Location = New System.Drawing.Point(11, 48)
        Me.GroupBoxOptions.Name = "GroupBoxOptions"
        Me.GroupBoxOptions.Size = New System.Drawing.Size(512, 159)
        Me.GroupBoxOptions.TabIndex = 88
        Me.GroupBoxOptions.TabStop = False
        Me.GroupBoxOptions.Text = "Options"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEdit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ButtonEdit.Location = New System.Drawing.Point(418, 127)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Rounded = False
        Me.ButtonEdit.Size = New System.Drawing.Size(88, 26)
        Me.ButtonEdit.TabIndex = 65
        Me.ButtonEdit.Text = "Edit Engines"
        Me.ButtonEdit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonSaveDefaults
        '
        Me.ButtonSaveDefaults.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSaveDefaults.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSaveDefaults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveDefaults.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ButtonSaveDefaults.Location = New System.Drawing.Point(418, 17)
        Me.ButtonSaveDefaults.Name = "ButtonSaveDefaults"
        Me.ButtonSaveDefaults.Rounded = False
        Me.ButtonSaveDefaults.Size = New System.Drawing.Size(88, 26)
        Me.ButtonSaveDefaults.TabIndex = 64
        Me.ButtonSaveDefaults.Text = "Save"
        Me.ButtonSaveDefaults.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Search Seed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "URL Filter"
        '
        'TextBoxSearchSeed
        '
        Me.TextBoxSearchSeed.Location = New System.Drawing.Point(81, 49)
        Me.TextBoxSearchSeed.Name = "TextBoxSearchSeed"
        Me.TextBoxSearchSeed.Size = New System.Drawing.Size(425, 20)
        Me.TextBoxSearchSeed.TabIndex = 14
        '
        'TextBoxURLFilter
        '
        Me.TextBoxURLFilter.Location = New System.Drawing.Point(81, 75)
        Me.TextBoxURLFilter.Name = "TextBoxURLFilter"
        Me.TextBoxURLFilter.Size = New System.Drawing.Size(425, 20)
        Me.TextBoxURLFilter.TabIndex = 13
        '
        'TextBoxLeechFilter
        '
        Me.TextBoxLeechFilter.Location = New System.Drawing.Point(81, 101)
        Me.TextBoxLeechFilter.Name = "TextBoxLeechFilter"
        Me.TextBoxLeechFilter.Size = New System.Drawing.Size(425, 20)
        Me.TextBoxLeechFilter.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Leech Filter"
        '
        'RadioButtonProxies
        '
        Me.RadioButtonProxies.AutoSize = True
        Me.RadioButtonProxies.BackColor = System.Drawing.Color.Black
        Me.RadioButtonProxies.ForeColor = System.Drawing.Color.White
        Me.RadioButtonProxies.Location = New System.Drawing.Point(81, 26)
        Me.RadioButtonProxies.Name = "RadioButtonProxies"
        Me.RadioButtonProxies.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonProxies.TabIndex = 5
        Me.RadioButtonProxies.TabStop = True
        Me.RadioButtonProxies.Text = "Proxies"
        Me.RadioButtonProxies.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Defaults"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Threads"
        '
        'RadioButtonOther
        '
        Me.RadioButtonOther.AutoSize = True
        Me.RadioButtonOther.BackColor = System.Drawing.Color.Black
        Me.RadioButtonOther.ForeColor = System.Drawing.Color.White
        Me.RadioButtonOther.Location = New System.Drawing.Point(146, 26)
        Me.RadioButtonOther.Name = "RadioButtonOther"
        Me.RadioButtonOther.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonOther.TabIndex = 2
        Me.RadioButtonOther.TabStop = True
        Me.RadioButtonOther.Text = "Other"
        Me.RadioButtonOther.UseVisualStyleBackColor = False
        '
        'NumericUpDownThreads
        '
        Me.NumericUpDownThreads.Location = New System.Drawing.Point(81, 128)
        Me.NumericUpDownThreads.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDownThreads.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownThreads.Name = "NumericUpDownThreads"
        Me.NumericUpDownThreads.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDownThreads.TabIndex = 0
        Me.NumericUpDownThreads.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'GroupBoxProgress
        '
        Me.GroupBoxProgress.Controls.Add(Me.LabelStatus)
        Me.GroupBoxProgress.Controls.Add(Me.ListBoxProgress)
        Me.GroupBoxProgress.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBoxProgress.Location = New System.Drawing.Point(11, 214)
        Me.GroupBoxProgress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxProgress.Name = "GroupBoxProgress"
        Me.GroupBoxProgress.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxProgress.Size = New System.Drawing.Size(512, 270)
        Me.GroupBoxProgress.TabIndex = 89
        Me.GroupBoxProgress.TabStop = False
        Me.GroupBoxProgress.Text = "Progress"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(6, 253)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(24, 13)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.Text = "Idle"
        '
        'ListBoxProgress
        '
        Me.ListBoxProgress.FormattingEnabled = True
        Me.ListBoxProgress.Location = New System.Drawing.Point(6, 21)
        Me.ListBoxProgress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxProgress.Name = "ListBoxProgress"
        Me.ListBoxProgress.Size = New System.Drawing.Size(500, 225)
        Me.ListBoxProgress.TabIndex = 0
        '
        'ButtonPause
        '
        Me.ButtonPause.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPause.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPause.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ButtonPause.Location = New System.Drawing.Point(11, 491)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Rounded = False
        Me.ButtonPause.Size = New System.Drawing.Size(88, 23)
        Me.ButtonPause.TabIndex = 66
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ButtonSave.Location = New System.Drawing.Point(354, 491)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Rounded = False
        Me.ButtonSave.Size = New System.Drawing.Size(88, 23)
        Me.ButtonSave.TabIndex = 90
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStart.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ButtonStart.Location = New System.Drawing.Point(448, 491)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Rounded = False
        Me.ButtonStart.Size = New System.Drawing.Size(88, 23)
        Me.ButtonStart.TabIndex = 91
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ProcessEnginesFile
        '
        Me.ProcessEnginesFile.StartInfo.Domain = ""
        Me.ProcessEnginesFile.StartInfo.LoadUserProfile = False
        Me.ProcessEnginesFile.StartInfo.Password = Nothing
        Me.ProcessEnginesFile.StartInfo.StandardErrorEncoding = Nothing
        Me.ProcessEnginesFile.StartInfo.StandardOutputEncoding = Nothing
        Me.ProcessEnginesFile.StartInfo.UserName = ""
        Me.ProcessEnginesFile.SynchronizingObject = Me
        '
        'Timer1
        '
        '
        'BackgroundWorkerEngines
        '
        '
        'BackgroundWorkerCrawler
        '
        '
        'Form23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(536, 520)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.GroupBoxProgress)
        Me.Controls.Add(Me.GroupBoxOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form23"
        Me.Text = "Mor Crawler"
        Me.GroupBoxOptions.ResumeLayout(False)
        Me.GroupBoxOptions.PerformLayout()
        CType(Me.NumericUpDownThreads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProgress.ResumeLayout(False)
        Me.GroupBoxProgress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxOptions As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearchSeed As TextBox
    Friend WithEvents TextBoxURLFilter As TextBox
    Friend WithEvents TextBoxLeechFilter As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButtonProxies As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButtonOther As RadioButton
    Friend WithEvents NumericUpDownThreads As NumericUpDown
    Friend WithEvents ButtonSaveDefaults As FlatButton
    Friend WithEvents ButtonEdit As FlatButton
    Friend WithEvents GroupBoxProgress As GroupBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ListBoxProgress As ListBox
    Friend WithEvents ButtonPause As FlatButton
    Friend WithEvents ButtonSave As FlatButton
    Friend WithEvents ButtonStart As FlatButton
    Friend WithEvents ProcessEnginesFile As Process
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorkerEngines As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerCrawler As System.ComponentModel.BackgroundWorker
End Class
