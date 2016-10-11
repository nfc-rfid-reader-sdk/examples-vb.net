<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.stbCardStatus = New System.Windows.Forms.StatusStrip()
        Me.pnlCard_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlCard_err_code = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlCard_err_expl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnSetConf = New System.Windows.Forms.Button()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.BtnGetColor = New System.Windows.Forms.Button()
        Me.BtnSetColor = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnGetConf = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBright = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnBmpRgb = New System.Windows.Forms.Button()
        Me.BtnBmpMono = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnBmpLoad = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnDispVer = New System.Windows.Forms.Button()
        Me.BtnDllVer = New System.Windows.Forms.Button()
        Me.stbCardStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'stbCardStatus
        '
        Me.stbCardStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stbCardStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pnlCard_status, Me.pnlCard_err_code, Me.pnlCard_err_expl, Me.ToolStripStatusLabel1})
        Me.stbCardStatus.Location = New System.Drawing.Point(0, 451)
        Me.stbCardStatus.Name = "stbCardStatus"
        Me.stbCardStatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.stbCardStatus.Size = New System.Drawing.Size(406, 22)
        Me.stbCardStatus.SizingGrip = False
        Me.stbCardStatus.TabIndex = 1
        Me.stbCardStatus.Text = "StatusStrip1"
        '
        'pnlCard_status
        '
        Me.pnlCard_status.AutoSize = False
        Me.pnlCard_status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.pnlCard_status.Name = "pnlCard_status"
        Me.pnlCard_status.Size = New System.Drawing.Size(240, 17)
        Me.pnlCard_status.Text = "DISPLAY STATUS"
        '
        'pnlCard_err_code
        '
        Me.pnlCard_err_code.AutoSize = False
        Me.pnlCard_err_code.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.pnlCard_err_code.Name = "pnlCard_err_code"
        Me.pnlCard_err_code.Size = New System.Drawing.Size(50, 17)
        Me.pnlCard_err_code.Text = " "
        '
        'pnlCard_err_expl
        '
        Me.pnlCard_err_expl.AutoSize = False
        Me.pnlCard_err_expl.Name = "pnlCard_err_expl"
        Me.pnlCard_err_expl.Size = New System.Drawing.Size(88, 17)
        Me.pnlCard_err_expl.Spring = True
        Me.pnlCard_err_expl.Text = " "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel1.Text = "."
        '
        'BtnSetConf
        '
        Me.BtnSetConf.Location = New System.Drawing.Point(133, 19)
        Me.BtnSetConf.Name = "BtnSetConf"
        Me.BtnSetConf.Size = New System.Drawing.Size(105, 35)
        Me.BtnSetConf.TabIndex = 6
        Me.BtnSetConf.Text = "SET CONFIG"
        Me.BtnSetConf.UseVisualStyleBackColor = True
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Location = New System.Drawing.Point(207, 15)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(140, 35)
        Me.BtnDisconnect.TabIndex = 3
        Me.BtnDisconnect.Text = "DISCONNECT"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(17, 15)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(140, 35)
        Me.BtnConnect.TabIndex = 2
        Me.BtnConnect.Text = "CONNECT"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnConnect)
        Me.GroupBox1.Controls.Add(Me.BtnDisconnect)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 62)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display Connection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtColor)
        Me.GroupBox2.Controls.Add(Me.BtnGetColor)
        Me.GroupBox2.Controls.Add(Me.BtnSetColor)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 68)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Default color setting"
        '
        'TxtColor
        '
        Me.TxtColor.BackColor = System.Drawing.Color.Red
        Me.TxtColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtColor.Location = New System.Drawing.Point(252, 27)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(95, 20)
        Me.TxtColor.TabIndex = 2
        '
        'BtnGetColor
        '
        Me.BtnGetColor.Location = New System.Drawing.Point(132, 19)
        Me.BtnGetColor.Name = "BtnGetColor"
        Me.BtnGetColor.Size = New System.Drawing.Size(105, 35)
        Me.BtnGetColor.TabIndex = 1
        Me.BtnGetColor.Text = "GET COLOR"
        Me.BtnGetColor.UseVisualStyleBackColor = True
        '
        'BtnSetColor
        '
        Me.BtnSetColor.Location = New System.Drawing.Point(12, 19)
        Me.BtnSetColor.Name = "BtnSetColor"
        Me.BtnSetColor.Size = New System.Drawing.Size(105, 35)
        Me.BtnSetColor.TabIndex = 0
        Me.BtnSetColor.Text = "SET COLOR"
        Me.BtnSetColor.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnGetConf)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtBright)
        Me.GroupBox3.Controls.Add(Me.BtnSetConf)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 67)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Display brightness setting"
        '
        'BtnGetConf
        '
        Me.BtnGetConf.Location = New System.Drawing.Point(243, 19)
        Me.BtnGetConf.Name = "BtnGetConf"
        Me.BtnGetConf.Size = New System.Drawing.Size(105, 35)
        Me.BtnGetConf.TabIndex = 7
        Me.BtnGetConf.Text = "GET CONFIG"
        Me.BtnGetConf.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Brightness"
        '
        'TxtBright
        '
        Me.TxtBright.Location = New System.Drawing.Point(68, 28)
        Me.TxtBright.Name = "TxtBright"
        Me.TxtBright.Size = New System.Drawing.Size(49, 20)
        Me.TxtBright.TabIndex = 0
        Me.TxtBright.Text = "10"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnBmpRgb)
        Me.GroupBox4.Controls.Add(Me.BtnBmpMono)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(363, 62)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bitmap operation"
        '
        'BtnBmpRgb
        '
        Me.BtnBmpRgb.Location = New System.Drawing.Point(205, 19)
        Me.BtnBmpRgb.Name = "BtnBmpRgb"
        Me.BtnBmpRgb.Size = New System.Drawing.Size(140, 35)
        Me.BtnBmpRgb.TabIndex = 1
        Me.BtnBmpRgb.Text = "RGB BMP LOAD"
        Me.BtnBmpRgb.UseVisualStyleBackColor = True
        '
        'BtnBmpMono
        '
        Me.BtnBmpMono.Location = New System.Drawing.Point(15, 19)
        Me.BtnBmpMono.Name = "BtnBmpMono"
        Me.BtnBmpMono.Size = New System.Drawing.Size(140, 35)
        Me.BtnBmpMono.TabIndex = 0
        Me.BtnBmpMono.Text = "MONO BMP LOAD"
        Me.BtnBmpMono.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnBmpLoad)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 320)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(360, 53)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BMP file operation"
        '
        'BtnBmpLoad
        '
        Me.BtnBmpLoad.Location = New System.Drawing.Point(106, 12)
        Me.BtnBmpLoad.Name = "BtnBmpLoad"
        Me.BtnBmpLoad.Size = New System.Drawing.Size(140, 35)
        Me.BtnBmpLoad.TabIndex = 0
        Me.BtnBmpLoad.Text = "LOAD BMP FILE"
        Me.BtnBmpLoad.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnDllVer)
        Me.GroupBox6.Controls.Add(Me.BtnDispVer)
        Me.GroupBox6.Location = New System.Drawing.Point(28, 384)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(357, 64)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Versions"
        '
        'BtnDispVer
        '
        Me.BtnDispVer.Location = New System.Drawing.Point(11, 16)
        Me.BtnDispVer.Name = "BtnDispVer"
        Me.BtnDispVer.Size = New System.Drawing.Size(140, 35)
        Me.BtnDispVer.TabIndex = 0
        Me.BtnDispVer.Text = "DISPLAY VERSION"
        Me.BtnDispVer.UseVisualStyleBackColor = True
        '
        'BtnDllVer
        '
        Me.BtnDllVer.Location = New System.Drawing.Point(201, 16)
        Me.BtnDllVer.Name = "BtnDllVer"
        Me.BtnDllVer.Size = New System.Drawing.Size(140, 35)
        Me.BtnDllVer.TabIndex = 1
        Me.BtnDllVer.Text = "DLL VERSION"
        Me.BtnDllVer.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 473)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.stbCardStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indoor Display Example v1.0"
        Me.stbCardStatus.ResumeLayout(False)
        Me.stbCardStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stbCardStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents pnlCard_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlCard_err_code As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlCard_err_expl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnSetConf As System.Windows.Forms.Button
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents BtnConnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGetColor As Button
    Friend WithEvents BtnSetColor As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBright As TextBox
    Friend WithEvents BtnGetConf As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnBmpRgb As Button
    Friend WithEvents BtnBmpMono As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnBmpLoad As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnDllVer As Button
    Friend WithEvents BtnDispVer As Button
End Class
