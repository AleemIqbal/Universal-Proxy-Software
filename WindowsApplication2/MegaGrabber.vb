Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class MegaGrabber
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim S_W As IO.StreamWriter
        Dim save As New SaveFileDialog
        save.FileName = "MegaProxy"
        save.Filter = "MegaProxy (*.txt)|*.txt|ALL Files (*.*)|*.*"
        save.CheckPathExists = True
        save.ShowDialog(Me)
        Dim enumerator As IEnumerator = Nothing
        Dim path As String = ("MegaProxy.txt")
        S_W = New IO.StreamWriter(save.FileName)
        enumerator = Me.lbMain.Items.GetEnumerator
        For Each o As Object In lbMain.Items
            S_W.WriteLine(o.ToString())
        Next
        S_W.Flush()
        S_W.Close()
    End Sub

    Private Sub btnGrab_Click(sender As Object, e As EventArgs) Handles btnGrab.Click
        If Not Me.grabbingCheck Then
            Me.lbMain.Items.Clear()
            Me.lbMain.Items.Add("Proxies grabbed using Mega Proxy Grabber.")
            Me.lbMain.Items.Add("+----------------------+")
            Me.grabbingCheck = True
            Me.firstCall()
            Me.secondCall()
            Me.thirdCall()
            Me.fourthCall()
            Me.fifthCall()
            Me.sixthCall()
            Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://sslproxies24.blogspot.com/feeds/posts/default")
            Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
            Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
            Dim code As String = stream_reader.ReadToEnd
            Dim expression As New System.Text.RegularExpressions.Regex("\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}")
            Dim mtac As MatchCollection = expression.Matches(code)
            For Each itemcode As Match In mtac
                lbMain.Items.Add(itemcode)
            Next
            Dim the_request2 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.httptunnel.ge/ProxyListForFree.aspx")
            Dim the_response2 As System.Net.HttpWebResponse = the_request2.GetResponse
            Dim stream_reader2 As System.IO.StreamReader = New System.IO.StreamReader(the_response2.GetResponseStream())
            Dim code2 As String = stream_reader2.ReadToEnd
            Dim expression2 As New System.Text.RegularExpressions.Regex("\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}")
            Dim mtac2 As MatchCollection = expression2.Matches(code2)
            For Each itemcode2 As Match In mtac2
                lbMain.Items.Add(itemcode2)
            Next
            Dim the_request3 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://proxylistforfree.blogspot.com/feeds/posts/default")
            Dim the_response3 As System.Net.HttpWebResponse = the_request3.GetResponse
            Dim stream_reader3 As System.IO.StreamReader = New System.IO.StreamReader(the_response3.GetResponseStream())
            Dim code3 As String = stream_reader3.ReadToEnd
            Dim expression3 As New System.Text.RegularExpressions.Regex("\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}")
            Dim mtac3 As MatchCollection = expression3.Matches(code3)
            For Each itemcode3 As Match In mtac3
                lbMain.Items.Add(itemcode3)
            Next
            For Row As Int16 = 0 To lbMain.Items.Count - 2
                For RowAgain As Int16 = lbMain.Items.Count - 1 To Row + 1 Step -1
                    If lbMain.Items(Row).ToString = lbMain.Items(RowAgain).ToString Then
                        lbMain.Items.RemoveAt(RowAgain)
                    End If
                Next
            Next
        Else
            MessageBox.Show("Mega Proxy Grabber is currently busy grabbing proxies!", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub


    Private Sub Lam__11()
        Me.txtLog.Text = "Getting new info..." & ChrW(13) & ChrW(10)
    End Sub


    Private Sub fifthCall()
        If Not Me.Reset Then
            If Not Me.Checking5 Then
                Me.Checking5 = True
                Dim thread As New Thread(New ThreadStart(AddressOf Me.fifthList))
                thread.IsBackground = True
                thread.Start()
            Else
                Me.Checking5 = False
            End If
        End If
    End Sub

    Private Sub fifthList()
        Me.setStatus("Grabbing proxies..")
        Me.curPage += 1
        Me.lblServer.Text = "socksproxylist24"
        Me.grabBlogger("socksproxylist24")
        Me.setStatus("Grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "newfreshproxies24"
        Me.grabBlogger("newfreshproxies24")
        Me.done5 = True
        Me.finalCheck("Done")
    End Sub

    Private Sub finalCheck(ByVal item As String)
        Dim ezar As New Clousure__3
        ezar.VBLOC_item = item
        ezar.vbme = Me
        Dim num As Integer = 0
        Dim num3 As Integer = 0
        Dim num2 As Integer = 0
        If (ezar.VBLOC_item.ToUpper = ezar.VBLOC_item.ToLower) Then
            num = 0
            num3 = 0
            num2 = 0
            Dim str As String = ezar.VBLOC_item
            Dim num5 As Integer = 0
            Dim length As Integer = str.Length
            Do While (num5 < length)
                Dim expression As Char = str.Chars(num5)
                If Versioned.IsNumeric(expression) Then
                    num += 1
                End If
                If (Conversions.ToString(expression) = ".") Then
                    num3 += 1
                End If
                If (Conversions.ToString(expression) = ":") Then
                    num2 += 1
                End If
                num5 += 1
            Loop
            If ((((num >= 4) And (num < &H16)) And (num3 = 3)) And (num2 = 1)) Then
                Me.Invoke(New AnonymousDelegate_0(AddressOf ezar.Lam__5))
            End If
        End If
        Dim i As Integer = (Me.lbMain.Items.Count - 1)
        Do While (i >= 0)
            If (Me.lbMain.Items.Item(i).ToString.Trim.Length = 0) Then
                Me.lbMain.Items.RemoveAt(i)
            End If
            i = (i + -1)
        Loop
        If (((((Me.done1 And Me.done2) And Me.done3) And Me.done4) And Me.done5) And Me.done6) Then
            Me.setStatus("Done grabbing proxies.")
        End If
    End Sub

    Private Sub firstCall()
        If Not Me.Reset Then
            If Not Me.Checking1 Then
                Me.Checking1 = True
                Dim thread As New Thread(New ThreadStart(AddressOf Me.firstList))
                thread.IsBackground = True
                thread.Start()
            Else
                Me.Checking1 = False
            End If
        End If
    End Sub

    Private Sub firstList()
        Me.setStatus("Started grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "free-proxy-list"
        Me.grabFplf("http://www.free-proxy-list.net/")
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "hide-my-ip"
        Me.grabHideMyIP()
        Me.curPage += 1
        Me.lblServer.Text = "IPCN"
        Me.grabIPCN()
        Me.setStatus("Grabbing proxies..")
        Me.curPage += 1
        Me.lblServer.Text = "Domain-Geek"
        Me.grabDomainGeek()
        Me.setStatus("Grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "sslproxies"
        Me.grabFplf("http://www.sslproxies.org/")
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "us-proxy"
        Me.grabFplf("http://www.us-proxy.org/")
        Me.done1 = True
        Me.finalCheck("Done")
    End Sub

    Private Sub fourthCall()
        If Not Me.Reset Then
            If Not Me.Checking4 Then
                Me.Checking4 = True
                Dim thread As New Thread(New ThreadStart(AddressOf Me.fourthList))
                thread.IsBackground = True
                thread.Start()
            Else
                Me.Checking4 = False
            End If
        End If
    End Sub

    Private Sub fourthList()
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "proxyrox"
        Me.grabProxyRox()
        Me.setStatus("Grabbing proxies..")
        Me.done4 = True
        Me.finalCheck("Done")
    End Sub

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
        Public Sub Lam__1()
            Me.vbme.Text = Me.VBLOC_newStr
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
        Public vbme As MegaGrabber
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
        <CompilerGenerated>
        Public Sub Lam__2()
        End Sub
        Public Sub Lam__3()
        End Sub


        ' Fields
        Public VBLOC_lines As String()
        Public VBLOC_rawIP As String
        Public vbme As MegaGrabber
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

        <CompilerGenerated>
        Public Sub Lam__5()
            Me.vbme.lbMain.Items.Add(Me.VBLOC_item)
        End Sub


        ' Fields
        Public VBLOC_item As String
        Public vbme As MegaGrabber
    End Class

    <CompilerGenerated>
    Friend Class Clousure__4
        ' Methods
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        <DebuggerNonUserCode>
        Public Sub New(ByVal other As Clousure__4)
            If (Not other Is Nothing) Then
                Me.vbme = other.vbme
                Me.VBLOC_status = other.VBLOC_status
            End If
        End Sub

        <CompilerGenerated>
        Public Sub Lam__6()
            Me.vbme.lblStatus.Text = Me.VBLOC_status
        End Sub


        ' Fields
        Public VBLOC_status As String
        Public vbme As MegaGrabber
    End Class

    <CompilerGenerated>
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

        <CompilerGenerated>
        Public Sub Lam__7()
            Me.vbme.txtLog.AppendText((ChrW(13) & ChrW(10) & Me.VBLOC_status))
        End Sub


        ' Fields
        Public VBLOC_status As String
        Public vbme As MegaGrabber
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

        <CompilerGenerated>
        Public Sub Lam__12()
            Me.vbme.txtLog.AppendText(Me.vbme.AES_Decrypt(Me.VBLOC_encAnn, "x1kfl12k4japl"))
        End Sub


        ' Fields
        Public VBLOC_encAnn As String
        Public vbme As MegaGrabber
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

        <CompilerGenerated>
        Public Sub Lam__13()
            Me.vbme.txtLog.Text = ("An error has occured while trying to fetch new info." & ChrW(13) & ChrW(10) & "Error: " & Me.VBLOC_ex.Message)
        End Sub


        ' Fields
        Public VBLOC_ex As Exception
        Public vbme As MegaGrabber
    End Class

    Friend Delegate Sub AnonymousDelegate_0()
    Private Sub secondCall()
        If Not Me.Reset Then
            If Not Me.Checking2 Then
                Me.Checking2 = True
                Dim thread As New Thread(New ThreadStart(AddressOf Me.secondList))
                thread.IsBackground = True
                thread.Start()
            Else
                Me.Checking2 = False
            End If
        End If
    End Sub

    Private Sub secondList()
        Me.setStatus("Grabbing proxies..")
        Me.curPage += 1
        Me.lblServer.Text = "free-proxy-list/uk-proxy"
        Me.grabFplf("http://www.free-proxy-list.net/uk-proxy.html")
        Me.setStatus("Grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "socks-proxy"
        Me.grabFplf("http://www.socks-proxy.net/")
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "irc-proxies24"
        Me.grabBlogger("irc-proxies24")
        Me.setStatus("Grabbing proxies..")
        Me.curPage += 1
        Me.lblServer.Text = "sockproxy"
        Me.grabBlogger("sockproxy")
        Me.done2 = True
        Me.finalCheck("Done")
    End Sub

    Private Sub setStatus(status As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub()
                                     Me.lblStatus.Text = status
                                 End Sub))
        Else
            Me.lblStatus.Text = status
        End If
    End Sub

    Private Sub sixthCall()
        If Not Me.Reset Then
            If Not Me.Checking6 Then
                Me.Checking6 = True
                Dim thread As New Thread(New ThreadStart(AddressOf Me.sixthList))
                thread.IsBackground = True
                thread.Start()
            Else
                Me.Checking6 = False
            End If
        End If
    End Sub

    Private Sub sixthList()
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "proxyserverlist-24"
        Me.grabBlogger("proxyserverlist-24")
        Me.setStatus("Grabbing proxies..")
        Me.curPage += 1
        Me.lblServer.Text = "googleproxies24"
        Me.grabBlogger("googleproxies24")
        Me.done6 = True
        Me.finalCheck("Done")
    End Sub

    Private Sub thirdCall()
        If Not Me.Reset Then
            If Not Me.Checking3 Then
                Me.Checking3 = True
                Dim thread As New Thread(New ThreadStart(AddressOf Me.thirdList))
                thread.IsBackground = True
                thread.Start()
            Else
                Me.Checking3 = False
            End If
        End If
    End Sub

    Private Sub thirdList()
        Me.setStatus("Grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "proxyocean"
        Me.grabBlogger("http://www.proxyocean.com/")
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "sslproxies24"
        Me.grabBlogger("sslproxies24")
        Me.setStatus("Grabbing proxies..")
        Me.curPage += 1
        Me.lblServer.Text = "google-proxy"
        Me.grabFplf("http://www.google-proxy.net/")
        Me.setStatus("Grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "free-proxy-list/anonymous-proxy"
        Me.grabFplf("http://www.free-proxy-list.net/anonymous-proxy.html")
        Me.done3 = True
        Me.finalCheck("Done")
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



    Private Sub updateLog(status As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub()
                                     Me.txtLog.AppendText(vbCrLf + status)
                                 End Sub))
        Else
            Me.txtLog.AppendText(vbCrLf + status)
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
    Private Sub grabBlogger(ByVal blName As String)
        Try
            Dim client As WebClient
            Dim total As String = String.Empty
            If (blName = "http://www.proxyocean.com/") Then
                Me.updateLog("Grabbed pocean page.")
            Else
                client = New WebClient
                client.Proxy = Nothing
                total = client.DownloadString(("http://" & blName & ".blogspot.com/"))
                Me.updateLog(("Grabbed " & blName & " page ~home; next list."))
            End If
            Dim str3 As String = Conversions.ToString(Me.parseText(total, "<h3 class='post-title entry-title' itemprop='name'>", "'>"))
            Dim address As String = str3
            If str3.Contains("<a href='") Then
                address = str3.Replace("<a href='", "")
            End If
            client = New WebClient
            client.Proxy = Nothing
            Dim rawStr As String = client.DownloadString(address)
            Dim str5 As String
            For Each str5 In Me.scrapeFormatted(rawStr)
                Me.finalCheck(str5)
            Next
            Me.lblPcount.Text = Conversions.ToString(Me.lbMain.Items.Count)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Function scrapeFormatted(ByVal rawStr As String) As List(Of String)
        Dim str As String = String.Empty
        Dim num2 As Integer = 0
        Dim list2 As New List(Of String)

        Dim str2 As String = rawStr
        Dim num4 As Integer = 0
        Dim length As Integer = str2.Length
        Do While (num4 < length)
            Dim ch As Char = str2.Chars(num4)
            str = (str & Conversions.ToString(ch))
            If ((((ch = ChrW(10)) Or (Conversions.ToString(ch) = ChrW(13) & ChrW(10))) Or (Conversions.ToString(ch) = ChrW(9))) Or (Conversions.ToString(ch) = Environment.NewLine)) Then
                str = (str & ChrW(13) & ChrW(10))
            End If
            num4 += 1
        Loop
        Return list2
    End Function
    Private Sub grabFplf(ByVal fplfUrl As String)
        Try
            Me.updateLog(("Grabbed list " & fplfUrl.Replace("http://www.", "")))
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(fplfUrl), HttpWebRequest)
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim input As String = New StreamReader(response.GetResponseStream).ReadToEnd
            Dim matchs As MatchCollection = New Regex("<tr><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td></tr>").Matches(input)
            Dim num As Integer = 0
            Do While (num <= matchs.Count)
                Dim enumerator As IEnumerator = Nothing
                Try
                    enumerator = matchs.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As Match = DirectCast(enumerator.Current, Match)
                        Dim str17 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(2)), "td>", "", 1, -1, CompareMethod.Binary)
                        Dim str15 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(4)), "td>", "", 1, -1, CompareMethod.Binary)
                        Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(6)), "td>", "", 1, -1, CompareMethod.Binary)
                        Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(8)), "td>", "", 1, -1, CompareMethod.Binary)
                        Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(10)), "td>", "", 1, -1, CompareMethod.Binary)
                        Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(12)), "td>", "", 1, -1, CompareMethod.Binary)
                        Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(14)), "td>", "", 1, -1, CompareMethod.Binary)
                        Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(&H10)), "td>", "", 1, -1, CompareMethod.Binary)
                        Me.finalCheck((str17 & ":" & str15))
                        num += 1
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.lblPcount.Text = Conversions.ToString(Me.lbMain.Items.Count)
            Loop
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Sub grabProxyRox()
        Try
            Dim str As String
            Dim num2 As Integer
            Dim num3 As Integer
            Dim num As Integer = 1
            GoTo Label_00AC
Label_0008:
            num2 += 1
Label_0076:
            If (num2 <= num3) Then
                GoTo Label_0008
            End If
            Me.lblPcount.Text = Conversions.ToString(Me.lbMain.Items.Count)
            num += 1
            If (num > 10) Then
                Return
            End If
Label_00AC:
            str = New WebClient().DownloadString(("http://www.socks24.org/feeds/posts/default" & Conversions.ToString(num)))
            Me.updateLog(("Grabbed list " & Conversions.ToString(num) & " ~ ProxyRox"))
            Dim str2 As String = Conversions.ToString(Me.parseText(str, "<tbody>", "</tbody>"))
            num2 = 0
            GoTo Label_0076
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Sub grabHideMyIP()
        Try
            Dim ezar As New Clousure__2
            ezar.vbme = Me
            Dim client As New WebClient
            client.Proxy = Nothing
            Dim total As String = client.DownloadString("https://www.hide-my-ip.com/proxylist.shtml")
            Me.updateLog("Grabbed HMI page.")
            ezar.VBLOC_rawIP = Conversions.ToString(Me.parseText(total, "var json = ", ";<!-- proxylist -->"))
            Me.Invoke(New AnonymousDelegate_0(AddressOf ezar.Lam__2))
            Me.Invoke(New AnonymousDelegate_0(AddressOf ezar.Lam__3))
            Dim num2 As Integer = (Enumerable.Count(Of String)(ezar.VBLOC_lines) - 1)
            Dim i As Integer = 1
            Do While (i <= num2)
                Me.finalCheck(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.parseText(ezar.VBLOC_lines(i), "[{""i"":""", """,""p"""), ":"), Me.parseText(ezar.VBLOC_lines(i), ",""p"":""", """,""c"": {"))))
                i += 1
            Loop
            Me.Invoke(New AnonymousDelegate_0(AddressOf Me.Lam__4))
            Me.lblPcount.Text = Conversions.ToString(Me.lbMain.Items.Count)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Sub Lam__4()
    End Sub
    Private Sub grabDomainGeek()
        Try
            Me.updateLog("Grabbed dg list.")
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://sslproxies24.blogspot.com/feeds/posts/default"), HttpWebRequest)
            request.Referer = "http://sslproxies24.blogspot.com/feeds/posts/default"
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Dim source As String() = reader.ReadToEnd.Split(New Char() {Conversions.ToChar(Environment.NewLine)})
            Dim num2 As Integer = (Enumerable.Count(Of String)(source) - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.finalCheck(source(i))
                i += 1
            Loop
            Me.lblPcount.Text = Conversions.ToString(Me.lbMain.Items.Count)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub grabIPCN()
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://proxy.ipcn.org/proxylist2.html"), HttpWebRequest)
            request.Referer = "http://proxy.ipcn.org/"
            request.KeepAlive = True
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.97 Safari/537.36"
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim total As String = New StreamReader(response.GetResponseStream).ReadToEnd
            total = Conversions.ToString(Me.parseText(total, "<pre>", "</pre>"))
            Me.updateLog("Grabbed IPCN list.")
            Dim source As String() = total.Split(New Char() {Conversions.ToChar(Environment.NewLine)})
            Dim num2 As Integer = (Enumerable.Count(Of String)(source) - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.finalCheck(source(i))
                i += 1
            Loop
            Me.lblPcount.Text = Conversions.ToString(Me.lbMain.Items.Count)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
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



    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim buffer As New StringBuilder

        buffer.Append(" ")
        If (lbMain.Items.Count > 0) Then
            buffer.Clear()
            For i As Integer = 0 To lbMain.Items.Count - 1

                buffer.Append(lbMain.Items.Item(i))
                buffer.Append(vbCrLf)
            Next
        End If

        My.Computer.Clipboard.SetText(buffer.ToString)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MegaGrabber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class