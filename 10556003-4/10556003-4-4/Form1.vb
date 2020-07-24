Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As Integer

        If RadioButton1.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = True Then
            str1 = 7980 + 588 + 390
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf (RadioButton1.Checked = True And CheckBox1.Checked = True) Then
            str1 = 7980 + 588
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf (RadioButton1.Checked = True And CheckBox2.Checked = True) Then
            str1 = 7980 + 390
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf RadioButton1.Checked = True Then
            str1 = 7980
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        End If

        If RadioButton2.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = True Then
            str1 = 8888 + 588 + 390
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf (RadioButton2.Checked = True And CheckBox1.Checked = True) Then
            str1 = 8888 + 588
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf (RadioButton2.Checked = True And CheckBox2.Checked = True) Then
            str1 = 8888 + 390
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf RadioButton2.Checked = True Then
            str1 = 8888
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        End If

        If RadioButton3.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = True Then
            str1 = 5880 + 588 + 390
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf (RadioButton3.Checked = True And CheckBox1.Checked = True) Then
            str1 = 5880 + 588
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf (RadioButton3.Checked = True And CheckBox2.Checked = True) Then
            str1 = 5880 + 390
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        ElseIf RadioButton3.Checked = True Then
            str1 = 5880
            If RadioButton4.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈清潔組"
            ElseIf RadioButton5.Checked = True Then
                Label2.Text = "總價" & str1 & "元,加贈保護貼"
            Else
                Label2.Text = "總價" & str1 & "元,加贈防潮盒"
            End If
        End If
    End Sub
End Class
