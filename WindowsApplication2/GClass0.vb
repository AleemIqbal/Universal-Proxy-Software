Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading

Public NotInheritable Class GClass0
    ' Methods
    Public Sub New(ByVal formMain_1 As MorCrawler)
        Me.formMain_0 = formMain_1
    End Sub

    Public Sub method_0(ByVal string_8 As String)
        If Not Class5.bool_0 Then
            Class7.smethod_0("AddSingle", string_8, Nothing)
            Me.int_0 = 0
            Try
                Me.string_0 = Me.method_3(string_8)
                If Class5.bool_0 Then
                    Return
                End If
                Me.regex_0 = New Regex(Class5.string_1)
                Me.match_0 = Me.regex_0.Match(Me.string_0)
                Me.list_0.Clear()

                Do While Me.match_0.Success
                    Me.string_1 = Me.match_0.Groups.Item(1).Value.ToString
                    Me.list_0.Add(Me.string_1)
                    Me.match_0 = Me.match_0.NextMatch
                Loop
                Me.int_0 = Conversions.ToInteger(Class7.smethod_0("AddArray", Nothing, Me.list_0))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            Me.string_7 = (Me.int_0.ToString & " Links added from " & string_8)
            Me.string_0 = String.Empty
            Me.regex_0 = Nothing
            Thread.Sleep(&H3E8)
        End If
    End Sub

    Public Sub method_1()
        If Not Class5.bool_0 Then
            If (Class5.int_4 >= (Class5.int_3 - 1)) Then
                If (Class5.int_0 >= (Class5.int_6 - 1)) Then
                    Return
                End If
                Class5.int_0 += 1
                Me.string_2 = Class6.smethod_0("GetNextSeed", Nothing, Class5.int_0)
                Dim num2 As Integer = (Class5.int_1 - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    Me.string_3 = Class5.list_0.Item(i)
                    Me.string_3 = Me.string_3.Replace("[SEARCH SEED]", Me.string_2)
                    Me.method_0(Me.string_3)
                    i += 1
                Loop
                Me.method_1()
            Else
                Class5.int_4 = Interlocked.Increment(Class5.int_4)
                Me.method_2()
            End If
            Thread.Sleep(&H3E8)
        End If
    End Sub

    Private Sub method_2()
        If Not Class5.bool_0 Then
            Me.int_1 = 0
            Me.string_4 = Class7.smethod_0("NextURLtoLeech", Nothing, Nothing)
            Try
                Me.list_1.Clear()
                Me.string_0 = Me.method_3(Me.string_4)
                If Class5.bool_0 Then
                    Return
                End If
                Me.regex_1 = New Regex(Class5.string_2)
                Me.match_0 = Me.regex_1.Match(Me.string_0)
                Do While Me.match_0.Success
                    Me.string_5 = Me.match_0.Groups.Item(1).Value.ToString
                    Me.list_1.Add(Me.string_5)
                    Me.match_0 = Me.match_0.NextMatch
                Loop
                Me.int_1 = Conversions.ToInteger(Class6.smethod_0("AddArray", Me.list_1, 0))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            If (Me.int_1 > 0) Then
                Me.string_7 = (Me.int_1.ToString & " Items leeched from " & Me.string_4)
            End If
            Me.string_0 = String.Empty
            Me.regex_1 = Nothing
            Class5.int_2 += 1
            Thread.Sleep(&H3E8)
            Me.method_1()
        End If
    End Sub

    Private Function method_3(ByVal string_8 As String) As String
        Me.string_6 = Nothing
        Try
            Me.uri_0 = New Uri(string_8)
            Me.webRequest_0 = WebRequest.Create(Me.uri_0)
            Me.webRequest_0.Timeout = &H1388
            Me.webResponse_0 = Me.webRequest_0.GetResponse
            Me.stream_0 = Me.webResponse_0.GetResponseStream
            Me.streamReader_0 = New StreamReader(Me.stream_0)
            Me.string_6 = Me.streamReader_0.ReadToEnd
            Me.streamReader_0.Close()
            Me.stream_0.Close()
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Me.string_6 = Nothing
            ProjectData.ClearProjectError()
        End Try
        Me.uri_0 = Nothing
        Return Me.string_6
    End Function


    ' Fields
    Private formMain_0 As MorCrawler
    Private int_0 As Integer = 0
    Private int_1 As Integer = 0
    Private list_0 As List(Of String) = New List(Of String)
    Private list_1 As List(Of String) = New List(Of String)
    Private match_0 As Match = Nothing
    Private regex_0 As Regex = Nothing
    Private regex_1 As Regex = Nothing
    Private stream_0 As Stream = Nothing
    Private streamReader_0 As StreamReader = Nothing
    Private string_0 As String = Nothing
    Private string_1 As String = Nothing
    Private string_2 As String = Nothing
    Private string_3 As String = Nothing
    Private string_4 As String = Nothing
    Private string_5 As String = Nothing
    Private string_6 As String = Nothing
    Private string_7 As String = Nothing
    Private uri_0 As Uri
    Private webRequest_0 As WebRequest = Nothing
    Private webResponse_0 As WebResponse = Nothing
End Class



