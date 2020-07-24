Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim S(5) As String
        Dim data(5, 2) As Single
        Dim i As Short
        Dim avg1, avg2, avg3 As Single
        Label1.Text &= "姓名" & Space(8) & "身高" & Space(5) & "體重" & Space(5) & "BMI" & vbNewLine & vbNewLine
        For i = 0 To 5
            S(i) = InputBox("請輸入姓名")
            data(i, 0) = InputBox("請輸入身高", S(i))
            data(i, 1) = InputBox("請輸入體重", S(i))
            data(i, 2) = data(i, 1) / ((data(i, 0) / 100) * (data(i, 0) / 100))
            avg1 = avg1 + data(i, 0)
            avg2 = avg2 + data(i, 1)
            avg3 = avg3 + data(i, 2)
            Label1.Text &= S(i) & Space(6) & data(i, 0) & Space(5) & data(i, 1) & Space(5) & data(i, 2) & vbNewLine
        Next
        avg1 = avg1 / 6
        avg2 = avg2 / 6
        avg3 = avg3 / 6
        Label1.Text &= vbNewLine & "平均" & Space(5) & avg1 & Space(3) & avg2 & Space(3) & avg3

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub
End Class
