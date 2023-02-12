<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextProxyLeecher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextProxyLeecher))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton5 = New WindowsApplication2.FlatButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 96)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 370)
        Me.TextBox1.TabIndex = 79
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(304, 96)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(286, 370)
        Me.TextBox2.TabIndex = 80
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 475)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(171, 46)
        Me.FlatButton1.TabIndex = 81
        Me.FlatButton1.Text = "Leech"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(301, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Proxies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(9, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Text/HTML:"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(494, 475)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(96, 46)
        Me.FlatButton3.TabIndex = 84
        Me.FlatButton3.Text = "Save"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
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
        Me.FlatLabel2.Location = New System.Drawing.Point(173, 18)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(307, 30)
        Me.FlatLabel2.TabIndex = 53
        Me.FlatLabel2.Text = "Proxy Extracter from Text/HTML"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(339, 475)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(141, 46)
        Me.FlatButton2.TabIndex = 85
        Me.FlatButton2.Text = "Copy to Clipboard"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(189, 475)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton5.TabIndex = 93
        Me.FlatButton5.Text = "Remove Duplicate"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TextProxyLeecher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(602, 533)
        Me.Controls.Add(Me.FlatButton5)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FlatLabel2)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TextProxyLeecher"
        Me.Text = "Text Proxy Leecher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
End Class
