Public Class Form1
    Dim b As Object
    Dim a As Integer
    Dim data1 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.SelectionBullet = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.SelectionBullet = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog1.Filter = "文書檔(*.txt)|*.txt|所有檔案(*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.DefaultExt = ".txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            b = OpenFileDialog1.FileName
            a = FreeFile()
            FileOpen(a, b, OpenMode.Input)
            RichTextBox1.Text = ""
            Do While Not EOF(a)
                Input(a, data1)
                RichTextBox1.Text = RichTextBox1.Text + data1
            Loop
            Me.Text = b & "記事本"
            FileClose(a)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub
End Class
