Public Class pilihanmenu
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        transaction.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Categories.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transaction.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Account.Show()
        Me.Close()
    End Sub
End Class