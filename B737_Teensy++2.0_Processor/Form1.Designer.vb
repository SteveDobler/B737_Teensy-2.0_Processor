<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formB737FMC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formB737FMC))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAllLeds = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnOfstOff = New System.Windows.Forms.Button()
        Me.btnCallOff = New System.Windows.Forms.Button()
        Me.btnMsgOff = New System.Windows.Forms.Button()
        Me.btnExecOff = New System.Windows.Forms.Button()
        Me.btnFailOff = New System.Windows.Forms.Button()
        Me.txtBoxOfst = New System.Windows.Forms.TextBox()
        Me.txtBoxMsg = New System.Windows.Forms.TextBox()
        Me.txtBoxFail = New System.Windows.Forms.TextBox()
        Me.txtBoxCall = New System.Windows.Forms.TextBox()
        Me.txtBoxExec = New System.Windows.Forms.TextBox()
        Me.btnOfstOn = New System.Windows.Forms.Button()
        Me.btnCallOn = New System.Windows.Forms.Button()
        Me.btnMsgOn = New System.Windows.Forms.Button()
        Me.btnExecOn = New System.Windows.Forms.Button()
        Me.btnFailOn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLcdAuto = New System.Windows.Forms.Button()
        Me.btnLcdMinus = New System.Windows.Forms.Button()
        Me.btnLcdPlus = New System.Windows.Forms.Button()
        Me.btnLcdMenu = New System.Windows.Forms.Button()
        Me.btnLcdPower = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button11 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 346)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtAllLeds)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnOfstOff)
        Me.GroupBox2.Controls.Add(Me.btnCallOff)
        Me.GroupBox2.Controls.Add(Me.btnMsgOff)
        Me.GroupBox2.Controls.Add(Me.btnExecOff)
        Me.GroupBox2.Controls.Add(Me.btnFailOff)
        Me.GroupBox2.Controls.Add(Me.txtBoxOfst)
        Me.GroupBox2.Controls.Add(Me.txtBoxMsg)
        Me.GroupBox2.Controls.Add(Me.txtBoxFail)
        Me.GroupBox2.Controls.Add(Me.txtBoxCall)
        Me.GroupBox2.Controls.Add(Me.txtBoxExec)
        Me.GroupBox2.Controls.Add(Me.btnOfstOn)
        Me.GroupBox2.Controls.Add(Me.btnCallOn)
        Me.GroupBox2.Controls.Add(Me.btnMsgOn)
        Me.GroupBox2.Controls.Add(Me.btnExecOn)
        Me.GroupBox2.Controls.Add(Me.btnFailOn)
        Me.GroupBox2.Location = New System.Drawing.Point(480, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 270)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LED Test"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(166, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "ALL OFF"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtAllLeds
        '
        Me.txtAllLeds.Location = New System.Drawing.Point(111, 236)
        Me.txtAllLeds.Name = "txtAllLeds"
        Me.txtAllLeds.Size = New System.Drawing.Size(42, 20)
        Me.txtAllLeds.TabIndex = 25
        Me.txtAllLeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(34, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 35)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "ALL ON"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnOfstOff
        '
        Me.btnOfstOff.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnOfstOff.Location = New System.Drawing.Point(166, 188)
        Me.btnOfstOff.Name = "btnOfstOff"
        Me.btnOfstOff.Size = New System.Drawing.Size(62, 35)
        Me.btnOfstOff.TabIndex = 23
        Me.btnOfstOff.Text = "OFST"
        Me.btnOfstOff.UseVisualStyleBackColor = False
        '
        'btnCallOff
        '
        Me.btnCallOff.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCallOff.Location = New System.Drawing.Point(166, 60)
        Me.btnCallOff.Name = "btnCallOff"
        Me.btnCallOff.Size = New System.Drawing.Size(62, 35)
        Me.btnCallOff.TabIndex = 20
        Me.btnCallOff.Text = "CALL"
        Me.btnCallOff.UseVisualStyleBackColor = False
        '
        'btnMsgOff
        '
        Me.btnMsgOff.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMsgOff.Location = New System.Drawing.Point(166, 146)
        Me.btnMsgOff.Name = "btnMsgOff"
        Me.btnMsgOff.Size = New System.Drawing.Size(62, 35)
        Me.btnMsgOff.TabIndex = 22
        Me.btnMsgOff.Text = "MSG"
        Me.btnMsgOff.UseVisualStyleBackColor = False
        '
        'btnExecOff
        '
        Me.btnExecOff.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnExecOff.Location = New System.Drawing.Point(166, 19)
        Me.btnExecOff.Name = "btnExecOff"
        Me.btnExecOff.Size = New System.Drawing.Size(62, 35)
        Me.btnExecOff.TabIndex = 19
        Me.btnExecOff.Text = "EXEC"
        Me.btnExecOff.UseVisualStyleBackColor = False
        '
        'btnFailOff
        '
        Me.btnFailOff.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFailOff.Location = New System.Drawing.Point(166, 103)
        Me.btnFailOff.Name = "btnFailOff"
        Me.btnFailOff.Size = New System.Drawing.Size(62, 35)
        Me.btnFailOff.TabIndex = 21
        Me.btnFailOff.Text = "FAIL"
        Me.btnFailOff.UseVisualStyleBackColor = False
        '
        'txtBoxOfst
        '
        Me.txtBoxOfst.Location = New System.Drawing.Point(111, 195)
        Me.txtBoxOfst.Name = "txtBoxOfst"
        Me.txtBoxOfst.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxOfst.TabIndex = 18
        Me.txtBoxOfst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxMsg
        '
        Me.txtBoxMsg.Location = New System.Drawing.Point(111, 154)
        Me.txtBoxMsg.Name = "txtBoxMsg"
        Me.txtBoxMsg.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxMsg.TabIndex = 17
        Me.txtBoxMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxFail
        '
        Me.txtBoxFail.Location = New System.Drawing.Point(111, 113)
        Me.txtBoxFail.Name = "txtBoxFail"
        Me.txtBoxFail.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxFail.TabIndex = 16
        Me.txtBoxFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxCall
        '
        Me.txtBoxCall.Location = New System.Drawing.Point(111, 72)
        Me.txtBoxCall.Name = "txtBoxCall"
        Me.txtBoxCall.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxCall.TabIndex = 15
        Me.txtBoxCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxExec
        '
        Me.txtBoxExec.Location = New System.Drawing.Point(111, 31)
        Me.txtBoxExec.Name = "txtBoxExec"
        Me.txtBoxExec.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxExec.TabIndex = 14
        Me.txtBoxExec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOfstOn
        '
        Me.btnOfstOn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnOfstOn.Location = New System.Drawing.Point(34, 187)
        Me.btnOfstOn.Name = "btnOfstOn"
        Me.btnOfstOn.Size = New System.Drawing.Size(62, 35)
        Me.btnOfstOn.TabIndex = 13
        Me.btnOfstOn.Text = "OFST"
        Me.btnOfstOn.UseVisualStyleBackColor = False
        '
        'btnCallOn
        '
        Me.btnCallOn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCallOn.Location = New System.Drawing.Point(34, 64)
        Me.btnCallOn.Name = "btnCallOn"
        Me.btnCallOn.Size = New System.Drawing.Size(62, 35)
        Me.btnCallOn.TabIndex = 10
        Me.btnCallOn.Text = "CALL"
        Me.btnCallOn.UseVisualStyleBackColor = False
        '
        'btnMsgOn
        '
        Me.btnMsgOn.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMsgOn.Location = New System.Drawing.Point(34, 146)
        Me.btnMsgOn.Name = "btnMsgOn"
        Me.btnMsgOn.Size = New System.Drawing.Size(62, 35)
        Me.btnMsgOn.TabIndex = 12
        Me.btnMsgOn.Text = "MSG"
        Me.btnMsgOn.UseVisualStyleBackColor = False
        '
        'btnExecOn
        '
        Me.btnExecOn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnExecOn.Location = New System.Drawing.Point(34, 23)
        Me.btnExecOn.Name = "btnExecOn"
        Me.btnExecOn.Size = New System.Drawing.Size(62, 35)
        Me.btnExecOn.TabIndex = 9
        Me.btnExecOn.Text = "EXEC"
        Me.btnExecOn.UseVisualStyleBackColor = False
        '
        'btnFailOn
        '
        Me.btnFailOn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFailOn.Location = New System.Drawing.Point(34, 105)
        Me.btnFailOn.Name = "btnFailOn"
        Me.btnFailOn.Size = New System.Drawing.Size(62, 35)
        Me.btnFailOn.TabIndex = 11
        Me.btnFailOn.Text = "FAIL"
        Me.btnFailOn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLcdAuto)
        Me.GroupBox1.Controls.Add(Me.btnLcdMinus)
        Me.GroupBox1.Controls.Add(Me.btnLcdPlus)
        Me.GroupBox1.Controls.Add(Me.btnLcdMenu)
        Me.GroupBox1.Controls.Add(Me.btnLcdPower)
        Me.GroupBox1.Location = New System.Drawing.Point(318, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 234)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LCD Screen Buttons"
        '
        'btnLcdAuto
        '
        Me.btnLcdAuto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLcdAuto.Location = New System.Drawing.Point(30, 187)
        Me.btnLcdAuto.Name = "btnLcdAuto"
        Me.btnLcdAuto.Size = New System.Drawing.Size(62, 35)
        Me.btnLcdAuto.TabIndex = 8
        Me.btnLcdAuto.Text = "S/Auto"
        Me.btnLcdAuto.UseVisualStyleBackColor = False
        '
        'btnLcdMinus
        '
        Me.btnLcdMinus.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnLcdMinus.Location = New System.Drawing.Point(30, 146)
        Me.btnLcdMinus.Name = "btnLcdMinus"
        Me.btnLcdMinus.Size = New System.Drawing.Size(62, 35)
        Me.btnLcdMinus.TabIndex = 7
        Me.btnLcdMinus.Text = "-"
        Me.btnLcdMinus.UseVisualStyleBackColor = False
        '
        'btnLcdPlus
        '
        Me.btnLcdPlus.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLcdPlus.Location = New System.Drawing.Point(30, 105)
        Me.btnLcdPlus.Name = "btnLcdPlus"
        Me.btnLcdPlus.Size = New System.Drawing.Size(62, 35)
        Me.btnLcdPlus.TabIndex = 6
        Me.btnLcdPlus.Text = "+"
        Me.btnLcdPlus.UseVisualStyleBackColor = False
        '
        'btnLcdMenu
        '
        Me.btnLcdMenu.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLcdMenu.Location = New System.Drawing.Point(30, 64)
        Me.btnLcdMenu.Name = "btnLcdMenu"
        Me.btnLcdMenu.Size = New System.Drawing.Size(62, 35)
        Me.btnLcdMenu.TabIndex = 5
        Me.btnLcdMenu.Text = "Menu"
        Me.btnLcdMenu.UseVisualStyleBackColor = False
        '
        'btnLcdPower
        '
        Me.btnLcdPower.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLcdPower.Location = New System.Drawing.Point(30, 23)
        Me.btnLcdPower.Name = "btnLcdPower"
        Me.btnLcdPower.Size = New System.Drawing.Size(62, 35)
        Me.btnLcdPower.TabIndex = 4
        Me.btnLcdPower.Text = "Power"
        Me.btnLcdPower.UseVisualStyleBackColor = False
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM9"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button11.Location = New System.Drawing.Point(639, 386)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(62, 35)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "EXIT"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'formB737FMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 450)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "formB737FMC"
        Me.Text = "B773 Configurator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBoxOfst As TextBox
    Friend WithEvents txtBoxMsg As TextBox
    Friend WithEvents txtBoxFail As TextBox
    Friend WithEvents txtBoxCall As TextBox
    Friend WithEvents txtBoxExec As TextBox
    Friend WithEvents btnOfstOn As Button
    Friend WithEvents btnCallOn As Button
    Friend WithEvents btnMsgOn As Button
    Friend WithEvents btnExecOn As Button
    Friend WithEvents btnFailOn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLcdAuto As Button
    Friend WithEvents btnLcdMinus As Button
    Friend WithEvents btnLcdPlus As Button
    Friend WithEvents btnLcdMenu As Button
    Friend WithEvents btnLcdPower As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button11 As Button
    Friend WithEvents btnOfstOff As Button
    Friend WithEvents btnCallOff As Button
    Friend WithEvents btnMsgOff As Button
    Friend WithEvents btnExecOff As Button
    Friend WithEvents btnFailOff As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtAllLeds As TextBox
    Friend WithEvents Button2 As Button
End Class
