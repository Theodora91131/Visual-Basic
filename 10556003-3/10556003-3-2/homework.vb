Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str1 As String
        str1 = "一個成語"
        str1 = (InputBox("請輸入一個成語"))
        MsgBox("" & str1)
        Label1.Text = str1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.BackColor = Color.Black

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.ForeColor = Color.Red

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Font = New Font("標楷體", 30, FontStyle.Bold)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.BackColor = Color.White

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.ForeColor = Color.Blue

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Font = New Font("標楷體", 30, FontStyle.Italic)

    End Sub
End Class
