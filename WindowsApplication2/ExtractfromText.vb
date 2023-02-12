Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Public Class ExtractfromText
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
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim oReader As StreamReader

        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            oReader = New StreamReader(OpenFileDialog1.FileName, True)
            TextBox1.Text = oReader.ReadToEnd
        End If

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
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
        Dim SaveFile As New SaveFileDialog
        SaveFile.FileName = "Leeched Combo"
        SaveFile.Filter = "Text Files (*.txt)|*.txt"
        SaveFile.Title = "Save"
        SaveFile.ShowDialog()
        Try
            Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
            Write.Write(TextBox2.Text)
            Write.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        TextBox2.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Dim lines As New List(Of String)(TextBox2.Lines)
        For i As Integer = lines.Count - 1 To 1 Step -1
            If lines(i) = lines(i - 1) Then
                lines.RemoveAt(i)
            End If
        Next
        TextBox2.Lines = lines.ToArray
    End Sub

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub
End Class