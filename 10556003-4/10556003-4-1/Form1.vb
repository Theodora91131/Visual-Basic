Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "請輸入整數後按確定紐,電腦會判斷是奇數還是偶數!"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_Chabged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Label2_Text(sender As Object, e As EventArgs) Handles Label2.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Label2.Text = IIf((0 = Val(TextBox1.Text) Mod 2), Val(TextBox1.Text) & "是偶數", Val(TextBox1.Text) & "是奇數 ")






    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
