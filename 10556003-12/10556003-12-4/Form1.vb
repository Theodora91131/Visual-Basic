﻿Public Class Form1
    Private Structure userrec
        Dim empno As String
        Dim name As String
        Dim title As String
        Dim dep As String
        Dim email As String
        Dim address As String
        Dim comn As String
        Dim sex As String
        Dim birthday As String
        Dim tel As String
    End Structure
    Dim data(100), data1, rec As userrec
    Dim a As String
    Dim c As String
    Dim file_no1, file_no2, n, i, k As Integer
    Dim v As String
    Dim j As String
    Dim filetoprint
    Dim printfont As System.Drawing.Font
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        data1.empno = TextBox1.Text
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        data1.address = TextBox7.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        data1.title = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        data1.dep = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        data1.birthday = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        data1.name = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        data1.tel = TextBox6.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        data1.email = TextBox8.Text
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        data1.comn = TextBox9.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "male" Then
            data1.sex = "male"
        Else
            data1.sex = "female"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a = "" Then
            Call p(sender, e)
        End If
        file_no1 = FreeFile()
        FileOpen(file_no1, a, OpenMode.Random, , , Len(rec))
        FilePut(file_no1, data1, 1)
        FileClose(file_no1)
        MsgBox("存檔成功")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox1.Text = ""
    End Sub

    Public Sub p(sender As Object, e As EventArgs)
        SaveFileDialog1.Filter = "文書檔(*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            a = SaveFileDialog1.FileName
            file_no1 = FreeFile()
            FileOpen(file_no1, a, OpenMode.Random)
            FilePut(file_no1, data1)
            FileClose(file_no1)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If a = "" Then
            MsgBox("新增失敗")
        ElseIf file_no1 = FreeFile() Then
            FileOpen(file_no1, a, OpenMode.Random, , , Len(rec))
            n = LOF(file_no1) \ Len(rec) + 1
            For i = 1 To n
                FileGet(file_no1, data(i))
            Next i
            FileClose(file_no1)
            file_no2 = FreeFile()
            FileOpen(file_no2, a, OpenMode.Random, , , Len(rec))
            For i = 1 To n
                FilePut(file_no2, data(i), i)
            Next i
            FilePut(file_no2, data1, n + 1)
            FileClose(file_no2)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            ComboBox1.Text = ""
            MsgBox("新增成功")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        v = InputBox("鍵入欲刪除之員工代號")
        c = Application.StartupPath & "\..\temp.txt"
        file_no1 = FreeFile()
        FileOpen(file_no1, a, OpenMode.Random, , , Len(rec))
        n = LOF(file_no1) \ Len(rec) + 1
        For i = 1 To n
            FileGet(file_no1, data(i))
        Next i
        FileClose(file_no1)
        Kill(a)
        file_no2 = FreeFile()
        FileOpen(file_no2, c, OpenMode.Random, , , Len(rec))
        k = 1
        For i = 1 To n
            If v = data(i).empno Then
                MsgBox("這筆記錄將被刪除")
            Else
                FilePut(file_no2, data(i), k)
                k = k + 1
            End If
        Next i
        FileClose(file_no2)
        Rename(c, a)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim key As Short
        j = InputBox("請輸入員工代號")
        file_no1 = FreeFile()
        FileOpen(file_no1, a, OpenMode.Random,,, Len(rec))
        n = LOF(file_no1) \ Len(rec) + 1
        For i = 1 To n
            FileGet(file_no1, data(i))
        Next i
        FileClose(file_no1)
        key = 0
        For i = 1 To n
            If j = data(i).empno Then
                key = i
            End If
        Next
        If key <> 0 Then
            TextBox1.Text = data(key).empno
            TextBox2.Text = data(key).title
            TextBox3.Text = data(key).dep
            TextBox4.Text = data(key).birthday
            TextBox5.Text = data(key).name
            TextBox6.Text = data(key).tel
            TextBox7.Text = data(key).address
            TextBox8.Text = data(key).email
            ComboBox1.Text = data(key).sex
            TextBox9.Text = data(key).comn
        Else
            MsgBox("沒有這筆資料")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'PrintDocument1.DocumentName = OpenFileDialog1.FileName
        'PrintDocument1.Print()
        'End If
        'file_no1 = FreeFile()
        'FileOpen(file_no1, a, OpenMode.Random,,, Len(rec))
        'n = LOF(file_no1) \ Len(rec) + 1
        'For i = 1 To n
        'FileGet(file_no1, data(i))
        'Next i
        'FileClose(file_no1)
        Dim PrintPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        'fileToPrint = New System.IO.StreamReader(PrintPath & OpenFileDialog1.FileName)
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            fileToPrint = New System.IO.StreamReader(OpenFileDialog1.FileName)
        End If
        printFont = New System.Drawing.Font("Arial", 10)
        PrintDocument1.Print()
        fileToPrint.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim line As String = Nothing
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        While count < linesPerPage
            line = fileToPrint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * printFont.GetHeight(e.Graphics)
            e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            count += 1
        End While
        If Not (line Is Nothing) Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
End Class
