Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Font = New Font("標楷體", 19)
        Label1.BackColor = Color.Aqua
        Label1.Text = "Visual Basic "

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Font = New Font("標楷體", 19)
        Label1.BackColor = Color.Coral
        Label1.Text = "基礎必修課"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = ""


    End Sub
End Class
