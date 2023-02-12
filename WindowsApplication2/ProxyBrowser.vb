Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class ProxyBrowser
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
    <Runtime.InteropServices.DllImport("wininet.dll", SetLastError:=True)>
    Private Shared Function InternetSetOption(ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    End Function

    Public Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure

    Private Sub UseProxy(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3

        Dim struct_IPI As Struct_INTERNET_PROXY_INFO

        struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy)
        struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local")

        Dim intptrStruct As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI))

        Marshal.StructureToPtr(struct_IPI, intptrStruct, True)

        Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))
    End Sub



    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        FlatLabel5.Text = (FlatTextBox2.Text & ":" & FlatTextBox3.Text)

    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        UseProxy(FlatLabel5.Text)
        WebBrowser1.Navigate(FlatTextBox1.Text)
    End Sub

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub
End Class