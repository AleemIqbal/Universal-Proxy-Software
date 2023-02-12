Imports Microsoft.VisualBasic.CompilerServices

<StandardModule>
Friend NotInheritable Class Class7
    ' Methods
    Public Shared Function smethod_0(ByVal string_0 As String, ByVal string_1 As String, ByVal list_0 As List(Of String)) As String
        Dim expression As Object = Class5.object_0
        ObjectFlowControl.CheckForSyncLockOnValueType(expression)
        SyncLock expression
            Select Case string_0
                Case "AddSingle"
                    If Not Class5.list_1.Contains(string_1) Then
                        Class5.list_1.Add(string_1)
                    End If
                    Exit Select
                Case "AddArray"
                    Class5.int_5 = 0
                    Dim str2 As String
                    For Each str2 In list_0
                        If Not Class5.list_1.Contains(str2) Then
                            Class5.list_1.Add(str2)
                            Class5.int_5 += 1
                            Class5.int_3 += 1
                        End If
                    Next
                    Class5.string_3 = Class5.int_5.ToString
                    Exit Select
                Case "NextURLtoLeech"
                    Class5.string_3 = Class5.list_1.Item(Class5.int_4).ToString
                    Exit Select
            End Select
        End SyncLock
        Return Class5.string_3
    End Function

End Class



