Imports System.Text.RegularExpressions
Imports System.Text
Imports IronWebScraper
Imports Microsoft.VisualBasic.CompilerServices

Public Class TextProxyLeecher
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Friend Class BlogScraper
        Inherits WebScraper
        Public Overrides Sub Init()
            Me.LoggingLevel = WebScraper.LogLevel.All
            Me.Request("http://premiumbuilds.com/", AddressOf Parse)

        End Sub
        Public Overrides Sub Parse(ByVal response As Response)
            System.Diagnostics.Debug.WriteLine(response)
        End Sub
    End Class
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
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        Dim input As String = TextBox1.Text
        Dim regex As New Regex("\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}")
        Dim matchs As MatchCollection = regex.Matches(input)
        Dim enumerator As IEnumerator = matchs.GetEnumerator
        Dim builder As New StringBuilder
        Do While enumerator.MoveNext
            Dim current As Match = DirectCast(enumerator.Current, Match)
            builder.AppendLine(current.ToString)
        Loop
        If TypeOf enumerator Is IDisposable Then
            TryCast(enumerator, IDisposable).Dispose()
        End If
        Me.TextBox2.Text = (Me.TextBox2.Text & builder.ToString)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim filetosaveas As String = sfd.FileName
            Dim objwriter As New System.IO.StreamWriter(filetosaveas)
            objwriter.Write(TextBox2.Text)
            objwriter.Close()
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Dim strs As List(Of String) = New List(Of String)(Me.TextBox2.Lines)
        For i As Integer = strs.Count - 1 To 1 Step -1
            If (Operators.CompareString(strs(i), strs(i - 1), False) = 0) Then
                strs.RemoveAt(i)
            End If
        Next

        Me.TextBox2.Lines = strs.ToArray()
        Interaction.MsgBox("Duplicate removed", MsgBoxStyle.Information, Nothing)
    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub
End Class