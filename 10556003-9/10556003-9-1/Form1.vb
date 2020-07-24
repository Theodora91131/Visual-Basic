Public Class Form1
    Public x, y As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do While x = 0
            x = InputBox("輸入第一個非零數字", "鍵入數值",, )
        Loop
        Do While y = 0
            y = InputBox("輸入第二個非零數字", "鍵入數值",, )
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
