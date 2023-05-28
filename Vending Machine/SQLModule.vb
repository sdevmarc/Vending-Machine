Imports MySql.Data.MySqlClient
Module SQLModule
    Private vendID, Thestock, ProdVal, Thechange, Theitembought, selectedval As Integer
    Dim constring As String = "server = localhost; user = root; password = 1234; database = db_vending;"
    Dim con As New MySqlConnection(constring)
    Dim cmd As MySqlCommand

    Property ComboBx As Integer
        Get
            Return selectedval
        End Get
        Set(value As Integer)
            selectedval = value
        End Set
    End Property

    Property StockID As Integer
        Get
            Return Thestock
        End Get
        Set(value As Integer)
            Thestock = value
        End Set
    End Property

    Property Change As Integer
        Get
            Return Thechange
        End Get
        Set(value As Integer)
            Thechange = value
        End Set
    End Property

    Property ItemBought As Integer
        Get
            Return Theitembought
        End Get
        Set(value As Integer)
            Theitembought = value
        End Set
    End Property
    Sub Receipt(inp As Object)
        con.Open()
        cmd = New MySqlCommand("select * from product", con)
        con.Close()
    End Sub

    Sub GetVenID(inp As Object)
        vendID = inp
    End Sub

    Function VerifyStocks() As Boolean
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM product where product_id = @pid", con)
        cmd.Parameters.AddWithValue("@pid", Thestock)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            Dim bal As Integer = read.GetInt32(read.GetOrdinal("stock"))
            read.Close()
            con.Close()
            If bal > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            read.Close()
            con.Close()
            Return False
        End If
    End Function

    Function VerifyPayment() As Boolean
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM vending_machine", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            Dim bal As Integer = read.GetInt32(read.GetOrdinal("balance"))
            read.Close()
            con.Close()
            If bal < ProdVal Then
                Return False
            Else
                Return True
            End If
        Else
            read.Close()
            con.Close()
            Return False
        End If
    End Function

    Sub GetProductVal()
        con.Open()
        cmd = New MySqlCommand("select * from product where product_id = @pid", con)
        cmd.Parameters.AddWithValue("@pid", vendID)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            ProdVal = read.GetInt32("price")
        End While
        read.Close()
        con.Close()
    End Sub

    Sub Reset()
        con.Open()
        cmd = New MySqlCommand("update vending_machine set balance = 0 where vend_id = 1", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub AddStock()
        con.Open()
        cmd = New MySqlCommand("update product set stock = @stock where product_id = @id", con)
        cmd.Parameters.AddWithValue("@stock", Stock.nudStock.Value)
        cmd.Parameters.AddWithValue("@id", selectedval)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Item got updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Sub ShowBal()
        con.Open()
        cmd = New MySqlCommand("select * from vending_machine", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            Main.txtBal.Text = read.GetString("balance")
        End While
        read.Close()
        con.Close()
    End Sub

    Sub Cashin()
        con.Open()
        cmd = New MySqlCommand("update vending_machine set balance = balance + @cashin where vend_id = 1", con)
        cmd.Parameters.AddWithValue("@cashin", Main.txtCashin.Text)
        MessageBox.Show("Cash-in succeeded!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub PayItem()
        con.Open()
        cmd = New MySqlCommand("update vending_machine set balance = balance - @pay where vend_id = 1", con)
        cmd.Parameters.AddWithValue("@pay", ProdVal)
        MessageBox.Show("Payment succeeded!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub BuyItem()
        con.Open()
        cmd = New MySqlCommand("update product set stock = stock - 1 where product_id = @id", con)
        cmd.Parameters.AddWithValue("@id", vendID)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub ShowProduct()
        con.Open()
        Stock.dgvProduct.Rows.Clear()
        cmd = New MySqlCommand("select * from product", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            Stock.dgvProduct.Rows.Add(read("product_id"), read("name"), read("stock"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub RetrieveProduct()
        con.Open()
        cmd = New MySqlCommand("select * from product", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            Dim items As String = read.GetString("name")
            Stock.cmbItems.Items.Add(items)
        End While
        read.Close()
        con.Close()
    End Sub

    Sub RetrieveStockVal()
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM product WHERE product_id = @pid", con)
        cmd.Parameters.AddWithValue("@pid", selectedval)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read()
            Dim items As Integer = read.GetInt32(read.GetOrdinal("stock"))
            Stock.nudStock.Value = items
        End While
        read.Close()
        con.Close()
    End Sub

End Module
