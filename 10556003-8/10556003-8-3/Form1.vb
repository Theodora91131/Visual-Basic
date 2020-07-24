Public Class Form1
    Dim data1(6) As Integer
    Dim pic(6) As PictureBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic(1) = PictureBox1
        pic(2) = PictureBox2
        pic(3) = PictureBox3
        pic(4) = PictureBox4
        pic(5) = PictureBox5
        pic(6) = PictureBox6
    End Sub
    Private Sub GetRnd(ByVal a As Short)
        Randomize()
        data1(a) = Int(Rnd() * 41 + 1) * 1
        For p = (a - 1) To 1 Step -1
            If data1(a) = data1(p) Then
                GetRnd(a)
            Else

            End If
        Next
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 6
            GetRnd(i)
            pic(i).Image = Image.FromFile(My.Computer.FileSystem.CurrentDirectory & "\" & data1(i) & ".gif")

        Next
    End Sub
End Class
