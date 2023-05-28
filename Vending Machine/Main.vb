Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBal()
    End Sub
    Private Sub DigitButton_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim digitButton As Button = DirectCast(sender, Button)
        Dim digit As String = digitButton.Text

        If txtCashin.Text.Length < 3 Then
            txtCashin.Text += digit
        End If

        If txtCashin.Text.Length > 3 Then
            txtCashin.Text = txtCashin.Text.Substring(0, 3)
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim targetControl As Control = txtCashin
        Dim currentText As String = targetControl.Text

        If currentText.Length > 0 Then
            currentText = currentText.Substring(0, currentText.Length - 1)
            targetControl.Text = currentText
        End If
    End Sub
    Private Sub lblClick_Click(sender As Object, e As EventArgs) Handles lblClick.Click
        Receipt.Show()
    End Sub

    Private Sub msStock_Click(sender As Object, e As EventArgs) Handles msStock.Click
        Stock.Show()
    End Sub

    Private Sub btnMilk_Click(sender As Object, e As EventArgs) Handles btnMilk.Click
        StockID = 1
        GetVenID(1)
        GetProductVal()
        If VerifyStocks() = True Then
            pnlMilk.Visible = False
            If VerifyPayment() = True Then
                If (MessageBox.Show("You chosen Fresh Milk, Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    PayItem()
                    BuyItem()
                    ShowBal()
                    MessageBox.Show("Please get your item below!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemBought = 1
                    Change = txtBal.Text
                    Reset()
                    ShowBal()
                    txtCashin.Text = ""
                    pnlProd.Enabled = False
                End If
            Else
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            pnlMilk.Visible = True
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        StockID = 2
        GetVenID(2)
        GetProductVal()
        If VerifyStocks() = True Then
            pnlDel.Visible = False
            If VerifyPayment() = True Then
                If (MessageBox.Show("You chosen Del Monte, Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                    PayItem()
                    BuyItem()
                    ShowBal()
                    MessageBox.Show("Please get your item below!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemBought = 2
                    Change = txtBal.Text
                    Reset()
                    ShowBal()
                    txtCashin.Text = ""
                    pnlProd.Enabled = False
                End If
            Else
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            pnlDel.Visible = True
        End If
    End Sub

    Private Sub btnGat_Click(sender As Object, e As EventArgs) Handles btnGat.Click
        StockID = 3
        GetVenID(3)
        GetProductVal()
        If VerifyStocks() = True Then
            pnlGat.Visible = False
            If VerifyPayment() = True Then
                If (MessageBox.Show("You chosen Gatorade, Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                    PayItem()
                    BuyItem()
                    ShowBal()
                    MessageBox.Show("Please get your item below!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemBought = 3
                    Change = txtBal.Text
                    Reset()
                    ShowBal()
                    txtCashin.Text = ""
                    pnlProd.Enabled = False
                End If
            Else
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            pnlGat.Visible = True
        End If
    End Sub

    Private Sub btnGum_Click(sender As Object, e As EventArgs) Handles btnGum.Click
        StockID = 4
        GetVenID(4)
        GetProductVal()
        If VerifyStocks() = True Then
            pnlGum.Visible = False
            If VerifyPayment() = True Then
                If (MessageBox.Show("You chosen Gummy, Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                    PayItem()
                    BuyItem()
                    ShowBal()
                    MessageBox.Show("Please get your item below!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemBought = 4
                    Change = txtBal.Text
                    Reset()
                    ShowBal()
                    txtCashin.Text = ""
                    pnlProd.Enabled = False
                End If
            Else
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            pnlGum.Visible = True
        End If
    End Sub

    Private Sub btnPring_Click(sender As Object, e As EventArgs) Handles btnPring.Click
        StockID = 5
        GetVenID(5)
        GetProductVal()
        If VerifyStocks() = True Then
            pnlPring.Visible = False
            If VerifyPayment() = True Then
                If (MessageBox.Show("You chosen Pringles, Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                    PayItem()
                    BuyItem()
                    ShowBal()
                    MessageBox.Show("Please get your item below!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemBought = 5
                    Change = txtBal.Text
                    Reset()
                    ShowBal()
                    txtCashin.Text = ""
                    pnlProd.Enabled = False
                End If
            Else
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            pnlPring.Visible = True
        End If
    End Sub

    Private Sub btnSoda_Click(sender As Object, e As EventArgs) Handles btnSoda.Click
        StockID = 6
        GetVenID(6)
        GetProductVal()
        If VerifyStocks() = True Then
            pnlSoda.Visible = False
            If VerifyPayment() = True Then
                If (MessageBox.Show("You chosen Soda, Proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                    PayItem()
                    BuyItem()
                    ShowBal()
                    MessageBox.Show("Please get your item below!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemBought = 6
                    Change = txtBal.Text
                    Reset()
                    ShowBal()
                    txtCashin.Text = ""
                    pnlProd.Enabled = False
                End If
            Else
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            pnlSoda.Visible = True
        End If
    End Sub

    Private Sub btnCashin_Click(sender As Object, e As EventArgs) Handles btnCashin.Click
        If txtCashin.Text = "" OrElse txtCashin.Text <= 0 Then
            MessageBox.Show("Please input a valid amount!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Cashin()
            ShowBal()
            pnlProd.Enabled = True
            txtCashin.Text = ""
        End If
    End Sub
End Class
