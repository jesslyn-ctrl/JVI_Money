Imports JVIMoney.JVI_MoneyDataSetTableAdapters

Public Class Account
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MessageBox.Show("Signing out from this device?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            akun.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        pilihanmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        changepass.Show()
        Me.Close()
    End Sub

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x = New UsersTableAdapter
        Label3.Text = x.GetEmail(userid)
    End Sub
End Class