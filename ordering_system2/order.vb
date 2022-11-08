Public Class frm_order

    Dim total As Integer
    Dim pasta1 As Integer = 0,
        pasta2 As Integer = 0,
        pasta3 As Integer = 0,
        pasta4 As Integer = 0,
        pasta5 As Integer = 0,
        bread1 As Integer = 0,
        bread2 As Integer = 0,
        bread3 As Integer = 0,
        bread4 As Integer = 0,
        bread5 As Integer = 0,
        coffee1 As Integer = 0,
        coffee2 As Integer = 0,
        coffee3 As Integer = 0,
        coffee4 As Integer = 0,
        coffee5 As Integer = 0

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


    Private Sub cbx_plainpasta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_plainpasta.CheckedChanged


        If cbx_plainpasta.Checked = True Then
            txt_quantityplainpasta.Enabled = True
        ElseIf cbx_plainpasta.Checked = False Then
            txt_quantityplainpasta.Enabled = False
            txt_quantityplainpasta.Text = "0"


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

    Private Sub Gcash_CheckedChanged(sender As Object, e As EventArgs) Handles Gcash.CheckedChanged
        txt_amounttendered.Enabled = False
        txt_change.Enabled = False



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        gcashITO.Show()

        Me.Enabled = False


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        gcashITO.Hide()

        Me.Enabled = True
    End Sub

    Private Sub txt_amounttendered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amounttendered.KeyPress

        If Not txt_amounttopay.Text = 0.00 Then

            btn_pay.Enabled = True


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

    Private Function totalQuanti(price As TextBox, quan As TextBox, stock As TextBox) As Integer
        Try




            stock.Text = stock.Text - quan.Text

            Dim a As Integer

            a = price.Text * quan.Text


            Return a
        Catch ex As Exception
            MessageBox.Show("Please use proper input")
        End Try

    End Function

    Private Sub btn_addorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addorder.Click

        Try

            If TextBox1.Text = "" Or TextBox17.Text = "" Then
                MessageBox.Show("Please Input customer name and address")
            Else

                total =
                totalQuanti(txt_priceplainpasta, txt_quantityplainpasta, txt_stocksplainpasta) + ''pasta
                totalQuanti(txt_pricecreamygarlicpasta, txt_quantitycreamygarlicpasta, TextBox2) +
                totalQuanti(txt_pricecreamytomatopasta, txt_quantitycreamytomatopasta, TextBox3) +
                totalQuanti(txt_priceblackpepperpasta, txt_quantityblackpepperpasta, TextBox4) +
                totalQuanti(txt_pricecheesepasta, txt_quantitycheesepasta, TextBox5) +
                totalQuanti(txt_priceplainbread, txt_quantityplainbread, TextBox6) + ''bread
                totalQuanti(txt_pricemilkbread, txt_quantitymilkbread, TextBox7) +
                totalQuanti(txt_pricecheesebread, txt_quantitycheesebread, TextBox8) +
                totalQuanti(txt_pricebananabread, txt_quantitybananabread, TextBox9) +
                totalQuanti(txt_pricechocolatebread, txt_quantitychocolatebread, TextBox10) +
                totalQuanti(txt_priceplaincoffee, txt_quantityplaincoffee, TextBox11) + ''Coffee
                totalQuanti(txt_priceclassiclatte, txt_quantityclassiclatte, TextBox12) +
                totalQuanti(txt_priceclassicmilkcoffee, txt_quantityclassicmilkcoffee, TextBox13) +
                totalQuanti(txt_priceclassicmocha, txt_quantityclassicmocha, TextBox14) +
                totalQuanti(txt_priceclassiccaramel, txt_quantityclassiccaramel, TextBox15)


            Dim VAT As Double = total * 0.12

            total = total + VAT
            txt_amounttopay.Text = total

            End If
        Catch ex As Exception

            MessageBox.Show("Please select order")

        End Try
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click

        cbx_plainpasta.Checked = False
        txt_quantityplainpasta.Text = 0.00
        cbx_creamygarlicpasta.Checked = False
        txt_quantitycreamygarlicpasta.Text = 0.00
        cbx_creamytomatopasta.Checked = False
        txt_quantitycreamytomatopasta.Text = 0.00
        cbx_blackpepperpasta.Checked = False
        txt_quantityblackpepperpasta.Text = 0.00
        cbx_cheesepasta.Checked = False
        txt_quantitycheesepasta.Text = 0.00
        cbx_plainbread.Checked = False
        txt_quantityplainbread.Text = 0.00
        cbx_milkbread.Checked = False
        txt_quantitymilkbread.Text = 0.00
        cbx_cheesebread.Checked = False
        txt_quantitycheesebread.Text = 0.00
        cbx_bananabread.Checked = False
        txt_quantitybananabread.Text = 0.00
        cbx_chocolatebread.Checked = False
        txt_quantitychocolatebread.Text = 0.00
        cbx_plaincoffee.Checked = False
        txt_quantityplaincoffee.Text = 0.00
        cbx_classiclatte.Checked = False
        txt_quantityclassiclatte.Text = 0.00
        cbx_classicmilkcoffee.Checked = False
        txt_quantityclassicmilkcoffee.Text = 0.00
        cbx_classicmocha.Checked = False
        txt_quantityclassicmocha.Text = 0.00
        cbx_classiccaramel.Checked = False
        txt_quantityclassiccaramel.Text = 0.00
        txt_amounttopay.Text = 0.00
        txt_amounttendered.Text = 0.00
        txt_change.Text = 0.00


    End Sub


    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click

        Try

            If Gcash.Checked = True Then
                    gcashITO.Show()
                    Me.Enabled = False

                Else
                    txt_change.Text = txt_amounttendered.Text - txt_amounttopay.Text
                    MessageBox.Show("Thank you for paying and being a good customer")
                End If

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



    Private Sub cash_CheckedChanged(sender As Object, e As EventArgs) Handles cashRadio.CheckedChanged
        txt_amounttendered.Enabled = True
        txt_change.Enabled = True



    End Sub

    Private Sub regular_CheckedChanged(sender As Object, e As EventArgs) Handles regular.CheckedChanged
        txt_amounttopay.Text = total
    End Sub

    Private Sub pwdSenior_CheckedChanged(sender As Object, e As EventArgs) Handles pwdSenior.CheckedChanged
        Dim seniorDiscount As Double

        seniorDiscount = total * 0.2

        txt_amounttopay.Text = total - seniorDiscount
    End Sub

    Private Sub Bornday_CheckedChanged(sender As Object, e As EventArgs) Handles Bornday.CheckedChanged
        Dim birthday As Double

        birthday = total * 0.05

        txt_amounttopay.Text = total - birthday
    End Sub
End Class