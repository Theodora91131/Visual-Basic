Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Y, R As Short
        Dim str2 As String = "       "
        Me.Font = New Font("細明體", 9)
        For Y = 6 To 1 Step (-1)
            For R = 6 To Y Step (-1)
                str2 &= "*"
            Next
            str2 &= vbCrLf & Space(Y)
        Next
        Label1.Text &= str2
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
