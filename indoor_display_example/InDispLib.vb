Imports System.Runtime.InteropServices

Public Class InDispLib

#If Not WIN64 Then
    Private Const DLL_NAME As String = "lib/Windows/x86/display_rgb_8x6-x86.dll"
#Else
    Private Const DLL_NAME As String = "display_rgb_8x6-x86.dll" 'for x64 platform
#End If

    Public Enum IN_DISP_ERROR_CODES
        IN_DISP_OK = 0
        IN_DISP_COMMUNICATION_ERROR = 1

        IN_DISP_COMMUNICATION_BREAK = &H50
        IN_DISP_NO_MEMORY_ERROR = &H51
        IN_DISP_CAN_NOT_OPEN_DISPLAY = &H52
        IN_DISP_DISPLAY_NOT_SUPPORTED = &H53
        IN_DISP_DISPLAY_OPENING_ERROR = &H54
        IN_DISP_DISPLAY_PORT_NOT_OPENED = &H55
        IN_DISP_CANT_CLOSE_DISPLAY_PORT = &H56

        IN_DISP_DEVICE_WRONG_HANDLE = &H100
        IN_DISP_DEVICE_INDEX_OUT_OF_BOUND
        IN_DISP_DEVICE_ALREADY_OPENED
        IN_DISP_DEVICE_ALREADY_CLOSED

        FILE_OPEN_ERROR = &H300
        FILE_READING_ERROR
        FILE_MAX_LENGTH_EXCEEDED
        FILE_CONTENT_ERROR

        BMP_DATA_WRONG_LENGTH
    End Enum

    <DllImport(DLL_NAME, EntryPoint:="DisplayOpen", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DisplayOpen() As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="DisplayClose", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DisplayClose() As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetDisplayVersion", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetDisplayVersion(ByRef hw_version As UInt32,
                                             ByRef fw_version As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="SetDisplayConfig", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SetDisplayConfig(ByVal module_row_nr As UInt32,
                                            ByVal module_col_nr As UInt32,
                                            ByVal brightness As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetDisplayConfig", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetDisplayConfig(ByRef module_row_nr As UInt32,
                                            ByRef module_col_nr As UInt32,
                                            ByRef brightness As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="UploadDisplayBmp", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function UploadDisplayBmp(ByVal file_name As String) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="UploadDisplayDataMono", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function UploadDisplayDataMono(ByRef data As Byte,
                                             ByVal data_size As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="UploadDisplayDataRgb", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function UploadDisplayDataRgb(ByRef data As Byte,
                                             ByVal data_size As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="SetRelayState", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function SetRelayState(ByVal relay_on As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="SetDefaultColor", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function SetDefaultcolor(ByVal red As Byte,
                                            ByVal green As Byte,
                                            ByVal blue As Byte) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetDefaultColor", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetDefaultcolor(ByRef red As Byte,
                                            ByRef green As Byte,
                                            ByRef blue As Byte) As UInt32
    End Function
    '--------------------------------------------------------------------------------------------------------------
    ' DLL version:
    '--------------------------------------------------------------------------------------------------------------
    'DL_API uint32_t (void);
    <DllImport(DLL_NAME, EntryPoint:="GetDllVersion", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetDllVersion() As UInt32
    End Function

End Class
