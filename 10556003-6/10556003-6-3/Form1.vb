Public Class Form1
    Dim test() As String = {"青菜", "山羊", "野狼", "農夫"}
    Dim test2() As String = {"青菜", "山羊"}
    Dim test3() As String = {"山羊", "野狼"}
    Dim test5() As String = {"野狼", "青菜"}


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(test)
        Button3.Enabled = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Items.Count = 2 Then
            For i = 0 To 1
                If ListBox1.Items(i) = test2(0) Then
                    For l = 0 To 1
                        If ListBox1.Items(l) = test2(1) Then
                            MsgBox("山羊吃掉青菜")
                            ListBox1.Items.Clear()
                            ListBox2.Items.Clear()
                            ListBox1.Items.AddRange(test)
                            Button3.Enabled = False
                            Button2.Enabled = True
                        End If
                    Next

                ElseIf ListBox1.Items(i) = test3(0) Then
                    For k = 0 To 1
                        If ListBox1.Items(k) = test3(1) Then
                            MsgBox("野狼吃掉山羊")
                            ListBox1.Items.Clear()
                            ListBox2.Items.Clear()
                            ListBox1.Items.AddRange(test)
                            Button3.Enabled = False
                            Button2.Enabled = True
                        End If
                    Next
                Else
                End If
                    Next
                End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.Items.Count = 4 Then
            MsgBox("任務完成！！！")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String
        str1 = "1.農夫一次只能帶一樣或空手過河。" & vbNewLine & "2.農夫不在時山羊會吃青菜，野狼會吃山羊。" & vbNewLine & "3.三件都帶過河就過關。"
        MsgBox(str1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Enabled = True
        Button2.Enabled = False
        If ListBox1.SelectedItem = test(3) Then
            ListBox2.Items.Add(test(3))
            ListBox1.Items.Remove(test(3))
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox2.Items.Add(test(3))
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox1.Items.Remove(test(3))
        End If
    End Sub

    Private Sub Button3_Enter(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button2.Enabled = True
        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(test)
        Button3.Enabled = False
        Button2.Enabled = True
    End Sub
End Class
