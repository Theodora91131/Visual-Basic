Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = Space(3) & "好友通訊錄" & Space(3) & Format(Now, "G") & vbCrLf & vbCrLf
        TextBox1.Text &= "姓名" & vbTab & "生日" & vbTab & "電話" & vbTab & vbCrLf & vbNewLine
        TextBox1.Text &= "張三丰" & vbTab & Format(#3/17/1991#, "yy-MM-dd") & vbTab & Space(1) & "0900123456" & vbNewLine
        TextBox1.Text &= "喬峰" & vbTab & Format(#8/1/1995#, "yy-MM-dd") & vbTab & Space(1) & "02-12345678" & vbNewLine
        TextBox1.Text &= "令狐沖" & vbTab & Format(#8/1/1995#, "yy-MM-dd") & vbTab & Space(1) & "04-12345678" & vbNewLine


    End Sub


End Class
