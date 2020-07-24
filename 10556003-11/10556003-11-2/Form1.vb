Public Class Form1
    Dim a As Short
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub 第一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第一張ToolStripMenuItem.Click
        a = 0
        PictureBox1.Image = ImageList1.Images(a)
    End Sub

    Private Sub 上一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上一張ToolStripMenuItem.Click
        If a <= 0 Then
            a = 0
        Else
            a = a - 1
        End If
        PictureBox1.Image = ImageList1.Images(a)
    End Sub

    Private Sub 下一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 下一張ToolStripMenuItem.Click
        If a >= 3 Then
            a = 3
        Else
            a = a + 1
        End If
        PictureBox1.Image = ImageList1.Images(a)
    End Sub

    Private Sub 最後一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 最後一張ToolStripMenuItem.Click
        a = 3
        PictureBox1.Image = ImageList1.Images(a)
    End Sub
End Class
