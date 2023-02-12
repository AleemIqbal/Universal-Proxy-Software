<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProxyLeecher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProxyLeecher))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.FlatTextBox1 = New WindowsApplication2.FlatTextBox()
        Me.FlatButton4 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlatTextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 52)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Url:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 387)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proxies:"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(536, 368)
        Me.ListBox1.TabIndex = 52
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(147, 107)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(134, 38)
        Me.FlatButton3.TabIndex = 56
        Me.FlatButton3.Text = "Copy to Clipboard"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(286, 107)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(134, 38)
        Me.FlatButton2.TabIndex = 55
        Me.FlatButton2.Text = "Save"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(10, 107)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(134, 38)
        Me.FlatButton1.TabIndex = 54
        Me.FlatButton1.Text = "Leech Proxies"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(128, 16)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(232, 30)
        Me.FlatLabel2.TabIndex = 51
        Me.FlatLabel2.Text = "Universal Proxy Leecher"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(7, 14)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(532, 29)
        Me.FlatTextBox1.TabIndex = 48
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(426, 107)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(134, 38)
        Me.FlatButton4.TabIndex = 57
        Me.FlatButton4.Text = "Remove Duplicates"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ProxyLeecher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(569, 558)
        Me.Controls.Add(Me.FlatButton4)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProxyLeecher"
        Me.Text = "Universal Proxy Leecher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
End Class
