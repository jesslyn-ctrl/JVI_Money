Imports System.ComponentModel
Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class transaction
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        add.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pilihanmenu.Show()
        Me.Close()
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        view.Show()
    End Sub

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JVI_MoneyDataSet.JVI_Main' table. You can move, or remove it, as needed.
        Me.JVI_MainTableAdapter.Fill(Me.JVI_MoneyDataSet.JVI_Main)

        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk
        DataGridView1.RowsDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.GhostWhite

        DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Descending)
        DataGridView1.Columns(3).DefaultCellStyle.Format = "###,###,###.00"

        Dim x = New UsersTableAdapter
        Label3.Text = String.Format("{0:n2}", x.GetSaldo(userid)) 
        Try
            Me.JVI_MainTableAdapter.FillBy(Me.JVI_MoneyDataSet.JVI_Main, CType(userid, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim res As Integer = MessageBox.Show("Are you sure you want to delete this transaction?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes
            Dim dbtotal As Decimal = DataGridView1.CurrentRow.Cells(3).Value
            Dim dbid As Integer = DataGridView1.CurrentRow.Cells("main_id").Value
            Dim x = New JVI_MainTableAdapter
            Dim u = New UsersTableAdapter
            Dim index As Integer

            Dim dbtotalmin = dbtotal*(-1)
            Dim saldo = u.GetSaldo(userid) + dbtotalmin
            u.UpdateSaldo(saldo, userid)

            index = DataGridView1.CurrentCell.RowIndex
            DataGridView1.Rows.RemoveAt(index)
            x.DeleteTranc(dbid)

            Me.Controls.Clear()
            InitializeComponent()
            Transaction_Load(e, e)
            Refresh()
        End If
    End Sub
End Class