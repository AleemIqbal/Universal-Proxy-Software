<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MegaProxyLeecher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MegaProxyLeecher))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel7 = New WindowsApplication2.FlatLabel()
        Me.Label3 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel4 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New WindowsApplication2.FlatLabel()
        Me.Label9 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel10 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel9 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel1 = New WindowsApplication2.FlatLabel()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FlatButton8 = New WindowsApplication2.FlatButton()
        Me.FlatButton4 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 58)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(615, 245)
        Me.TextBox1.TabIndex = 80
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(633, 58)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 604)
        Me.TextBox2.TabIndex = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.FlatLabel7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FlatLabel4)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(16, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 211)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(113, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 30)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "0"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel7.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel7.Location = New System.Drawing.Point(63, 115)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(134, 30)
        Me.FlatLabel7.TabIndex = 87
        Me.FlatLabel7.Text = "Total Proxies:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(113, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 30)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "0"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel4.Location = New System.Drawing.Point(63, 42)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(114, 30)
        Me.FlatLabel4.TabIndex = 85
        Me.FlatLabel4.Text = "Total Links:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(149, 25)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(164, 30)
        Me.FlatLabel2.TabIndex = 83
        Me.FlatLabel2.Text = "Paste Links Here"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.FlatLabel10)
        Me.GroupBox2.Controls.Add(Me.FlatLabel9)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(23, 564)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 97)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(145, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 21)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Done"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(13, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 21)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "none"
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel10.Location = New System.Drawing.Point(172, 39)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(0, 30)
        Me.FlatLabel10.TabIndex = 89
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel9.Location = New System.Drawing.Point(12, 59)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(127, 25)
        Me.FlatLabel9.TabIndex = 88
        Me.FlatLabel9.Text = "Current in Use:"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel1.Location = New System.Drawing.Point(628, 25)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(84, 30)
        Me.FlatLabel1.TabIndex = 86
        Me.FlatLabel1.Text = "Proxies:"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(311, 496)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(96, 46)
        Me.FlatButton3.TabIndex = 87
        Me.FlatButton3.Text = "Start"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(413, 496)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(96, 46)
        Me.FlatButton1.TabIndex = 88
        Me.FlatButton1.Text = "Stop"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(515, 496)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(96, 46)
        Me.FlatButton2.TabIndex = 89
        Me.FlatButton2.Text = "Save"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BackgroundWorker1
        '
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton8.Location = New System.Drawing.Point(311, 430)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = False
        Me.FlatButton8.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton8.TabIndex = 90
        Me.FlatButton8.Text = "Copy to Clipboard"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(467, 430)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(144, 46)
        Me.FlatButton4.TabIndex = 91
        Me.FlatButton4.Text = "Remove Duplicates"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MegaProxyLeecher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(901, 674)
        Me.Controls.Add(Me.FlatButton4)
        Me.Controls.Add(Me.FlatButton8)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MegaProxyLeecher"
        Me.Text = "Mega Proxy Leecher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents Label4 As FlatLabel
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents FlatLabel10 As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents Label9 As FlatLabel
    Friend WithEvents Label10 As FlatLabel
    Friend WithEvents Label3 As FlatLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
End Class
