<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MegaGrabber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MegaGrabber))
        Me.stripStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SS_springLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.linkHeader = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbMain = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.btnExport = New WindowsApplication2.FlatButton()
        Me.btnGrab = New WindowsApplication2.FlatButton()
        Me.stripStatus.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stripStatus
        '
        Me.stripStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus, Me.SS_springLabel, Me.ToolStripStatusLabel3, Me.lblServer, Me.ToolStripStatusLabel2, Me.lblPcount})
        Me.stripStatus.Location = New System.Drawing.Point(0, 631)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.Size = New System.Drawing.Size(1000, 24)
        Me.stripStatus.TabIndex = 8
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
        'linkHeader
        '
        Me.linkHeader.AutoSize = True
        Me.linkHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkHeader.ForeColor = System.Drawing.Color.DarkGray
        Me.linkHeader.Location = New System.Drawing.Point(319, 9)
        Me.linkHeader.Name = "linkHeader"
        Me.linkHeader.Size = New System.Drawing.Size(312, 45)
        Me.linkHeader.TabIndex = 7
        Me.linkHeader.Text = "Mega Proxy Grabber"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblVersion.Location = New System.Drawing.Point(895, 86)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(90, 12)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "V E R S I O N : 1.0.0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtLog)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox5.Location = New System.Drawing.Point(728, 75)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(251, 389)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "< Log >"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(3, 19)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(245, 367)
        Me.txtLog.TabIndex = 0
        Me.txtLog.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbMain)
        Me.GroupBox6.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox6.Location = New System.Drawing.Point(22, 75)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(700, 541)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "< Grabbed Proxies >"
        '
        'lbMain
        '
        Me.lbMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lbMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMain.ForeColor = System.Drawing.Color.SeaGreen
        Me.lbMain.FormattingEnabled = True
        Me.lbMain.ItemHeight = 21
        Me.lbMain.Items.AddRange(New Object() {""})
        Me.lbMain.Location = New System.Drawing.Point(3, 16)
        Me.lbMain.Name = "lbMain"
        Me.lbMain.Size = New System.Drawing.Size(694, 522)
        Me.lbMain.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(150, 76)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(83, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(92, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(79, 126)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(98, 101)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(269, 26)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(250, 51)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(262, 76)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(254, 101)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(728, 544)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(248, 32)
        Me.FlatButton1.TabIndex = 91
        Me.FlatButton1.Text = "Copy to Clipboard"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(728, 581)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(248, 32)
        Me.FlatButton2.TabIndex = 88
        Me.FlatButton2.Text = "Reset"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnExport.Location = New System.Drawing.Point(728, 508)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Rounded = False
        Me.btnExport.Size = New System.Drawing.Size(248, 32)
        Me.btnExport.TabIndex = 87
        Me.btnExport.Text = "Export Proxies"
        Me.btnExport.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnGrab
        '
        Me.btnGrab.BackColor = System.Drawing.Color.Transparent
        Me.btnGrab.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGrab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrab.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnGrab.Location = New System.Drawing.Point(725, 470)
        Me.btnGrab.Name = "btnGrab"
        Me.btnGrab.Rounded = False
        Me.btnGrab.Size = New System.Drawing.Size(248, 32)
        Me.btnGrab.TabIndex = 86
        Me.btnGrab.Text = "Grab Proxies"
        Me.btnGrab.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MegaGrabber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1000, 655)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnGrab)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.stripStatus)
        Me.Controls.Add(Me.linkHeader)
        Me.Controls.Add(Me.lblVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MegaGrabber"
        Me.Text = "Mega Proxy Grabber"
        Me.stripStatus.ResumeLayout(False)
        Me.stripStatus.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stripStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents SS_springLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblServer As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblPcount As ToolStripStatusLabel
    Friend WithEvents linkHeader As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtLog As RichTextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbMain As ListBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnGrab As FlatButton
    Friend WithEvents btnExport As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
End Class
