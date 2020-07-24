Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String
        str1 = IIf(Val(TextBox1.Text) < 300000, 0, IIf(Val(TextBox1.Text) >= 300000 And Val(TextBox1.Text) <= 600000,
        Val(TextBox1.Text) * 0.03, IIf(Val(TextBox1.Text) >= 600000 And Val(TextBox1.Text) <= 900000,
        Val(TextBox1.Text) * 0.06, IIf(Val(TextBox1.Text) >= 900000 And Val(TextBox1.Text) <= 1500000,
        Val(TextBox1.Text) * 0.12, IIf(Val(TextBox1.Text) >= 1500000 And Val(TextBox1.Text) <= 5000000,
        Val(TextBox1.Text) * 0.2, Val(TextBox1.Text) * 0.3)))))

        Label2.Text = "年所得" & Val(TextBox1.Text) & "元,應收所得稅" & str1 & "元"

    End Sub
End Class
