Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TrackBar1.Maximum = 255
        Label4.BackColor = Color.FromArgb(255, 0, 0)
        Label4.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        TrackBar2.Maximum = 255
        Label4.BackColor = Color.FromArgb(0, 255, 0)
        Label4.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        TrackBar3.Maximum = 255
        Label4.BackColor = Color.FromArgb(0, 0, 255)
        Label4.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
