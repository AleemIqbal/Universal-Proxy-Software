<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProxyGrabber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProxyGrabber))
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FlatButton4 = New WindowsApplication2.FlatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(51, 19)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(173, 38)
        Me.FlatButton1.TabIndex = 44
        Me.FlatButton1.Text = "Get Proxy"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(51, 112)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(173, 38)
        Me.FlatButton2.TabIndex = 45
        Me.FlatButton2.Text = "Export"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(51, 63)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(173, 38)
        Me.FlatButton3.TabIndex = 46
        Me.FlatButton3.Text = "Reset"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.RadioButton1.Location = New System.Drawing.Point(15, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 29)
        Me.RadioButton1.TabIndex = 35
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Https"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.RadioButton2.Location = New System.Drawing.Point(15, 89)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(96, 29)
        Me.RadioButton2.TabIndex = 36
        Me.RadioButton2.Text = "Socks5"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(23, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 255)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proxy Type:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 474)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(14, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Proxies:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(693, 446)
        Me.ListBox1.TabIndex = 33
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(51, 156)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(173, 38)
        Me.FlatButton4.TabIndex = 50
        Me.FlatButton4.Text = "Copy to Clipboard"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FlatButton4)
        Me.GroupBox3.Controls.Add(Me.FlatButton3)
        Me.GroupBox3.Controls.Add(Me.FlatButton1)
        Me.GroupBox3.Controls.Add(Me.FlatButton2)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(23, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 200)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls:"
        '
        'ProxyGrabber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1028, 499)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProxyGrabber"
        Me.Text = "Proxy Grabber"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents GroupBox3 As GroupBox
End Class
