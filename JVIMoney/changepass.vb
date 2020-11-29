Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class changepass
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (TextBox2.UseSystemPasswordChar = True) Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (TextBox1.UseSystemPasswordChar = True) Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Account.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x = New UsersTableAdapter
        If x.GetPassword(userid).Trim() = TextBox1.Text
            If TextBox1.Text = TextBox2.Text
                MessageBox.Show("New Password cannot be the same as the old one!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else 
                x.UpdatePassword(TextBox2.Text, userid)
                RichTextBox1.Visible = True
                If (RichTextBox1.Visible = True) Then
                    Timer1.Start()
                End If
            End If
        Else 
            MessageBox.Show("Wrong Password Entered!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text += 1
        If Label4.Text = 3 Then
            Timer1.Stop()
            Account.Show()
            Me.Close()
        End If
    End Sub
End Class