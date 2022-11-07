Public Class frm_order2


    Private Sub gb_pasta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb_pasta.Enter

        For Each Control As Control In Me.gb_pasta.Controls

            If TypeOf Control Is TextBox Then

                Control.Enabled = False

            End If

        Next

    End Sub

    Private Sub cbx_plainpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plainpasta.CheckedChanged

        If cbx_plainpasta.Checked = True Then
            txt_quantityplainpasta.Enabled = True

        ElseIf cbx_plainpasta.Checked = False Then
            txt_quantityplainpasta.Enabled = False
            txt_quantityplainpasta.Text = ""


        End If

    End Sub

    Private Sub cbx_creamygarlicpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_creamygarlicpasta.CheckedChanged

        If cbx_creamygarlicpasta.Checked = True Then
            txt_quantitycreamygarlicpasta.Enabled = True

        ElseIf cbx_creamygarlicpasta.Checked = False Then
            txt_quantitycreamygarlicpasta.Enabled = False
            txt_quantitycreamygarlicpasta.Text = ""

        End If

    End Sub

    Private Sub cbx_creamytomatopasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_creamytomatopasta.CheckedChanged

        If cbx_creamytomatopasta.Checked = True Then
            txt_quantitycreamytomatopasta.Enabled = True

        ElseIf cbx_creamytomatopasta.Checked = False Then
            txt_quantitycreamytomatopasta.Enabled = False
            txt_quantitycreamytomatopasta.Text = ""

        End If

    End Sub

    Private Sub cbx_blackpepperpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_blackpepperpasta.CheckedChanged

        If cbx_blackpepperpasta.Checked = True Then
            txt_quantityblackpepperpasta.Enabled = True

        ElseIf cbx_blackpepperpasta.Checked = False Then
            txt_quantityblackpepperpasta.Enabled = False
            txt_quantityblackpepperpasta.Text = ""

        End If

    End Sub

    Private Sub cbx_cheesepasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cheesepasta.CheckedChanged

        If cbx_cheesepasta.Checked = True Then
            txt_quantitycheesepasta.Enabled = True

        ElseIf cbx_cheesepasta.Checked = False Then
            txt_quantitycheesepasta.Enabled = False
            txt_quantitycheesepasta.Text = ""

        End If

    End Sub

    Private Sub cbx_plainbread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plainbread.CheckedChanged

        If cbx_plainbread.Checked = True Then
            txt_quantityplainbread.Enabled = True

        ElseIf cbx_plainbread.Checked = False Then
            txt_quantityplainbread.Enabled = False
            txt_quantityplainbread.Text = ""

        End If

    End Sub

    Private Sub cbx_milkbread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_milkbread.CheckedChanged

        If cbx_milkbread.Checked = True Then
            txt_quantitymilkbread.Enabled = True

        ElseIf cbx_milkbread.Checked = False Then
            txt_quantitymilkbread.Enabled = False
            txt_quantitymilkbread.Text = ""

        End If

    End Sub

    Private Sub cbx_cheesebread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_cheesebread.CheckedChanged

        If cbx_cheesebread.Checked = True Then
            txt_quantitycheesebread.Enabled = True

        ElseIf cbx_cheesebread.Checked = False Then
            txt_quantitycheesebread.Enabled = False
            txt_quantitycheesebread.Text = ""

        End If

    End Sub

    Private Sub cbx_bananabread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_bananabread.CheckedChanged

        If cbx_bananabread.Checked = True Then
            txt_quantitybananabread.Enabled = True

        ElseIf cbx_bananabread.Checked = False Then
            txt_quantitybananabread.Enabled = False
            txt_quantitybananabread.Text = ""

        End If

    End Sub

    Private Sub cbx_chocolatebread_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_chocolatebread.CheckedChanged

        If cbx_chocolatebread.Checked = True Then
            txt_quantitychocolatebread.Enabled = True

        ElseIf cbx_chocolatebread.Checked = False Then
            txt_quantitychocolatebread.Enabled = False
            txt_quantitychocolatebread.Text = ""

        End If

    End Sub

    Private Sub cbx_plaincoffee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plaincoffee.CheckedChanged

        If cbx_plaincoffee.Checked = True Then
            txt_quantityplaincoffee.Enabled = True

        ElseIf cbx_plaincoffee.Checked = False Then
            txt_quantityplaincoffee.Enabled = False
            txt_quantityplaincoffee.Text = ""

        End If

    End Sub

    Private Sub cbx_classiclatte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classiclatte.CheckedChanged


        If cbx_classiclatte.Checked = True Then
            txt_quantityclassiclatte.Enabled = True

        ElseIf cbx_classiclatte.Checked = False Then
            txt_quantityclassiclatte.Enabled = False
            txt_quantityclassiclatte.Text = ""

        End If

    End Sub

    Private Sub cbx_classicmilkcoffee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classicmilkcoffee.CheckedChanged

        If cbx_classicmilkcoffee.Checked = True Then
            txt_quantityclassicmilkcoffee.Enabled = True

        ElseIf cbx_classicmilkcoffee.Checked = False Then
            txt_quantityclassicmilkcoffee.Enabled = False
            txt_quantityclassicmilkcoffee.Text = ""

        End If

    End Sub

    Private Sub cbx_classicmocha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classicmocha.CheckedChanged


        If cbx_classicmocha.Checked = True Then
            txt_quantityclassicmocha.Enabled = True

        ElseIf cbx_classicmocha.Checked = False Then
            txt_quantityclassicmocha.Enabled = False
            txt_quantityclassicmocha.Text = ""

        End If

    End Sub

    Private Sub cbx_classiccaramel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_classiccaramel.CheckedChanged

        If cbx_classiccaramel.Checked = True Then
            txt_quantityclassiccaramel.Enabled = True

        ElseIf cbx_classiccaramel.Checked = False Then
            txt_quantityclassiccaramel.Enabled = False
            txt_quantityclassiccaramel.Text = ""

        End If

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        Application.Exit()

    End Sub

    Private Sub btn_addorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addorder.Click

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim f As Integer
        Dim g As Integer
        Dim h As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        a = (Convert.ToString(txt_priceplainpasta.Text * txt_quantityplainpasta.Text))
        b = (Convert.ToString(txt_pricecreamygarlicpasta.Text * txt_quantitycreamygarlicpasta.Text))
        c = (Convert.ToString(txt_pricecreamytomatopasta.Text * txt_quantitycreamytomatopasta.Text))
        d = (Convert.ToString(txt_priceblackpepperpasta.Text * txt_quantityblackpepperpasta.Text))
        f = (Convert.ToString(txt_pricecheesepasta.Text * txt_quantitycheesepasta.Text))
        g = (Convert.ToString(txt_priceplainbread.Text * txt_quantityplainbread.Text))
        h = (Convert.ToString(txt_pricemilkbread.Text * txt_quantitymilkbread.Text))
        i = (Convert.ToString(txt_pricecheesebread.Text * txt_quantitycheesebread.Text))
        j = (Convert.ToString(txt_pricebananabread.Text * txt_quantitybananabread.Text))
        k = (Convert.ToString(txt_pricechocolatebread.Text * txt_quantitychocolatebread.Text))

        txt_amounttopay.Text = a + b + c + d + f + g + h + i + j + k


    End Sub

    Private Sub txt_quantityplainpasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_quantityplainpasta.TextChanged

        txt_quantityplainpasta.Text = "0.00"

    End Sub
End Class