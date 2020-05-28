Public Class formB737FMC
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLcdPower.Click
        SerialPort1.Write("#")
        SerialPort1.Write("P")
    End Sub

    Private Sub btnExecOn_Click(sender As Object, e As EventArgs) Handles btnExecOn.Click
        SerialPort1.Write("<")
        SerialPort1.Write("E")
        txtBoxExec.Text = "ON"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnFailOn.Click
        SerialPort1.Write("<")
        SerialPort1.Write("F")
        txtBoxFail.Text = "ON"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOfstOn.Click
        SerialPort1.Write("<")
        SerialPort1.Write("O")
        txtBoxOfst.Text = "ON"
    End Sub

    Private Sub btnExecOff_Click(sender As Object, e As EventArgs) Handles btnExecOff.Click
        SerialPort1.Write(">")
        SerialPort1.Write("E")
        txtBoxExec.Text = "OFF"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnCallOff.Click
        SerialPort1.Write(">")
        SerialPort1.Write("C")
        txtBoxCall.Text = "OFF"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnFailOff.Click
        SerialPort1.Write(">")
        SerialPort1.Write("F")
        txtBoxFail.Text = "OFF"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnMsgOff.Click
        SerialPort1.Write(">")
        SerialPort1.Write("M")
        txtBoxMsg.Text = "OFF"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnOfstOff.Click
        SerialPort1.Write(">")
        SerialPort1.Write("O")
        txtBoxOfst.Text = "OFF"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLcdMenu.Click
        SerialPort1.Write("#")
        SerialPort1.Write("M")
    End Sub

    Private Sub btnCallOn_Click(sender As Object, e As EventArgs) Handles btnCallOn.Click
        SerialPort1.Write("<")
        SerialPort1.Write("C")
        txtBoxCall.Text = "ON"
    End Sub

    Private Sub btnMsgOn_Click(sender As Object, e As EventArgs) Handles btnMsgOn.Click
        SerialPort1.Write("<")
        SerialPort1.Write("M")
        txtBoxMsg.Text = "ON"
    End Sub

    Private Sub btnLcdPlus_Click(sender As Object, e As EventArgs) Handles btnLcdPlus.Click
        SerialPort1.Write("#")
        SerialPort1.Write("+")
    End Sub

    Private Sub btnLcdMinus_Click(sender As Object, e As EventArgs) Handles btnLcdMinus.Click
        SerialPort1.Write("#")
        SerialPort1.Write("-")
    End Sub

    Private Sub btnLcdAuto_Click(sender As Object, e As EventArgs) Handles btnLcdAuto.Click
        SerialPort1.Write("#")
        SerialPort1.Write("S")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
