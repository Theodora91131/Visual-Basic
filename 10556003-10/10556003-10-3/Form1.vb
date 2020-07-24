Public Class Form1
    Dim DATA1, DATA2, DATA3, DATA4, DATA5, DATA6 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DATA1 = Val(2400) * Val(TextBox1.Text)
            Label12.Text = Val(Label12.Text) + DATA1 & "元"
        ElseIf CheckBox1.Checked = False Then
            Label12.Text = Val(Label12.Text) - DATA1 & "元"
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CheckBox1.Checked = True

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            DATA2 = Val(1600) * Val(TextBox2.Text)
            Label12.Text = Val(Label12.Text) + DATA2 & "元"
        ElseIf CheckBox2.Checked = False Then
            Label12.Text = Val(Label12.Text) - DATA2 & "元"
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        CheckBox2.Checked = False
        CheckBox2.Checked = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            DATA3 = Val(3000) * Val(TextBox3.Text)
            Label12.Text = Val(Label12.Text) + DATA3 & "元"
        ElseIf CheckBox3.Checked = False Then
            Label12.Text = Val(Label12.Text) - DATA3 & "元"
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        CheckBox3.Checked = True
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            DATA4 = Val(2400) * Val(TextBox4.Text)
            Label12.Text = Val(Label12.Text) + DATA4 & "元"
        ElseIf CheckBox4.Checked = False Then
            Label12.Text = Val(Label12.Text) - DATA4 & "元"
            TextBox4.Text = ""
        End If
                End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        CheckBox4.Checked = True
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            DATA5 = Val(3500) * Val(TextBox5.Text)
            Label12.Text = Val(Label12.Text) + DATA5 & "元"
        ElseIf CheckBox5.Checked = False Then
            Label12.Text = Val(Label12.Text) - DATA5 & "元"
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        CheckBox5.Checked = True
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
    Private Sub CheckBox1_MouseHover(sender As Object, e As EventArgs) Handles CheckBox1.MouseHover
        Label1.Text = "頂級套房，蜜月專屬"

    End Sub
    Private Sub CheckBox1_Mouseleave(sender As Object, e As EventArgs) Handles CheckBox1.MouseLeave
        Label1.Text = "歡迎光臨VB民宿"
    End Sub
    Private Sub CheckBox2_MouseHover(sender As Object, e As EventArgs) Handles CheckBox2.MouseHover
        Label1.Text = "普通套房，普通衛浴,電視"
    End Sub
    Private Sub CheckBox2_Mouseleave(sender As Object, e As EventArgs) Handles CheckBox2.MouseLeave
        Label1.Text = "歡迎光臨VB民宿"
    End Sub
    Private Sub CheckBox3_Mouseleave(sender As Object, e As EventArgs) Handles CheckBox3.MouseLeave
        Label1.Text = "歡迎光臨VB民宿"
    End Sub
    Private Sub CheckBox3_MouseHover(sender As Object, e As EventArgs) Handles CheckBox3.MouseHover
        Label1.Text = "小木屋，有客廳,按摩衛浴,SPA"
    End Sub
    Private Sub CheckBox4_MouseHover(sender As Object, e As EventArgs) Handles CheckBox4.MouseHover
        Label1.Text = "普通套房，普通衛浴,電視"
    End Sub
    Private Sub CheckBox4_Mouseleave(sender As Object, e As EventArgs) Handles CheckBox4.MouseLeave
        Label1.Text = "歡迎光臨VB民宿"
    End Sub
    Private Sub CheckBox5_MouseHover(sender As Object, e As EventArgs) Handles CheckBox5.MouseHover
        Label1.Text = "普通套房，普通衛浴,電視"
    End Sub
    Private Sub CheckBox5_Mouseleave(sender As Object, e As EventArgs) Handles CheckBox5.MouseLeave
        Label1.Text = "歡迎光臨VB民宿"
    End Sub
End Class



