Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Font = New Font("細明體", 8)

        Dim i, J As Integer
        For J = 1 To 9 Step (3)
            For i = 1 To 9
                Label1.Text &= vbNewLine &
                J & "*" & i & "=" & J * i & Space(4) &
                    IIf((J * i) <= 10, Space(5), Space(4)) &
               J + 1 & "*" & i & "=" & (J + 1) * i & Space(3) &
                      IIf((J + 1) * i >= 10, Space(3), Space(4)) &
               J + 2 & "*" & i & "=" & (J + 2) * i & Space(1) &
                 IIf((J + 2) * i >= 10, Space(3), Space(4))
            Next
            Label1.Text &= vbNewLine
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
