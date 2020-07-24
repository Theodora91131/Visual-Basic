Public Class Form1
    Private Structure UserRec
        Dim password As String
        Dim priv As String
        Dim sex As String
        Dim email As String
    End Structure
    Dim UserDict As New Dictionary(Of String, UserRec)
    Dim name As String
    Dim data As UserRec
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserDict.ContainsKey(TextBox1.Text) Then
            UserDict.TryGetValue(TextBox1.Text, data)
            If TextBox2.Text = data.password Then
                ComboBox2.SelectedItem = data.priv
                TextBox8.Text = TextBox1.Text
                TextBox9.Text = data.password
                Label14.Text = data.email
                If data.sex = 1 Then
                    RadioButton3.Checked = True
                Else
                    RadioButton3.Checked = False
                End If
                If data.sex = 2 Then
                    RadioButton4.Checked = True
                Else
                    RadioButton4.Checked = False
                End If
                TabControl1.SelectTab(TabPage3)
            Else
                MsgBox("密碼錯誤!")
            End If
        Else
            MsgBox("使用着 " & TextBox1.Text & "不存在!請新增使用着資料")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        data.priv = ComboBox1.SelectedItem
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        name = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        data.password = TextBox4.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox4.Text = "" Or TextBox6.Text = "" Or name = "" Then
            MsgBox("資料不齊全!")
        Else
            If UserDict.ContainsKey(name) Then
                MsgBox("使用着" & name & "已存在")
            Else
                If TextBox4.Text = TextBox6.Text Then
                    UserDict.Add(name, data)
                    MsgBox("新增完成,請重新登入")
                    TabControl1.SelectTab(TabPage1)
                Else
                    MsgBox("密碼不一致")
                End If
            End If
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        data.email = TextBox7.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            data.sex = "2"
        Else
            data.sex = ""
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            data.sex = "1"
        Else
            data.sex = ""
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If UserDict.ContainsKey(name) Then
            MsgBox("使用着 " & name & "已存在")
        Else
            MsgBox("使用着 " & name & "不存在!可以繼續輸入資料")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
End Class
