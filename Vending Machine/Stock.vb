Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveProduct()
        ShowProduct()
        cmbItems.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (cmbItems.SelectedIndex = 0) Then
            AddStock()
            ShowProduct()
        ElseIf (cmbItems.SelectedIndex = 1) Then
            AddStock()
            ShowProduct()
        ElseIf (cmbItems.SelectedIndex = 2) Then
            AddStock()
            ShowProduct()
        ElseIf (cmbItems.SelectedIndex = 3) Then
            AddStock()
            ShowProduct()
        ElseIf (cmbItems.SelectedIndex = 4) Then
            AddStock()
            ShowProduct()
        ElseIf (cmbItems.SelectedIndex = 5) Then
            AddStock()
            ShowProduct()
        End If
    End Sub

    Private Sub cmbItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItems.SelectedIndexChanged
        If (cmbItems.SelectedIndex = 0) Then
            ComboBx = 1
            RetrieveStockVal()
        ElseIf (cmbItems.SelectedIndex = 1) Then
            ComboBx = 2
            RetrieveStockVal()
        ElseIf (cmbItems.SelectedIndex = 2) Then
            ComboBx = 3
            RetrieveStockVal()
        ElseIf (cmbItems.SelectedIndex = 3) Then
            ComboBx = 4
            RetrieveStockVal()
        ElseIf (cmbItems.SelectedIndex = 4) Then
            ComboBx = 5
            RetrieveStockVal()
        ElseIf (cmbItems.SelectedIndex = 5) Then
            ComboBx = 6
            RetrieveStockVal()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class