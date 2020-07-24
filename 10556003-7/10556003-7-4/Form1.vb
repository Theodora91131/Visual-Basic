Public Class Form1
    Dim img() As String = {"冬.jpg", "夏.jpg", "春.jpg", "秋.jpg"}
    Dim data1 As String
    Dim data2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        data1 = MonthCalendar1.SelectionStart
        data2 = Month(data1)
        If data2 = 1 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\冬.jpg")
        ElseIf data2 = 2 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\冬.jpg")
        ElseIf data2 = 12 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\冬.jpg")
        ElseIf data2 = 3 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\春.jpg")
        ElseIf data2 = 4 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\春.jpg")
        ElseIf data2 = 5 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\春.jpg")
        ElseIf data2 = 6 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\夏.jpg")
        ElseIf data2 = 7 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\夏.jpg")
        ElseIf data2 = 8 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\夏.jpg")
        ElseIf data2 = 9 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\秋.jpg")
        ElseIf data2 = 10 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\秋.jpg")
        ElseIf data2 = 11 Then
            PictureBox1.Image = Image.FromFile("C:\Users\廖怡涵\Desktop\vb\ch07\images\秋.jpg")
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
