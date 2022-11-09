Public Class stocks
    Private Sub txt_stocksplainpasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stocksplainpasta.KeyPress, txt_priceplainpasta.KeyPress, txt_priceplaincoffee.KeyPress, txt_priceplainbread.KeyPress, txt_pricemilkbread.KeyPress, txt_pricecreamytomatopasta.KeyPress, txt_pricecreamygarlicpasta.KeyPress, txt_priceclassicmocha.KeyPress, txt_priceclassicmilkcoffee.KeyPress, txt_priceclassiclatte.KeyPress, txt_priceclassiccaramel.KeyPress, txt_pricechocolatebread.KeyPress, txt_pricecheesepasta.KeyPress, txt_pricecheesebread.KeyPress, txt_priceblackpepperpasta.KeyPress, txt_pricebananabread.KeyPress, TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frm_order.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Hide()
        Form2.Show()

    End Sub
End Class