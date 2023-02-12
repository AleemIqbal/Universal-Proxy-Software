<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProxyChanger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProxyChanger))
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatTextBox2 = New WindowsApplication2.FlatTextBox()
        Me.FlatTextBox1 = New WindowsApplication2.FlatTextBox()
        Me.FlatLabel4 = New WindowsApplication2.FlatLabel()
        Me.FlatLabel3 = New WindowsApplication2.FlatLabel()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(30, 29)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(238, 30)
        Me.FlatLabel2.TabIndex = 52
        Me.FlatLabel2.Text = "Universal Proxy Changer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlatTextBox2)
        Me.GroupBox1.Controls.Add(Me.FlatTextBox1)
        Me.GroupBox1.Controls.Add(Me.FlatLabel4)
        Me.GroupBox1.Controls.Add(Me.FlatLabel3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(14, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 213)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(22, 165)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = False
        Me.FlatTextBox2.Size = New System.Drawing.Size(201, 29)
        Me.FlatTextBox2.TabIndex = 57
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = False
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(22, 80)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(201, 29)
        Me.FlatTextBox1.TabIndex = 56
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(23, 137)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(21, 17)
        Me.FlatLabel4.TabIndex = 53
        Me.FlatLabel4.Text = "IP:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(18, 56)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(43, 17)
        Me.FlatLabel3.TabIndex = 52
        Me.FlatLabel3.Text = "Proxy:"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(14, 337)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(159, 38)
        Me.FlatButton1.TabIndex = 55
        Me.FlatButton1.Text = "Change PC IP"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(207, 337)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(91, 38)
        Me.FlatButton2.TabIndex = 56
        Me.FlatButton2.Text = "Disable Proxy"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ProxyChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(317, 401)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlatLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProxyChanger"
        Me.Text = "Universal Proxy Changer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatTextBox2 As FlatTextBox
    Friend WithEvents FlatTextBox1 As FlatTextBox
End Class
