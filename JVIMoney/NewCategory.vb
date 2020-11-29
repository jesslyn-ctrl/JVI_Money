Imports System.Data.SqlClient

Public Class NewCategory
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Categories.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If TextBox1.Text = Nothing Then
            Label5.Visible = True
        Else 
            con.Open()
            Select Case setradbtn
                Case 1
                    Dim cmd As New SqlCommand("INSERT INTO Category (category_name, category_type, u_id)" & 
                                                       "VALUES ('"& TextBox1.Text &"', '"& RadioButton1.Text &"', @id)", con)
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = userid
                    cmd.ExecuteNonQuery()
                Case 2
                    Dim cmd As New SqlCommand("INSERT INTO Category (category_name, category_type, u_id)" & 
                                              "VALUES ('"& TextBox1.Text &"', '"& RadioButton2.Text &"', @id)", con)
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = userid
                    cmd.ExecuteNonQuery()
            End Select
            Categories.Show()
            Me.Close()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        setradbtn = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        setradbtn = 2
    End Sub

    Private Sub NewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub
End Class