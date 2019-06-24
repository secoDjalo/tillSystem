Public Class Payment
    Dim textboxText As String
    Dim totalOwed As Double
    Dim totalEntered As Double
    Dim change As Double

    'This variable holds the total price 
    Dim amountEntered As Double

    Public Shared fileName As String

    Dim generatedNumber As String

    'Writing in the textbox
    Private Sub btnFiveP_Click(sender As Object, e As EventArgs) Handles btnFiveP.Click
        textboxText = textboxText + "5"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnTwentyP_Click(sender As Object, e As EventArgs) Handles btnTwentyP.Click
        textboxText = textboxText + "20"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnTwoP_Click(sender As Object, e As EventArgs) Handles btnTwoP.Click
        textboxText = textboxText + "2"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnTenP_Click(sender As Object, e As EventArgs) Handles btnTenP.Click
        textboxText = textboxText + "10"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnThirtyP_Click(sender As Object, e As EventArgs) Handles btnThirtyP.Click
        textboxText = textboxText + "30"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnFifteenP_Click(sender As Object, e As EventArgs) Handles btnFifteenP.Click
        textboxText = textboxText + "15"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        textboxText = textboxText + "0"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        textboxText = textboxText + "."
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        textboxText = textboxText + "1"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        textboxText = textboxText + "2"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        textboxText = textboxText + "3"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        textboxText = textboxText + "4"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        textboxText = textboxText + "5"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        textboxText = textboxText + "6"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        textboxText = textboxText + "7"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        textboxText = textboxText + "8"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        textboxText = textboxText + "9"
        txtAmountSelected.Text = textboxText
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmountSelected.Text = ""
        textboxText = ""
    End Sub

    Private Sub btnCancelSale_Click(sender As Object, e As EventArgs) Handles btnCancelSale.Click
        txtAmountSelected.Text = ""
        textboxText = ""
        PaymentReceipt.Items.Clear()
        Me.Close()
        MainWindow.Show()
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newFont As New Font(New FontFamily("Courier New"), 12) ' Define a fixed-width font for PadRight tabbing.
        PaymentReceipt.Font = newFont ' Employ the fixed-width font in the List Box.
        lblTotalToBePaid.Text = MainWindow.lblCash.Text
        PaymentReceipt.Items.AddRange(MainWindow.Receipt.Items)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'converts the string into double so that calculation can be made
        amountEntered = CDbl(Val(txtAmountSelected.Text))

        'Writes the amout entered in the label
        lblTotalEntered.Text = amountEntered.ToString("c")

        'Puts the total price to the variable
        totalOwed = MainWindow.TotalPrice

        If txtAmountSelected.Text = "" Then
            MsgBox("Please enter the amount", MsgBoxStyle.Information, "Information")

            txtAmountSelected.Focus()

        ElseIf amountEntered < totalOwed Then
            MsgBox("The amount entered is less than the bill", MsgBoxStyle.Information, "Information")
            txtAmountSelected.Clear()
            textboxText = ""
            txtAmountSelected.Focus()
        Else
            'Calculates the change
            change = amountEntered - totalOwed
            'round the reult at 2 decimal points
            change = Math.Round(change, 2)
            'writes the result in the lable
            lblChangeToBeGiven.Text = change.ToString("c")


            Dim r As New List(Of Integer)
            Dim rg As New Random
            Dim rn As Integer

            Do
                rn = rg.Next(1, 50)
                If Not r.Contains(rn) Then
                    r.Add(rn)
                End If
            Loop Until r.Count = 10

            generatedNumber = generatedNumber + r(0).ToString
            generatedNumber = generatedNumber + r(1).ToString
            generatedNumber = generatedNumber + r(2).ToString
            generatedNumber = generatedNumber + r(3).ToString
            generatedNumber = generatedNumber + r(4).ToString
            generatedNumber = generatedNumber + r(5).ToString
            generatedNumber = generatedNumber + r(6).ToString
            generatedNumber = generatedNumber + r(7).ToString
            generatedNumber = generatedNumber + r(8).ToString
            generatedNumber = generatedNumber + r(9).ToString

            IO.Directory.CreateDirectory("TillSales")

            'Save the sale into a file inside the the above directory
            Dim writeToFile As New IO.StreamWriter("TillSales\" & generatedNumber & ".txt", True)
            fileName = "TillSales\"

            'writes the Name of the restaurant
            writeToFile.WriteLine(Receipt.Label1.Text)

            'writes served by and the name of the employee
            writeToFile.WriteLine(Receipt.Label5.Text + "       " + MainWindow.lblUserName.Text)

            'this variable is used to loop the file
            Dim i As Integer

            For i = 0 To PaymentReceipt.Items.Count - 1
                writeToFile.WriteLine(PaymentReceipt.Items.Item(i))
            Next
            'writes the total to be paid
            writeToFile.WriteLine(Label2.Text + "       " + lblTotalToBePaid.Text)

            'writes the entered amount
            writeToFile.WriteLine(lblPaymentTotal.Text + "       " + lblTotalEntered.Text)

            'writes the change given
            writeToFile.WriteLine(Label1.Text + "       " + lblChangeToBeGiven.Text)

            'writes the date and time
            writeToFile.WriteLine(MainWindow.lblTimeANDdate.Text)

            'closes the streamwriter
            writeToFile.Close()

            'writes a message for the user
            'MsgBox("Transaction registered successfully", MsgBoxStyle.Information, "Information")

            Receipt.Show()

            'closes the payment window
            Me.Close()

        End If

    End Sub
End Class


