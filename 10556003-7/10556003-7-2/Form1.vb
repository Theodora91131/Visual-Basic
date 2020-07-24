Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Button1, "按一下換算成華氏溫度")
        ToolTip1.SetToolTip(MaskedTextBox1, "請輸入攝氏溫度")
        ToolTip1.SetToolTip(Label2, "顯示換算後華氏溫度")
        MaskedTextBox1.Mask = "#### 度"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        ToolTip1.SetToolTip(MaskedTextBox1, "請輸入數字!!")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "華氏溫度="
        Label2.Text &= Val(9 / 5) * Val(MaskedTextBox1.Text) + 32 & "度"

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
