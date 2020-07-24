Public Class Form1
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Customers)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'Customers._customers' 資料表。您可以視需要進行移動或移除。
        Me.CustomersTableAdapter.Fill(Me.Customers._customers)


    End Sub

    Private Sub CustomersBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CustomersBindingNavigator.RefreshItems

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) 
    'Try
    'Me.CustomersTableAdapter.FillBy(Me.Customers._customers)
    'Catch ex As System.Exception
    'System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    'End Sub

    'Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
    'Try
    'Me.CustomersTableAdapter.FillBy1(Me.Customers._customers)
    'Catch ex As System.Exception
    'System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    'End Sub

    'Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
    'Try
    'Me.CustomersTableAdapter.FillBy2(Me.Customers._customers)
    'Catch ex As System.Exception
    'System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    'End Sub
End Class
