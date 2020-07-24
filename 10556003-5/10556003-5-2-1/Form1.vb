Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str1 As String = ""
        Dim I, J As Short
        For I = 1 To 6
            For J = I To 6
                str1 &= "*" & Space(3)
            Next
            str1 &= vbNewLine
        Next
        MsgBox(str1)
    End Sub

End Class
