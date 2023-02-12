Imports System
Imports System.Runtime.InteropServices

Public Class IEProxy
    Public Enum Options
        INTERNET_PER_CONN_FLAGS = 1
        INTERNET_PER_CONN_PROXY_SERVER = 2
        INTERNET_PER_CONN_PROXY_BYPASS = 3
        INTERNET_PER_CONN_AUTOCONFIG_URL = 4
        INTERNET_PER_CONN_AUTODISCOVERY_FLAGS = 5
        INTERNET_OPTION_REFRESH = 37
        INTERNET_OPTION_PER_CONNECTION_OPTION = 75
        INTERNET_OPTION_SETTINGS_CHANGED = 39
        PROXY_TYPE_PROXY = &H2
        PROXY_TYPE_DIRECT = &H1
    End Enum

    <StructLayout(LayoutKind.Sequential)>
    Private Class FILETIME
        Public dwLowDateTime As Integer
        Public dwHighDateTime As Integer
    End Class

    <StructLayout(LayoutKind.Explicit, Size:=12)>
    Private Structure INTERNET_PER_CONN_OPTION
        <FieldOffset(0)> Dim dwOption As Integer
        <FieldOffset(4)> Dim dwValue As Integer
        <FieldOffset(4)> Dim pszValue As IntPtr
        <FieldOffset(4)> Dim ftValue As IntPtr

        Public Function GetBytes() As Byte()
            Dim b(12) As Byte
            BitConverter.GetBytes(dwOption).CopyTo(b, 0)
            Select Case dwOption
                Case Options.INTERNET_PER_CONN_FLAGS
                    BitConverter.GetBytes(dwValue).CopyTo(b, 4)
                Case Options.INTERNET_PER_CONN_PROXY_BYPASS
                    BitConverter.GetBytes(pszValue.ToInt32()).CopyTo(b, 4)
                Case Options.INTERNET_PER_CONN_PROXY_SERVER
                    BitConverter.GetBytes(pszValue.ToInt32()).CopyTo(b, 4)
            End Select
            Return b
        End Function
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Private Class INTERNET_PER_CONN_OPTION_LIST
        Public dwSize As Integer
        Public pszConnection As String
        Public dwOptionCount As Integer
        Public dwOptionError As Integer
        Public pOptions As IntPtr
    End Class

    <StructLayout(LayoutKind.Sequential)>
    Private Class INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public lpszProxy As IntPtr
        Public lpszProxyBypass As IntPtr
    End Class

    Private Const ERROR_INSUFFICIENT_BUFFER = 122
    Private Const INTERNET_OPTION_PROXY = 38
    Private Const INTERNET_OPEN_TYPE_DIRECT = 1

    <DllImport("wininet.dll")>
    Private Shared Function InternetSetOption(ByVal hInternet As IntPtr,
             ByVal dwOption As Integer,
             ByVal lpBuffer As INTERNET_PER_CONN_OPTION_LIST,
             ByVal dwBufferLength As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GetLastError() As Integer
    End Function

    Public Function SetProxy(ByVal proxy_full_addr As String) As Boolean
        Dim bReturn As Boolean
        Dim list As New INTERNET_PER_CONN_OPTION_LIST
        Dim dwBufSize As Integer = Marshal.SizeOf(list)
        Dim opts(3) As INTERNET_PER_CONN_OPTION
        Dim opt_size As Integer = Marshal.SizeOf(opts(0))

        list.dwSize = dwBufSize
        list.pszConnection = ControlChars.NullChar
        list.dwOptionCount = 3

        'set flags
        opts(0).dwOption = Options.INTERNET_PER_CONN_FLAGS
        opts(0).dwValue = Options.PROXY_TYPE_DIRECT Or Options.PROXY_TYPE_PROXY

        'set proxyname
        opts(1).dwOption = Options.INTERNET_PER_CONN_PROXY_SERVER
        opts(1).pszValue = Marshal.StringToHGlobalAnsi(proxy_full_addr)

        'set override
        opts(2).dwOption = Options.INTERNET_PER_CONN_PROXY_BYPASS
        opts(2).pszValue = Marshal.StringToHGlobalAnsi("local")

        Dim b(3 * opt_size) As Byte
        opts(0).GetBytes().CopyTo(b, 0)
        opts(1).GetBytes().CopyTo(b, opt_size)
        opts(2).GetBytes().CopyTo(b, 2 * opt_size)

        Dim ptr As IntPtr = Marshal.AllocCoTaskMem(3 * opt_size)
        Marshal.Copy(b, 0, ptr, 3 * opt_size)

        list.pOptions = ptr
        'Set the options on the connection
        bReturn = InternetSetOption(IntPtr.Zero, Options.INTERNET_OPTION_PER_CONNECTION_OPTION, list, dwBufSize)
        If Not bReturn Then
            Debug.WriteLine(GetLastError)
        End If

        'Notify existing Internet Explorer instances that the settings have changed
        bReturn = InternetSetOption(IntPtr.Zero, Options.INTERNET_OPTION_SETTINGS_CHANGED, Nothing, 0)
        If Not bReturn Then
            Debug.WriteLine(GetLastError)
        End If

        'Flush the current IE proxy setting
        bReturn = InternetSetOption(IntPtr.Zero, Options.INTERNET_OPTION_REFRESH, Nothing, 0)
        If Not bReturn Then
            Debug.WriteLine(GetLastError)
        End If

        Marshal.FreeHGlobal(opts(1).pszValue)
        Marshal.FreeHGlobal(opts(2).pszValue)
        Marshal.FreeCoTaskMem(ptr)
        Return bReturn
    End Function

    Public Function DisableProxy() As Boolean
        Dim bReturn As Boolean
        Dim list As New INTERNET_PER_CONN_OPTION_LIST
        Dim dwBufSize As Integer = Marshal.SizeOf(list)
        Dim opts(0) As INTERNET_PER_CONN_OPTION
        Dim opt_size As Integer = Marshal.SizeOf(opts(0))

        list.dwSize = dwBufSize
        list.pszConnection = ControlChars.NullChar
        list.dwOptionCount = 1

        opts(0).dwOption = Options.INTERNET_PER_CONN_FLAGS
        opts(0).dwValue = Options.PROXY_TYPE_DIRECT

        Dim b(opt_size) As Byte
        opts(0).GetBytes().CopyTo(b, 0)

        Dim ptr As IntPtr = Marshal.AllocCoTaskMem(opt_size)
        Marshal.Copy(b, 0, ptr, opt_size)

        list.pOptions = ptr
        'Set the options on the connection
        bReturn = InternetSetOption(IntPtr.Zero, Options.INTERNET_OPTION_PER_CONNECTION_OPTION, list, dwBufSize)
        If Not bReturn Then
            Debug.WriteLine(GetLastError)
        End If

        'Notify existing Internet Explorer instances that the settings have changed
        bReturn = InternetSetOption(IntPtr.Zero, Options.INTERNET_OPTION_SETTINGS_CHANGED, Nothing, 0)
        If Not bReturn Then
            Debug.WriteLine(GetLastError)
        End If

        'Flush the current IE proxy setting
        bReturn = InternetSetOption(IntPtr.Zero, Options.INTERNET_OPTION_REFRESH, Nothing, 0)
        If Not bReturn Then
            Debug.WriteLine(GetLastError)
        End If

        Marshal.FreeCoTaskMem(ptr)
        Return bReturn
    End Function
End Class