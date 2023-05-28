Public Class Receipt
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ItemBought = 1 Then
            pbMilk.Visible = True
        ElseIf ItemBought = 2 Then
            pbDel.Visible = True
        ElseIf ItemBought = 3 Then
            pbGat.Visible = True
        ElseIf ItemBought = 4 Then
            pbGum.Visible = True
        ElseIf ItemBought = 5 Then
            pbPringles.Visible = True
        ElseIf ItemBought = 6 Then
            pbSoda.Visible = True
        End If
        lblChange.Text = "PHP " + Change().ToString + ".00"
    End Sub
End Class