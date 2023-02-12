<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MegaProxyChecker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MegaProxyChecker))
        Me.txtImport = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.proxyBox = New System.Windows.Forms.ListView()
        Me.Proxy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Response = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.numThreads = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCLoaded = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCValid = New System.Windows.Forms.Label()
        Me.lblCInvalid = New System.Windows.Forms.Label()
        Me.numPtimeout = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbOriginal = New System.Windows.Forms.ListBox()
        Me.stripStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SS_springLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnImport = New WindowsApplication2.FlatButton()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatLabel1 = New WindowsApplication2.FlatLabel()
        Me.btnStart = New WindowsApplication2.FlatButton()
        Me.btnStop = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numPtimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.stripStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtImport
        '
        Me.txtImport.Location = New System.Drawing.Point(140, 67)
        Me.txtImport.Name = "txtImport"
        Me.txtImport.Size = New System.Drawing.Size(760, 20)
        Me.txtImport.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(19, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "I M P O R T   L I S T :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.proxyBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(405, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 372)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "< Results >"
        '
        'proxyBox
        '
        Me.proxyBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.proxyBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Proxy, Me.Response})
        Me.proxyBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.proxyBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proxyBox.ForeColor = System.Drawing.Color.DarkGray
        Me.proxyBox.GridLines = True
        Me.proxyBox.HideSelection = False
        Me.proxyBox.Location = New System.Drawing.Point(3, 16)
        Me.proxyBox.Name = "proxyBox"
        Me.proxyBox.Size = New System.Drawing.Size(565, 353)
        Me.proxyBox.TabIndex = 0
        Me.proxyBox.UseCompatibleStateImageBehavior = False
        Me.proxyBox.View = System.Windows.Forms.View.Details
        '
        'Proxy
        '
        Me.Proxy.Text = "Proxy"
        Me.Proxy.Width = 240
        '
        'Response
        '
        Me.Response.Text = "Response"
        Me.Response.Width = 120
        '
        'numThreads
        '
        Me.numThreads.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numThreads.Location = New System.Drawing.Point(764, 479)
        Me.numThreads.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numThreads.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numThreads.Name = "numThreads"
        Me.numThreads.Size = New System.Drawing.Size(212, 20)
        Me.numThreads.TabIndex = 17
        Me.numThreads.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(705, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Threads:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblCLoaded)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblCValid)
        Me.GroupBox2.Controls.Add(Me.lblCInvalid)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(405, 471)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "< Stats >"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Proxies Loaded:"
        '
        'lblCLoaded
        '
        Me.lblCLoaded.AutoSize = True
        Me.lblCLoaded.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCLoaded.Location = New System.Drawing.Point(102, 19)
        Me.lblCLoaded.Name = "lblCLoaded"
        Me.lblCLoaded.Size = New System.Drawing.Size(13, 13)
        Me.lblCLoaded.TabIndex = 4
        Me.lblCLoaded.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label8.Location = New System.Drawing.Point(6, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Valid:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(6, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Invalid:"
        '
        'lblCValid
        '
        Me.lblCValid.AutoSize = True
        Me.lblCValid.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblCValid.Location = New System.Drawing.Point(48, 44)
        Me.lblCValid.Name = "lblCValid"
        Me.lblCValid.Size = New System.Drawing.Size(13, 13)
        Me.lblCValid.TabIndex = 1
        Me.lblCValid.Text = "0"
        '
        'lblCInvalid
        '
        Me.lblCInvalid.AutoSize = True
        Me.lblCInvalid.ForeColor = System.Drawing.Color.Crimson
        Me.lblCInvalid.Location = New System.Drawing.Point(58, 69)
        Me.lblCInvalid.Name = "lblCInvalid"
        Me.lblCInvalid.Size = New System.Drawing.Size(13, 13)
        Me.lblCInvalid.TabIndex = 0
        Me.lblCInvalid.Text = "0"
        '
        'numPtimeout
        '
        Me.numPtimeout.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numPtimeout.Location = New System.Drawing.Point(764, 508)
        Me.numPtimeout.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.numPtimeout.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numPtimeout.Name = "numPtimeout"
        Me.numPtimeout.Size = New System.Drawing.Size(212, 20)
        Me.numPtimeout.TabIndex = 14
        Me.numPtimeout.Value = New Decimal(New Integer() {4500, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(705, 510)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Timeout:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbOriginal)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(19, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 475)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "< Original List >"
        '
        'lbOriginal
        '
        Me.lbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbOriginal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbOriginal.FormattingEnabled = True
        Me.lbOriginal.Location = New System.Drawing.Point(3, 16)
        Me.lbOriginal.Name = "lbOriginal"
        Me.lbOriginal.Size = New System.Drawing.Size(374, 456)
        Me.lbOriginal.TabIndex = 0
        '
        'stripStatus
        '
        Me.stripStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus, Me.SS_springLabel, Me.ToolStripStatusLabel3, Me.lblServer, Me.ToolStripStatusLabel2, Me.lblPcount})
        Me.stripStatus.Location = New System.Drawing.Point(0, 631)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.Size = New System.Drawing.Size(1000, 24)
        Me.stripStatus.TabIndex = 22
        Me.stripStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 19)
        Me.ToolStripStatusLabel1.Text = "STATUS:"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(29, 19)
        Me.lblStatus.Text = "Idle."
        '
        'SS_springLabel
        '
        Me.SS_springLabel.AutoSize = False
        Me.SS_springLabel.Name = "SS_springLabel"
        Me.SS_springLabel.Size = New System.Drawing.Size(683, 19)
        Me.SS_springLabel.Spring = True
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.DarkGray
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(48, 19)
        Me.ToolStripStatusLabel3.Text = "Server:"
        '
        'lblServer
        '
        Me.lblServer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblServer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServer.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(81, 19)
        Me.lblServer.Text = "Disconnected"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(78, 19)
        Me.ToolStripStatusLabel2.Text = "Proxy Count:"
        '
        'lblPcount
        '
        Me.lblPcount.Name = "lblPcount"
        Me.lblPcount.Size = New System.Drawing.Size(13, 19)
        Me.lblPcount.Text = "0"
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.Transparent
        Me.btnImport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnImport.Location = New System.Drawing.Point(906, 67)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Rounded = False
        Me.btnImport.Size = New System.Drawing.Size(67, 20)
        Me.btnImport.TabIndex = 99
        Me.btnImport.Text = "..."
        Me.btnImport.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(880, 577)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(84, 32)
        Me.FlatButton1.TabIndex = 98
        Me.FlatButton1.Text = "Export"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel1.Location = New System.Drawing.Point(345, 21)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(203, 30)
        Me.FlatLabel1.TabIndex = 97
        Me.FlatLabel1.Text = "Mega Proxy Checker"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnStart.Location = New System.Drawing.Point(708, 578)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Rounded = False
        Me.btnStart.Size = New System.Drawing.Size(80, 32)
        Me.btnStart.TabIndex = 96
        Me.btnStart.Text = "Start"
        Me.btnStart.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnStop.Location = New System.Drawing.Point(794, 577)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Rounded = False
        Me.btnStop.Size = New System.Drawing.Size(80, 32)
        Me.btnStop.TabIndex = 100
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(764, 539)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(134, 32)
        Me.FlatButton2.TabIndex = 101
        Me.FlatButton2.Text = "Copy to Clipboard"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MegaProxyChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1000, 655)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.stripStatus)
        Me.Controls.Add(Me.txtImport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.numThreads)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.numPtimeout)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MegaProxyChecker"
        Me.Text = "Mega Proxy Checker"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.numThreads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numPtimeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.stripStatus.ResumeLayout(False)
        Me.stripStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtImport As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents proxyBox As ListView
    Friend WithEvents Proxy As ColumnHeader
    Friend WithEvents Response As ColumnHeader
    Friend WithEvents numThreads As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCLoaded As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCValid As Label
    Friend WithEvents lblCInvalid As Label
    Friend WithEvents numPtimeout As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbOriginal As ListBox
    Friend WithEvents stripStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents SS_springLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblServer As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblPcount As ToolStripStatusLabel
    Friend WithEvents btnStart As FlatButton
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents btnImport As FlatButton
    Friend WithEvents btnStop As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
End Class
