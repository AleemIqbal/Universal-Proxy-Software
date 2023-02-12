<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MegaproxyEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MegaproxyEditor))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatButton7 = New WindowsApplication2.FlatButton()
        Me.FlatButton6 = New WindowsApplication2.FlatButton()
        Me.FlatButton5 = New WindowsApplication2.FlatButton()
        Me.FlatButton4 = New WindowsApplication2.FlatButton()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.FlatButton8 = New WindowsApplication2.FlatButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(23, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 547)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(19, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Proxies:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(17, 42)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(516, 122)
        Me.TextBox1.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Combo"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(17, 383)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(516, 130)
        Me.TextBox4.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(17, 183)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(242, 181)
        Me.TextBox3.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Proxy/Port:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(274, 183)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(259, 181)
        Me.TextBox2.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlatButton8)
        Me.GroupBox1.Controls.Add(Me.FlatButton7)
        Me.GroupBox1.Controls.Add(Me.FlatButton6)
        Me.GroupBox1.Controls.Add(Me.FlatButton5)
        Me.GroupBox1.Controls.Add(Me.FlatButton4)
        Me.GroupBox1.Controls.Add(Me.FlatButton3)
        Me.GroupBox1.Controls.Add(Me.FlatButton2)
        Me.GroupBox1.Controls.Add(Me.FlatButton1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(636, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 519)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls:"
        '
        'FlatButton7
        '
        Me.FlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton7.Location = New System.Drawing.Point(18, 398)
        Me.FlatButton7.Name = "FlatButton7"
        Me.FlatButton7.Rounded = False
        Me.FlatButton7.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton7.TabIndex = 61
        Me.FlatButton7.Text = "Exit"
        Me.FlatButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton6.Location = New System.Drawing.Point(18, 346)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton6.TabIndex = 60
        Me.FlatButton6.Text = "Reset"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(18, 242)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton5.TabIndex = 59
        Me.FlatButton5.Text = "Save"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(18, 190)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton4.TabIndex = 58
        Me.FlatButton4.Text = "Combine"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(18, 138)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton3.TabIndex = 57
        Me.FlatButton3.Text = "<"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(18, 86)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton2.TabIndex = 56
        Me.FlatButton2.Text = ">"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(18, 34)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton1.TabIndex = 55
        Me.FlatButton1.Text = "Open"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(34, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Delimiter"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {":", "|", "+", ";"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 458)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(58, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'sfd
        '
        Me.sfd.FileName = "Text File"
        Me.sfd.Filter = "Text File *.txt|*.txt"
        '
        'ofd
        '
        Me.ofd.FileName = "Text File"
        Me.ofd.Filter = "Text File *.txt|*.txt"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(127, 23)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(183, 30)
        Me.FlatLabel2.TabIndex = 63
        Me.FlatLabel2.Text = "Mega Proxy Editor"
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton8.Location = New System.Drawing.Point(18, 294)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = False
        Me.FlatButton8.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton8.TabIndex = 62
        Me.FlatButton8.Text = "Copy to Clipboard"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MegaproxyEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(834, 641)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlatLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MegaproxyEditor"
        Me.Text = "Mega Proxy Editor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents FlatButton8 As FlatButton
End Class
