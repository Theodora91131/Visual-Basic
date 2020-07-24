Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "20"
        TextBox1.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim WHATDAY As Integer
        WHATDAY = DateTimePicker1.Value.DayOfWeek
        If WHATDAY = 1 Then
            MsgBox("週一不開館")
        ElseIf WHATDAY = 0 And RadioButton2.Checked = True Then
            MsgBox("週日不售二日券")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
        Else
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            TextBox1.Enabled = False
        ElseIf CheckBox2.Checked = True Then
            TextBox1.Enabled = True

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            MsgBox("請輸入數字",, "人數錯誤")
        ElseIf IsNumeric(TextBox1.Text) = False Then
            MsgBox("請輸入數字",, "人數錯誤")
        ElseIf Val(TextBox1.Text) < 20 Then
            MsgBox("須至少20人,才能購買團體票",, "人數錯誤")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Label6.Text = Val(100)
            Label6.BackColor = Color.AliceBlue
        ElseIf RadioButton2.Checked = True Then
            Label6.Text = Val(180)
            Label6.BackColor = Color.AliceBlue
        End If
        If RadioButton3.Checked = True Then
            Label6.Text = Label6.Text * Val(1)
            Label6.BackColor = Color.AliceBlue
        ElseIf RadioButton4.Checked = True Then
            Label6.Text = Label6.Text * Val(2)
            Label6.BackColor = Color.AliceBlue
        ElseIf RadioButton5.Checked = True Then
            Label6.Text = Label6.Text * Val(3)
            Label6.BackColor = Color.AliceBlue
        ElseIf RadioButton6.Checked = True Then
            Label6.Text = Label6.Text * Val(4)
            Label6.BackColor = Color.AliceBlue
        End If
        If CheckBox3.Checked = True And CheckBox4.Checked = True Then
            Label6.Text = Label6.Text + Val(50) + Val(50)
            Label6.BackColor = Color.AliceBlue
        ElseIf CheckBox4.Checked = True Then
            Label6.Text = Label6.Text + Val(50)
            Label6.BackColor = Color.AliceBlue
        ElseIf CheckBox3.Checked = True Then
            Label6.Text = Label6.Text + Val(50)
            Label6.BackColor = Color.AliceBlue
        End If
        If CheckBox2.Checked = True Then
            Label6.Text = Label6.Text * Val(TextBox1.Text) * 0.8
            Label6.BackColor = Color.AliceBlue
        End If
        Label6.Text = "應付金額:NT$" & Label6.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        Label6.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim WHATDAY As Integer
        WHATDAY = DateTimePicker1.Value.DayOfWeek
        If WHATDAY = 1 Then
            MsgBox("週一不開館")
        ElseIf WHATDAY = 0 And RadioButton2.Checked = True Then
            MsgBox("週日不售二日券")
        End If
        DateTimePicker1.MinDate = Today
    End Sub
End Class
