Public Class Form1
    Dim AryN() As Object = {"N鬼使神差", "N地海戰記", "N亞瑟的奇幻王國", "N夏綠蒂的網", "N花田少年史", "N惡靈戰警", "N血鑽石"}
    Dim AryS() As Object = {"S白雪公主", "S小鹿班比", "S幻想曲", "S愛麗絲夢遊仙境", "S101忠狗", "S小美人魚"}
    Dim data4() As Object = {"", "", "", "", "", "", ""}
    Dim data1 As Short
    Dim data2 As Short
    Dim data3 As Short

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = 0
        Label5.Text = 0
        Label7.Text = 0
    End Sub

    Private Sub 功能選單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 功能選單ToolStripMenuItem.Click

    End Sub

    Private Sub 影片種類ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 影片種類ToolStripMenuItem.Click

    End Sub

    Private Sub 重新選擇ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重新選擇ToolStripMenuItem.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(data4)
        TextBox1.Text = 0
        Label3.Text = 0
        Label5.Text = 0
        Label7.Text = 0
        DateTimePicker1.Text = Today
    End Sub

    Private Sub N熱門新片ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles N熱門新片ToolStripMenuItem.Click
        Call SetN()
    End Sub

    Private Sub S經典動畫ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles S經典動畫ToolStripMenuItem.Click
        Call SetS()
    End Sub

    Private Sub 結束ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 結束ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.MinDate = Today
        data3 = DateDiff(DateInterval.Day, DateTimePicker1.Value, Today)
        data3 = Val(data3) * -1
        Label7.Text = data3
        Call CalTotal()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndices.Count = 0 Then
            MsgBox("請選擇要租的影片!", 64, "")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            Label5.Text = Val(Label5.Text) + data2
        End If
        data1 = ListBox2.Items.Count
        Label3.Text = data1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedIndices.Count = 0 Then
            MsgBox("請選擇不租的影片!", 64, "")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            Label5.Text = Val(Label5.Text) - data2
        End If
        data1 = ListBox2.Items.Count
        Label3.Text = data1
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
    Public Sub SetN()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(AryN)
        Label10.Text = "N熱門新片"
        Label12.Text = 100
        data2 = 100
        data4 = AryN
    End Sub
    Public Sub SetS()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(AryS)
        Label10.Text = "S經典動畫"
        Label12.Text = 50
        data2 = 50
        data4 = AryS
    End Sub
    Public Sub CalTotal()
        TextBox1.Text = Val(Label5.Text) + (10 * Val(Label7.Text) * Val(Label3.Text))
    End Sub
End Class
