Public Class Form1
    Dim Pay, OrderQuantityS, MainPriceS, UpGradePriceS As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub P()
        Call GetAmt(Pay, OrderQuantityS, MainPriceS, UpGradePriceS)
        Label4.Text = Pay
    End Sub
    Public Overloads Sub GetAmt(ByRef TotAmountS, ByVal OrderQuantityS, ByVal MainPriceS, ByVal UpGradePriceS)
        TotAmountS = OrderQuantityS * (MainPriceS + UpGradePriceS)

    End Sub
    Private Sub RadioButton2_clicked(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox1.Text = 99
        End If
        TextBox1.Text = MainPriceS
        Call P()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub RadioButton1_clicked(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Text = 129
            TextBox1.Text = MainPriceS
        End If
        Call P()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = False Then
            CheckBox1.Enabled = False
            CheckBox1.Checked = False
        ElseIf RadioButton3.Checked = True Then
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = False Then
            CheckBox2.Enabled = False
            CheckBox2.Checked = False
        ElseIf RadioButton6.Checked = True Then
            CheckBox2.Enabled = True
        End If

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            CheckBox2.Enabled = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            CheckBox2.Enabled = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpGradePriceS = 0
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            UpGradePriceS += 5
            UpGradePriceS += 5
        ElseIf CheckBox1.Checked = True Then
            UpGradePriceS += 5
        End If
        Call P()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        UpGradePriceS = 0
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            UpGradePriceS += 5
            UpGradePriceS += 5
        ElseIf CheckBox2.Checked = True Then
            UpGradePriceS += 5
        End If
        Call P()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        MainPriceS = Val(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        OrderQuantityS = Val(TextBox2.Text)
        Call P()
    End Sub

    Private Sub Label4_clicked(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("謝謝光臨!")
        RadioButton1.Checked = True
        RadioButton3.Checked = True
        RadioButton6.Checked = True
        TextBox2.Text = ""
        Label4.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub
End Class