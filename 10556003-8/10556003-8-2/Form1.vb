Public Class Form1
    Dim n As Long
    Dim data1 As Long
    Dim k As Long
    Dim sum As Long
    Dim data2 As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sum = 1
        n = InputBox("請輸入求階層的數?(1~12)")
        k = n
        For data1 = (k - 1) To 1 Step -1
            data2 = (n - data1)
            sum = data2 * sum
        Next
        sum = sum * n
        MsgBox(n & "!=" & sum)
    End Sub
End Class
