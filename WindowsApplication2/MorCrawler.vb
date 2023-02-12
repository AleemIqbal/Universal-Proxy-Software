Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml
Public Class MorCrawler
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
    Private bool_0 As Boolean
    Private dateTime_0 As DateTime
    Private int_0 As Integer
    Private int_1 As Integer
    Private list_0 As List(Of String)
    Private list_1 As List(Of String)
    Private list_2 As List(Of String)
    Private list_3 As List(Of String)
    Private list_4 As List(Of String)
    Private list_5 As List(Of String)
    Public ListBoxDelegate As AddListBoxItem
    Private string_0 As String
    Private string_1 As String
    Private string_2 As String
    Private thread_0 As Thread()
    Private gclass0_0 As GClass0()

    Public Delegate Sub AddListBoxItem(ByVal [Text] As String)
    Public Delegate Sub GDelegate0(ByVal label_0 As Label, ByVal string_0 As String)

    Public Sub New()
        Me.string_0 = (Application.StartupPath & "\Engines.txt")
        Me.string_1 = (Application.StartupPath & "\Defaults.xml")
        Me.list_0 = New List(Of String)
        Me.list_1 = New List(Of String)
        Me.list_2 = New List(Of String)
        Me.list_3 = New List(Of String)
        Me.list_4 = New List(Of String)
        Me.list_5 = New List(Of String)
        Me.int_0 = 0
        Me.string_2 = Nothing
        Me.int_1 = 0
        Me.bool_0 = False
        Me.thread_0 = New Thread(1 - 1) {}
        Me.gclass0_0 = New GClass0(1 - 1) {}
        Me.InitializeComponent()
    End Sub
    Public Sub AddListBoxItemMethod(ByVal [Text] As String)
        If (Me.ListBoxProgress.Items.Count > &H10) Then
            Me.ListBoxProgress.Items.Clear()
        End If
        Me.ListBoxProgress.Items.Add([Text])
        Me.ListBoxProgress.SelectedIndex = (Me.ListBoxProgress.Items.Count - 1)
        Application.DoEvents()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If Not File.Exists(Me.string_0) Then
            MessageBox.Show(("Cannot find engines file" & ChrW(13) & ChrW(10) & Me.string_0), "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.method_28(False)
            Me.LabelStatus.Text = "Editing engines file"
            Me.BackgroundWorkerEngines.RunWorkerAsync()
        End If
    End Sub

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaximizeBox = False
        If File.Exists(Me.string_0) Then
            Me.method_0()
        Else
            MessageBox.Show(("Cannot find engines file   " & ChrW(13) & ChrW(10) & Me.string_0), "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.LabelStatus.Text = "Engines file not found"
        End If
        If File.Exists(Me.string_1) Then
            Me.method_4()
        Else
            Me.method_26()
            MessageBox.Show(("Cannot find defaults file   " & ChrW(13) & ChrW(10) & Me.string_0), "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.LabelStatus.Text = "Defaults file not found"
        End If
    End Sub

    Private Sub method_0()
        Class5.list_0.Clear
        Dim reader As New StreamReader(Me.string_0)
        Do While (reader.Peek <> -1)
            Class5.list_0.Add(reader.ReadLine)
        Loop
        reader.Close()
        Me.LabelStatus.Text = ("Engines loaded = " & Class5.list_0.Count.ToString)
    End Sub

    Private Sub method_10()
        Me.thread_0 = New Thread(((Me.int_1 - 1) + 1) - 1) {}
        Me.gclass0_0 = New GClass0(((Me.int_1 - 1) + 1) - 1) {}
        Dim num2 As Integer = (Me.int_1 - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            Me.gclass0_0(i) = New GClass0(Me)
            Dim class1 As GClass0 = Me.gclass0_0(i)
            Me.thread_0(i) = New Thread(New ThreadStart(AddressOf class1.method_1))
            Me.thread_0(i).Name = i.ToString
            Me.thread_0(i).IsBackground = True
            Me.thread_0(i).Start()
            i += 1
        Loop
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerCrawler.DoWork
        Dim str As String = Nothing
        Dim class2 As New GClass0(Me)
        Dim num2 As Integer = (Class5.int_1 - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            str = Class5.list_0.Item(i)
            str = str.Replace("[SEARCH SEED]", Me.string_2)
            class2.method_0(str)
            i += 1
        Loop
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerCrawler.RunWorkerCompleted
        If Not Class5.bool_0 Then
            Me.dateTime_0 = DateTime.Now
            Me.Timer1.Interval = &H3E8
            Me.Timer1.Start()
            Me.ButtonPause.Enabled = True
            Me.method_10()
        End If
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        Try
            If (Me.ButtonPause.Text = "Pause") Then
                Dim num As Integer = (Me.int_1 - 1)
                Dim i As Integer = 0
                Do While (i <= num)
                    Me.thread_0(i).Suspend()
                    i += 1
                Loop
                Me.ButtonPause.Text = "Resume"
                Me.ButtonSave.Enabled = True
                Me.bool_0 = True
            Else
                Dim num3 As Integer = (Me.int_1 - 1)
                Dim j As Integer = 0
                Do While (j <= num3)
                    Me.thread_0(j).Resume()
                    j += 1
                Loop
                Me.ButtonPause.Text = "Pause"
                Me.ButtonSave.Enabled = False
                Me.bool_0 = False
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Function method_14() As Boolean
        If (Class5.list_0.Count = 0) Then
            MessageBox.Show("No engines loaded   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        End If
        Using enumerator As IEnumerator(Of String) = Class5.list_0.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As String = enumerator.Current
                If Not current.Contains("[SEARCH SEED]") Then
                    GoTo Label_004F
                End If
            Loop
            GoTo Label_0077
Label_004F:
            MessageBox.Show("Engine is invalid   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        End Using
Label_0077:
        If (Me.TextBoxSearchSeed.Text = Nothing) Then
            MessageBox.Show("Seed is required   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.TextBoxSearchSeed.Focus()
            Return False
        End If
        If (Me.TextBoxURLFilter.Text = Nothing) Then
            MessageBox.Show("URL Filter is required   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.TextBoxURLFilter.Focus()
            Return False
        End If
        If (Me.TextBoxLeechFilter.Text = Nothing) Then
            MessageBox.Show("Leech filter is required   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.TextBoxLeechFilter.Focus()
            Return False
        End If
        If (Not Me.TextBoxLeechFilter.Text.Contains("(") Or Not Me.TextBoxLeechFilter.Text.Contains(")")) Then
            MessageBox.Show("Leech filter must contain a 'Group'" & ChrW(13) & ChrW(10) & "i.e. the string to be extracted MUST be within brackets", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.TextBoxLeechFilter.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub method_15()
        Class5.bool_0 = False
        Me.bool_0 = False
        Class5.list_1.Clear
        Class5.list_2.Clear
        Class5.int_3 = 0
        Class5.int_4 = 0
        Class5.int_6 = 0
        Class5.int_0 = 0
        Class5.int_2 = 0
        Class5.int_1 = Class5.list_0.Count
        Me.string_2 = Me.TextBoxSearchSeed.Text
        Class5.string_1 = Me.TextBoxURLFilter.Text
        Class5.string_2 = Me.TextBoxLeechFilter.Text
        Me.int_1 = Conversions.ToInteger(Me.NumericUpDownThreads.Text)
    End Sub

    Private Sub method_16()
        Me.ListBoxProgress.Items.Clear()
        Me.ButtonStart.Text = "Stop"
        Me.ButtonSave.Enabled = False
        Me.GroupBoxOptions.Enabled = False
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If (Class5.list_2.Count <> 0) Then
            Dim dialog As SaveFileDialog = Me.SaveFileDialog1
            dialog.DefaultExt = "txt"
            dialog.FileName = "morCrawler.txt"
            dialog.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*"
            dialog.InitialDirectory = Class5.string_0
            dialog = Nothing
            If ((Me.SaveFileDialog1.ShowDialog <> DialogResult.Cancel) AndAlso (Me.SaveFileDialog1.FileName <> Nothing)) Then
                Me.method_18()
            End If
        End If
    End Sub
    Private Sub method_18()
        Dim dz As New Thread(New ThreadStart(AddressOf Me.method_19)) With {.IsBackground = True}
        dz.Start()
    End Sub

    Private Sub method_19()
        Me.method_20()
        Me.method_21(Me.SaveFileDialog1.FileName)
        Me.method_27(Me.LabelStatus, ("File saved  ::  Items retained = " & Me.list_5.Count.ToString("#,#", CultureInfo.InvariantCulture) & "  ::  Duplicates removed = " & Me.int_0.ToString("#,#", CultureInfo.InvariantCulture)))
        MessageBox.Show("Duplicates removed and file saved   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub BackgroundWorkerEngines_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerEngines.DoWork
        Me.ProcessEnginesFile.StartInfo.FileName = Me.string_0
        Me.ProcessEnginesFile.Start()
        Me.ProcessEnginesFile.WaitForExit()
        Me.ProcessEnginesFile.Close()
    End Sub

    Private Sub BackgroundWorkerEngines_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerEngines.RunWorkerCompleted
        Me.method_0()
        Me.method_28(True)
    End Sub
    Private Sub method_20()
        Dim enumerator As IEnumerator(Of String) = Nothing
        Me.method_27(Me.LabelStatus, "Sorting...")
        Me.list_4 = Class5.list_2
        Me.list_4.Sort()
        Me.method_27(Me.LabelStatus, "Removing duplicates...")
        Me.list_5.Clear()
        Me.int_0 = 0
        Try
            enumerator = Me.list_4.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As String = enumerator.Current
                If (Me.list_5.BinarySearch(current) < 0) Then
                    Me.list_5.Add(current)
                Else
                    Me.int_0 += 1
                End If
            Loop
        Finally
            enumerator.Dispose()
        End Try
    End Sub
    Private Sub method_21(ByVal string_3 As String)
        Me.method_27(Me.LabelStatus, "Saving...")
        Dim writer As New StreamWriter(string_3)
        Dim str As String
        For Each str In Me.list_5
            writer.Write(str)
            writer.Write(ChrW(13) & ChrW(10))
        Next
        writer.Close()
    End Sub

    Private Sub RadioButtonProxies_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonProxies.CheckedChanged
        Me.method_5()
    End Sub


    Private Sub RadioButtonOther_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOther.CheckedChanged
        Me.method_5()
    End Sub
    Private Sub method_26()
        Me.RadioButtonProxies.Enabled = False
        Me.RadioButtonOther.Enabled = False
        Me.ButtonSaveDefaults.Enabled = False
    End Sub

    Private Sub method_27(ByVal label_8 As Label, ByVal string_3 As String)
        If label_8.InvokeRequired Then
            Dim method As GDelegate0 = New GDelegate0(AddressOf Me.method_27)
            label_8.Invoke(method, New Object() {label_8, string_3})
        Else
            label_8.Text = string_3
            Application.DoEvents()
        End If
    End Sub

    Private Sub method_28(ByVal bool_1 As Boolean)
        Me.GroupBoxOptions.Enabled = bool_1
        Me.GroupBoxProgress.Enabled = bool_1
        Me.ButtonSave.Enabled = bool_1
        Me.ButtonStart.Enabled = bool_1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim num As Integer = 0
        Try
            Dim num2 As Integer = (Me.int_1 - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If Me.thread_0(i).IsAlive Then
                    num += 1
                ElseIf (Class5.int_0 < (Class5.int_6 - 1)) Then
                    Dim class1 As GClass0 = Me.gclass0_0(i)
                    Me.thread_0(i) = New Thread(New ThreadStart(AddressOf class1.method_1))
                    Me.thread_0(i).Name = i.ToString
                    Me.thread_0(i).IsBackground = True
                    Me.thread_0(i).Start()
                End If
                i += 1
            Loop
            If (num = 0) Then
                Me.Timer1.Stop()
                Me.LabelStatus.Text = ("Finished  ::  Pages Scanned = " & Class5.int_2.ToString("#,#", CultureInfo.InvariantCulture) & "  ::  Items Leeched = " & Class5.int_6.ToString("#,#", CultureInfo.InvariantCulture))
                Me.ButtonStart.Text = "Start"
                Me.ButtonSave.Enabled = True
                MessageBox.Show("Finished   ", "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.GroupBoxOptions.Enabled = True
                Return
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        If Me.bool_0 Then
            Me.LabelStatus.Text = "Paused"
        Else
            Dim span As TimeSpan = DateTime.Now.Subtract(Me.dateTime_0)
            Me.LabelStatus.Text = String.Concat(New String() {"Time = ", Strings.Left(span.ToString, 8), "  ::  Threads = ", num.ToString, "  ::  Pages Scanned = ", Class5.int_2.ToString("#,#", CultureInfo.InvariantCulture), "  ::  Items Leeched = ", Class5.int_6.ToString("#,#", CultureInfo.InvariantCulture)})
        End If
    End Sub
    Private Sub method_4()
        Me.list_0.Clear()
        Me.list_1.Clear()
        Me.list_2.Clear()
        Me.list_3.Clear()

        Try
            Dim enumerator As IEnumerator = Nothing
            Dim enumerator2 As IEnumerator = Nothing
            Dim enumerator3 As IEnumerator = Nothing
            Dim enumerator4 As IEnumerator = Nothing
            Dim document As New XmlDocument
            document.Load(Me.string_1)
            Dim list As XmlNodeList = document.SelectNodes("/Defaults/Combos")
            Try
                enumerator = list.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As XmlNode = DirectCast(enumerator.Current, XmlNode)
                    Me.list_0.Add(current.ChildNodes.Item(0).InnerText)
                    Me.list_0.Add(current.ChildNodes.Item(1).InnerText)
                    Me.list_0.Add(current.ChildNodes.Item(2).InnerText)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            list = document.SelectNodes("/Defaults/Proxies")
            Try
                enumerator2 = list.GetEnumerator
                Do While enumerator2.MoveNext
                    Dim node2 As XmlNode = DirectCast(enumerator2.Current, XmlNode)
                    Me.list_1.Add(node2.ChildNodes.Item(0).InnerText)
                    Me.list_1.Add(node2.ChildNodes.Item(1).InnerText)
                    Me.list_1.Add(node2.ChildNodes.Item(2).InnerText)
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            list = document.SelectNodes("/Defaults/Email")
            Try
                enumerator3 = list.GetEnumerator
                Do While enumerator3.MoveNext
                    Dim node3 As XmlNode = DirectCast(enumerator3.Current, XmlNode)
                    Me.list_2.Add(node3.ChildNodes.Item(0).InnerText)
                    Me.list_2.Add(node3.ChildNodes.Item(1).InnerText)
                    Me.list_2.Add(node3.ChildNodes.Item(2).InnerText)
                Loop
            Finally
                If TypeOf enumerator3 Is IDisposable Then
                    TryCast(enumerator3, IDisposable).Dispose()
                End If
            End Try
            list = document.SelectNodes("/Defaults/Other")
            Try
                enumerator4 = list.GetEnumerator
                Do While enumerator4.MoveNext
                    Dim node4 As XmlNode = DirectCast(enumerator4.Current, XmlNode)
                    Me.list_3.Add(node4.ChildNodes.Item(0).InnerText)
                    Me.list_3.Add(node4.ChildNodes.Item(1).InnerText)
                    Me.list_3.Add(node4.ChildNodes.Item(2).InnerText)
                Loop
            Finally
                If TypeOf enumerator4 Is IDisposable Then
                    TryCast(enumerator4, IDisposable).Dispose()
                End If
            End Try
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.method_26()
            MessageBox.Show(("Error loading Defaults.xml   " & ChrW(13) & ChrW(10) & exception.Message), "morCrawler", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub method_5()
        Dim list As New List(Of String)
        If Me.RadioButtonProxies.Checked Then
            list = Me.list_1
        ElseIf Me.RadioButtonOther.Checked Then
            list = Me.list_3
        End If
        Me.TextBoxSearchSeed.Text = list.Item(0).ToString
        Me.TextBoxURLFilter.Text = list.Item(1).ToString
        Me.TextBoxLeechFilter.Text = list.Item(2).ToString
    End Sub

    Private Sub ButtonSaveDefaults_Click(sender As Object, e As EventArgs) Handles ButtonSaveDefaults.Click
        Me.method_7()
    End Sub
    Private Sub method_7()
        Dim list As New List(Of String) From {Me.TextBoxSearchSeed.Text, Me.TextBoxURLFilter.Text, Me.TextBoxLeechFilter.Text}
        If Me.RadioButtonProxies.Checked Then
            Me.list_1 = list
        ElseIf Me.RadioButtonOther.Checked Then
            Me.list_3 = list
        End If
        Dim writer As New XmlTextWriter(Me.string_1, Encoding.Default)
        Dim writer2 As XmlTextWriter = writer
        writer2.Formatting = Formatting.Indented
        writer2.Indentation = 4
        writer2.WriteRaw("<?xml version=""1.0""?>")
        writer2.WriteStartElement("Defaults")
        writer2.WriteStartElement("Combos")
        writer2.WriteStartElement("SearchSeed")
        writer2.WriteString(Me.list_0.Item(0).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("URLFilter")
        writer2.WriteString(Me.list_0.Item(1).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("LeechFilter")
        writer2.WriteString(Me.list_0.Item(2).ToString)
        writer2.WriteEndElement()
        writer2.WriteEndElement()
        writer2.WriteStartElement("Proxies")
        writer2.WriteStartElement("SearchSeed")
        writer2.WriteString(Me.list_1.Item(0).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("URLFilter")
        writer2.WriteString(Me.list_1.Item(1).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("LeechFilter")
        writer2.WriteString(Me.list_1.Item(2).ToString)
        writer2.WriteEndElement()
        writer2.WriteEndElement()
        writer2.WriteStartElement("Email")
        writer2.WriteStartElement("SearchSeed")
        writer2.WriteString(Me.list_2.Item(0).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("URLFilter")
        writer2.WriteString(Me.list_2.Item(1).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("LeechFilter")
        writer2.WriteString(Me.list_2.Item(2).ToString)
        writer2.WriteEndElement()
        writer2.WriteEndElement()
        writer2.WriteStartElement("Other")
        writer2.WriteStartElement("SearchSeed")
        writer2.WriteString(Me.list_3.Item(0).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("URLFilter")
        writer2.WriteString(Me.list_3.Item(1).ToString)
        writer2.WriteEndElement()
        writer2.WriteStartElement("LeechFilter")
        writer2.WriteString(Me.list_3.Item(2).ToString)
        writer2.WriteEndElement()
        writer2.WriteEndElement()
        writer2.WriteEndElement()
        writer2 = Nothing
        writer.Close()
        Me.LabelStatus.Text = "Defaults saved"
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If (Me.ButtonStart.Text = "Stop") Then
            Class5.bool_0 = True
            Me.ButtonStart.Text = "Start"
            Me.ButtonPause.Text = "Pause"
            Me.GroupBoxOptions.Enabled = True
            Me.ButtonPause.Enabled = False
            Me.ButtonSave.Enabled = True
            Me.Timer1.Stop()
            Me.LabelStatus.Text = ("Cancelled  ::  Pages Scanned = " & Class5.int_2.ToString("#,#", CultureInfo.InvariantCulture) & "  ::  Items Leeched = " & Class5.int_6.ToString("#,#", CultureInfo.InvariantCulture))
        ElseIf Me.method_14 Then
            If File.Exists((Class5.string_0 & "\morCrawler AutoSave.txt")) Then
                Select Case CInt(MessageBox.Show("Overwrite AutoSave file?   ", "morCrawler", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk))
                    Case 6
                        File.Delete((Class5.string_0 & "\morCrawler AutoSave.txt"))
                        Exit Select
                    Case 2
                        Return
                End Select
            End If
            Me.ListBoxDelegate = New AddListBoxItem(AddressOf Me.AddListBoxItemMethod)
            Me.method_15()
            Me.method_16()
            Me.method_9()
        End If
    End Sub
    Private Sub method_9()
        Me.LabelStatus.Text = "Planting seed..."
        Application.DoEvents()
        Me.BackgroundWorkerCrawler.WorkerReportsProgress = False
        Try
            Me.BackgroundWorkerCrawler.RunWorkerAsync()
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub ListBoxProgress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProgress.SelectedIndexChanged

    End Sub
End Class
