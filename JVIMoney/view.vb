Imports System.ComponentModel

Public Class view
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transaction.GroupBox1.Visible = False
        transaction.GroupBox2.Visible = False
        month.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        transaction.DataGridView1.Sort(transaction.DataGridView1.Columns(1), ListSortDirection.Descending)
        transaction.GroupBox1.Visible = False
        transaction.GroupBox2.Visible = False
        transaction.JVI_MainTableAdapter.FillBy(transaction.JVI_MoneyDataSet.JVI_Main, CType(userid, Integer))
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        transaction.DataGridView1.Sort(transaction.DataGridView1.Columns(2), ListSortDirection.Ascending)
        transaction.GroupBox1.Visible = False
        transaction.GroupBox2.Visible = False
        transaction.JVI_MainTableAdapter.FillByCategoryName(transaction.JVI_MoneyDataSet.JVI_Main, userid)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        transaction.DataGridView1.Sort(transaction.DataGridView1.Columns(1), ListSortDirection.Descending)
        transaction.GroupBox1.Visible = False
        transaction.GroupBox2.Visible = False
        transaction.JVI_MainTableAdapter.FillByIncome(transaction.JVI_MoneyDataSet.JVI_Main, userid)
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        transaction.DataGridView1.Sort(transaction.DataGridView1.Columns(1), ListSortDirection.Descending)
        transaction.GroupBox1.Visible = False
        transaction.GroupBox2.Visible = False
        transaction.JVI_MainTableAdapter.FillByExpense(transaction.JVI_MoneyDataSet.JVI_Main, userid)
        Me.Close()
    End Sub
End Class