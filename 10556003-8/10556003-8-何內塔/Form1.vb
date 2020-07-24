Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim m As Integer
        Dim s As String
        m = 0
        Do While m <= 0
            m = Val(TextBox1.Text)
            If m <= 0 Then
                MsgBox("輸入錯誤")
                Exit Do
            Else
                s = hanoi(m, "A", "C", "B")
                MsgBox(s)
            End If
        Loop
    End Sub

    Function hanoi(ByVal n As Integer, ByVal start As String, ByVal theend As String, ByVal temp As String)
        Dim s, s1, s2, s3 As String
        If n = 1 Then
            s = "第" & n & "盤子從" & start & " ==> " & theend & vbNewLine
        Else
            s1 = hanoi(n - 1, start, temp, theend)
            s2 = "第" & n & "盤子從" & start & " ==> " & theend & vbNewLine
            s3 = hanoi(n - 1, temp, theend, start)
            s = s1 & s2 & s3
        End If
        Return s
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
