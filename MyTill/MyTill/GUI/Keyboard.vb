Public Class Keyboard

    'This variable holds the entered value
    Dim inputValue As String

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'closes this form
        Me.Close()
        'opens main window form
        MainWindow.Show()

        'shows button offer discount 
        MainWindow.btnOfferDiscount.Visible = True
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtBoxPercentage.Text = "" Then
            'no discount therefore no action
            MainWindow.percentage = 0
        Else
            MainWindow.percentage = txtBoxPercentage.Text()
            MainWindow.percentage = MainWindow.percentage / 100

            'message to the user
            MsgBox(txtBoxPercentage.Text + "% discount to all items", MsgBoxStyle.Information, "Information")

            'closes the keyboard form
            Me.Close()
        End If

        'Clear the textbox
        txtBoxPercentage.Text = ""

        'Enables the button Reset Prices
        MainWindow.btnResetPrices.Visible = True
    End Sub

    'Writing in the textbox
    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        inputValue = inputValue + "3"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        inputValue = inputValue + "."
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        inputValue = inputValue + "0"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        inputValue = inputValue + "2"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        inputValue = inputValue + "1"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        inputValue = inputValue + "4"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        inputValue = inputValue + "5"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        inputValue = inputValue + "6"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        inputValue = inputValue + "7"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        inputValue = inputValue + "8"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        inputValue = inputValue + "9"
        txtBoxPercentage.Text = inputValue
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxPercentage.Text = ""
        inputValue = ""
    End Sub

    Private Sub Keyboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class