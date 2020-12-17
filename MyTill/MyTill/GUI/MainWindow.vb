Imports System.IO
Imports System.Data.OleDb
Public Class MainWindow
    Dim connection As OleDb.OleDbConnection
    Dim query As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter()

    'Holds the text of the receipt
    Dim textInRecipt As String
    'Holds the Prices
    Public Shared TotalPrice As Double
    'holds the price of the product
    Dim productPrice As Double
    'product price rouded to two decimal points
    Dim roundedPrice As Double
    'Holds the percentage entered by the user
    Public Shared percentage As Double
    'holds the selected item name and price
    Dim selectedItem As String
    'Holds the selected item's price
    Public Shared SelectedItemPrice As Double

    Dim file1 As String
    Dim generatedNumber1 As String

    Private Sub pBoxTransaction_MouseHover(sender As Object, e As EventArgs) Handles pBoxTransaction.MouseHover
        pBoxTransaction.Image = My.Resources.transaction1
    End Sub

    Private Sub pBoxTransaction_MouseLeave(sender As Object, e As EventArgs) Handles pBoxTransaction.MouseLeave
        pBoxTransaction.Image = My.Resources.Transactions_Icon_dark
    End Sub

    Private Sub btnATS_Click(sender As Object, e As EventArgs) Handles btnATS.Click
        LogIn.txtBoxPassword.Clear()
        LogIn.txtBoxUserName.Clear()
        Me.Hide()
        LogIn.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Sub ConnectToDataBase()

        'Build a connection String
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " &
                                         "Data Source=SystemDB.accdb;")
        'open the connection
        connection.Open()

    End Sub

    Sub DisconnectFromDataBase()
        'closes connection
        connection.Close()
    End Sub
    Sub GetProducts()

        'buil query
        query = "SELECT * FROM Products ORDER BY Barcode"

        ' pass the sql string and connection object to the data adapter
        da = New OleDb.OleDbDataAdapter(query, connection)
        'fill the dataset with records of from the database table
        da.Fill(ds, "SystemDB")

    End Sub

    Sub AddProducts()

    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'font
        Dim newFont As New Font(New FontFamily("Courier New"), 12) ' Define a fixed-width font for PadRight tabbing.

        Receipt.Items.Clear()

        Receipt.Font = newFont ' Employ the fixed-width font in the List Box.

        Timer1.Enabled = True

        'Connect to the Database
        ConnectToDataBase()

        'gests products
        GetProducts()

        'disconect from the database 
        DisconnectFromDataBase()

        'Hides Everything on the form
        For Each ctl As Control In Controls
            ctl.Visible = False
        Next
        
        'Shows Butoon Exit and Access the till system
        btnExit.Visible = True
        btnATS.Visible = True
        lblTimeANDdate.Visible = True

        'Filling in the Menus (Menu Natrual Drinks)
        btnND1.Text = ds.Tables("SystemDB").Rows(6).Item(1)
        btnND2.Text = ds.Tables("SystemDB").Rows(7).Item(1)
        btnND3.Text = ds.Tables("SystemDB").Rows(8).Item(1)
        btnND4.Text = ds.Tables("SystemDB").Rows(9).Item(1)
        btnND5.Text = ds.Tables("SystemDB").Rows(10).Item(1)
        btnND6.Text = ds.Tables("SystemDB").Rows(11).Item(1)
        btnND7.Text = ds.Tables("SystemDB").Rows(12).Item(1)
        btnND8.Text = ds.Tables("SystemDB").Rows(13).Item(1)
        btnND9.Text = ds.Tables("SystemDB").Rows(14).Item(1)

        'Menu Coffee
        btnCD1.Text = ds.Tables("SystemDB").Rows(0).Item(1)
        btnCD2.Text = ds.Tables("SystemDB").Rows(1).Item(1)
        btnCD3.Text = ds.Tables("SystemDB").Rows(2).Item(1)
        btnCD4.Text = ds.Tables("SystemDB").Rows(3).Item(1)
        btnCD5.Text = ds.Tables("SystemDB").Rows(4).Item(1)
        btnCD6.Text = ds.Tables("SystemDB").Rows(5).Item(1)

        'Menu Fizzy Drinks

        btnFD1.Text = ds.Tables("SystemDB").Rows(15).Item(1)
        btnFD2.Text = ds.Tables("SystemDB").Rows(16).Item(1)
        btnFD3.Text = ds.Tables("SystemDB").Rows(17).Item(1)
        btnFD4.Text = ds.Tables("SystemDB").Rows(18).Item(1)
        btnFD5.Text = ds.Tables("SystemDB").Rows(19).Item(1)
        btnFD6.Text = ds.Tables("SystemDB").Rows(20).Item(1)
        btnFD7.Text = ds.Tables("SystemDB").Rows(21).Item(1)
        btnFD8.Text = ds.Tables("SystemDB").Rows(22).Item(1)
        btnFD9.Text = ds.Tables("SystemDB").Rows(23).Item(1)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Application.Restart()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeANDdate.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub btnCD1_Click(sender As Object, e As EventArgs) Handles btnCD1.Click
        Receipt.Refresh()
        'Deducting percentage
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(0).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(0).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(0).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If


        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(0).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear recipt
        Receipt.Items.Clear()

        'Clear label that shows the amount of the sale
        lblCash.Text = ""

        'inicialises the variable to 0
        TotalPrice = 0

        SelectedItemPrice = 0
        percentage = 0

        'hides the button reset prices
        btnResetPrices.Visible = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Receipt.Refresh()
        'Removes an item from the lisbox
        If Receipt.SelectedIndex <= -1 Then
            MsgBox("Select an item", MsgBoxStyle.Information, "Information")
        Else
            selectedItem = (Receipt.SelectedItem)
            'remove an item from recipt
            Receipt.Items.Remove(Receipt.SelectedItem)

            TotalPrice = TotalPrice - SelectedItemPrice
            TotalPrice = Math.Round(TotalPrice, 2)

            lblCash.Text = TotalPrice.ToString("c")

        End If
    End Sub

    Private Sub btnCD2_Click(sender As Object, e As EventArgs) Handles btnCD2.Click

        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(1).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(1).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(1).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(1).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")

    End Sub

    Private Sub btnCD3_Click(sender As Object, e As EventArgs) Handles btnCD3.Click

        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(2).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(2).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(2).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(2).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)

        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")

    End Sub

    Private Sub btnCD4_Click(sender As Object, e As EventArgs) Handles btnCD4.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(3).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(3).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(3).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(3).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnCD5_Click(sender As Object, e As EventArgs) Handles btnCD5.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(4).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(4).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(4).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(4).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnCD6_Click(sender As Object, e As EventArgs) Handles btnCD6.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(5).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(5).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(5).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(5).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND1_Click(sender As Object, e As EventArgs) Handles btnND1.Click
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(6).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(6).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(6).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(6).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub
    Private Sub btnND2_Click(sender As Object, e As EventArgs) Handles btnND2.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(7).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(7).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(7).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(7).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND3_Click(sender As Object, e As EventArgs) Handles btnND3.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(8).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(8).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(8).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(8).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND4_Click(sender As Object, e As EventArgs) Handles btnND4.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(9).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(9).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(9).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(9).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND5_Click(sender As Object, e As EventArgs) Handles btnND5.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(10).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(10).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(10).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(10).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND6_Click(sender As Object, e As EventArgs) Handles btnND6.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(11).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(11).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(11).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(11).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND7_Click(sender As Object, e As EventArgs) Handles btnND7.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(12).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(12).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(12).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(12).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND8_Click(sender As Object, e As EventArgs) Handles btnND8.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(13).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(13).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(13).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(13).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnND9_Click(sender As Object, e As EventArgs) Handles btnND9.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(14).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(14).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(14).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(14).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD1_Click(sender As Object, e As EventArgs) Handles btnFD1.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(15).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(15).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(15).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(15).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD2_Click(sender As Object, e As EventArgs) Handles btnFD2.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(16).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(16).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(16).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(16).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD3_Click(sender As Object, e As EventArgs) Handles btnFD3.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(17).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(17).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(17).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(17).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD4_Click(sender As Object, e As EventArgs) Handles btnFD4.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(18).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(18).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(18).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(18).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD5_Click(sender As Object, e As EventArgs) Handles btnFD5.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(19).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(19).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(19).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(19).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD6_Click(sender As Object, e As EventArgs) Handles btnFD6.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(20).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(20).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(20).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(20).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD7_Click(sender As Object, e As EventArgs) Handles btnFD7.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(21).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(21).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(21).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(21).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD8_Click(sender As Object, e As EventArgs) Handles btnFD8.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(22).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(22).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(22).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(22).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnFD9_Click(sender As Object, e As EventArgs) Handles btnFD9.Click
        'discounts the percentage to the price
        If percentage = 0 Then
            productPrice = ds.Tables("SystemDB").Rows(23).Item(3)
        Else
            productPrice = percentage * ds.Tables("SystemDB").Rows(23).Item(3)
            productPrice = ds.Tables("SystemDB").Rows(23).Item(3) - productPrice
            productPrice = Math.Round(productPrice, 2)
        End If

        'Getting the selected item price to then remove it from the total amount
        If selectedItem = textInRecipt Then
            SelectedItemPrice = productPrice
        End If

        'Add item to the list box

        Receipt.Items.Add(System.Environment.NewLine + ds.Tables("SystemDB").Rows(23).Item(1).ToString.PadRight(20) + productPrice.ToString("c"))

        'Getting the price of the product and adding it to last product's price
        TotalPrice = TotalPrice + productPrice
        TotalPrice = Math.Round(TotalPrice, 2)
        'Putting the total price on the label
        lblCash.Text = TotalPrice.ToString("c")
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        
        'Validate the price
        If TotalPrice = 0 Then
            'Message to the user
            MsgBox("Iniciate a sale", MsgBoxStyle.Information, "Information")

        Else
            'Show payment window
            Payment.Show()
        End If
    End Sub

    Private Sub btnResetPrices_Click(sender As Object, e As EventArgs) Handles btnResetPrices.Click
        'Prices are reset to normal
        percentage = 0

        'message to user
        MsgBox("Back to Original Prices", MsgBoxStyle.Information, "Information")

        'hides the button reset prices
        btnResetPrices.Hide()
    End Sub

    Private Sub btnOfferDiscount_Click(sender As Object, e As EventArgs) Handles btnOfferDiscount.Click
        'shows the keyboard
        Keyboard.Show()
    End Sub

    Private Sub pBoxTransaction_Click(sender As Object, e As EventArgs) Handles pBoxTransaction.Click
        Transactions.Show()
    End Sub

    Private Sub pbUpdateProducts_Click(sender As Object, e As EventArgs) Handles pbUpdateProducts.Click
        UpdateInfo.Show()
    End Sub

    Private Sub btnPayLater_Click(sender As Object, e As EventArgs) Handles btnPayLater.Click
        Dim r As New List(Of Integer)
        Dim rg As New Random
        Dim rn As Integer

        If TotalPrice <= 0 Then
            MsgBox("No items on receipt", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Do
            rn = rg.Next(1, 9)
            If Not r.Contains(rn) Then
                r.Add(rn)
            End If
        Loop Until r.Count = 5

        generatedNumber1 = generatedNumber1 + r(0).ToString
        generatedNumber1 = generatedNumber1 + r(1).ToString
        generatedNumber1 = generatedNumber1 + r(2).ToString
        generatedNumber1 = generatedNumber1 + r(3).ToString
        generatedNumber1 = generatedNumber1 + r(4).ToString

        IO.Directory.CreateDirectory("TillSalesOnHold")

        'Save the sale into a file inside the the above directory
        Dim writeToFile As New IO.StreamWriter("TillSalesOnHold\" & generatedNumber1 & ".txt", True)

        'this variable is used to loop the file
        Dim i As Integer

        For i = 0 To Receipt.Items.Count - 1
            writeToFile.WriteLine(Receipt.Items.Item(i))
        Next
        'writes the total to be paid
        writeToFile.WriteLine(lblTotal.Text + "       " + lblCash.Text)

        'closes the streamwriter
        writeToFile.Close()

        'clear receipt and cash label
        Receipt.Items.Clear()
        lblCash.Text = ""
        'TotalPrice = 0
    End Sub

    Private Sub btnVHistory_Click(sender As Object, e As EventArgs) Handles btnVHistory.Click
        'If History.RName.Items.Count - 1 Then
        'MsgBox("No sales on hold", MsgBoxStyle.Information, "Information")
        'Else
        History.Show()
        'End If
    End Sub
End Class