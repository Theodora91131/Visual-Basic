Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = ImageList1.Images(p(i))
        PictureBox2.Image = ImageList2.Images(p(i))
        PictureBox3.Image = ImageList3.Images(p(i))
        PictureBox4.Image = ImageList4.Images(p(i))
    End Sub
    Function p(ByRef i As Short)
        Randomize()
        i = Int(Rnd() * 9 + 0) * 1
        Return i
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
