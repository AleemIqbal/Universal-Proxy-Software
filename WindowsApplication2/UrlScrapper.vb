Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Public Class UrlScrapper
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.ListBox1.Items.Clear()

        If Me.VCheckBox1.Checked Then
            Me.ListBox1.Items.Add("http://www.socks-proxy.net/")
        End If
        If Me.VCheckBox2.Checked Then
            Me.ListBox1.Items.Add("http://free-proxy-list.net/anonymous-proxy.html")
        End If
        If Me.VCheckBox3.Checked Then
            Me.ListBox1.Items.Add("http://www.us-proxy.org/")
        End If
        If Me.VCheckBox4.Checked Then
            Me.ListBox1.Items.Add("http://www.proxynova.com/proxy-server-list/port-8080/")
            Me.ListBox1.Items.Add("http://www.proxynova.com/proxy-server-list/port-80/")
        End If
        If Me.VCheckBox5.Checked Then
            Me.ListBox1.Items.Add("http://www.sslproxies.org/")
        End If
        If Me.VCheckBox6.Checked Then
            Dim num2 As Integer
            Dim num As Integer = 1
            Do
                Me.ListBox1.Items.Add(("http://proxy-list.org/english/index.php?p=" & Conversions.ToString(num)))
                num += 1
                num2 = 10
            Loop While (num <= num2)
        End If
        If Me.VCheckBox7.Checked Then
            Me.ListBox1.Items.Add("http://www.google-proxy.net/")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Using dialog As SaveFileDialog = New SaveFileDialog
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Dim writer As New StreamWriter(dialog.FileName)
                Dim num2 As Integer = (Me.ListBox1.Items.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    writer.WriteLine(RuntimeHelpers.GetObjectValue(Me.ListBox1.Items.Item(i)))
                    i += 1
                Loop
                writer.Close()
            End If
        End Using
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim buffer As New StringBuilder

        buffer.Append(" ")
        If (ListBox1.Items.Count > 0) Then
            buffer.Clear()
            For i As Integer = 0 To ListBox1.Items.Count - 1

                buffer.Append(ListBox1.Items.Item(i))
                buffer.Append(vbCrLf)
            Next
        End If

        My.Computer.Clipboard.SetText(buffer.ToString)
    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub
End Class