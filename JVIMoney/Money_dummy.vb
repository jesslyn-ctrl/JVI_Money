Public Class Money_dummy
    Private Sub Money_dummy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JVI_MoneyDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.JVI_MoneyDataSet.Users)

    End Sub
End Class