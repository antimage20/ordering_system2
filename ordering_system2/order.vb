Public Class frm_order

    Dim total As Integer
    Public pasta1 As Integer = 0,
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim ff1 As New Font("Century Gothic", 12, FontStyle.Regular)

        e.Graphics.DrawString(" Coffee | Bread | Pasta ", ff1, Brushes.Black, 200, 20)
        e.Graphics.DrawString(" Ordering System ", ff1, Brushes.Black, 225, 40)
        e.Graphics.DrawString("------------------------------------------------------------------------------------", ff1, Brushes.Black, 50, 60)

        e.Graphics.DrawString(DateTimePicker1.Text, ff1, Brushes.Black, 180, 80)
        e.Graphics.DrawString(" CUSTOMER #: 000000 ", ff1, Brushes.Black, 200, 120)

        e.Graphics.DrawString("Customer Name: " + TextBox1.Text, ff1, Brushes.Black, 50, 150)
        e.Graphics.DrawString("Address: " + TextBox17.Text, ff1, Brushes.Black, 50, 170)

        e.Graphics.DrawString(RichTextBox1.Text, ff1, Brushes.Black, 50, 200)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Private Sub totasl()
        'RichTextBox1.Text = RichTextBox1.Text.Replace(ControlChars.Lf, ",")
        RichTextBox1.Text = RichTextBox1.Text.Replace("************************************************************************************", "")



        RichTextBox1.Text = RichTextBox1.Text.Replace("Discount: Regular discount", "")
        RichTextBox1.Text = RichTextBox1.Text.Replace("Discount: 20% PWD and Senior Citizen Discount", "")
        RichTextBox1.Text = RichTextBox1.Text.Replace("Discount: 5% Birthday Discount", "")

        If regular.Checked Then

            RichTextBox1.Text += "************************************************************************************" + vbNewLine
            RichTextBox1.Text += "Discount: Regular discount" + vbNewLine
        ElseIf pwdSenior.Checked Then

            RichTextBox1.Text += "************************************************************************************" + vbNewLine
            RichTextBox1.Text += "Discount: 20% PWD and Senior Citizen Discount" + vbNewLine
        ElseIf Bornday.Checked Then

            RichTextBox1.Text += "************************************************************************************" + vbNewLine
            RichTextBox1.Text += "Discount: 5% Birthday Discount" + vbNewLine
        End If



    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        totasl()

        btn_pay.Enabled = True

        PageSetupDialog1.Document.DefaultPageSettings.Color = True
        PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("Long Paper", 850, 1300)
        ''PageSetupDialog1.ShowDialog()
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''pasta
        stocks.txt_priceplainpasta.Text = txt_priceplainpasta.Text
        stocks.txt_stocksplainpasta.Text = txt_stocksplainpasta.Text

        stocks.txt_pricecreamygarlicpasta.Text = txt_pricecreamygarlicpasta.Text
        stocks.TextBox2.Text = TextBox2.Text

        stocks.txt_pricecreamytomatopasta.Text = txt_pricecreamytomatopasta.Text
        stocks.TextBox3.Text = TextBox3.Text

        stocks.txt_priceblackpepperpasta.Text = txt_priceblackpepperpasta.Text
        stocks.TextBox4.Text = TextBox4.Text

        stocks.txt_pricecheesepasta.Text = txt_pricecheesepasta.Text
        stocks.TextBox5.Text = TextBox5.Text

        ''Bread
        stocks.txt_priceplainbread.Text = txt_priceplainbread.Text
        stocks.TextBox6.Text = TextBox6.Text

        stocks.txt_pricemilkbread.Text = txt_pricemilkbread.Text
        stocks.TextBox7.Text = TextBox7.Text

        stocks.txt_pricecheesebread.Text = txt_pricecheesebread.Text
        stocks.TextBox8.Text = TextBox8.Text

        stocks.txt_pricebananabread.Text = txt_pricebananabread.Text
        stocks.TextBox9.Text = TextBox9.Text

        stocks.txt_pricechocolatebread.Text = txt_pricechocolatebread.Text
        stocks.TextBox10.Text = TextBox10.Text

        ''Paste-ta
        stocks.txt_priceplaincoffee.Text = txt_priceplaincoffee.Text
        stocks.TextBox11.Text = TextBox11.Text

        stocks.txt_priceclassiclatte.Text = txt_priceclassiclatte.Text
        stocks.TextBox12.Text = TextBox12.Text

        stocks.txt_priceclassicmilkcoffee.Text = txt_priceclassicmilkcoffee.Text
        stocks.TextBox13.Text = TextBox13.Text

        stocks.txt_priceclassicmocha.Text = txt_priceclassicmocha.Text
        stocks.TextBox14.Text = TextBox14.Text

        stocks.txt_priceclassiccaramel.Text = txt_priceclassiccaramel.Text
        stocks.TextBox15.Text = TextBox15.Text

        Me.Hide()
        stocks.Show()
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

    Private Function totalQuanti(check As CheckBox, price As TextBox, quan As TextBox, stock As TextBox) As Integer
        Try




            stock.Text = stock.Text - quan.Text

            Dim a As Integer

            a = price.Text * quan.Text

            If check.Checked Then
                RichTextBox1.Text += check.Text +
                    "      Price: " + price.Text +
                    "      Qty: " + quan.Text + vbNewLine


            End If

            Return a
        Catch ex As Exception
            MessageBox.Show("Please use proper input")
        End Try

        Return 0
    End Function

    Private Sub btn_addorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addorder.Click

        Try

            If TextBox1.Text = "" Or TextBox17.Text = "" Then
                MessageBox.Show("Please Input customer name and address")
            Else

                total =
                totalQuanti(cbx_plainpasta, txt_priceplainpasta, txt_quantityplainpasta, txt_stocksplainpasta) + ''pasta
                totalQuanti(cbx_creamygarlicpasta, txt_pricecreamygarlicpasta, txt_quantitycreamygarlicpasta, TextBox2) +
                totalQuanti(cbx_creamytomatopasta, txt_pricecreamytomatopasta, txt_quantitycreamytomatopasta, TextBox3) +
                totalQuanti(cbx_blackpepperpasta, txt_priceblackpepperpasta, txt_quantityblackpepperpasta, TextBox4) +
                totalQuanti(cbx_cheesepasta, txt_pricecheesepasta, txt_quantitycheesepasta, TextBox5) +
                totalQuanti(cbx_plainbread, txt_priceplainbread, txt_quantityplainbread, TextBox6) + ''bread
                totalQuanti(cbx_milkbread, txt_pricemilkbread, txt_quantitymilkbread, TextBox7) +
                totalQuanti(cbx_cheesebread, txt_pricecheesebread, txt_quantitycheesebread, TextBox8) +
                totalQuanti(cbx_bananabread, txt_pricebananabread, txt_quantitybananabread, TextBox9) +
                totalQuanti(cbx_chocolatebread, txt_pricechocolatebread, txt_quantitychocolatebread, TextBox10) +
                totalQuanti(cbx_plaincoffee, txt_priceplaincoffee, txt_quantityplaincoffee, TextBox11) + ''Coffee
                totalQuanti(cbx_classiclatte, txt_priceclassiclatte, txt_quantityclassiclatte, TextBox12) +
                totalQuanti(cbx_classicmilkcoffee, txt_priceclassicmilkcoffee, txt_quantityclassicmilkcoffee, TextBox13) +
                totalQuanti(cbx_classicmocha, txt_priceclassicmocha, txt_quantityclassicmocha, TextBox14) +
                totalQuanti(cbx_classiccaramel, txt_priceclassiccaramel, txt_quantityclassiccaramel, TextBox15)


                Dim VAT As Double = total * 0.12

            total = total + VAT
            txt_amounttopay.Text = total

            End If
        Catch ex As Exception

            MessageBox.Show("Please select order")

        End Try
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        total = 0

        Button2.Enabled = False

        btn_pay.Enabled = False
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

        RichTextBox1.Text = ""

    End Sub


    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click

        Try

            If Gcash.Checked = True Then
                gcashITO.Show()
                Me.Enabled = False

            Else

                Dim change As Double = txt_amounttendered.Text - txt_amounttopay.Text


                If change < 0 Then
                    MessageBox.Show("Input a valid amount")
                Else

                    Button2.Enabled = True
                    MessageBox.Show("Thank you for paying and being a good customer")
                    txt_change.Text = change

                    If Gcash.Checked Then
                        RichTextBox1.Text += "Mode of Payment: GCASH" + vbNewLine
                    Else
                        RichTextBox1.Text += "Mode of Payment: Cash" + vbNewLine
                    End If

                    RichTextBox1.Text += "VAT: 12%" + vbNewLine
                    RichTextBox1.Text += "Total Bill: " + txt_amounttopay.Text + vbNewLine
                    RichTextBox1.Text += "Change: " + txt_change.Text + vbNewLine


                    PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("Long Paper", 850, 1300)
                    Me.PrintDocument1.Print()
                    btn_pay.Enabled = False

                End If


            End If




        Catch ex As Exception

            MessageBox.Show(ex.ToString)
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