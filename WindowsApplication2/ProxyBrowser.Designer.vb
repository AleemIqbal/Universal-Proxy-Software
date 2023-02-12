<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProxyBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProxyBrowser))
        Me.FlatLabel1 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel3 = New WindowsApplication2.FlatLabel()
        Me.FlatButton8 = New WindowsApplication2.FlatButton()
        Me.FlatLabel4 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel5 = New WindowsApplication2.FlatLabel()
        Me.FlatTextBox2 = New WindowsApplication2.FlatTextBox()
        Me.FlatTextBox3 = New WindowsApplication2.FlatTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Browser = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatTextBox1 = New WindowsApplication2.FlatTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Browser.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(4, 41)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(26, 21)
        Me.FlatLabel1.TabIndex = 89
        Me.FlatLabel1.Text = "IP:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(210, 41)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(41, 21)
        Me.FlatLabel3.TabIndex = 95
        Me.FlatLabel3.Text = "Port:"
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton8.Location = New System.Drawing.Point(439, 33)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = False
        Me.FlatButton8.Size = New System.Drawing.Size(234, 29)
        Me.FlatButton8.TabIndex = 97
        Me.FlatButton8.Text = "Use Proxy"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(251, 100)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(97, 19)
        Me.FlatLabel4.TabIndex = 98
        Me.FlatLabel4.Text = "Current Proxy:"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(354, 100)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(80, 19)
        Me.FlatLabel5.TabIndex = 99
        Me.FlatLabel5.Text = "0.0.0.0.0:21"
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(36, 33)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = False
        Me.FlatTextBox2.Size = New System.Drawing.Size(168, 29)
        Me.FlatTextBox2.TabIndex = 102
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatTextBox3
        '
        Me.FlatTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox3.Location = New System.Drawing.Point(276, 33)
        Me.FlatTextBox3.MaxLength = 32767
        Me.FlatTextBox3.Multiline = False
        Me.FlatTextBox3.Name = "FlatTextBox3"
        Me.FlatTextBox3.ReadOnly = False
        Me.FlatTextBox3.Size = New System.Drawing.Size(113, 29)
        Me.FlatTextBox3.TabIndex = 103
        Me.FlatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox3.UseSystemPasswordChar = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.FlatTextBox3)
        Me.GroupBox1.Controls.Add(Me.FlatTextBox2)
        Me.GroupBox1.Controls.Add(Me.FlatLabel5)
        Me.GroupBox1.Controls.Add(Me.FlatLabel4)
        Me.GroupBox1.Controls.Add(Me.FlatButton8)
        Me.GroupBox1.Controls.Add(Me.FlatLabel3)
        Me.GroupBox1.Controls.Add(Me.FlatLabel1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 142)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(6, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(795, 529)
        Me.TabControl1.TabIndex = 107
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(787, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Browser"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(-4, -2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(795, 478)
        Me.WebBrowser1.TabIndex = 106
        '
        'Browser
        '
        Me.Browser.Controls.Add(Me.TabPage2)
        Me.Browser.Location = New System.Drawing.Point(8, 219)
        Me.Browser.Name = "Browser"
        Me.Browser.SelectedIndex = 0
        Me.Browser.Size = New System.Drawing.Size(797, 498)
        Me.Browser.TabIndex = 107
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(789, 472)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Browser"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(403, 19)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(81, 29)
        Me.FlatButton1.TabIndex = 110
        Me.FlatButton1.Text = "Go"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(15, 19)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(372, 29)
        Me.FlatTextBox1.TabIndex = 109
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlatButton1)
        Me.GroupBox2.Controls.Add(Me.FlatTextBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(137, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 57)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Navigate:"
        '
        'ProxyBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(819, 726)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProxyBrowser"
        Me.Text = "Proxy Viewer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Browser.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents FlatTextBox2 As FlatTextBox
    Friend WithEvents FlatTextBox3 As FlatTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Browser As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
