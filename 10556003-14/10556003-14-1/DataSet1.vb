Partial Class DataSet1
    Partial Public Class TableDataTable
        Private Sub TableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.姓名Column.ColumnName) Then
                '在此處加入使用者程式碼
            End If

        End Sub

    End Class
End Class

Namespace DataSet1TableAdapters

    Partial Public Class TableTableAdapter
    End Class
End Namespace
