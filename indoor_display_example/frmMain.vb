Imports indoor_display_example.InDispLib

Public Class frmMain
    Dim disp_ready As Boolean


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_ready = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Dim status As UInt32

        If disp_ready Then
            MessageBox.Show("Display port already opened.")
            Return
        End If

        status = DisplayOpen()
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            disp_ready = True
            pnlCard_status.Text = "Display ready"
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Can't open display port"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        Dim status As UInt32

        If Not disp_ready Then
            MessageBox.Show("Display not opened.")
            Return
        End If

        status = DisplayClose()
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            disp_ready = False
            pnlCard_status.Text = "Display port closed"
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Can't close display port"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim pattern() As Byte = New Byte() {24, 102, 66, 129, 129, 66, 102, 24, 24, 24, 24, 102, 66, 129, 129, 66, 102, 24}


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnSetConf.Click
        Dim status, brightness As UInt32

        brightness = Val(TxtBright.Text)
        status = SetDisplayConfig(1, 3, brightness)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "Successfully setup display config"
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Error while setting up display config"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim pattern(18) As Byte
        Dim i As Byte

        For i = 0 To 17
            pattern(i) = 0
        Next


    End Sub

    Private Sub BtnSetColor_Click(sender As Object, e As EventArgs) Handles BtnSetColor.Click
        Dim status As UInt32
        Dim red, green, blue As Byte

        ColorDialog1.AllowFullOpen() = True
        ColorDialog1.Color = TxtColor.BackColor
        If (ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TxtColor.BackColor = ColorDialog1.Color
            red = ColorDialog1.Color.R
            green = ColorDialog1.Color.G
            blue = ColorDialog1.Color.B
        End If

        status = SetDefaultcolor(red, green, blue)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "Default color setting is successful"
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Error while default color setting"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If
    End Sub

    Private Sub BtnGetColor_Click(sender As Object, e As EventArgs) Handles BtnGetColor.Click
        Dim status As UInteger

        Dim red, green, blue As Byte
        Dim display_color As Color

        status = GetDefaultcolor(red, green, blue)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "Default color reading is successful"
            pnlCard_err_expl.Text = ""

            display_color = Color.FromArgb(255, red, green, blue)
            TxtColor.BackColor = display_color
        Else
            pnlCard_status.Text = "Error while default color reading"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If

    End Sub

    Private Sub BtnGetConf_Click(sender As Object, e As EventArgs) Handles BtnGetConf.Click
        Dim status, brightness, row_nr, col_nr As UInt32

        status = GetDisplayConfig(row_nr, col_nr, brightness)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "Successfully setup display config"
            pnlCard_err_expl.Text = ""
            TxtBright.Text = CStr(brightness)
        Else
            pnlCard_status.Text = "Error while setting up display config"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If
    End Sub

    Private Sub BtnBmpMono_Click(sender As Object, e As EventArgs) Handles BtnBmpMono.Click
        Dim status As UInt32
        Dim bmp_data() As Byte = New Byte() {&HFE, &H2, &H2, &H2, &H2, &H0, &HFE, &H92, &H92, &H92, &H82, &H0, &HFE, &H82, &H82, &H44, &H38, &H0}

        status = UploadDisplayDataMono(bmp_data(0), 18)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "Successfully sent data to display"
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Error while sending data to display"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If
    End Sub

    Private Sub BtnBmpRgb_Click(sender As Object, e As EventArgs) Handles BtnBmpRgb.Click
        Dim status As UInt32
        Dim bmp_data(1024) As Byte
        Dim i As UInt16

        For i = 0 To 144
            If (i < 48) Then
                bmp_data(i * 3) = 0
                bmp_data(i * 3 + 1) = 0
                bmp_data(i * 3 + 2) = 255
            ElseIf (i < 96) Then
                bmp_data(i * 3) = 255
                bmp_data(i * 3 + 1) = 255
                bmp_data(i * 3 + 2) = 255
            Else
                bmp_data(i * 3) = 0
                bmp_data(i * 3 + 1) = 255
                bmp_data(i * 3 + 2) = 0
            End If
        Next

        status = UploadDisplayDataRgb(bmp_data(0), 432)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "Successfully sent data to display"
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Error while sending data to display"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If
    End Sub

    Private Sub BtnBmpLoad_Click(sender As Object, e As EventArgs) Handles BtnBmpLoad.Click
        Dim status As UInt32
        Dim file_name As String
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "bmp files (*.bmp)|*.bmp"
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            file_name = openFileDialog1.FileName
            status = UploadDisplayBmp(file_name)
            If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
                pnlCard_status.Text = "Successfully sent data to display"
                pnlCard_err_expl.Text = ""
            Else
                pnlCard_status.Text = "Error while sending data to display"
                pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
            End If
        End If

    End Sub

    Private Sub BtnDispVer_Click(sender As Object, e As EventArgs) Handles BtnDispVer.Click
        Dim status, hw_ver, fw_ver As UInt32

        status = GetDisplayVersion(hw_ver, fw_ver)
        If status = InDispLib.IN_DISP_ERROR_CODES.IN_DISP_OK Then
            pnlCard_status.Text = "HW version = " + CStr(hw_ver) + " FW version = " + CStr(fw_ver)
            pnlCard_err_expl.Text = ""
        Else
            pnlCard_status.Text = "Error while reading version"
            pnlCard_err_expl.Text = "Error code: &&H" + Hex(status)
        End If

    End Sub

    Private Sub BtnDllVer_Click(sender As Object, e As EventArgs) Handles BtnDllVer.Click
        Dim dll_ver As UInt32

        dll_ver = GetDllVersion()
        Dim byteArray() As Byte = BitConverter.GetBytes(dll_ver)

        pnlCard_status.Text = "Dll version = " + CStr(byteArray(0)) + "." + CStr(byteArray(1))

    End Sub
End Class
