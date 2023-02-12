<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UrlScrapper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UrlScrapper))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox4 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox5 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox6 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox7 = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VCheckBox1)
        Me.GroupBox1.Controls.Add(Me.VCheckBox2)
        Me.GroupBox1.Controls.Add(Me.VCheckBox3)
        Me.GroupBox1.Controls.Add(Me.VCheckBox4)
        Me.GroupBox1.Controls.Add(Me.VCheckBox5)
        Me.GroupBox1.Controls.Add(Me.VCheckBox6)
        Me.GroupBox1.Controls.Add(Me.VCheckBox7)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 270)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sites:"
        '
        'VCheckBox1
        '
        Me.VCheckBox1.AutoSize = True
        Me.VCheckBox1.ForeColor = System.Drawing.Color.White
        Me.VCheckBox1.Location = New System.Drawing.Point(5, 29)
        Me.VCheckBox1.Name = "VCheckBox1"
        Me.VCheckBox1.Size = New System.Drawing.Size(163, 17)
        Me.VCheckBox1.TabIndex = 6
        Me.VCheckBox1.Text = "http://www.socks-proxy.net/"
        Me.VCheckBox1.UseVisualStyleBackColor = True
        '
        'VCheckBox2
        '
        Me.VCheckBox2.AutoSize = True
        Me.VCheckBox2.ForeColor = System.Drawing.Color.White
        Me.VCheckBox2.Location = New System.Drawing.Point(5, 61)
        Me.VCheckBox2.Name = "VCheckBox2"
        Me.VCheckBox2.Size = New System.Drawing.Size(245, 17)
        Me.VCheckBox2.TabIndex = 5
        Me.VCheckBox2.Text = "http://free-proxy-list.net/anonymous-proxy.html"
        Me.VCheckBox2.UseVisualStyleBackColor = True
        '
        'VCheckBox3
        '
        Me.VCheckBox3.AutoSize = True
        Me.VCheckBox3.ForeColor = System.Drawing.Color.White
        Me.VCheckBox3.Location = New System.Drawing.Point(6, 91)
        Me.VCheckBox3.Name = "VCheckBox3"
        Me.VCheckBox3.Size = New System.Drawing.Size(146, 17)
        Me.VCheckBox3.TabIndex = 4
        Me.VCheckBox3.Text = "http://www.us-proxy.org/"
        Me.VCheckBox3.UseVisualStyleBackColor = True
        '
        'VCheckBox4
        '
        Me.VCheckBox4.AutoSize = True
        Me.VCheckBox4.ForeColor = System.Drawing.Color.White
        Me.VCheckBox4.Location = New System.Drawing.Point(5, 124)
        Me.VCheckBox4.Name = "VCheckBox4"
        Me.VCheckBox4.Size = New System.Drawing.Size(161, 17)
        Me.VCheckBox4.TabIndex = 3
        Me.VCheckBox4.Text = "http://www.proxynova.com/"
        Me.VCheckBox4.UseVisualStyleBackColor = True
        '
        'VCheckBox5
        '
        Me.VCheckBox5.AutoSize = True
        Me.VCheckBox5.ForeColor = System.Drawing.Color.White
        Me.VCheckBox5.Location = New System.Drawing.Point(6, 155)
        Me.VCheckBox5.Name = "VCheckBox5"
        Me.VCheckBox5.Size = New System.Drawing.Size(152, 17)
        Me.VCheckBox5.TabIndex = 2
        Me.VCheckBox5.Text = "http://www.sslproxies.org/"
        Me.VCheckBox5.UseVisualStyleBackColor = True
        '
        'VCheckBox6
        '
        Me.VCheckBox6.AutoSize = True
        Me.VCheckBox6.ForeColor = System.Drawing.Color.White
        Me.VCheckBox6.Location = New System.Drawing.Point(6, 185)
        Me.VCheckBox6.Name = "VCheckBox6"
        Me.VCheckBox6.Size = New System.Drawing.Size(120, 17)
        Me.VCheckBox6.TabIndex = 1
        Me.VCheckBox6.Text = "http://proxy-list.org/"
        Me.VCheckBox6.UseVisualStyleBackColor = True
        '
        'VCheckBox7
        '
        Me.VCheckBox7.AutoSize = True
        Me.VCheckBox7.ForeColor = System.Drawing.Color.White
        Me.VCheckBox7.Location = New System.Drawing.Point(6, 212)
        Me.VCheckBox7.Name = "VCheckBox7"
        Me.VCheckBox7.Size = New System.Drawing.Size(167, 17)
        Me.VCheckBox7.TabIndex = 0
        Me.VCheckBox7.Text = "http://www.google-proxy.net/"
        Me.VCheckBox7.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(318, 420)
        Me.ListBox1.TabIndex = 91
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(286, 26)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(151, 30)
        Me.FlatLabel2.TabIndex = 92
        Me.FlatLabel2.Text = "Proxy Scrapper"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(366, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 450)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sites Scraped:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FlatButton3)
        Me.GroupBox3.Controls.Add(Me.FlatButton2)
        Me.GroupBox3.Controls.Add(Me.FlatButton1)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(11, 372)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 166)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls:"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(171, 43)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(128, 35)
        Me.FlatButton2.TabIndex = 97
        Me.FlatButton2.Text = "Export"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(15, 43)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(128, 35)
        Me.FlatButton1.TabIndex = 96
        Me.FlatButton1.Text = "Start Scrapping"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(101, 99)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(128, 35)
        Me.FlatButton3.TabIndex = 98
        Me.FlatButton3.Text = "Copy to Clipboard"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'UrlScrapper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(700, 551)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UrlScrapper"
        Me.Text = "Proxy Scrapper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VCheckBox1 As CheckBox
    Friend WithEvents VCheckBox2 As CheckBox
    Friend WithEvents VCheckBox3 As CheckBox
    Friend WithEvents VCheckBox4 As CheckBox
    Friend WithEvents VCheckBox5 As CheckBox
    Friend WithEvents VCheckBox6 As CheckBox
    Friend WithEvents VCheckBox7 As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
End Class
