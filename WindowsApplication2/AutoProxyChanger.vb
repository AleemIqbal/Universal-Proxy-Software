Imports System
Imports System.Runtime.InteropServices
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Timers
Public Class AutoProxyChanger
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim FILE_NAME As String 
    Dim label As String
    Public proxy(2000) As String
    Public index As Integer = 0
    Public max_proxys As Integer = 0
    Dim a As String
    Dim start_check As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub



    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ''Timer1.Stop()
        FlatTextBox1.Text = proxy(index)
        index = index + 1
        Dim clsProxy As New IEProxy
        If clsProxy.SetProxy(FlatTextBox1.Text) Then
            ''MessageBox.Show("Proxy successfully enabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ''MessageBox.Show("Error enabling proxy.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If index >= max_proxys Then
            index = 0
        End If
        If label.Equals("false") Then
            Timer1.Stop()
        End If
    End Sub

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

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatTextBox3_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox3.TextChanged

    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If (Not (New IEProxy()).DisableProxy()) Then
            MessageBox.Show("Error disabling proxy.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Proxy successfully disabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If (start_check > 0) Then
            index = 0
            Do While index <> max_proxys
                proxy(index) = ""
                index = index + 1
            Loop
            If FlatTextBox3.Text = "" Then
                FILE_NAME = FlatTextBox3.Text
            End If
        End If
        If FlatTextBox3.Text <> "" Then
            FILE_NAME = FlatTextBox3.Text
        End If
        Try
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(FILE_NAME)
            index = 0
            Do While reader.Peek <> -1
                a = reader.ReadLine
                proxy(index) = a.ToString
                index = index + 1
            Loop
            max_proxys = index
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("File Not Found")
            Timer1.Stop()
        End Try
        label = "true"
        index = 0
        ''TextBox1.Text = proxy(0)
        If FlatTextBox2.Text = "" Then
            Timer1.Interval = 1000 'ms
        Else
            Try
                Dim a As Integer = Convert.ToDecimal(FlatTextBox2.Text)
                Timer1.Interval = a * 1000 'ms
            Catch ex As Exception
                MessageBox.Show(ex.Message & "Please Enter Valid Time in Seconds ")
                If Timer1.Enabled Then
                    Timer1.Stop()
                End If
            End Try
        End If
        start_check = 1
        Timer1.Start()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        label = "false"
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "Text (*.txt)|*.txt"
        If (dialog.ShowDialog = DialogResult.OK) Then
            Dim fileName As String = dialog.FileName
            Me.FlatTextBox3.Text = fileName
            Dim items As String() = File.ReadAllLines(fileName)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class