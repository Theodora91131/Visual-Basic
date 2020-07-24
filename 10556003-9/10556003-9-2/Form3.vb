Public Class Form3
    Dim a As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(Form1.data(1)) + Val(Form1.data(2)) + Val(Form1.data(3)) + Val(Form1.data(4))
        Label1.Text = Form1.data(1) & Space(1) & "您的成績如下:" & vbNewLine & vbNewLine & "國文:" & Space(1) & Form1.data(2) & vbNewLine & "英文:" & Space(1) & Form1.data(3) & vbNewLine & "數學:" & Space(1) & Form1.data(4) & vbNewLine & vbNewLine & "總分:" & a

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class