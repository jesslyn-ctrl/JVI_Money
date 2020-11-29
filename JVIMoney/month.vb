Imports System.ComponentModel
Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class month
    'Dim setMon As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        transaction.JVI_MainTableAdapter.FillByDate(transaction.JVI_MoneyDataSet.JVI_Main, NumericUpDown1.Value,ComboBox2.Text, userid)

        transaction.GroupBox1.Visible = True
        transaction.GroupBox2.Visible = True

        transaction.DataGridView1.Sort(transaction.DataGridView1.Columns(0), ListSortDirection.Descending)
        Dim x = New JVI_MainTableAdapter
        transaction.Label4.Text = "Rp. " & String.Format("{0:n2}", x.GetIncomeMon(NumericUpDown1.Value, ComboBox2.Text, userid)) 
        transaction.Label5.Text = "Rp. " & String.Format("{0:n2}", x.GetExpenseMon(NumericUpDown1.Value, ComboBox2.Text, userid)) 
        transaction.Show()
        Me.Close()
    End Sub

    Private Sub Month_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As Date = Date.Now()
        Dim strYear As String = year.ToString("yyyy")
        Dim intYear As Integer = Int(strYear)

        For i = 0 To 3
            ComboBox2.Items.Add(intYear)
            intYear -= 1
        Next

    End Sub
End Class