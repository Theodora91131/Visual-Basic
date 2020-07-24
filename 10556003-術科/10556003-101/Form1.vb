Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Val(1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        ElseIf CheckBox2.Checked = True Then
            CheckBox3.Checked = False
            CheckBox1.Checked = False
        ElseIf CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        ElseIf CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        ElseIf CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        ElseIf CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        ElseIf CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Label2.Text = "NT$" & Val(250) * Val(TextBox1.Text)
        ElseIf CheckBox2.Checked = True Then
            Label2.Text = "NT$" & Val(275) * Val(TextBox1.Text)
        ElseIf CheckBox3.Checked = True Then
            Label2.Text = "NT$" & Val(350) * Val(TextBox1.Text)
        End If
    End Sub
End Class
