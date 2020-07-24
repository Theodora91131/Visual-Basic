Public Class Form1
    Dim i As Short
    Dim j As Short
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("請輸入數值!", 16)
            Application.Exit()
        ElseIf IsNumeric(TextBox2.Text) = False Then
            MsgBox("請輸入數值!", 16)
            Application.Exit()
        ElseIf RadioButton1.Checked = True Then
            Label2.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
                Label1.Text = "+"
            ElseIf RadioButton2.Checked = True Then
                Label2.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
                Label1.Text = "-"
            ElseIf RadioButton3.Checked = True Then
                Label2.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
                Label1.Text = "*"
            ElseIf RadioButton4.Checked = True Then
                Label2.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
                Label1.Text = "/"
            ElseIf RadioButton5.Checked = True Then
                If Val(TextBox1.Text) > Val(TextBox2.Text) Then
                MsgBox("連加數字由小到大!")
            End If
                For i = Val(TextBox1.Text) To Val(TextBox2.Text) Step 1
                    j = j + i
                Next
                Label1.Text = "+...+"
            Label2.Text = j
        End If

    End Sub
End Class
