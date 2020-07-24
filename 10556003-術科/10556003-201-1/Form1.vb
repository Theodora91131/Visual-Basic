Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Text = Val(345)
        TextBox1.Text = Val(0)
        TextBox2.Text = Val(0)
        TextBox3.Text = Val(0)
        TextBox4.Text = Val(0)
    End Sub

    Private Sub 功能FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 功能FToolStripMenuItem.Click

    End Sub

    Private Sub 兌換CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 兌換CToolStripMenuItem.Click
        Dim X As Integer
        Dim a() As Integer = {0, 0, 0, 0, 1}
        Dim b() As Integer = {0, 50, 10, 5, 1}
        X = TextBox5.Text
        If CheckBox1.Checked = True Then
            a(1) = 1
        End If
        If CheckBox2.Checked = True Then
            a(2) = 1
        End If
        If CheckBox3.Checked = True Then
            a(3) = 1
        End If
        For i = 1 To 4
            If a(i) = 1 Then
                a(i) = X \ b(i)
                X = X Mod b(i)
            End If
            If X = 0 Then
                Exit For
            End If
        Next
        TextBox1.Text = a(1)
        TextBox2.Text = a(2)
        TextBox3.Text = a(3)
        TextBox4.Text = a(4)
    End Sub

    Private Sub 離開XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 離開XToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox1.Text = Val(0)
        TextBox2.Text = Val(0)
        TextBox3.Text = Val(0)
        TextBox4.Text = Val(0)
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub
End Class
