Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_password.Text = "admin1234" Then

            ''pasta
            frm_order.txt_priceplainpasta.Text = stocks.txt_priceplainpasta.Text
            frm_order.txt_stocksplainpasta.Text = stocks.txt_stocksplainpasta.Text

            frm_order.txt_pricecreamygarlicpasta.Text = stocks.txt_pricecreamygarlicpasta.Text
            frm_order.TextBox2.Text = stocks.TextBox2.Text

            frm_order.txt_pricecreamytomatopasta.Text = stocks.txt_pricecreamytomatopasta.Text
            frm_order.TextBox3.Text = stocks.TextBox3.Text

            frm_order.txt_priceblackpepperpasta.Text = stocks.txt_priceblackpepperpasta.Text
            frm_order.TextBox4.Text = stocks.TextBox4.Text

            frm_order.txt_pricecheesepasta.Text = stocks.txt_pricecheesepasta.Text
            frm_order.TextBox5.Text = stocks.TextBox5.Text

            ''Bread
            frm_order.txt_priceplainbread.Text = stocks.txt_priceplainbread.Text
            frm_order.TextBox6.Text = stocks.TextBox6.Text

            frm_order.txt_pricemilkbread.Text = stocks.txt_pricemilkbread.Text
            frm_order.TextBox7.Text = stocks.TextBox7.Text

            frm_order.txt_pricecheesebread.Text = stocks.txt_pricecheesebread.Text
            frm_order.TextBox8.Text = stocks.TextBox8.Text

            frm_order.txt_pricebananabread.Text = stocks.txt_pricebananabread.Text
            frm_order.TextBox9.Text = stocks.TextBox9.Text

            frm_order.txt_pricechocolatebread.Text = stocks.txt_pricechocolatebread.Text
            frm_order.TextBox10.Text = stocks.TextBox10.Text

            ''Paste-ta
            frm_order.txt_priceplaincoffee.Text = stocks.txt_priceplaincoffee.Text
            frm_order.TextBox11.Text = stocks.TextBox11.Text

            frm_order.txt_priceclassiclatte.Text = stocks.txt_priceclassiclatte.Text
            frm_order.TextBox12.Text = stocks.TextBox12.Text

            frm_order.txt_priceclassicmilkcoffee.Text = stocks.txt_priceclassicmilkcoffee.Text
            frm_order.TextBox13.Text = stocks.TextBox13.Text

            frm_order.txt_priceclassicmocha.Text = stocks.txt_priceclassicmocha.Text
            frm_order.TextBox14.Text = stocks.TextBox14.Text

            frm_order.txt_priceclassiccaramel.Text = stocks.txt_priceclassiccaramel.Text
            frm_order.TextBox15.Text = stocks.TextBox15.Text

            Me.Hide()
            frm_order.Show()
        Else
            MessageBox.Show("Incorrect Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        stocks.Show()
    End Sub

    Private Sub cbx_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_showpassword.CheckedChanged
        If cbx_showpassword.Checked Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True

        End If
    End Sub
End Class