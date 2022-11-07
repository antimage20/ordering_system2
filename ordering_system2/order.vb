Public Class frm_order


    Public Sub gb_pasta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_pasta.Enter

        For Each Control As Control In Me.gb_pasta.Controls

            If TypeOf Control Is TextBox Then

                Control.Enabled = False

            End If
        Next

    End Sub

    Private Sub gb_bread_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_bread.Enter

        For Each Control As Control In Me.gb_bread.Controls

            If TypeOf Control Is TextBox Then

                Control.Enabled = False

            End If
        Next
    End Sub

    Private Sub gb_coffee_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_coffee.Enter

        For Each Control As Control In Me.gb_coffee.Controls

            If TypeOf Control Is TextBox Then

                Control.Enabled = False

            End If
        Next
    End Sub

    Private Sub gb_payment_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_payment.Enter

        txt_amounttopay.Enabled = False
        txt_change.Enabled = False
        btn_pay.Enabled = False

    End Sub

    Private Sub cbx_plainpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plainpasta.CheckedChanged


        If cbx_plainpasta.Checked = True Then
            txt_quantityplainpasta.Enabled = True

        ElseIf cbx_plainpasta.Checked = False Then
            txt_quantityplainpasta.Enabled = False
            txt_quantityplainpasta.Text = "0.00"


        End If

    End Sub


    Private Sub cbx_creamygarlicpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_creamygarlicpasta.CheckedChanged

        If cbx_creamygarlicpasta.Checked = True Then
            txt_quantitycreamygarlicpasta.Enabled = True

        ElseIf cbx_creamygarlicpasta.Checked = False Then
            txt_quantitycreamygarlicpasta.Enabled = False
            txt_quantitycreamygarlicpasta.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_creamytomatopasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_creamytomatopasta.CheckedChanged

        If cbx_creamytomatopasta.Checked = True Then
            txt_quantitycreamytomatopasta.Enabled = True

        ElseIf cbx_creamytomatopasta.Checked = False Then
            txt_quantitycreamytomatopasta.Enabled = False
            txt_quantitycreamytomatopasta.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_blackpepperpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_blackpepperpasta.CheckedChanged

        If cbx_blackpepperpasta.Checked = True Then
            txt_quantityblackpepperpasta.Enabled = True

        ElseIf cbx_blackpepperpasta.Checked = False Then
            txt_quantityblackpepperpasta.Enabled = False
            txt_quantityblackpepperpasta.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_cheesepasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cheesepasta.CheckedChanged

        If cbx_cheesepasta.Checked = True Then
            txt_quantitycheesepasta.Enabled = True

        ElseIf cbx_cheesepasta.Checked = False Then
            txt_quantitycheesepasta.Enabled = False
            txt_quantitycheesepasta.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_plainbread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plainbread.CheckedChanged

        If cbx_plainbread.Checked = True Then
            txt_quantityplainbread.Enabled = True

        ElseIf cbx_plainbread.Checked = False Then
            txt_quantityplainbread.Enabled = False
            txt_quantityplainbread.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_milkbread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_milkbread.CheckedChanged

        If cbx_milkbread.Checked = True Then
            txt_quantitymilkbread.Enabled = True

        ElseIf cbx_milkbread.Checked = False Then
            txt_quantitymilkbread.Enabled = False
            txt_quantitymilkbread.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_cheesebread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cheesebread.CheckedChanged


        If cbx_cheesebread.Checked = True Then
            txt_quantitycheesebread.Enabled = True

        ElseIf cbx_cheesebread.Checked = False Then
            txt_quantitycheesebread.Enabled = False
            txt_quantitycheesebread.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_bananabread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_bananabread.CheckedChanged

        If cbx_bananabread.Checked = True Then
            txt_quantitybananabread.Enabled = True

        ElseIf cbx_bananabread.Checked = False Then
            txt_quantitybananabread.Enabled = False
            txt_quantitybananabread.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_chocolatebread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_chocolatebread.CheckedChanged

        If cbx_chocolatebread.Checked = True Then
            txt_quantitychocolatebread.Enabled = True

        ElseIf cbx_chocolatebread.Checked = False Then
            txt_quantitychocolatebread.Enabled = False
            txt_quantitychocolatebread.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_plaincoffee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plaincoffee.CheckedChanged

        If cbx_plaincoffee.Checked = True Then
            txt_quantityplaincoffee.Enabled = True

        ElseIf cbx_plaincoffee.Checked = False Then
            txt_quantityplaincoffee.Enabled = False
            txt_quantityplaincoffee.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_classiclatte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classiclatte.CheckedChanged


        If cbx_classiclatte.Checked = True Then
            txt_quantityclassiclatte.Enabled = True

        ElseIf cbx_classiclatte.Checked = False Then
            txt_quantityclassiclatte.Enabled = False
            txt_quantityclassiclatte.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_classicmilkcoffee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classicmilkcoffee.CheckedChanged

        If cbx_classicmilkcoffee.Checked = True Then
            txt_quantityclassicmilkcoffee.Enabled = True

        ElseIf cbx_classicmilkcoffee.Checked = False Then
            txt_quantityclassicmilkcoffee.Enabled = False
            txt_quantityclassicmilkcoffee.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_classicmocha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classicmocha.CheckedChanged

        If cbx_classicmocha.Checked = True Then
            txt_quantityclassicmocha.Enabled = True

        ElseIf cbx_classicmocha.Checked = False Then
            txt_quantityclassicmocha.Enabled = False
            txt_quantityclassicmocha.Text = "0.00"

        End If

    End Sub

    Private Sub cbx_classiccaramel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classiccaramel.CheckedChanged

        If cbx_classiccaramel.Checked = True Then
            txt_quantityclassiccaramel.Enabled = True

        ElseIf cbx_classiccaramel.Checked = False Then
            txt_quantityclassiccaramel.Enabled = False
            txt_quantityclassiccaramel.Text = "0.00"

        End If

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        Application.Exit()

    End Sub

    Private Sub btn_addorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addorder.Click

        Try




            btn_pay.Enabled = True
            Dim a As Integer

            a = txt_priceplainpasta.Text * txt_quantityplainpasta.Text


            txt_amounttopay.Text = a

        Catch ex As Exception

            MessageBox.Show("Please select order")

        End Try
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click

        cbx_plainpasta.Checked = False
        txt_quantityplainpasta.Text = ""
        cbx_creamygarlicpasta.Checked = False
        txt_quantitycreamygarlicpasta.Text = ""
        cbx_creamytomatopasta.Checked = False
        txt_quantitycreamytomatopasta.Text = ""
        cbx_blackpepperpasta.Checked = False
        txt_quantityblackpepperpasta.Text = ""
        cbx_cheesepasta.Checked = False
        txt_quantitycheesepasta.Text = ""
        cbx_plainbread.Checked = False
        txt_quantityplainbread.Text = ""
        cbx_milkbread.Checked = False
        txt_quantitymilkbread.Text = ""
        cbx_cheesebread.Checked = False
        txt_quantitycheesebread.Text = ""
        cbx_bananabread.Checked = False
        txt_quantitybananabread.Text = ""
        cbx_chocolatebread.Checked = False
        txt_quantitychocolatebread.Text = ""
        cbx_plaincoffee.Checked = False
        txt_quantityplaincoffee.Text = ""
        cbx_classiclatte.Checked = False
        txt_quantityclassiclatte.Text = ""
        cbx_classicmilkcoffee.Checked = False
        txt_quantityclassicmilkcoffee.Text = ""
        cbx_classicmocha.Checked = False
        txt_quantityclassicmocha.Text = ""
        cbx_classiccaramel.Checked = False
        txt_quantityclassiccaramel.Text = ""
        txt_amounttopay.Text = ""
        txt_amounttendered.Text = ""
        txt_change.Text = ""


    End Sub


    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click

        Try
            txt_change.Text = txt_amounttendered.Text - txt_amounttopay.Text
            MessageBox.Show("Thank you for paying and being a good customer")

            cbx_plainpasta.Checked = False
            txt_quantityplainpasta.Text = "0.00"
            cbx_creamygarlicpasta.Checked = False
            txt_quantitycreamygarlicpasta.Text = "0.00"
            cbx_creamytomatopasta.Checked = False
            txt_quantitycreamytomatopasta.Text = "0.00"
            cbx_blackpepperpasta.Checked = False
            txt_quantityblackpepperpasta.Text = "0.00"
            cbx_cheesepasta.Checked = False
            txt_quantitycheesepasta.Text = "0.00"
            cbx_plainbread.Checked = False
            txt_quantityplainbread.Text = "0.00"
            cbx_milkbread.Checked = False
            txt_quantitymilkbread.Text = "0.00"
            cbx_cheesebread.Checked = False
            txt_quantitycheesebread.Text = "0.00"
            cbx_bananabread.Checked = False
            txt_quantitybananabread.Text = "0.00"
            cbx_chocolatebread.Checked = False
            txt_quantitychocolatebread.Text = "0.00"
            cbx_plaincoffee.Checked = False
            txt_quantityplaincoffee.Text = "0.00"
            cbx_classiclatte.Checked = False
            txt_quantityclassiclatte.Text = "0.00"
            cbx_classicmilkcoffee.Checked = False
            txt_quantityclassicmilkcoffee.Text = "0.00"
            cbx_classicmocha.Checked = False
            txt_quantityclassicmocha.Text = "0.00"
            cbx_classiccaramel.Checked = False
            txt_quantityclassiccaramel.Text = "0.00"
            txt_amounttopay.Text = "0.00"
            txt_amounttendered.Text = "0.00"
            txt_change.Text = "0.00"

        Catch ex As Exception

            MessageBox.Show("Please enter amount")
        End Try

    End Sub

    Private Sub txt_amounttendered_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amounttendered.TextChanged

        btn_pay.Enabled = True

    End Sub
End Class