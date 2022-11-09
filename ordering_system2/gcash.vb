Public Class gcashITO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        frm_order.Enabled = True


        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim change As Double = frm_order.txt_amounttendered.Text - frm_order.txt_amounttendered.Text


        If change < 0 Then
            MessageBox.Show("Input a valid amount")
        Else
            frm_order.Button2.Enabled = True
            MessageBox.Show("Thank you for paying and being a good customer")
            frm_order.txt_change.Text = change

            If frm_order.Gcash.Checked Then
                frm_order.RichTextBox1.Text += "Mode of Payment: GCASH" + vbNewLine
            Else
                frm_order.RichTextBox1.Text += "Mode of Payment: Cash" + vbNewLine
            End If

            frm_order.RichTextBox1.Text += "VAT: 12%" + vbNewLine
            frm_order.RichTextBox1.Text += "Total Bill: " + frm_order.txt_amounttopay.Text + vbNewLine
            frm_order.RichTextBox1.Text += "Change: " + frm_order.txt_change.Text + vbNewLine


            frm_order.PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("Long Paper", 850, 1300)
            frm_order.PrintDocument1.Print()

            frm_order.btn_pay.Enabled = False

            frm_order.Enabled = True
            Me.Hide()
        End If



    End Sub
End Class