Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str3 As String = ""
        Dim A, B As Short
        For A = 1 To 3
            For B = 1 To A
                str3 &= "*" & Space(2)
            Next
            str3 &= vbNewLine
        Next
        Dim H, T As Short
        For H = 1 To 4
            For T = H To 4
                str3 &= "*" & Space(2)
            Next
            str3 &= vbNewLine
        Next
        MsgBox(str3)










    End Sub
End Class
