Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function gcd(x As Integer, y As Integer)
        Dim m As Integer = x Mod y
        If m = 0 Then
            Return y
        Else
            Return gcd(y, m)
        End If
    End Function
    Private Overloads Function lcm(x As Integer, y As Integer)
        Dim w As Integer
        w = gcd(x, y)
        lcm = x * y \ w
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        If x = 0 Then
            MsgBox("請輸入大於0的數", 16)
        ElseIf y = 0 Then
            MsgBox("請輸入大於0的數", 16)
        Else
            Dim max1 As Integer = Math.Max(x, y)
            Dim min1 As Integer = Math.Min(x, y)
            MsgBox("最大公因數(GCD)=" & gcd(max1, min1) & "最小公倍數(LCM)=" & lcm(x, y))
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
