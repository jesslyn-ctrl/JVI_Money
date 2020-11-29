Imports System.Data.SqlClient
Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class signin

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        transaction.GroupBox1.Visible = False
        transaction.GroupBox2.Visible = False
        Dim x = New UsersTableAdapter()
        x.Login(TextBox1.Text, TextBox2.Text)

        If TextBox1.Text.Trim() = "" And TextBox2.Text.Trim() = ""
            MessageBox.Show("Email and Passsword Field Cannot be Empty", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text.Trim() = ""
            MessageBox.Show("Email Field Cannot be Empty", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text.Trim() = ""
            MessageBox.Show("Passsword Field Cannot be Empty", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If x.Login(TextBox1.Text, TextBox2.Text).Rows.Count <= 0 Then
                MessageBox.Show("This Username and/or Password doesn't exists", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                userid = x.GetId(TextBox1.Text, TextBox2.Text)
                MessageBox.Show("Login Success!", "LOGIN INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                transaction.Show()
                Me.Close()
            End If
        End If
        
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If TextBox1.Text.Trim() = ""
            MessageBox.Show("Email Field Cannot be Empty", "FORGOT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Your Verification Code Has Been Sent To Your Email", "FORGOT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Text = ""
        End If
        
    End Sub
End Class