Imports WindowsApplication2

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProxyChecker
    Inherits System.Windows.Forms.Form
    Private Shared __ENCList As List(Of WeakReference)
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProxyChecker))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(265, 321)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(289, 34)
        Me.ProgressBar1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 27)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(735, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 19)
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(691, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox3.TabIndex = 78
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(712, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 41)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Universal Proxy Checker"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(562, 77)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel1.TabIndex = 12
        Me.MaterialLabel1.Text = "Total Items :"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(562, 100)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(117, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Checked Items :"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(562, 123)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MaterialLabel3.TabIndex = 4
        Me.MaterialLabel3.Text = "Threads :"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(562, 147)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel7.TabIndex = 15
        Me.MaterialLabel7.Text = "Working :"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(562, 171)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(101, 19)
        Me.MaterialLabel8.TabIndex = 16
        Me.MaterialLabel8.Text = "Not Working :"
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(562, 195)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel12.TabIndex = 16
        Me.MaterialLabel12.Text = "Time Left :"
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.AutoSize = True
        Me.MaterialLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel13.Location = New System.Drawing.Point(562, 218)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel13.TabIndex = 18
        Me.MaterialLabel13.Text = "Timeout :"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(662, 77)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel4.TabIndex = 20
        Me.MaterialLabel4.Text = "0"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(685, 100)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel5.TabIndex = 21
        Me.MaterialLabel5.Text = "0"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(639, 123)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel6.TabIndex = 22
        Me.MaterialLabel6.Text = "0"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(639, 147)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel9.TabIndex = 23
        Me.MaterialLabel9.Text = "0"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(669, 171)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel10.TabIndex = 24
        Me.MaterialLabel10.Text = "0"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(649, 195)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel11.TabIndex = 25
        Me.MaterialLabel11.Text = "0"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(641, 218)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(41, 20)
        Me.NumericUpDown1.TabIndex = 26
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 71)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(544, 239)
        Me.ListView1.TabIndex = 27
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 280
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 120
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(13, 315)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(55, 36)
        Me.MaterialFlatButton1.TabIndex = 28
        Me.MaterialFlatButton1.Text = "Start"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(131, 315)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(111, 36)
        Me.MaterialFlatButton2.TabIndex = 29
        Me.MaterialFlatButton2.Text = "Save Working"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(76, 315)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(47, 36)
        Me.MaterialFlatButton3.TabIndex = 30
        Me.MaterialFlatButton3.Text = "Load"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(563, 315)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(54, 36)
        Me.MaterialFlatButton4.TabIndex = 31
        Me.MaterialFlatButton4.Text = "Clear"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = True
        '
        'ProxyChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(753, 361)
        Me.Controls.Add(Me.MaterialFlatButton4)
        Me.Controls.Add(Me.MaterialFlatButton3)
        Me.Controls.Add(Me.MaterialFlatButton2)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.MaterialLabel11)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel13)
        Me.Controls.Add(Me.MaterialLabel12)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProxyChecker"
        Me.ShowIcon = False
        Me.Text = "Universal Proxy Checker"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Shared Sub New()
        ProxyChecker.__ENCList = New List(Of WeakReference)()
        ProxyChecker.validProxies = New List(Of String)()
        ProxyChecker.savelist = New List(Of String)()
    End Sub
    Public Sub New()
        MyBase.New()
        Dim form11 As ProxyChecker = Me
        AddHandler MyBase.Load, New EventHandler(AddressOf form11.Form3_Load)
        Me.proxiesA = New ListView()
        Me.proxiesB = New ListView()
        Me.proxiesC = New ListView()
        Me.proxiesD = New ListView()
        Me.InitializeComponent()
    End Sub


    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
