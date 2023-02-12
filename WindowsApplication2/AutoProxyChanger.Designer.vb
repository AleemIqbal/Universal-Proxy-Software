<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoProxyChanger
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoProxyChanger))
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatTextBox3 = New WindowsApplication2.FlatTextBox()
        Me.FlatLabel5 = New WindowsApplication2.FlatLabel()
        Me.FlatTextBox2 = New WindowsApplication2.FlatTextBox()
        Me.FlatLabel4 = New WindowsApplication2.FlatLabel()
        Me.FlatTextBox1 = New WindowsApplication2.FlatTextBox()
        Me.FlatLabel1 = New WindowsApplication2.FlatLabel()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlatButton4 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(99, 22)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(199, 30)
        Me.FlatLabel2.TabIndex = 88
        Me.FlatLabel2.Text = "Auto Proxy Changer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlatTextBox3)
        Me.GroupBox1.Controls.Add(Me.FlatLabel5)
        Me.GroupBox1.Controls.Add(Me.FlatTextBox2)
        Me.GroupBox1.Controls.Add(Me.FlatLabel4)
        Me.GroupBox1.Controls.Add(Me.FlatTextBox1)
        Me.GroupBox1.Controls.Add(Me.FlatLabel1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(24, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 317)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IP Changer:"
        '
        'FlatTextBox3
        '
        Me.FlatTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox3.Location = New System.Drawing.Point(16, 244)
        Me.FlatTextBox3.MaxLength = 32767
        Me.FlatTextBox3.Multiline = False
        Me.FlatTextBox3.Name = "FlatTextBox3"
        Me.FlatTextBox3.ReadOnly = False
        Me.FlatTextBox3.Size = New System.Drawing.Size(338, 29)
        Me.FlatTextBox3.TabIndex = 61
        Me.FlatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox3.UseSystemPasswordChar = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(13, 212)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(120, 17)
        Me.FlatLabel5.TabIndex = 60
        Me.FlatLabel5.Text = "Enter Path of a File:"
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(16, 165)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = False
        Me.FlatTextBox2.Size = New System.Drawing.Size(338, 29)
        Me.FlatTextBox2.TabIndex = 59
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(13, 136)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(77, 17)
        Me.FlatLabel4.TabIndex = 58
        Me.FlatLabel4.Text = "Time in Sec:"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(16, 93)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(338, 29)
        Me.FlatTextBox1.TabIndex = 57
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(13, 58)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(90, 17)
        Me.FlatLabel1.TabIndex = 54
        Me.FlatLabel1.Text = "Current Proxy:"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(24, 395)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(69, 38)
        Me.FlatButton1.TabIndex = 62
        Me.FlatButton1.Text = "Start"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(194, 395)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(79, 38)
        Me.FlatButton2.TabIndex = 90
        Me.FlatButton2.Text = "Stop"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(279, 395)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(118, 38)
        Me.FlatButton3.TabIndex = 91
        Me.FlatButton3.Text = "Disable Proxy"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(99, 395)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(90, 38)
        Me.FlatButton4.TabIndex = 92
        Me.FlatButton4.Text = "Open Proxies"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'AutoProxyChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(413, 446)
        Me.Controls.Add(Me.FlatButton4)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlatLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AutoProxyChanger"
        Me.Text = "Auto Proxy Changer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatTextBox2 As FlatTextBox
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents FlatTextBox3 As FlatTextBox
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlatButton4 As FlatButton
End Class
