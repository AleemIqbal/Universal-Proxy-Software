<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExtractfromText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtractfromText))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatButton5 = New WindowsApplication2.FlatButton()
        Me.FlatButton4 = New WindowsApplication2.FlatButton()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.FlatButton6 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlatButton6)
        Me.GroupBox1.Controls.Add(Me.FlatButton5)
        Me.GroupBox1.Controls.Add(Me.FlatButton4)
        Me.GroupBox1.Controls.Add(Me.FlatButton3)
        Me.GroupBox1.Controls.Add(Me.FlatButton2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.FlatButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(793, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 518)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(18, 255)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(126, 46)
        Me.FlatButton5.TabIndex = 65
        Me.FlatButton5.Text = "Copy to Clipboard"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(18, 307)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(126, 46)
        Me.FlatButton4.TabIndex = 64
        Me.FlatButton4.Text = "Reset"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(18, 203)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(126, 46)
        Me.FlatButton3.TabIndex = 63
        Me.FlatButton3.Text = "Save"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(18, 95)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(126, 46)
        Me.FlatButton2.TabIndex = 62
        Me.FlatButton2.Text = "Leech"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Controls:"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(18, 43)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(126, 46)
        Me.FlatButton1.TabIndex = 55
        Me.FlatButton1.Text = "Open"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(754, 513)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(366, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Proxies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Text:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(6, 34)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 463)
        Me.TextBox1.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(369, 34)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(366, 463)
        Me.TextBox2.TabIndex = 27
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'sfd
        '
        Me.sfd.InitialDirectory = "Leeched.txt"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(291, 9)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(241, 30)
        Me.FlatLabel2.TabIndex = 53
        Me.FlatLabel2.Text = "Extract Proxies from Text"
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton6.Location = New System.Drawing.Point(18, 147)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(126, 50)
        Me.FlatButton6.TabIndex = 92
        Me.FlatButton6.Text = "Remove Duplicates"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ExtractfromText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1005, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlatLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExtractfromText"
        Me.Text = "Mega Text Combo Leecher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
End Class
