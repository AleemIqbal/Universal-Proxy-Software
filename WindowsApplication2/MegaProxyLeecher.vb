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
Public Class MegaProxyLeecher
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

    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Label9.Visible = False
        Me.Label10.Visible = True
    End Sub


    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Me.TextBox2.Text = ""
        Me.BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.BackgroundWorker1.CancelAsync

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If (Me.TextBox2.Text = "") Then
            Interaction.MsgBox("No data to save", MsgBoxStyle.Critical, Nothing)
        Else
            Dim dialog As New SaveFileDialog With {
            .RestoreDirectory = True,
            .Filter = "txt files (*.txt)|*.txt",
            .FilterIndex = 1
        }
            dialog.ShowDialog()

            If (dialog.FileName <> Nothing) Then
                Using writer As StreamWriter = New StreamWriter(dialog.FileName)
                    writer.WriteLine(Me.TextBox2.Text)
                End Using
            End If
        End If

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Control.CheckForIllegalCrossThreadCalls = False
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        Me.Label9.Visible = False
        Me.Label10.Visible = False
    End Sub



    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Label3.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TextBox1.Lines))
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.Label4.Text = Conversions.ToString(Enumerable.Count(Of String)(Me.TextBox2.Lines))
        Me.TextBox2.Select(Me.TextBox2.Text.Length, 0)
        Me.TextBox2.ScrollToCaret()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Dim lines As New List(Of String)(TextBox2.Lines)
        For i As Integer = lines.Count - 1 To 1 Step -1
            If lines(i) = lines(i - 1) Then
                lines.RemoveAt(i)
            End If
        Next
        TextBox2.Lines = lines.ToArray
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim num3 As Integer

        Try
            Dim num4 As Integer
Label_0001:
            ProjectData.ClearProjectError()
            Dim num2 As Integer = -2
Label_000A:
            num4 = 2
            Dim strArray As String() = Me.TextBox1.Text.Split(New Char() {ChrW(13)})
Label_002E:
            num4 = 3
            Dim strArray2 As String() = strArray


            Dim index As Integer = 0
            Do While (index < strArray2.Length)
                Dim requestUriString As String = strArray2(index)
Label_0043:
                num4 = 4
                Dim request As HttpWebRequest = DirectCast(WebRequest.Create(requestUriString), HttpWebRequest)
Label_0054:
                num4 = 5
                Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
Label_0065:
                num4 = 6
                Dim reader As New StreamReader(response.GetResponseStream)
Label_0076:
                num4 = 7
                Dim input As String = reader.ReadToEnd
Label_0081:
                num4 = 8
                Dim regex As New Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
Label_008F:
                num4 = 9
                Dim matchs As MatchCollection = regex.Matches(input)
Label_009C:
                num4 = 10
                Me.Label9.ForeColor = Color.Lime
Label_00B1:
                num4 = 11
                Me.Label9.Text = requestUriString
Label_00C3:
                num4 = 12
                Me.Label9.Visible = True
Label_00D4:
                num4 = 13
                Dim builder As New StringBuilder
Label_00DE:
                num4 = 14
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                Dim enumerator As IEnumerator = matchs.GetEnumerator
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                Do While enumerator.MoveNext
                    Dim current As Match = DirectCast(enumerator.Current, Match)
Label_00FB:
                    num4 = 15

#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                    builder.AppendLine(current.ToString)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
Label_010D:
                    num4 = &H10
                Loop
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
Label_0140:
                num4 = &H11
                Me.TextBox2.Text = (Me.TextBox2.Text & builder.ToString)
                index += 1
Label_016C:
                num4 = &H12
            Loop
            GoTo Label_0234
Label_018F:
            num3 = 0
            Select Case (num3 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_000A
                Case 3
                    GoTo Label_002E
                Case 4
                    GoTo Label_0043
                Case 5
                    GoTo Label_0054
                Case 6
                    GoTo Label_0065
                Case 7
                    GoTo Label_0076
                Case 8
                    GoTo Label_0081
                Case 9
                    GoTo Label_008F
                Case 10
                    GoTo Label_009C
                Case 11
                    GoTo Label_00B1
                Case 12
                    GoTo Label_00C3
                Case 13
                    GoTo Label_00D4
                Case 14
                    GoTo Label_00DE
                Case 15
                    GoTo Label_00FB
                Case &H10
                    GoTo Label_010D
                Case &H11
                    GoTo Label_0140
                Case &H12
                    GoTo Label_016C
                Case &H13
                    GoTo Label_0234
                Case Else
                    GoTo Label_0229
            End Select
Label_01E9:
            num3 = num4
            Select Case If((num2 > -2), num2, 1)
                Case 0
                    GoTo Label_0229
                Case 1
                    GoTo Label_018F
            End Select
        Catch exception1 As Exception When (num3 = 0)
            ProjectData.SetProjectError(exception1)
            GoTo Label_01E9
        End Try
Label_0229:
        Throw ProjectData.CreateProjectError(-2146828237)
Label_0234:
        If (num3 <> 0) Then
            ProjectData.ClearProjectError()
        End If
    End Sub







End Class