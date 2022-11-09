Public Class Form1
    Public attempts As Integer = 0

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click

        frm_order.Show()

        Me.Hide()

        If txt_username.Text = "admin" And txt_password.Text = "admin1234" Then
            MessageBox.Show("Login successfully")
            frm_order.Show()
            Me.Hide()

        ElseIf MessageBox.Show("Wrong username or password") Then
            txt_password.Text = ""
            txt_username.Clear()
            txt_username.Focus()
            attempts += 1

            If attempts = 3 Then
                txt_password.Enabled = False
                txt_username.Enabled = False
                btn_login.Enabled = False
                btn_exit.Enabled = False
                cbx_showpassword.Enabled = False

            End If

        End If
    End Sub

    Private Sub btn_password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        Application.Exit()

    End Sub

    Private Sub cbx_showpassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_showpassword.CheckedChanged

        If cbx_showpassword.Checked Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True

        End If
        
    End Sub

End Class
