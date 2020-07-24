Public Class Form1
    Dim filename1, filename2 As String
    Dim filenum1 As Integer
    Dim str1, str2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        OpenFileDialog1.Filter = "文字檔案(*.txt)|*.txt"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.DefaultExt = "txt"
        If OpenFileDialog1.ShowDialog() = Me.DialogResult.OK Then
            filename1 = OpenFileDialog1.FileName
            filenum1 = FreeFile()
            TextBox1.Text = filename1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("未輸入檔案路徑",, "提示")
        Else
            str2 = ""
            TextBox2.Clear()
            FileOpen(filenum1, filename1, OpenMode.Input)
            Do While Not EOF(filenum1)
                Input(filenum1, str1)
                str2 = str2 & str1 & vbNewLine
            Loop
            FileClose(filenum1)
            TextBox2.Text = str2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("未輸入檔案路徑",, "提示")
        Else
            TextBox2.Clear()
            SaveFileDialog1.Filter = "文字檔案(*.txt)|*.txt"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True
            SaveFileDialog1.DefaultExt = "txt"
            If SaveFileDialog1.ShowDialog() = Me.DialogResult.OK Then
                filename2 = SaveFileDialog1.FileName
                FileCopy(filename1, filename2)
                If TextBox1.Text = "" Then
                    MsgBox("未輸入檔案路徑",, "提示")
                End If
                TextBox1.Text = ""
                MsgBox("儲存成功....",, "提示")
                filename1 = ""
                filename2 = ""
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class
