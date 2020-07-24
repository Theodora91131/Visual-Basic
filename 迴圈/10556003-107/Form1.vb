Public Class Form1
    Dim rnd1 As New Random
    Dim rnd2 As New Random
    Dim rnd3 As New Random
    Dim a As Integer
    Dim b As Integer
    Dim C As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_KeyPress(keyascii As Integer)

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

    Private Sub TextBox1_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("請輸入一個三位數!")
        ElseIf TextBox1.Text = C Then
            MsgBox("恭喜你答對了!")
        ElseIf TextBox1.Text <> C Then
            If TextBox1.Text < Label1.Text Then
                MsgBox("請輸入介於" & Label1.Text & "到 " & Label5.Text & "的數!")
            ElseIf TextBox1.Text > Label5.Text Then
                MsgBox("請輸入介於" & Label1.Text & "到 " & Label5.Text & "的數!")
            ElseIf TextBox1.Text < C Then
                MsgBox("請輸入大一點的數!")
                Label1.Text = TextBox1.Text
            ElseIf TextBox1.Text > C Then
                MsgBox("請輸入小一點的數!")
                Label5.Text = TextBox1.Text

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As Short
        a = rnd1.Next(100, 1000)
        b = rnd2.Next(120, 980)
        If a > b Then
            d = a
            a = b
            b = d
        End If
        C = rnd3.Next(a, b)
        Label1.Text = a
        Label5.Text = b
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
