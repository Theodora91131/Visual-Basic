Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox1.Text = Val(0)
    End Sub

    Private Sub 票選第一品牌OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 票選第一品牌OToolStripMenuItem.Click
        If Val(TextBox2.Text) = Val(TextBox3.Text) And Val(TextBox3.Text) = Val(TextBox4.Text) Then
            MsgBox("票數相同")
        ElseIf Val(TextBox3.Text) > Val(TextBox2.Text) And Val(TextBox3.Text) > Val(TextBox4.Text) Then
            MsgBox("第一品牌是" & "SonyErricsson新力易利信!")
        ElseIf Val(TextBox4.Text) > Val(TextBox2.Text) And Val(TextBox4.Text) > Val(TextBox3.Text) Then
            MsgBox("第一品牌是" & "Nokia諾基亞!")
        ElseIf Val(TextBox2.Text) > Val(TextBox3.Text) And Val(TextBox2.Text) > Val(TextBox4.Text) Then
            MsgBox("第一品牌是" & "Motorola摩托羅拉!")
        ElseIf Val(TextBox2.Text) = Val(TextBox3.Text) Then
            MsgBox("第一品牌是" & "Motorola摩托羅拉!和SonyErricsson新力易利信!")
        ElseIf Val(TextBox3.Text) = Val(TextBox4.Text) Then
            MsgBox("第一品牌是" & "SonyErricsson新力易利信!和Nokia諾基亞!")
        ElseIf Val(TextBox2.Text) = Val(TextBox4.Text) Then
            MsgBox("第一品牌是" & "Motorola摩托羅拉!和Nokia諾基亞!")
        End If
    End Sub

    Private Sub 離開XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 離開XToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Val(TextBox2.Text) + 1
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = Val(TextBox3.Text) + 1
        ElseIf RadioButton3.Checked = True Then
            TextBox4.Text = Val(TextBox4.Text) + 1
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MsgBox("沒有選取手機廠牌...")
        End If
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Val(TextBox2.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        ElseIf Val(TextBox3.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        ElseIf Val(TextBox4.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Val(TextBox2.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        ElseIf Val(TextBox3.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        ElseIf Val(TextBox4.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Val(TextBox2.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        ElseIf Val(TextBox3.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        ElseIf Val(TextBox4.Text) + 1 Then
            TextBox1.Text = Val(TextBox1.Text) + 1
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
