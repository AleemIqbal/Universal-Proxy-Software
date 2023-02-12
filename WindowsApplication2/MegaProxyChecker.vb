Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Public Class MegaProxyChecker
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub New()
        Me.proxyList = New List(Of String)
        Me.cleanSource = False
        Me.curPage = 0
        Me.grabbingCheck = False
        Me.done1 = False
        Me.done2 = False
        Me.done3 = False
        Me.done4 = False
        Me.done5 = False
        Me.done6 = False
        Me.Reset = False
        Me.importCheck = False
        Me._ThreadCount = 1
        Me.InitializeComponent()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Me.lbOriginal.Items.Clear()
        Dim dialog As New OpenFileDialog
        dialog.Filter = "Text (*.txt)|*.txt"
        If (dialog.ShowDialog = DialogResult.OK) Then
            Dim fileName As String = dialog.FileName
            Me.txtImport.Text = fileName
            Dim items As String() = File.ReadAllLines(fileName)
            Me.lbOriginal.Items.AddRange(items)
            Me.lblCLoaded.Text = Conversions.ToString(Me.lbOriginal.Items.Count)
            Me.importCheck = True
            Me.setStatus("Successfully imported proxy list.")
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim enumerator As IEnumerator = Nothing
        If Not Me.importCheck Then
            Me.lblCLoaded.Text = Conversions.ToString(Me.lbOriginal.Items.Count)
        End If
        Me.fileLoc = ("Checked_Proxies_Temp_" & DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") & ".txt")
        Dim writer As New StreamWriter(Me.fileLoc)
        Try
            enumerator = Me.lbOriginal.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim str As String = Conversions.ToString(enumerator.Current)
                writer.WriteLine(str)
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        writer.Close()
        Me.proxyCList = Me.fileLoc
        If Not Me.CheckingC Then
            Me.setStatus("Started checking proxies...")
            Me.CheckingC = True
            Me.btnStart.Enabled = False
            Me.btnImport.Enabled = False
            Me.proxyReader = New StreamReader(Me.proxyCList)
            Dim threadCount As Integer = Me.ThreadCount
            Dim i As Integer = 0
            Do While (i <= threadCount)
                Dim thread As New Thread(New ThreadStart(AddressOf Me.checkProxy))
                thread.IsBackground = True
                thread.Start()
                i += 1
            Loop
        End If
    End Sub

    Private Sub Lam__10()
        Me.lblCInvalid.Text = Conversions.ToString(CDbl((Conversions.ToDouble(Me.lblCInvalid.Text) + 1)))
    End Sub


    Private Sub Lam__8()
        Dim lblCValid As Label = Me.lblCValid
        lblCValid.Text = Conversions.ToString(CDbl((Conversions.ToDouble(lblCValid.Text) + 1)))
    End Sub

    Private Sub Lam__9()
        Me.lblCInvalid.Text = Conversions.ToString(CDbl((Conversions.ToDouble(Me.lblCInvalid.Text) + 1)))
    End Sub

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim str As String = Nothing
        Dim managed As New RijndaelManaged
        Dim provider As New MD5CryptoServiceProvider
        Try
            Dim destinationArray As Byte() = New Byte(&H20 - 1) {}
            Dim sourceArray As Byte() = provider.ComputeHash(Encoding.ASCII.GetBytes(pass))
            Array.Copy(sourceArray, 0, destinationArray, 0, &H10)
            Array.Copy(sourceArray, 0, destinationArray, 15, &H10)
            managed.Key = destinationArray
            managed.Mode = CipherMode.ECB
            Dim transform As ICryptoTransform = managed.CreateDecryptor
            Dim inputBuffer As Byte() = Convert.FromBase64String(input)
            str = Encoding.ASCII.GetString(transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Sub checkProxy()
        Dim stopwatch As New Stopwatch
        Try
            Do
                Dim request As HttpWebRequest
                If Me.proxyReader.EndOfStream Then
                    GoTo Label_0108
                End If
                Try
                    Dim address As String = Me.proxyReader.ReadLine.Trim
                    request = DirectCast(WebRequest.Create("http://www.google.com"), HttpWebRequest)
                    request.Proxy = New WebProxy(address)
                    request.Timeout = Convert.ToInt32(Me.numPtimeout.Value)
                    stopwatch.Start()
                    Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
                    stopwatch.Stop()

                    If (stopwatch.Elapsed.Milliseconds <> 0) Then
                        Me.UpdateListview((address & "#" & Conversions.ToString(stopwatch.Elapsed.Milliseconds) & "ms"))
                        Me.Invoke(New AnonymousDelegate_0(AddressOf Me.Lam__8))
                    End If
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Me.Invoke(New AnonymousDelegate_0(AddressOf Me.Lam__9))
                    ProjectData.ClearProjectError()
                Finally
                    request = Nothing
                    stopwatch.Reset()
                End Try
            Loop While Me.CheckingC
            Return
Label_0108:
            Me.setStatus("Done checking; Idle.")
        Catch exception3 As Exception
            ProjectData.SetProjectError(exception3)
            Try
                Me.Invoke(New AnonymousDelegate_0(AddressOf Me.Lam__10))
            Catch ex As Exception

            End Try

            ProjectData.ClearProjectError()
        End Try
    End Sub



    Private Sub numThreads_ValueChanged(sender As Object, e As EventArgs) Handles numThreads.ValueChanged
        Me.ThreadCount = Convert.ToInt32(Me.numThreads.Value)
    End Sub
    Public Function parseText(ByRef total As String, ByVal first As String, ByVal last As String) As Object
        Dim obj2 As Object = Nothing
        Try
            Dim start As Short = CShort(((total.IndexOf(first) + 1) + first.Length))
            obj2 = Strings.Trim(Strings.Mid(total, start, (total.Substring(start).IndexOf(last) + 1)))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Return obj2
    End Function
    Private Sub setStatus(status As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub()
                                     Me.lblStatus.Text = status
                                 End Sub))
        Else
            Me.lblStatus.Text = status
        End If
    End Sub



    Public Sub UpdateListview(ByVal proxyString As String)
        If Me.proxyBox.InvokeRequired Then
            Me.Invoke(New _UpdateListview(AddressOf Me.UpdateListview), New Object() {proxyString})
        Else
            Dim strArray As String() = proxyString.Split(New Char() {"#"c})
            Dim text As String = strArray(0)
            Dim str2 As String = strArray(1)
            Dim str3 As String = String.Empty
            Me.proxyBox.Columns.Item(1).TextAlign = HorizontalAlignment.Center
            Dim item As ListViewItem = Me.proxyBox.Items.Add([text])
            item.UseItemStyleForSubItems = False
            str3 = str2.Remove((str2.Length - 2))
            Convert.ToInt32(str3)
            item.SubItems.Add(str2)
            If (Conversions.ToDouble(str3) > 900) Then
                item.SubItems.Item(1).BackColor = Color.LightCoral
            ElseIf ((Conversions.ToDouble(str3) > 500) And (Conversions.ToDouble(str3) < 900)) Then
                item.SubItems.Item(1).BackColor = Color.MediumSeaGreen
            ElseIf ((Conversions.ToDouble(str3) < 500) And (Conversions.ToDouble(str3) > 100)) Then
                item.SubItems.Item(1).BackColor = Color.SeaGreen
            Else
                item.SubItems.Item(1).BackColor = Color.Green
            End If
            item.SubItems.Item(1).ForeColor = Color.White
            Me.proxyBox.EnsureVisible((Me.proxyBox.Items.Count - 1))
        End If
    End Sub

    Public Property Checking1 As Boolean
        Get
            Return Me._Checking1
        End Get
        Set(ByVal value As Boolean)
            Me._Checking1 = value
        End Set
    End Property

    Public Property Checking2 As Boolean
        Get
            Return Me._Checking2
        End Get
        Set(ByVal value As Boolean)
            Me._Checking2 = value
        End Set
    End Property

    Public Property Checking3 As Boolean
        Get
            Return Me._Checking3
        End Get
        Set(ByVal value As Boolean)
            Me._Checking3 = value
        End Set
    End Property

    Public Property Checking4 As Boolean
        Get
            Return Me._Checking4
        End Get
        Set(ByVal value As Boolean)
            Me._Checking4 = value
        End Set
    End Property

    Public Property Checking5 As Boolean
        Get
            Return Me._Checking5
        End Get
        Set(ByVal value As Boolean)
            Me._Checking5 = value
        End Set
    End Property

    Public Property Checking6 As Boolean
        Get
            Return Me._Checking6
        End Get
        Set(ByVal value As Boolean)
            Me._Checking6 = value
        End Set
    End Property

    Public Property CheckingC As Boolean
        Get
            Return Me._CheckingC
        End Get
        Set(ByVal value As Boolean)
            Me._CheckingC = value
        End Set
    End Property

    Public Property proxyCList As String
        Get
            Return Me._proxyCList
        End Get
        Set(ByVal value As String)
            Me._proxyCList = value
        End Set
    End Property

    Public Property proxyReader As StreamReader
        Get
            Return Me._ProxyReader
        End Get
        Set(ByVal value As StreamReader)
            Me._ProxyReader = value
        End Set
    End Property
    Public Property ThreadCount As Integer
        Get
            Return Me._ThreadCount
        End Get
        Set(ByVal value As Integer)
            Me._ThreadCount = value
        End Set
    End Property


    '  Private _CheckBox2 As CheckBox
    Private _Checking1 As Boolean
    Private _Checking2 As Boolean
    Private _Checking3 As Boolean
    Private _Checking4 As Boolean
    Private _Checking5 As Boolean
    Private _Checking6 As Boolean
    Private _CheckingC As Boolean
    Private _proxyCList As String
    Private _ProxyReader As StreamReader
    Private _ThreadCount As Integer
    Private cleanSource As Boolean
    Private curPage As Integer
    Private done1 As Boolean
    Private done2 As Boolean
    Private done3 As Boolean
    Private done4 As Boolean
    Private done5 As Boolean
    Private done6 As Boolean
    Private fileLoc As String
    Private grabbingCheck As Boolean
    Private importCheck As Boolean
    Private proxyList As List(Of String)
    Private Reset As Boolean
    Private Const Tc As Integer = 1



    Friend Class Clousure__1
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__1)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_newStr = other.VBLOC_newStr
            End If
        End Sub


        ' Fields
        Public VBLOC_newStr As String
        Public vbme As MegaProxyChecker
    End Class

    <CompilerGenerated>
    Friend Class Clousure__2
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__2)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_lines = other.VBLOC_lines
                Me.VBLOC_rawIP = other.VBLOC_rawIP
            End If
        End Sub



        ' Fields
        Public VBLOC_lines As String()
        Public VBLOC_rawIP As String
        Public vbme As MegaProxyChecker
    End Class

    <CompilerGenerated>
    Friend Class Clousure__3
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__3)
            If (Not other Is Nothing) Then
                Me.VBLOC_item = other.VBLOC_item
                Me.vbme = other.vbme
            End If
        End Sub


        ' Fields
        Public VBLOC_item As String
        Public vbme As MegaProxyChecker
    End Class

    Friend Class Clousure__4
        Public Sub New()
        End Sub

        Public Sub New(ByVal other As Clousure__4)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_status = other.VBLOC_status
            End If
        End Sub

        Public Sub Lam__6()
            Me.vbme.lblStatus.Text = Me.VBLOC_status
        End Sub


        ' Fields
        Public VBLOC_status As String
        Public vbme As MegaProxyChecker
    End Class

    Friend Class Clousure__5
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__5)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_status = other.VBLOC_status
            End If
        End Sub


        ' Fields
        Public VBLOC_status As String
        Public vbme As MegaProxyChecker
    End Class

    <CompilerGenerated>
    Friend Class Clousure__6
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__6)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_encAnn = other.VBLOC_encAnn
            End If
        End Sub



        ' Fields
        Public VBLOC_encAnn As String
        Public vbme As MegaProxyChecker
    End Class

    Friend Class Clousure__7
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__7)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_ex = other.VBLOC_ex
            End If
        End Sub


        ' Fields
        Public VBLOC_ex As Exception
        Public vbme As MegaProxyChecker
    End Class

    Public Delegate Sub _UpdateListview(ByVal proxyString As String)
    Friend Delegate Sub AnonymousDelegate_0()


    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        Dim S_W As IO.StreamWriter
        Dim save As New SaveFileDialog
        save.FileName = "ProxiesChecked"
        save.Filter = "ProxiesChecked (*.txt)|*.txt|ALL Files (*.*)|*.*"
        save.CheckPathExists = True
        save.ShowDialog(Me)
        Dim enumerator As IEnumerator = Nothing
        Me.CheckingC = False
        If (Not Me.proxyReader Is Nothing) Then
            Me.proxyReader.Dispose()
        End If
        Me.btnStart.Enabled = True
        Me.btnImport.Enabled = True
        Me.btnStop.Enabled = False
        If File.Exists(Me.fileLoc) Then
            File.Delete(Me.fileLoc)
        End If
        Me.fileLoc = ("ProxiesChecked.txt")
        S_W = New IO.StreamWriter(save.FileName)
        Try
            enumerator = Me.proxyBox.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                S_W.WriteLine(current.Text)
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        S_W.Close()
        Me.importCheck = False
        Me.setStatus("Stopped checking; Idle.")
    End Sub

    Private Sub FlatButton2_Click_1(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim buffer As New StringBuilder

        buffer.Append(" ")
        If (proxyBox.Items.Count > 0) Then
            buffer.Clear()

            For i As Integer = 0 To proxyBox.Items.Count - 1
                buffer.Append(proxyBox.Items(i).SubItems(0).Text)
                buffer.Append(vbCrLf)
            Next
        End If



        My.Computer.Clipboard.SetText(buffer.ToString)
    End Sub

    Private Sub MegaProxyChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim enumerator As IEnumerator = Nothing
        Me.CheckingC = False
        If (Not Me.proxyReader Is Nothing) Then
            Me.proxyReader.Dispose()
        End If
        Me.btnStart.Enabled = True
        Me.btnImport.Enabled = True
        Me.btnStop.Enabled = False
        Me.importCheck = False
        Me.setStatus("Stopped checking; Idle.")
    End Sub
End Class