Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class ProxyURLGrabber
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
    Private a As Integer
    Private Sub backgroundWorker6_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker6.RunWorkerCompleted
        Interaction.MsgBox("Done. You can now filter and grab your data", MsgBoxStyle.Information, Nothing)
    End Sub


    Private Sub backgroundWorker7_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker7.RunWorkerCompleted
        Try
            Me.a = Me.a + 1
            Me.Label3.Text = Me.TextBox2.Lines(Me.a)
            Me.BackgroundWorker7.RunWorkerAsync()
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Done", MsgBoxStyle.Information, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Control.CheckForIllegalCrossThreadCalls = False
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        Me.BackgroundWorker3.WorkerSupportsCancellation = True
        Me.BackgroundWorker4.WorkerSupportsCancellation = True
        Me.BackgroundWorker5.WorkerSupportsCancellation = True
        Me.BackgroundWorker6.WorkerSupportsCancellation = True
        Me.BackgroundWorker7.WorkerSupportsCancellation = True
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If (Operators.CompareString(Me.TextBox1.Text, "", False) <> 0) Then
            Me.RichTextBox1.Clear()
            Me.RichTextBox2.Clear()
            Me.RichTextBox3.Clear()
            Me.TextBox2.Text = ""
            Me.BackgroundWorker1.RunWorkerAsync()
            Me.BackgroundWorker2.RunWorkerAsync()
            Me.BackgroundWorker3.RunWorkerAsync()
            Me.BackgroundWorker4.RunWorkerAsync()
            Me.BackgroundWorker5.RunWorkerAsync()
            Me.BackgroundWorker6.RunWorkerAsync()
        Else
            Interaction.MsgBox("Insert keywords first !", MsgBoxStyle.Critical, Nothing)
        End If
    End Sub



    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        If (Operators.CompareString(Me.TextBox3.Text, "", False) <> 0) Then
            Me.TextBox3.Text = Me.TextBox3.Text.Replace("q=http://webcache.googleusercontent.com/search", "").Trim()
            Me.TextBox3.Text = Me.TextBox3.Text.Replace("q=https://www.youtube.com/watch", "").Trim()
            Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
            Dim matchCollections As MatchCollection = regex.Matches(Me.TextBox3.Text)
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Try
                enumerator = matchCollections.GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                    stringBuilder.AppendLine(current.ToString())
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.TextBox2.Text = String.Concat(Me.TextBox2.Text, stringBuilder.ToString())
            Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
            Dim matchCollections1 As MatchCollection = regex1.Matches(Me.TextBox3.Text)
            Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
            Try
                enumerator1 = matchCollections1.GetEnumerator()
                While enumerator1.MoveNext()
                    Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                    stringBuilder1.AppendLine(match.ToString())
                End While
            Finally
                If (TypeOf enumerator1 Is IDisposable) Then
                    TryCast(enumerator1, IDisposable).Dispose()
                End If
            End Try
            Me.TextBox2.Text = String.Concat(Me.TextBox2.Text, stringBuilder1.ToString())
            Interaction.MsgBox("Filter done. Now you can grab your data", MsgBoxStyle.Information, Nothing)
        Else
            Interaction.MsgBox("No data to filter.", MsgBoxStyle.Critical, Nothing)
        End If
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If (Operators.CompareString(Me.TextBox2.Text, "", False) <> 0) Then
            Me.Label3.Text = Me.TextBox2.Lines(0)
            Me.BackgroundWorker7.RunWorkerAsync()
        Else
            Interaction.MsgBox("No data to grab. Please first search for some data", MsgBoxStyle.Critical, Nothing)
        End If
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Dim strs As List(Of String) = New List(Of String)(Me.TextBox4.Lines)
        For i As Integer = strs.Count - 1 To 1 Step -1
            If (Operators.CompareString(strs(i), strs(i - 1), False) = 0) Then
                strs.RemoveAt(i)
            End If
        Next

        Me.TextBox4.Lines = strs.ToArray()
        Interaction.MsgBox("Duplicate removed", MsgBoxStyle.Information, Nothing)
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.BackgroundWorker1.CancelAsync()
        Me.BackgroundWorker2.CancelAsync()
        Me.BackgroundWorker3.CancelAsync()
        Me.BackgroundWorker4.CancelAsync()
        Me.BackgroundWorker5.CancelAsync()
        Me.BackgroundWorker6.CancelAsync()
        Me.BackgroundWorker7.CancelAsync()
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        If (Operators.CompareString(Me.TextBox4.Text, "", False) <> 0) Then
            Dim saveFileDialog As System.Windows.Forms.SaveFileDialog = New System.Windows.Forms.SaveFileDialog() With
            {
                .RestoreDirectory = True,
                .Filter = "txt files (*.txt)|*.txt",
                .FilterIndex = 1
            }
            saveFileDialog.ShowDialog()
            If (Operators.CompareString(saveFileDialog.FileName, Nothing, False) <> 0) Then
                Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(saveFileDialog.FileName)
                    streamWriter.WriteLine(Me.TextBox4.Text)
                End Using
            End If
        Else
            Interaction.MsgBox("No data to save", MsgBoxStyle.Critical, Nothing)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Try
            Dim strArrays As String() = Me.TextBox1.Text.Split(New Char() {Strings.ChrW(13)})
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim str As String = strArrays(num)
                Dim webClient As System.Net.WebClient = New System.Net.WebClient()
                Dim str1 As String = webClient.DownloadString(String.Concat("http://www.google.com/search?q=", str, "&start=0"))
                Me.RichTextBox1.Text = str1
                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections As MatchCollection = regex.Matches(Me.RichTextBox1.Text)
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator = matchCollections.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                        stringBuilder.AppendLine(current.ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder.ToString())
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections1 As MatchCollection = regex1.Matches(Me.RichTextBox1.Text)
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator1 = matchCollections1.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                        stringBuilder1.AppendLine(match.ToString())
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder1.ToString())
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Your IP is banned. Please change proxy", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Try
            Dim strArrays As String() = Me.TextBox1.Text.Split(New Char() {Strings.ChrW(13)})
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim str As String = strArrays(num)
                Dim webClient As System.Net.WebClient = New System.Net.WebClient()
                Dim str1 As String = webClient.DownloadString(String.Concat("http://www.google.com/search?q=", str, "&start=10"))
                Me.RichTextBox2.Text = str1
                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections As MatchCollection = regex.Matches(Me.RichTextBox2.Text)
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator = matchCollections.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                        stringBuilder.AppendLine(current.ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder.ToString())
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections1 As MatchCollection = regex1.Matches(Me.RichTextBox2.Text)
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator1 = matchCollections1.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                        stringBuilder1.AppendLine(match.ToString())
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder1.ToString())
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Your IP is banned. Please change proxy", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Try
            Dim strArrays As String() = Me.TextBox1.Text.Split(New Char() {Strings.ChrW(13)})
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim str As String = strArrays(num)
                Dim webClient As System.Net.WebClient = New System.Net.WebClient()
                Dim str1 As String = webClient.DownloadString(String.Concat("http://www.google.com/search?q=", str, "&start=20"))
                Me.RichTextBox3.Text = str1
                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections As MatchCollection = regex.Matches(Me.RichTextBox3.Text)
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator = matchCollections.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                        stringBuilder.AppendLine(current.ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder.ToString())
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections1 As MatchCollection = regex1.Matches(Me.RichTextBox3.Text)
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator1 = matchCollections1.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                        stringBuilder1.AppendLine(match.ToString())
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder1.ToString())
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Your IP is banned. Please change proxy", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Try
            Dim strArrays As String() = Me.TextBox1.Text.Split(New Char() {Strings.ChrW(13)})
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim str As String = strArrays(num)
                Dim webClient As System.Net.WebClient = New System.Net.WebClient()
                Dim str1 As String = webClient.DownloadString(String.Concat("http://www.google.com/search?q=", str, "&start=30"))
                Me.RichTextBox4.Text = str1
                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections As MatchCollection = regex.Matches(Me.RichTextBox4.Text)
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator = matchCollections.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                        stringBuilder.AppendLine(current.ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder.ToString())
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections1 As MatchCollection = regex1.Matches(Me.RichTextBox4.Text)
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator1 = matchCollections1.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                        stringBuilder1.AppendLine(match.ToString())
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder1.ToString())
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Your IP is banned. Please change proxy", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BackgroundWorker5_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Try
            Dim strArrays As String() = Me.TextBox1.Text.Split(New Char() {Strings.ChrW(13)})
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim str As String = strArrays(num)
                Dim webClient As System.Net.WebClient = New System.Net.WebClient()
                Dim str1 As String = webClient.DownloadString(String.Concat("http://www.google.com/search?q=", str, "&start=50"))
                Me.RichTextBox6.Text = str1
                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections As MatchCollection = regex.Matches(Me.RichTextBox5.Text)
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator = matchCollections.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                        stringBuilder.AppendLine(current.ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder.ToString())
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections1 As MatchCollection = regex1.Matches(Me.RichTextBox5.Text)
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator1 = matchCollections1.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                        stringBuilder1.AppendLine(match.ToString())
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder1.ToString())
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Your IP is banned. Please change proxy", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BackgroundWorker6_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Try
            Dim strArrays As String() = Me.TextBox1.Text.Split(New Char() {Strings.ChrW(13)})
            Dim num As Integer = 0
            While num < CInt(strArrays.Length)
                Dim str As String = strArrays(num)
                Dim webClient As System.Net.WebClient = New System.Net.WebClient()
                Dim str1 As String = webClient.DownloadString(String.Concat("http://www.google.com/search?q=", str, "&start=40"))
                Me.RichTextBox5.Text = str1
                Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections As MatchCollection = regex.Matches(Me.RichTextBox6.Text)
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator = matchCollections.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As System.Text.RegularExpressions.Match = DirectCast(enumerator.Current, System.Text.RegularExpressions.Match)
                        stringBuilder.AppendLine(current.ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder.ToString())
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})")
                Dim matchCollections1 As MatchCollection = regex1.Matches(Me.RichTextBox6.Text)
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Try
                    enumerator1 = matchCollections1.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim match As System.Text.RegularExpressions.Match = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Match)
                        stringBuilder1.AppendLine(match.ToString())
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
                Me.TextBox3.Text = String.Concat(Me.TextBox3.Text, stringBuilder1.ToString())
                num = num + 1
            End While
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Interaction.MsgBox("Your IP is banned. Please change proxy", MsgBoxStyle.Critical, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BackgroundWorker7_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker7.DoWork
        Try
            Dim strArrays As String() = Me.Label3.Text.Split(New Char() {"="c})
            Dim str As String = strArrays(0)
            Dim str1 As String = strArrays(1)
            Me.TextBox4.Text = String.Concat(Me.TextBox4.Text, Environment.NewLine, str1)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.Label6.Text = Conversions.ToString(Me.TextBox2.Lines.Count())
    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Me.Label5.Text = Conversions.ToString(Me.TextBox3.Lines.Count())
    End Sub

    Private Sub TextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.Label8.Text = Conversions.ToString(Me.TextBox4.Lines.Count())
    End Sub
End Class