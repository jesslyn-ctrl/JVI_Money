Partial Class JVI_MoneyDataSet
    Partial Public Class TransactionDataTable


    End Class

    Partial Public Class UsersDataTable
        Private Sub UsersDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.u_passColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace JVI_MoneyDataSetTableAdapters

End Namespace
