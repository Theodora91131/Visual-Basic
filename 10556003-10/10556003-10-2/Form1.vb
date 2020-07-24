Public Class Form1
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            PictureBox1.Image = ImageList1.Images(1)
        ElseIf e.Button = MouseButtons.Right Then
            PictureBox1.Image = ImageList1.Images(2)
        ElseIf e.Button = MouseButtons.Middle Then
            PictureBox1.Image = ImageList1.Images(2)
        Else
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = ImageList1.Images(0)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
