<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UniversalProxyCombiner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UniversalProxyCombiner))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Ports = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.ofd2 = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.FlatButton3 = New WindowsApplication2.FlatButton()
        Me.FlatButton2 = New WindowsApplication2.FlatButton()
        Me.FlatButton1 = New WindowsApplication2.FlatButton()
        Me.FlatLabel2 = New WindowsApplication2.FlatLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IPS})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(247, 310)
        Me.DataGridView1.TabIndex = 80
        '
        'IPS
        '
        Me.IPS.HeaderText = "IPS"
        Me.IPS.Name = "IPS"
        Me.IPS.Width = 219
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ports})
        Me.DataGridView2.Location = New System.Drawing.Point(256, 65)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(252, 310)
        Me.DataGridView2.TabIndex = 81
        '
        'Ports
        '
        Me.Ports.HeaderText = "PORTS"
        Me.Ports.Name = "Ports"
        Me.Ports.Width = 219
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        '
        'ofd2
        '
        Me.ofd2.FileName = "ofd2"
        '
        'sfd
        '
        Me.sfd.FileName = "Proxies.txt"
        Me.sfd.Filter = "Text File *.txt|*.txt"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(417, 381)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(91, 38)
        Me.FlatButton3.TabIndex = 84
        Me.FlatButton3.Text = "Load Ports"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(216, 381)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(91, 38)
        Me.FlatButton2.TabIndex = 83
        Me.FlatButton2.Text = "Save Proxies"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 381)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(91, 38)
        Me.FlatButton1.TabIndex = 82
        Me.FlatButton1.Text = "Load IPS"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.FlatLabel2.Location = New System.Drawing.Point(123, 10)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(250, 30)
        Me.FlatLabel2.TabIndex = 79
        Me.FlatLabel2.Text = "Universal Proxy Combiner"
        '
        'UniversalProxyCombiner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(516, 443)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FlatLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UniversalProxyCombiner"
        Me.Text = "Universal Proxy Combiner"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IPS As DataGridViewTextBoxColumn
    Friend WithEvents Ports As DataGridViewTextBoxColumn
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents ofd2 As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
End Class
