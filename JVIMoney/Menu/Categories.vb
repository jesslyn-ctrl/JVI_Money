Imports System.Data.SqlClient
Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class Categories
    Private dtIncome, dtExpense As DataTable
    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = GetDataIncome()
        ListBox1.DisplayMember = "category_name"

        ListBox2.DataSource = GetDataExpense()
        ListBox2.DisplayMember = "category_name"
    End Sub

    Private Function GetDataIncome() As DataTable
        dtIncome = New DataTable

        Dim query As New SqlCommand("SELECT category_name FROM Category WHERE category_type = 'Income' AND (u_id = 0 OR u_id = @id)", con)
        query.Parameters.Add("@id", SqlDbType.Int).Value = userid

        Using adapter As New SqlDataAdapter(query)
            adapter.Fill(dtIncome)
        End Using

        Return dtIncome
    End Function

    Private Function GetDataExpense() As DataTable
        dtExpense = New DataTable

        Dim query As New SqlCommand("SELECT category_name FROM Category WHERE category_type = 'Expense' AND (u_id = 0 OR u_id = @id)", con)
        query.Parameters.Add("@id", SqlDbType.Int).Value = userid

        Using adapter As New SqlDataAdapter(query)
            adapter.Fill(dtExpense)
        End Using

        Return dtExpense
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        pilihanmenu.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NewCategory.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim res As Integer = MessageBox.Show("Are you sure you want to delete this income item?", "DELETE CATEGORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim x = New CategoryTableAdapter

        If res = DialogResult.Yes
            x.DeleteCategory(ListBox1.GetItemText(ListBox1.SelectedItem), userid)

            Me.Controls.Clear()
            InitializeComponent()
            Categories_Load(e, e)
            Refresh()
        End If
    End Sub


    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        Dim res As Integer = MessageBox.Show("Are you sure you want to delete this expense item?", "DELETE CATEGORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim x = New CategoryTableAdapter

        If res = DialogResult.Yes
            x.DeleteCategory(ListBox2.GetItemText(ListBox2.SelectedItem), userid)

            Me.Controls.Clear()
            InitializeComponent()
            Categories_Load(e, e)
            Refresh()
        End If
    End Sub
End Class