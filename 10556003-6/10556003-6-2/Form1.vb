Public Class Form1

    Dim i As Short
    Dim j As Short
    Dim S(4) As String
    Dim str1, str2 As String
    Dim t() = {"小胖", "小玲", "小琥", "張宇", "Roger"}
    Dim data(4, 5) As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str1 = "姓名" & Space(4)
        For j = 0 To 4
            str1 &= t(j) & Space(5)
        Next
        str1 &= "總分" & vbCrLf
        For i = 0 To 4
            S(i) = InputBox("請輸入第" & i + 1 & "位參賽者姓名:")
            str1 &= S(i)
            For j = 0 To 4
                data(i, j) = InputBox("輸入" & t(j) & "老師給分:")
                data(i, 5) = data(i, 5) + data(i, j)
                str1 &= Space(7) & data(i, j)
            Next
            str1 &= Space(7) & data(i, 5) & vbCrLf
        Next
        Label1.Text = str1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = str1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        str2 = "姓名" & Space(4)
        For j = 0 To 4
            str2 &= t(j) & Space(7)
        Next
        str2 &= "總分" & vbCrLf
        For i = 0 To 4
            If data(i, 5) >= 16 Then
                str2 &= S(i)
                For j = 0 To 4
                    str2 &= Space(7) & data(i, j)
                Next
                str2 &= Space(7) & data(i, 5) & vbCrLf
            End If
        Next
        Label1.Text = str2
    End Sub
End Class
