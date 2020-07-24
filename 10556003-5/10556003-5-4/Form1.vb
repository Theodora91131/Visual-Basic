Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(TextBox1.Text) > Val(TextBox2.Text)) Then
            Label4.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
            TextBox3.Text = Val(Label4.Text) \ Val(1000) & "張"
            TextBox6.Text = (Val(Label4.Text) - Val(TextBox3.Text) * 1000) \ Val(500) & "張"
            TextBox5.Text = (Val(Label4.Text) - Val(TextBox3.Text) * 1000 - Val(TextBox6.Text) * 500) \ Val(100) & "張"
            TextBox4.Text = (Val(Label4.Text) - Val(TextBox3.Text) * 1000 - Val(TextBox6.Text) * 500 - Val(TextBox5.Text) * 100) \ Val(50) & "張"
            TextBox8.Text = (Val(Label4.Text) - Val(TextBox3.Text) * 1000 - Val(TextBox6.Text) * 500 - Val(TextBox5.Text) * 100 - Val(TextBox4.Text) * 50) \ Val(10) & "張"
            TextBox7.Text = (Val(Label4.Text) - Val(TextBox3.Text) * 1000 - Val(TextBox6.Text) * 500 - Val(TextBox5.Text) * 100 - Val(TextBox4.Text) * 50 - Val(TextBox8.Text) * 10) \ Val(5) & "張"
            TextBox9.Text = (Val(Label4.Text) - Val(TextBox3.Text) * 1000 - Val(TextBox6.Text) * 500 - Val(TextBox5.Text) * 100 - Val(TextBox4.Text) * 50 - Val(TextBox8.Text) * 10 - Val(TextBox7.Text) * 5) \ Val(1) & "張"
        ElseIf MsgBox("收現金額不足!請注意!!", 48) Then
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class
