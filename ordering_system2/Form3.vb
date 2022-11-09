Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_password.Text = "admin1234" Or TextBox1.Text = "" Then
            ''pasta
            frm_order.txt_stocksplainpasta.Text = CDbl(frm_order.txt_stocksplainpasta.Text) + CDbl(frm_order.txt_quantityplainpasta.Text)
            frm_order.TextBox2.Text = CDbl(frm_order.TextBox2.Text) + CDbl(frm_order.txt_quantitycreamygarlicpasta.Text)
            frm_order.TextBox3.Text = CDbl(frm_order.TextBox3.Text) + CDbl(frm_order.txt_quantitycreamytomatopasta.Text)
            frm_order.TextBox4.Text = CDbl(frm_order.TextBox4.Text) + CDbl(frm_order.txt_quantityblackpepperpasta.Text)
            frm_order.TextBox5.Text = CDbl(frm_order.TextBox5.Text) + CDbl(frm_order.txt_quantitycheesepasta.Text)

            ''bread
            frm_order.TextBox6.Text = CDbl(frm_order.TextBox6.Text) + CDbl(frm_order.txt_quantityplainbread.Text)
            frm_order.TextBox7.Text = CDbl(frm_order.TextBox7.Text) + CDbl(frm_order.txt_quantitymilkbread.Text)
            frm_order.TextBox8.Text = CDbl(frm_order.TextBox8.Text) + CDbl(frm_order.txt_quantitycheesebread.Text)
            frm_order.TextBox9.Text = CDbl(frm_order.TextBox9.Text) + CDbl(frm_order.txt_quantitybananabread.Text)
            frm_order.TextBox10.Text = CDbl(frm_order.TextBox10.Text) + CDbl(frm_order.txt_quantitychocolatebread.Text)

            ''coffee
            frm_order.TextBox11.Text = CDbl(frm_order.TextBox11.Text) + CDbl(frm_order.txt_quantityplaincoffee.Text)
            frm_order.TextBox12.Text = CDbl(frm_order.TextBox12.Text) + CDbl(frm_order.txt_quantityclassiclatte.Text)
            frm_order.TextBox13.Text = CDbl(frm_order.TextBox13.Text) + CDbl(frm_order.txt_quantityclassicmilkcoffee.Text)
            frm_order.TextBox14.Text = CDbl(frm_order.TextBox14.Text) + CDbl(frm_order.txt_quantityclassicmocha.Text)
            frm_order.TextBox15.Text = CDbl(frm_order.TextBox15.Text) + CDbl(frm_order.txt_quantityclassiccaramel.Text)


            ''reset
            Button2.Enabled = False

            frm_order.btn_pay.Enabled = False
            frm_order.cbx_plainpasta.Checked = False
            frm_order.txt_quantityplainpasta.Text = 0.00
            frm_order.cbx_creamygarlicpasta.Checked = False
            frm_order.txt_quantitycreamygarlicpasta.Text = 0.00
            frm_order.cbx_creamytomatopasta.Checked = False
            frm_order.txt_quantitycreamytomatopasta.Text = 0.00
            frm_order.cbx_blackpepperpasta.Checked = False
            frm_order.txt_quantityblackpepperpasta.Text = 0.00
            frm_order.cbx_cheesepasta.Checked = False
            frm_order.txt_quantitycheesepasta.Text = 0.00
            frm_order.cbx_plainbread.Checked = False
            frm_order.txt_quantityplainbread.Text = 0.00
            frm_order.cbx_milkbread.Checked = False
            frm_order.txt_quantitymilkbread.Text = 0.00
            frm_order.cbx_cheesebread.Checked = False
            frm_order.txt_quantitycheesebread.Text = 0.00
            frm_order.cbx_bananabread.Checked = False
            frm_order.txt_quantitybananabread.Text = 0.00
            frm_order.cbx_chocolatebread.Checked = False
            frm_order.txt_quantitychocolatebread.Text = 0.00
            frm_order.cbx_plaincoffee.Checked = False
            frm_order.txt_quantityplaincoffee.Text = 0.00
            frm_order.cbx_classiclatte.Checked = False
            frm_order.txt_quantityclassiclatte.Text = 0.00
            frm_order.cbx_classicmilkcoffee.Checked = False
            frm_order.txt_quantityclassicmilkcoffee.Text = 0.00
            frm_order.cbx_classicmocha.Checked = False
            frm_order.txt_quantityclassicmocha.Text = 0.00
            frm_order.cbx_classiccaramel.Checked = False
            frm_order.txt_quantityclassiccaramel.Text = 0.00
            frm_order.txt_amounttopay.Text = 0.00
            frm_order.txt_amounttendered.Text = 0.00
            frm_order.txt_change.Text = 0.00

            frm_order.RichTextBox1.Text = ""
            Me.Hide()
            frm_order.Show()
        Else
            MessageBox.Show("Incorrect Password")
        End If

    End Sub

    Private Sub cbx_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_showpassword.CheckedChanged
        If cbx_showpassword.Checked Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frm_order.Show()
    End Sub
End Class