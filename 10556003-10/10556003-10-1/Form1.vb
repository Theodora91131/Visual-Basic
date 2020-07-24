Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_keydown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim move = 10
        Select Case e.KeyCode
            Case Keys.Up
                TextBox1.Top -= move
            Case Keys.Down
                TextBox1.Top += move
            Case Keys.Left
                TextBox1.Left -= move
            Case Keys.Right
                TextBox1.Left += move
        End Select
    End Sub
End Class
