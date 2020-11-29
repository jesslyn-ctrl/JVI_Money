Imports System.Data
Imports System.Data.SqlClient
Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class newacc
    Private Sub Newacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        akun.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (TextBox2.UseSystemPasswordChar = True) Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        signin.Show()
        Me.Close()
    End Sub

    Private Function userExist(ByVal user As String) As Boolean
        Dim tb As New DataTable()
        Dim adapter As New SqlDataAdapter()
        Dim query As New SqlCommand("SELECT * FROM Users WHERE u_name = @username", con)
        query.Parameters.Add("@username", SqlDbType.VarChar).Value = user

        adapter.SelectCommand = query
        adapter.Fill(tb)

        If tb.Rows.Count > 0
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        If TextBox1.Text.Trim() = "" And TextBox2.Text.Trim() = ""
            MessageBox.Show("Email and Passsword Field Cannot be Empty", "REGISTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text.Trim() = ""
            MessageBox.Show("Email Field Cannot be Empty", "REGISTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text.Trim() = ""
            MessageBox.Show("Passsword Field Cannot be Empty", "REGISTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf userExist(TextBox1.Text)
            MessageBox.Show("This Email Already Exists!", "REGISTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text.Contains("@") = False
            MessageBox.Show("Invalid Email!", "REGISTER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim x = new UsersTableAdapter
            x.Regist(TextBox1.Text, TextBox2.Text)

            MessageBox.Show("Register Success!", "REGISTER INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            signin.Show()

            Me.Close()
        End If
    End Sub
End Class