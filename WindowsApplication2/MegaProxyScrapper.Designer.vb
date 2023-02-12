<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MegaProxyScrapper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MegaProxyScrapper))
        Me.grpParsed = New System.Windows.Forms.GroupBox()
        Me.txtScraped = New System.Windows.Forms.RichTextBox()
        Me.grpWebtext = New System.Windows.Forms.GroupBox()
        Me.txtParse = New System.Windows.Forms.RichTextBox()
        Me.grpService = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.grpCfg = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.btnParse = New System.Windows.Forms.Button()
        Me.btnReset2 = New System.Windows.Forms.Button()
        Me.stripStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SS_springLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.grpParsed.SuspendLayout()
        Me.grpWebtext.SuspendLayout()
        Me.grpService.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCfg.SuspendLayout()
        Me.stripStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpParsed
        '
        Me.grpParsed.Controls.Add(Me.txtScraped)
        Me.grpParsed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParsed.ForeColor = System.Drawing.Color.DimGray
        Me.grpParsed.Location = New System.Drawing.Point(630, 75)
        Me.grpParsed.Name = "grpParsed"
        Me.grpParsed.Size = New System.Drawing.Size(349, 468)
        Me.grpParsed.TabIndex = 2
        Me.grpParsed.TabStop = False
        Me.grpParsed.Text = "< Parsed Proxies >"
        '
        'txtScraped
        '
        Me.txtScraped.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtScraped.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScraped.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScraped.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtScraped.Location = New System.Drawing.Point(3, 19)
        Me.txtScraped.Name = "txtScraped"
        Me.txtScraped.Size = New System.Drawing.Size(343, 446)
        Me.txtScraped.TabIndex = 0
        Me.txtScraped.Text = ""
        '
        'grpWebtext
        '
        Me.grpWebtext.Controls.Add(Me.txtParse)
        Me.grpWebtext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWebtext.ForeColor = System.Drawing.Color.DimGray
        Me.grpWebtext.Location = New System.Drawing.Point(20, 77)
        Me.grpWebtext.Name = "grpWebtext"
        Me.grpWebtext.Size = New System.Drawing.Size(602, 463)
        Me.grpWebtext.TabIndex = 6
        Me.grpWebtext.TabStop = False
        Me.grpWebtext.Text = "< Parse Text >"
        '
        'txtParse
        '
        Me.txtParse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtParse.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParse.ForeColor = System.Drawing.Color.DimGray
        Me.txtParse.Location = New System.Drawing.Point(3, 14)
        Me.txtParse.Name = "txtParse"
        Me.txtParse.Size = New System.Drawing.Size(593, 443)
        Me.txtParse.TabIndex = 0
        Me.txtParse.Text = "Paste in unformatted webpage text here."
        '
        'grpService
        '
        Me.grpService.Controls.Add(Me.RadioButton4)
        Me.grpService.Controls.Add(Me.PictureBox8)
        Me.grpService.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpService.ForeColor = System.Drawing.Color.DimGray
        Me.grpService.Location = New System.Drawing.Point(20, 563)
        Me.grpService.Name = "grpService"
        Me.grpService.Size = New System.Drawing.Size(153, 52)
        Me.grpService.TabIndex = 93
        Me.grpService.TabStop = False
        Me.grpService.Text = "< Services >"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButton4.Location = New System.Drawing.Point(6, 22)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(89, 19)
        Me.RadioButton4.TabIndex = 13
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "HTTPTunnel"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(98, 25)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox8.TabIndex = 4
        Me.PictureBox8.TabStop = False
        '
        'grpCfg
        '
        Me.grpCfg.Controls.Add(Me.CheckBox1)
        Me.grpCfg.Controls.Add(Me.Label4)
        Me.grpCfg.Controls.Add(Me.lblService)
        Me.grpCfg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCfg.ForeColor = System.Drawing.Color.DimGray
        Me.grpCfg.Location = New System.Drawing.Point(193, 563)
        Me.grpCfg.Name = "grpCfg"
        Me.grpCfg.Size = New System.Drawing.Size(119, 52)
        Me.grpCfg.TabIndex = 92
        Me.grpCfg.TabStop = False
        Me.grpCfg.Text = "< Config >"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox1.Location = New System.Drawing.Point(3, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 19)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "IP:Port Source"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Detected Service:"
        Me.Label4.Visible = False
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(107, 125)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(37, 15)
        Me.lblService.TabIndex = 0
        Me.lblService.Text = "Other"
        Me.lblService.Visible = False
        '
        'btnParse
        '
        Me.btnParse.Location = New System.Drawing.Point(630, 549)
        Me.btnParse.Name = "btnParse"
        Me.btnParse.Size = New System.Drawing.Size(238, 30)
        Me.btnParse.TabIndex = 95
        Me.btnParse.Text = "P A R S E   P R O X I E S"
        Me.btnParse.UseVisualStyleBackColor = True
        '
        'btnReset2
        '
        Me.btnReset2.Location = New System.Drawing.Point(874, 549)
        Me.btnReset2.Name = "btnReset2"
        Me.btnReset2.Size = New System.Drawing.Size(105, 30)
        Me.btnReset2.TabIndex = 94
        Me.btnReset2.Text = "R E S E T"
        Me.btnReset2.UseVisualStyleBackColor = True
        '
        'stripStatus
        '
        Me.stripStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus, Me.SS_springLabel, Me.ToolStripStatusLabel3, Me.lblServer, Me.ToolStripStatusLabel2, Me.lblPcount})
        Me.stripStatus.Location = New System.Drawing.Point(0, 631)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.Size = New System.Drawing.Size(1000, 24)
        Me.stripStatus.TabIndex = 96
        Me.stripStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 19)
        Me.ToolStripStatusLabel1.Text = "STATUS:"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(380, 26)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(210, 30)
        Me.FlatLabel2.TabIndex = 93
        Me.FlatLabel2.Text = "Mega Proxy Scrapper"
        '
        'MegaProxyScrapper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1000, 655)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.stripStatus)
        Me.Controls.Add(Me.btnParse)
        Me.Controls.Add(Me.btnReset2)
        Me.Controls.Add(Me.grpService)
        Me.Controls.Add(Me.grpCfg)
        Me.Controls.Add(Me.grpWebtext)
        Me.Controls.Add(Me.grpParsed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MegaProxyScrapper"
        Me.Text = "Mega Proxy Scrapper"
        Me.grpParsed.ResumeLayout(False)
        Me.grpWebtext.ResumeLayout(False)
        Me.grpService.ResumeLayout(False)
        Me.grpService.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCfg.ResumeLayout(False)
        Me.grpCfg.PerformLayout()
        Me.stripStatus.ResumeLayout(False)
        Me.stripStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpParsed As GroupBox
    Friend WithEvents txtScraped As RichTextBox
    Friend WithEvents grpWebtext As GroupBox
    Friend WithEvents txtParse As RichTextBox
    Friend WithEvents grpService As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents grpCfg As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblService As Label
    Friend WithEvents btnParse As Button
    Friend WithEvents btnReset2 As Button
    Friend WithEvents stripStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents SS_springLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblServer As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblPcount As ToolStripStatusLabel
    Friend WithEvents FlatLabel2 As FlatLabel
End Class
