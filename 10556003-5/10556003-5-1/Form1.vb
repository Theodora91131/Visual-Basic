Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim A, B, C As Short
        Dim str1 As String
        Do Until A > 7 And A < 100
            A = Val(InputBox("請輸入大於7小於100的正整數"))
        Loop
        str1 = "1到" & A & "被7整除的數" & vbCrLf
        For B = 1 To A
            If 0 = B Mod 7 Then
                str1 &= B & vbCrLf
                C += B
            End If
        Next
        str1 &= "-----------" & vbCrLf
        str1 &= "總和等於" & C
        MsgBox(str1)
    End Sub
End Class
