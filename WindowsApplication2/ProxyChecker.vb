Imports System.IO
Imports System.Net
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports WindowsApplication2.My
Public Class ProxyChecker
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private proxiesA As ListView
    Private proxiesB As ListView
    Private proxiesC As ListView
    Private proxiesD As ListView
    Public Shared validProxies As List(Of String)
    Private checked As Integer
    Private working As Integer
    Private notworking As Integer
    Public Shared savelist As List(Of String)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaterialLabel6.Text = "0"
        Me.NumericUpDown1.Minimum = Decimal.One
        Control.CheckForIllegalCrossThreadCalls = False
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub Form3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim fo As New OpenFileDialog
        fo.RestoreDirectory = True
        fo.Multiselect = False
        fo.Filter = "txt files (*.txt)|*.txt"
        fo.FilterIndex = 1
        fo.ShowDialog()
        If (Not fo.FileName = Nothing) Then
        End If
    End Sub


    Private Sub FlatMini1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FlatMax1_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub
    Public Function CheckProxy(ByVal Proxy As String) As Boolean
        Dim flag As Boolean
        Try
            Dim myProxy As WebProxy = New WebProxy(Proxy, True)
            Dim tempCookies As CookieContainer = New CookieContainer()
            Dim postData As String = ""
            Encoding.UTF8.GetBytes(postData)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://google.com"), HttpWebRequest)
            request.Proxy = myProxy
            request.Timeout = Convert.ToInt32(Decimal.Multiply(Me.NumericUpDown1.Value, New Decimal(CLng(1000))))
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = CLng(postData.Length)
            request.KeepAlive = True
            request.CookieContainer = tempCookies
            tempCookies.Add(DirectCast(request.GetResponse(), HttpWebResponse).Cookies)
            flag = True
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            flag = False
            ProjectData.ClearProjectError()
        End Try
        Return flag
    End Function
    Private Sub finalchek()
        Dim enumerator As IEnumerator = Nothing
        Try
            Me.ProgressBar1.Value = Me.ListView1.Items.Count
            Try
                enumerator = Me.ListView1.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim item As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim asd As String = item.Text
                    If (item.SubItems(2).Text.Contains("Unchecked")) Then
                        If (Me.CheckProxy(asd)) Then
                            Me.MaterialLabel9.Text = Conversions.ToString(Conversions.ToDouble(Me.MaterialLabel9.Text) + 1)
                            item.UseItemStyleForSubItems = False
                            item.SubItems(2).Text = "Online"
                            item.SubItems(2).ForeColor = Color.Blue
                        End If
                        If (Not Me.CheckProxy(asd)) Then
                            Me.MaterialLabel10.Text = Conversions.ToString(Conversions.ToDouble(Me.MaterialLabel10.Text) + 1)
                            item.SubItems(2).Text = "Offline"
                            item.UseItemStyleForSubItems = False
                            item.SubItems(2).ForeColor = Color.Red
                        End If
                    End If
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Me.finalchek()
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Me.ValidateProxy()
        Me.Timer1.Start()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Try
            ProxyChecker.savelist.Clear()
            Dim count As Integer = Me.ListView1.Items.Count - 1
            Dim i As Integer = 0
            Do
                If (Me.ListView1.Items(i).SubItems(2).Text.Contains("Online")) Then
                    ProxyChecker.savelist.Add(Me.ListView1.Items(i).SubItems(1).Text)
                End If
                i = i + 1
            Loop While i <= count
            Dim value As String = String.Join("" & vbCrLf & "", ProxyChecker.savelist)
            Me.SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
            If (Me.SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
                MyProject.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, value, True)
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Nothing to save", MsgBoxStyle.OkOnly, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        Dim openfile As OpenFileDialog = New OpenFileDialog() With
        {
            .Filter = "Text (*.txt)|*.txt"
        }

        If (openfile.ShowDialog() = DialogResult.OK) Then
            Dim strArrays As String() = File.ReadAllLines(openfile.FileName)
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim line As String = strArrays(num)
                Dim lvi As ListViewItem = New ListViewItem()
                lvi.SubItems.Add(line)
                lvi.SubItems.Add("Unchecked")
                Me.ListView1.Items.Add(lvi)
                num = num + 1
            End While
            Dim count As Integer = Me.ListView1.Items.Count - 1
            For i As Integer = 0 To count
                Me.ListView1.Items(i).Text = (i + 1).ToString()
            Next

        End If
        If (Conversions.ToString(Me.ListView1.Items.Count) >= 1000) Then
            MsgBox("The Combo list must not be over 1000")

        End If
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        Me.Timer1.[Stop]()
        Me.Timer2.[Stop]()
        Me.ListView1.Items.Clear()
        ProxyChecker.validProxies.Clear()
        Me.proxiesA.Items.Clear()
        Me.proxiesB.Items.Clear()
        Me.proxiesC.Items.Clear()
        Me.proxiesD.Items.Clear()
        ProxyChecker.savelist.Clear()
        Me.MaterialLabel4.Text = "0"
        Me.MaterialLabel5.Text = "0"
        Me.MaterialLabel6.Text = "0"
        Me.MaterialLabel9.Text = "0"
        Me.MaterialLabel10.Text = "0"
        Me.MaterialLabel11.Text = "0"
        Me.ProgressBar1.Value = 0
        Me.checked = 0
        Me.notworking = 0
        Me.working = 0
    End Sub

    Public Sub TaskA()
        Dim enumerator As IEnumerator = Nothing
        Try
            Dim counter As Integer = 0
            Try
                enumerator = Me.proxiesA.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim item As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim asd As String = item.SubItems(1).Text
                    If (Operators.CompareString(item.SubItems(2).Text, "Unchecked", False) <> 0) Then
                        Me.TaskA()
                    Else
                        Try
                            Dim temp As ListViewItem = Me.ListView1.Items(counter)
                            If (Me.CheckProxy(asd)) Then
                                Me.working = Me.working + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Online"
                                temp.SubItems(2).ForeColor = Color.Blue
                            End If
                            If (Not Me.CheckProxy(asd)) Then
                                Me.notworking = Me.notworking + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Offline"
                                temp.SubItems(2).ForeColor = Color.Red
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                    counter = counter + 1
                    Me.checked = Me.checked + 1
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            Me.TaskA()
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub TaskB()
        Dim enumerator As IEnumerator = Nothing
        Try
            Dim counter As Integer = 0
            Try
                enumerator = Me.proxiesB.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim item As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim asd As String = item.SubItems(1).Text
                    If (Operators.CompareString(item.SubItems(2).Text, "Unchecked", False) <> 0) Then
                        Me.TaskB()
                    Else
                        Try
                            Dim temp As ListViewItem = Me.ListView1.Items(counter + Me.proxiesA.Items.Count)
                            If (Me.CheckProxy(asd)) Then
                                Me.working = Me.working + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Online"
                                temp.SubItems(2).ForeColor = Color.Blue
                            End If
                            If (Not Me.CheckProxy(asd)) Then
                                Me.notworking = Me.notworking + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Offline"
                                temp.SubItems(2).ForeColor = Color.Red
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                    counter = counter + 1
                    Me.checked = Me.checked + 1
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            Me.TaskB()
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub TaskC()
        Dim enumerator As IEnumerator = Nothing
        Try
            Dim counter As Integer = 0
            Try
                enumerator = Me.proxiesC.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim item As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim asd As String = item.SubItems(1).Text
                    If (Operators.CompareString(item.SubItems(2).Text, "Unchecked", False) <> 0) Then
                        Me.TaskC()
                    Else
                        Try
                            Dim temp As ListViewItem = Me.ListView1.Items(counter + Me.proxiesA.Items.Count + Me.proxiesB.Items.Count)
                            If (Me.CheckProxy(asd)) Then
                                Me.working = Me.working + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Online"
                                temp.SubItems(2).ForeColor = Color.Blue
                            End If
                            If (Not Me.CheckProxy(asd)) Then
                                Me.notworking = Me.notworking + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Offline"
                                temp.SubItems(2).ForeColor = Color.Red
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                    counter = counter + 1
                    Me.checked = Me.checked + 1
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            Me.TaskC()
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub TaskD()
        Dim enumerator As IEnumerator = Nothing
        Try
            Dim counter As Integer = 0
            Try
                enumerator = Me.proxiesD.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim item As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim asd As String = item.SubItems(1).Text
                    If (Operators.CompareString(item.SubItems(2).Text, "Unchecked", False) <> 0) Then
                        Me.TaskD()
                    Else
                        Try
                            Dim temp As ListViewItem = Me.ListView1.Items(counter + Me.proxiesA.Items.Count + Me.proxiesB.Items.Count + Me.proxiesC.Items.Count)
                            If (Me.CheckProxy(asd)) Then
                                Me.working = Me.working + 1
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).Text = "Online"
                                temp.SubItems(2).ForeColor = Color.Blue
                            End If
                            If (Not Me.CheckProxy(asd)) Then
                                Me.notworking = Me.notworking + 1
                                temp.SubItems(2).Text = "Offline"
                                temp.UseItemStyleForSubItems = False
                                temp.SubItems(2).ForeColor = Color.Red
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                    counter = counter + 1
                    Me.checked = Me.checked + 1
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            Me.TaskD()
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim jorma1 As Integer = Conversions.ToInteger(Me.MaterialLabel5.Text)
        Dim jorma2 As Integer = Conversions.ToInteger(Me.MaterialLabel4.Text)
        If (Conversions.ToInteger(Strings.FormatNumber(CDbl((CDbl(jorma1) * 100 / CDbl(jorma2))), 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)) > 95) Then
            Me.Timer1.[Stop]()
            Me.MaterialLabel11.Text = "0"
            Me.MaterialLabel5.Text = Me.MaterialLabel4.Text
            Me.finalchek()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.ProgressBar1.Maximum = Me.ListView1.Items.Count
        Me.MaterialLabel10.Text = Conversions.ToString(Me.notworking)
        Me.MaterialLabel9.Text = Conversions.ToString(Me.working)
        Me.MaterialLabel5.Text = Conversions.ToString(Me.checked)
        Me.ProgressBar1.Value = Me.checked
        Dim materialLabel6 As MaterialLabel = Me.MaterialLabel6
        Dim count As Integer = Process.GetCurrentProcess().Threads.Count
        materialLabel6.Text = count.ToString()
        Me.MaterialLabel4.Text = Conversions.ToString(Me.ListView1.Items.Count)
        If (Conversions.ToDouble(Conversions.ToString(Me.ListView1.Items.Count)) >= 4) Then
            Dim str As String = Conversions.ToString(Me.notworking + Me.working)
            Dim str1 As String = Conversions.ToString(Me.ListView1.Items.Count)
            Dim str2 As String = Conversions.ToString(Conversions.ToDouble(str1) - Conversions.ToDouble(str))
            Dim str3 As String = Conversions.ToString(Conversions.ToDouble(str2) * Convert.ToDouble(Me.NumericUpDown1.Value))
            Dim str4 As String = Conversions.ToString(Conversions.ToDouble(str3) / 60)
            Dim result2 As String = Conversions.ToString(Conversions.ToDouble(str4) / 4)
            Me.MaterialLabel11.Text = String.Concat(Strings.FormatNumber(Conversions.ToDouble(result2), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), "  Minutes")
        Else
            Dim workplusnot As String = Conversions.ToString(Me.notworking + Me.working)
            Dim itemscount As String = Conversions.ToString(Me.ListView1.Items.Count)
            Dim total As String = Conversions.ToString(Conversions.ToDouble(itemscount) - Conversions.ToDouble(workplusnot))
            Dim answer As String = Conversions.ToString(Conversions.ToDouble(total) * Convert.ToDouble(Me.NumericUpDown1.Value))
            Dim result As String = Conversions.ToString(Conversions.ToDouble(answer) / 60)
            Me.MaterialLabel11.Text = String.Concat(Strings.FormatNumber(Conversions.ToDouble(result), 1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), "  Minutes")
        End If
    End Sub
    Public Sub ValidateProxy()
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        If (Conversions.ToDouble(Conversions.ToString(Me.ListView1.Items.Count)) >= 4) Then
            Try
                enumerator1 = Me.ListView1.Items.GetEnumerator()
                While enumerator1.MoveNext()
                    Dim current As System.Windows.Forms.ListViewItem = DirectCast(enumerator1.Current, System.Windows.Forms.ListViewItem)
                    Dim num As Integer = 4
                    Dim str As String = Conversions.ToString(CDbl(Me.ListView1.Items.Count) / CDbl(num))
                    Dim text As String = Nothing
                    Dim text1 As String = Nothing
                    text = current.SubItems(1).Text
                    text1 = current.SubItems(2).Text
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.SubItems.Add(text)
                    listViewItem.SubItems.Add(text1)
                    If (CDbl(Me.proxiesA.Items.Count) < Conversions.ToDouble(str)) Then
                        Me.proxiesA.Items.Add(listViewItem)
                    ElseIf (CDbl(Me.proxiesB.Items.Count) < Conversions.ToDouble(str)) Then
                        Me.proxiesB.Items.Add(listViewItem)
                    ElseIf (CDbl(Me.proxiesC.Items.Count) < Conversions.ToDouble(str)) Then
                        Me.proxiesC.Items.Add(listViewItem)
                    ElseIf (CDbl(Me.proxiesD.Items.Count) < Conversions.ToDouble(str)) Then
                        Me.proxiesD.Items.Add(listViewItem)
                    End If
                End While
            Finally
                If (TypeOf enumerator1 Is IDisposable) Then
                    TryCast(enumerator1, IDisposable).Dispose()
                End If
            End Try
            Dim form1 As WindowsApplication2.ProxyChecker = Me
            Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form1.TaskA))
            Dim form11 As WindowsApplication2.ProxyChecker = Me
            Dim thread1 As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form11.TaskB))
            Dim form12 As WindowsApplication2.ProxyChecker = Me
            Dim thread2 As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form12.TaskC))
            Dim form13 As WindowsApplication2.ProxyChecker = Me
            Dim thread3 As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form13.TaskD))
            thread.Start()
            thread1.Start()
            thread2.Start()
            thread3.Start()
        Else
            Dim maxThreads As Integer = 1
            Dim maxItem As Integer = CInt(Math.Round(CDbl(Me.ListView1.Items.Count) / CDbl(maxThreads)))
            Try
                enumerator = Me.ListView1.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim item As System.Windows.Forms.ListViewItem = DirectCast(enumerator.Current, System.Windows.Forms.ListViewItem)
                    Dim asd As String = Nothing
                    Dim asd2 As String = Nothing
                    asd = item.SubItems(1).Text
                    asd2 = item.SubItems(2).Text
                    Dim lvi As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    lvi.SubItems.Add(asd)
                    lvi.SubItems.Add(asd2)
                    If (Me.proxiesA.Items.Count < maxItem) Then
                        Me.proxiesA.Items.Add(lvi)
                    ElseIf (Me.proxiesB.Items.Count < maxItem) Then
                        Me.proxiesB.Items.Add(lvi)
                    ElseIf (Me.proxiesC.Items.Count < maxItem) Then
                        Me.proxiesC.Items.Add(lvi)
                    ElseIf (Me.proxiesD.Items.Count < maxItem) Then
                        Me.proxiesD.Items.Add(lvi)
                    End If
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim form14 As WindowsApplication2.ProxyChecker = Me
            Dim A As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form14.TaskA))
            Dim form15 As WindowsApplication2.ProxyChecker = Me
            Dim B As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form15.TaskB))
            Dim form16 As WindowsApplication2.ProxyChecker = Me
            Dim C As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form16.TaskC))
            Dim form17 As WindowsApplication2.ProxyChecker = Me
            Dim D As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf form17.TaskD))
            A.Start()
            B.Start()
            C.Start()
            D.Start()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized


        End If
    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs) Handles MaterialLabel4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class