Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function A(ByVal m As String, ByVal n As String) As String
        Dim z As String
        If Val(m) = 0 Then
            z = Val(n) + 1
        ElseIf Val(n) = 0 And Val(m) > 0 Then
            z = A(Val(m) - 1, 1)
        Else
            z = A(Val(m) - 1, A(Val(m), Val(n) - 1))
        End If
        Return z
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m, n As Integer
        m = -1
        n = -1
        Do While m < 0 Or n < 0
            m = Val(TextBox1.Text)
            n = Val(TextBox2.Text)
            If m < 0 Or n < 0 Then
                MsgBox("輸入錯誤")
                Exit Do
            Else
                Label2.Text = A(m, n) & vbCrLf
            End If
        Loop
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
