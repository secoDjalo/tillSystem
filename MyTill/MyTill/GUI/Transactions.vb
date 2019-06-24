Public Class Transactions
    Dim nameoffile As String

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newFont As New Font(New FontFamily("Courier New"), 12) ' Define a fixed-width font for PadRight tabbing.
        ListBox2.Font = newFont ' Employ the fixed-width font in the List Box.

        ' make a reference to a directory
        ' Dim directory As New IO.DirectoryInfo("C:\Users\Administrator\Documents\Visual Studio 2013\Projects\TillSales")
        Dim directory As New IO.DirectoryInfo("TillSales")
        Dim diar1 As IO.FileInfo() = directory.GetFiles()
        Dim info As IO.FileInfo
        'list the names of all files in the specified directory
        For Each info In diar1
            ListBox1.Items.Add(info)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'clears the listbox whenever a name is selected
        ListBox2.Items.Clear()
        'saves the name of the file
        nameoffile = ListBox1.SelectedItem.ToString
        'read the file and writes its to the lisbox
        'ListBox2.Items.AddRange(IO.File.ReadAllLines("C:\Users\Administrator\Documents\Visual Studio 2013\Projects\TillSales\" & nameoffile))
        ListBox2.Items.AddRange(IO.File.ReadAllLines("TillSales\" & nameoffile))
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class