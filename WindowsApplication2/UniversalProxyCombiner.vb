Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Runtime.CompilerServices
Public Class UniversalProxyCombiner
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

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If (Me.ofd.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 <= num
                    Dim str As String = strArrays(0)
                    num1 = num1 + 1
                    Me.DataGridView1.Rows.Add(New Object() {str})
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If (Me.ofd2.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd2.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 <= num
                    Dim str As String = strArrays(0)
                    num1 = num1 + 1
                    Me.DataGridView2.Rows.Add(New Object() {str})
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)

        Me.WindowState = FormWindowState.Minimized
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

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim writer As StreamWriter = File.CreateText(Me.sfd.FileName)
            Dim view As DataGridView = Me.DataGridView1
            Dim num As Integer = (Me.DataGridView1.RowCount - 1)
            Dim i As Integer = 0
            Do While (i <= num)
                writer.WriteLine(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Me.DataGridView1.Item(0, i).Value), ":")), RuntimeHelpers.GetObjectValue(Me.DataGridView2.Item(0, i).Value))))
                i += 1
            Loop
            writer.Close()
            view = Nothing
        End If


    End Sub
End Class