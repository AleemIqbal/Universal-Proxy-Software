Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO

<StandardModule>
Friend NotInheritable Class Class6
    ' Methods
    Public Shared Function smethod_0(ByVal string_0 As String, ByVal list_0 As List(Of String), ByVal int_0 As Integer) As String
        Dim expression As Object = Class5.object_1
        ObjectFlowControl.CheckForSyncLockOnValueType(expression)
        SyncLock expression
            Select Case string_0
                Case "AddArray"
                    Class5.list_3.Clear()
                    Class5.int_7 = 0
                    Dim str2 As String
                    For Each str2 In list_0
                        Class5.list_2.Add(str2)
                        Class5.int_7 += 1
                        Class5.int_6 += 1
                        Class5.list_3.Add(str2)
                    Next
                    Class5.string_4 = Class5.int_7.ToString
                    If (Class5.list_3.Count > 0) Then
                        Class6.smethod_1(Class5.list_3)
                    End If
                    Exit Select
                Case "GetNextSeed"
                    Class5.string_4 = Class5.list_2.Item(int_0).ToString
                    Exit Select
            End Select
        End SyncLock
        Return Class5.string_4
    End Function

    Private Shared Sub smethod_1(ByVal list_0 As List(Of String))
        Dim writer As New StreamWriter((Class5.string_0 & "\morCrawler AutoSave.txt"), True)
        Dim str2 As String
        For Each str2 In list_0
            writer.Write(str2)
            writer.Write(ChrW(13) & ChrW(10))
        Next
        writer.Close()
    End Sub

End Class


