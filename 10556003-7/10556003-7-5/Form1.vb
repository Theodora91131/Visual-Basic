Public Class Form1
    Dim data1 As String
    Dim data2 As String
    Dim data3 As String
    Dim data4 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(TextBox1, "例:王大同或Michael Jordan")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected
        ToolTip2.SetToolTip(MaskedTextBox2, "請注意輸入的字元是否合法或是超過字數!!")
    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        data1 = "您的姓名是:" & TextBox1.Text
        data2 = "您的生日是:" & MaskedTextBox1.Text
        data3 = "您的身分證字號是:" & MaskedTextBox2.Text
        data4 = "您的電話是:" & MaskedTextBox3.Text
        MsgBox(data1 & vbNewLine & data2 & vbNewLine & data3 & vbNewLine & data4 & vbNewLine & "謝謝您的配合!!")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
