Imports System.Data.SqlClient

Public Class createwallet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newacc.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        transaction.Show()
        newacc.Close()
        Me.Close()
    End Sub

    Private Sub Createwallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class