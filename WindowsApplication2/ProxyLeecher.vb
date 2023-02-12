Imports System.Text.RegularExpressions
Imports System.Text
Imports System.IO

Public Class ProxyLeecher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim Data1 As String
        Data1 = FlatTextBox1.Text
        Dim the_request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Data1)
        Dim the_response As System.Net.HttpWebResponse = the_request.GetResponse
        Dim stream_reader As System.IO.StreamReader = New System.IO.StreamReader(the_response.GetResponseStream())
        Dim code As String = stream_reader.ReadToEnd
        Dim expression As New System.Text.RegularExpressions.Regex("\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}")
        Dim mtac As MatchCollection = expression.Matches(code)
        For Each itemcode As Match In mtac
            ListBox1.Items.Add(itemcode)
        Next
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If ListBox1.Items.Count = (0) Then
            MessageBox.Show("Please Leech Proxies First.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim S_W As IO.StreamWriter

            Dim itms() As String = {ListBox1.Items.ToString}

            Dim save As New SaveFileDialog
            Dim it As Integer
            save.FileName = "Grabbed Proxies"
            save.Filter = "Grabbed Proxies (*.txt)|*.txt|ALL Files (*.*)|*.*"
            save.CheckPathExists = True
            save.ShowDialog(Me)
            S_W = New IO.StreamWriter(save.FileName)
            For it = 0 To ListBox1.Items.Count - 1
                S_W.WriteLine(ListBox1.Items.Item(it))
            Next
            S_W.Close()
        End If
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

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

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        For Row As Int16 = 0 To ListBox1.Items.Count - 2
            For RowAgain As Int16 = ListBox1.Items.Count - 1 To Row + 1 Step -1
                If ListBox1.Items(Row).ToString = ListBox1.Items(RowAgain).ToString Then
                    ListBox1.Items.RemoveAt(RowAgain)
                End If
            Next
        Next
    End Sub
End Class