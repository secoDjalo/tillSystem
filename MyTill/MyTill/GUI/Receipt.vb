Public Class Receipt

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Dim newFont As New Font(New FontFamily("Courier New"), 12) ' Define a fixed-width font for PadRight tabbing.
        ListBox1.Font = newFont ' Employ the fixed-width font in the List Box.

        'ListBox1.Items.AddRange(Payment.PaymentReceipt.Items)
        lblServer.Text = MainWindow.lblUserName.Text
        lblTotal.Text = Payment.lblTotalToBePaid.Text
        lblAP.Text = Payment.lblTotalEntered.Text
        lblChange.Text = Payment.lblChangeToBeGiven.Text

        'Dim objReader As New System.IO.StreamReader(Payment.fileName)
        ListBox1.Items.AddRange(Payment.PaymentReceipt.Items)
        'objReader.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        'shows the print preview dialog
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim lineheight As Single

        lineheight = Me.Label1.Font.GetHeight(e.Graphics)
        'Font and size for the name of the company
        Dim font1 As New Font("Ravie", 28, FontStyle.Regular)
        'writes the the name of the company
        e.Graphics.DrawString(Label1.Text, font1, Brushes.Black, x, y)
        y += lineheight

        'defines the font for the lables
        Dim font2 As New Font("Modern No. 20", 16, FontStyle.Regular)

        'writes served by and the name of the user
        lineheight = Me.Label5.Font.GetHeight(e.Graphics)
        e.Graphics.DrawString(Label5.Text + "                    " + lblServer.Text, font2, Brushes.Black, x, y)
        y += lineheight

        'writes the items
        lineheight = Me.ListBox1.Font.GetHeight(e.Graphics)
        For Each item As String In Me.ListBox1.Items()
            e.Graphics.DrawString(item, Me.ListBox1.Font, Brushes.Black, x, y)
            y += lineheight
        Next

        y += lineheight

        'writes the total 
        lineheight = Me.Label2.Font.GetHeight(e.Graphics)
        e.Graphics.DrawString(Label2.Text + "                                      " + lblTotal.Text, font2, Brushes.Black, x, y)
        y += lineheight

        'writes the amount paid
        lineheight = Me.Label3.Font.GetHeight(e.Graphics)
        e.Graphics.DrawString(Label3.Text + "                        " + lblAP.Text, font2, Brushes.Black, x, y)
        y += lineheight

        'writes the change
        lineheight = Me.Label4.Font.GetHeight(e.Graphics)
        e.Graphics.DrawString(Label4.Text + "                                  " + lblChange.Text, font2, Brushes.Black, x, y)
        y += lineheight

        'writes the date and time
        lineheight = Me.lblTime.Font.GetHeight(e.Graphics)
        e.Graphics.DrawString("         " + lblTime.Text, font2, Brushes.Black, x, y)
        y += lineheight

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'print the receipt
        If Me.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.PrintDocument1.Print()
        End If
    End Sub
End Class