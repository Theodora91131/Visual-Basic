Public Class Form1
    Dim data1() As Object = {"紅豆", "綠豆", "薏仁", "珍珠", "芋頭"}
    Dim data2() As Object = {"西瓜", "香蕉", "草莓", "芒果"}
    Dim data5() As Object = {"", "", "", "", ""}
    Dim data3 As Short
    Dim data4 As Short
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = 0
        TextBox1.Text = 1
    End Sub

    Private Sub 功能選單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 功能選單ToolStripMenuItem.Click

    End Sub

    Private Sub 冰品選擇ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 冰品選擇ToolStripMenuItem.Click

    End Sub

    Private Sub 重選ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重選ToolStripMenuItem.Click
        Label2.Text = 0
        TextBox1.Text = 1
        TextBox2.Text = data3
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(data5)
    End Sub

    Private Sub 八堡冰ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 八堡冰ToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(data1)
        data3 = 25
        TextBox2.Text = 25
        Label5.Text = "八堡冰"
        data5 = data1
    End Sub

    Private Sub 水果冰ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 水果冰ToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(data2)
        data3 = 35
        TextBox2.Text = 35
        Label5.Text = "水果冰"
        data5 = data2
    End Sub

    Private Sub 結束ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 結束ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndices.Count = 0 Then
            MsgBox("請選擇加入項目!")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)

            If ListBox2.Items.Count = 1 Then
                Label2.Text = Val(Label2.Text) + data3
            Else
                data4 = 5
                Label2.Text = Val(Label2.Text) + data4
            End If
        End If
        Call P()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedIndices.Count = 0 Then
            MsgBox("請選擇加入項目!")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            If ListBox2.Items.Count = 0 Then
                Label2.Text = Val(Label2.Text) - data3
            Else
                data4 = 5
                Label2.Text = Val(Label2.Text) - data4
            End If
        End If
        Call P()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Val(Label2.Text) * Val(TextBox1.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = Val(TextBox2.Text).ToString("#,##0")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Public Sub P()
        TextBox2.Text = Val(Label2.Text) * Val(TextBox1.Text)
    End Sub
End Class
