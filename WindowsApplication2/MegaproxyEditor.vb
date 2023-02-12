Imports System.IO
Public Class MegaproxyEditor
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

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fl As String
            fl = ofd.FileName

            Dim sr As New StreamReader(fl)
            TextBox1.Text = sr.ReadToEnd()
            sr.Close()
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim allLineSplits = From line In TextBox1.Lines
                            Let split = line.Split({":", "|", "+", ";"}, StringSplitOptions.RemoveEmptyEntries)
                            Where split.Length >= 2
                            Select split

        Dim textBox2Lines = From split In allLineSplits
                            Select split(0)
        Dim textBox3Lines = From split In allLineSplits
                            Select split(1)
        TextBox2.Lines = textBox2Lines.ToArray()
        TextBox3.Lines = textBox3Lines.ToArray()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim allLineSplits = From line In TextBox1.Lines
                            Let split = line.Split({":"}, StringSplitOptions.RemoveEmptyEntries)
                            Where split.Length >= 2
                            Select split

        Dim textBox2Lines = From split In allLineSplits
                            Select split(1)
        Dim textBox3Lines = From split In allLineSplits
                            Select split(0)
        TextBox2.Lines = textBox2Lines.ToArray()
        TextBox3.Lines = textBox3Lines.ToArray()
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Please Select Delimiter", "Error",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End If
        Dim allLines = From line In TextBox2.Lines.Zip(TextBox3.Lines, Function(l1, l2) New With {l1, l2})
        Dim textBox4Lines = From x In allLines Select $"{x.l1}{ComboBox1.Text }{x.l2}"
        TextBox4.Lines = textBox4Lines.ToArray()
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click

        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim filetosaveas As String = sfd.FileName
            Dim objwriter As New System.IO.StreamWriter(filetosaveas)
            objwriter.Write(TextBox4.Text)
            objwriter.Close()
        End If
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        TextBox4.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()
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

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Clipboard.SetText(TextBox4.Text)
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Me.Close()
    End Sub
End Class