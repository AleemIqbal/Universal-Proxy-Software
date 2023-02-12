Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class MegaProxyScrapper
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

    Private Sub MinimizeMaximize_Click(sender As Object, e As EventArgs) 
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) 
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

    Private Sub btnParse_Click(sender As Object, e As EventArgs) Handles btnParse.Click
        If Me.CheckBox1.Checked Then
            Me.cleanSource = True
        End If
        If ((Me.txtParse.Text = String.Empty) Or (Me.txtParse.Text = ChrW(13) & ChrW(10))) Then
            Me.txtScraped.Text = "Please paste an unformatted webpage text to scrape the proxies from."
        Else
            If Me.txtParse.Text.Contains("httptunnel") Then
                Me.RadioButton4.Checked = True
            End If
            Dim button As RadioButton
            For Each button In Enumerable.OfType(Of RadioButton)(Me.grpService.Controls)
                If button.Checked Then
                    Me.lblService.Text = button.Text
                End If
            Next
            Me.Label4.Visible = True
            Me.lblService.Visible = True
            Me.scrapeCore(Me.lblService.Text)
            Me.txtParse.Clear()
        End If
    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click
        Me.txtParse.Clear()
        Me.txtScraped.Clear()
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
        End If
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
        Me.curPage += 1
        Me.lblServer.Text = "getproxy"
        Me.grabGetProxy()
        Me.setStatus("Grabbing proxies...")
        Me.curPage += 1
        Me.lblServer.Text = "proxyspy"
        Me.grabProxySpy()
        Me.setStatus("Grabbing proxies.")
        Me.curPage += 1
        Me.lblServer.Text = "proxylistchecker"
        Me.grabProxyListChecker()
        Me.done4 = True
        Me.finalCheck("Done")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaximizeBox = False
    End Sub

    Private Sub grabBlogger(ByVal blName As String)
        Try
            Dim client As WebClient
            Dim total As String = String.Empty
            If (blName = "http://www.proxyocean.com/") Then
                total = New WebClient().DownloadString("http://www.proxyocean.com/")
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
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub grabDomainGeek()
        Try
            Me.updateLog("Grabbed dg list.")
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://domaingeek.org/static/proxies.txt"), HttpWebRequest)
            request.Referer = "http://domaingeek.org/"
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Dim source As String() = reader.ReadToEnd.Split(New Char() {Conversions.ToChar(Environment.NewLine)})
            Dim num2 As Integer = (Enumerable.Count(Of String)(source) - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.finalCheck(source(i))
                i += 1
            Loop
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

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
            Loop
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub grabGetProxy()
        Try
            Dim str As String
            Dim num2 As Integer
            Dim num3 As Integer
            Dim num As Integer = 1
            GoTo Label_00BA
Label_0008:
            If Me.txtParse.Lines(num2).Contains("<td style='text-align:left;'") Then
                Me.finalCheck(Me.txtParse.Lines(num2).Replace("<td style='text-align:left;'", "").Replace("</td>", "").Replace(" ", "").Replace(">", "").Replace(ChrW(9) & ChrW(9), ""))
            End If
            num2 += 1
Label_0083:
            If (num2 <= num3) Then
                GoTo Label_0008
            End If
            num += 1
            If (num > 5) Then
                Return
            End If
Label_00BA:
            str = New WebClient().DownloadString(("http://www.getproxy.jp/en/default/" & Conversions.ToString(num)))
            Me.updateLog(("Grabbed list " & Conversions.ToString(num) & " ~ GetProxy"))
            Me.txtParse.Text = Conversions.ToString(Me.parseText(str, "<table class=""mytable"" id=""mytable"" width=""675"">", "</table>"))
            num3 = (Enumerable.Count(Of String)(Me.txtParse.Lines) - 1)
            num2 = 0
            GoTo Label_0083
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
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub grabProxyListChecker()
        Try
            Dim ezar As Clousure__1 = Nothing
            Dim list As List(Of String)
            Dim ch As Char
            Dim num4 As Integer
            Dim str4 As String
            Dim length As Integer
            Dim num As Integer = 1
            GoTo Label_0206
Label_0009:
            ch = str4.Chars(num4)
            If ((((Versioned.IsNumeric(ch) Or (Conversions.ToString(ch) = "-")) Or (Conversions.ToString(ch) = " ")) Or (Conversions.ToString(ch) = ".")) Or (Conversions.ToString(ch) = ":")) Then
                If (Conversions.ToString(ch) = " ") Then
                    ezar.VBLOC_newStr = (ezar.VBLOC_newStr & ChrW(13) & ChrW(10))
                Else
                    ezar.VBLOC_newStr = (ezar.VBLOC_newStr & Conversions.ToString(ch))
                End If
            End If
            num4 += 1
Label_00C7:
            If (num4 < length) Then
                GoTo Label_0009
            End If
            Me.Invoke(New AnonymousDelegate_0(AddressOf ezar.Lam__1))
            Dim num6 As Integer = (Enumerable.Count(Of String)(Me.txtParse.Lines) - 1)
            Dim i As Integer = 0
            Do While (i <= num6)
                If Me.txtParse.Lines(i).Contains("--") Then
                    list.Add(Me.txtParse.Lines(i))
                End If
                i += 1
            Loop
            Dim item As String = String.Empty
            Me.txtParse.Lines = list.ToArray
            Dim num7 As Integer = (Enumerable.Count(Of String)(Me.txtParse.Lines) - 1)
            Dim j As Integer = 0
            Do While (j <= num7)
                item = Me.txtParse.Lines(j).Replace(Conversions.ToString(Me.parseText(Me.txtParse.Lines(j), "--", "--")), "").Replace("----", "")
                Me.finalCheck(item)
                j += 1
            Loop
            num += 1
            If (num > 15) Then
                Return
            End If
Label_0206:
            ezar = New Clousure__1(ezar)
            ezar.vbme = Me
            Dim client As New WebClient
            client.Proxy = Nothing
            Dim total As String = client.DownloadString(("http://proxylistchecker.org/proxylists.php?t=elite&p=" & Conversions.ToString(num)))
            Me.updateLog(("Grabbed list " & Conversions.ToString(num) & " ~ PLC"))
            total = total.Replace("<div style='padding-bottom: 2px; background-color: #eee; padding-left: 5px; padding-right: 5px; padding-top: 2px'>", "")
            Dim str3 As String = Conversions.ToString(Me.parseText(total, "<th>Country</th>", "</table>")).Replace("<tr><td>", "").Replace("</a></div></td><td>", "").Replace("</div></td><td>", "").Replace("width='16' height='11'", "").Replace("</div></td></tr><div style='padding-bottom: 2px; background-color: #fff; padding-left: 5px; padding-right: 5px; padding-top: 2px'>", "").Replace("<div style='padding-bottom: 2px; background-color: #fff; padding-left: 5px; padding-right: 5px; padding-top: 2px'>", "")
            ezar.VBLOC_newStr = String.Empty
            list = New List(Of String)
            str4 = str3
            num4 = 0
            length = str4.Length
            GoTo Label_00C7
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
            If Me.txtParse.Lines(num2).Contains("<td><a href=""/proxy/") Then
                Me.finalCheck(Conversions.ToString(Me.txtParse.Lines(num2).Replace("<td><a href=""/proxy/", "").Replace("</a></td>", "").Split(New Char() {">"c}).GetValue(1)))
            End If
            num2 += 1
Label_0076:
            If (num2 <= num3) Then
                GoTo Label_0008
            End If
            num += 1
            If (num > 10) Then
                Return
            End If
Label_00AC:
            str = New WebClient().DownloadString(("http://proxyrox.com/?p=" & Conversions.ToString(num)))
            Me.updateLog(("Grabbed list " & Conversions.ToString(num) & " ~ ProxyRox"))
            Dim str2 As String = Conversions.ToString(Me.parseText(str, "<tbody>", "</tbody>"))
            Me.txtParse.Text = str2
            num3 = (Enumerable.Count(Of String)(Me.txtParse.Lines) - 1)
            num2 = 0
            GoTo Label_0076
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub grabProxySpy()
        Try
            Dim str As String = New WebClient().DownloadString("http://txt.proxyspy.net/proxy.txt")
            Me.updateLog("Grabbed proxyspy list.")
            Me.txtParse.Text = str
            Dim num2 As Integer = (Enumerable.Count(Of String)(Me.txtParse.Lines) - 1)
            Dim i As Integer = 2
            Do While (i <= num2)
                Me.finalCheck(Conversions.ToString(Me.txtParse.Lines(i).Split(New Char() {" "c}).GetValue(0)))
                i += 1
            Loop
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
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

 
    Private Sub scrapeCore(ByVal selService As String)
        Me.setStatus("Scraping proxies...")
        If Not Me.cleanSource Then
            Dim str2 As String = String.Empty
            Dim text As String = Me.txtParse.Text
            Me.txtScraped.Clear()
            Me.txtScraped.Text = Me.txtParse.Text
            Dim str3 As String = [text]
            Dim num7 As Integer = 0
            Dim length As Integer = str3.Length
            Do While (num7 < length)
                Dim expression As Char = str3.Chars(num7)
                If (Versioned.IsNumeric(expression) Or (Conversions.ToString(expression) = ".")) Then
                    str2 = (str2 & Conversions.ToString(expression))
                End If
                If ((((expression = ChrW(10)) Or (Conversions.ToString(expression) = ChrW(13) & ChrW(10))) Or (Conversions.ToString(expression) = "<")) Or (Conversions.ToString(expression) = ChrW(9))) Then
                    str2 = (str2 & ChrW(13) & ChrW(10))
                End If
                num7 += 1
            Loop
            Me.txtScraped.Clear()
            Me.txtScraped.Text = str2
            Me.txtScraped.Lines = Me.txtScraped.Text.Split(New Char() {ChrW(10)}, StringSplitOptions.RemoveEmptyEntries)
            Dim list As New List(Of String)
            Dim lines As String() = Me.txtScraped.Lines
            Dim num9 As Integer = (Enumerable.Count(Of String)(lines) - 2)
            Dim j As Integer = 0
            Do While (j <= num9)
                If lines(j).Contains(".") Then
                    list.Add((lines(j) & ":" & lines((j + 1))))
                End If
                j += 1
            Loop
            Me.txtScraped.Clear()
            lines = list.ToArray
            Me.txtScraped.Lines = lines
            lines = Me.txtScraped.Lines
            Dim list2 As New List(Of String)
            Dim num As Integer = 0
            Dim num2 As Integer = 0
            Dim num10 As Integer = (Enumerable.Count(Of String)(lines) - 1)
            Dim k As Integer = 3
            Do While (k <= num10)
                If ((lines(k).ToUpper = lines(k).ToLower) AndAlso (lines(k).Contains(":") And (lines(k).Length > 7))) Then
                    num = 0
                    num2 = 0
                    Dim str4 As String = lines(k)
                    Dim num11 As Integer = 0
                    Dim num12 As Integer = str4.Length
                    Do While (num11 < num12)
                        Dim ch2 As Char = str4.Chars(num11)
                        If Versioned.IsNumeric(ch2) Then
                            num += 1
                        End If
                        If (Conversions.ToString(ch2) = ".") Then
                            num2 += 1
                        End If
                        num11 += 1
                    Loop
                    If ((num >= 4) And (num2 = 3)) Then
                        list2.Add(lines(k))
                    End If
                End If
                k += 1
            Loop
            lines = list2.ToArray
            Me.txtScraped.Clear()
            Me.txtScraped.Lines = lines
        Else
            Dim list3 As New List(Of String)
            Dim source As String() = Me.scrapeFormatted(Me.txtParse.Text).ToArray
            Dim num13 As Integer = (Enumerable.Count(Of String)(source) - 1)
            Dim m As Integer = 0
            Do While (m <= num13)
                If (source(m).ToUpper = source(m).ToLower) Then
                    list3.Add(source(m))
                End If
                m += 1
            Loop
            source = list3.ToArray
            Me.txtScraped.Lines = source
        End If
        Dim num14 As Integer = (Enumerable.Count(Of String)(Me.txtScraped.Lines) - 1)
        Me.grpParsed.Text = ("< Parsed Proxies: " & Conversions.ToString(Enumerable.Count(Of String)(Me.txtScraped.Lines)) & " >")
        Me.setStatus("Done.")
    End Sub

    Private Function scrapeFormatted(ByVal rawStr As String) As List(Of String)
        Dim str As String = String.Empty
        Dim num2 As Integer = 0
        Dim list2 As New List(Of String)
        Me.txtScraped.Clear()
        Me.txtScraped.Text = Me.txtParse.Text
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
        Me.txtParse.Text = str
        Dim lines As String() = Me.txtParse.Lines
        Dim num6 As Integer = (Enumerable.Count(Of String)(lines) - 1)
        Dim i As Integer = 0
        Do While (i <= num6)
            num2 = 0
            If lines(i).Contains(":") Then
                Dim str3 As String = lines(i)
                Dim num7 As Integer = 0
                Dim num8 As Integer = str3.Length
                Do While (num7 < num8)
                    Dim ch2 As Char = str3.Chars(num7)
                    If (Conversions.ToString(ch2) = ".") Then
                        num2 += 1
                    End If
                    num7 += 1
                Loop
                If (num2 = 3) Then
                    list2.Add(lines(i))
                End If
            End If
            i += 1
        Loop
        Return list2
    End Function

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


    Private Sub updateLog(status As String)
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

        <CompilerGenerated>
        Public Sub Lam__1()
            Me.vbme.txtParse.Text = Me.VBLOC_newStr
        End Sub


        ' Fields
        Public VBLOC_newStr As String
        Public vbme As MegaProxyScrapper
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
            Me.vbme.txtParse.Text = Me.VBLOC_rawIP
        End Sub

        <CompilerGenerated>
        Public Sub Lam__3()
            Me.VBLOC_lines = Me.vbme.txtParse.Lines
        End Sub


        ' Fields
        Public VBLOC_lines As String()
        Public VBLOC_rawIP As String
        Public vbme As MegaProxyScrapper
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
        Public vbme As MegaProxyScrapper
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
        Public vbme As MegaProxyScrapper
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


        ' Fields
        Public VBLOC_status As String
        Public vbme As MegaProxyScrapper
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
        Public vbme As MegaProxyScrapper
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
        Public vbme As MegaProxyScrapper
    End Class

    Public Delegate Sub _UpdateListview(ByVal proxyString As String)

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Friend Delegate Sub AnonymousDelegate_0()

End Class