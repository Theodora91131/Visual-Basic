Public Class Form1
    Dim a As Boolean = False
    Dim dx, dy As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_mousedown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            a = True
            dx = e.X
            dy = e.Y
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub PictureBox1_mousemove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If a = True Then
            PictureBox1.Left += e.X - dx
            PictureBox1.Top += e.Y - dy
        End If
    End Sub
    Private Sub PictureBox1_mouseup(sender As Object, e As EventArgs) Handles PictureBox1.MouseUp
        a = False
    End Sub
    Private Sub PictureBox1_zoom(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If e.Delta > 0 Then
            PictureBox1.Width += 10
            PictureBox1.Height += 10
        Else
            PictureBox1.Width -= 10
            PictureBox1.Height -= 10
        End If
    End Sub
End Class
