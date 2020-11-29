Imports System.Data.SqlClient
Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class add
    Private dtCategory As DataTable
    Private setVal As Integer
  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x = New JVI_MainTableAdapter
        Dim y = New UsersTableAdapter
        Select Case setVal
            Case 1
                x.AddTranc(userid, RichTextBox1.Text, TextBox1.Text, RadioButton1.Text, DateTimePicker1.Value, ComboBox1.Text)
            Case 2
                Dim minus = Int(TextBox1.Text)*(-1)
                x.AddTranc(userid, RichTextBox1.Text, minus.ToString(), RadioButton2.Text, DateTimePicker1.Value, ComboBox1.Text)
        End Select
        usersaldo = x.SUMSaldo(userid)
        if usersaldo < 0
            MessageBox.Show("You Spent More Than Your Income","WARNING",MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        y.UpdateSaldo(usersaldo, userid)
        transaction.Show()
        Me.Close()
    End Sub

    Private Function GetIncomeData() As DataTable
        dtCategory = New DataTable

        Dim query As New SqlCommand("SELECT category_name FROM Category WHERE category_type = 'Income' AND (u_id = 0 OR u_id = @id)", con)
        query.Parameters.Add("@id", SqlDbType.Int).Value = userid

        Using adapter As New SqlDataAdapter(query)
            adapter.Fill(dtCategory)
        End Using

        Return dtCategory
    End Function

    Private Function GetExpenseData() As DataTable
        dtCategory = New DataTable

        Dim query As New SqlCommand("SELECT category_name FROM Category WHERE category_type = 'Expense' AND (u_id = 0 OR u_id = @id)", con)
        query.Parameters.Add("@id", SqlDbType.Int).Value = userid

        Using adapter As New SqlDataAdapter(query)
            adapter.Fill(dtCategory)
        End Using

        Return dtCategory
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox1.DataSource = GetIncomeData()
        ComboBox1.DisplayMember = "category_name"
        setVal = 1
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox1.DataSource = GetExpenseData()
        ComboBox1.DisplayMember = "category_name"
        setVal = 2
    End Sub
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JVI_MoneyDataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.JVI_MoneyDataSet.Category)
        RadioButton1.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transaction.Show()
        Me.Close()
    End Sub
End Class