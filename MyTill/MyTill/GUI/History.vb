Public Class History
    Dim nameoffile1 As String
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newFont As New Font(New FontFamily("Courier New"), 12) ' Define a fixed-width font for PadRight tabbing.
        RName.Font = newFont ' Employ the fixed-width font in the List Box.

        ' make a reference to a directory
        ' Dim directory As New IO.DirectoryInfo("C:\Users\Administrator\Documents\Visual Studio 2013\Projects\TillSales")
        Dim directory As New IO.DirectoryInfo("TillSalesOnHold")
        Dim diar1 As IO.FileInfo() = directory.GetFiles()
        Dim info As IO.FileInfo
        'list the names of all files in the specified directory
        For Each info In diar1
            RName.Items.Add(info)
        Next
        If RName.Items.Count < 0 Then
            Button1.Hide()
        End If
    End Sub

    Private Sub Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RName.SelectedIndexChanged
        'clears the listbox whenever a name is selected
        Content.Items.Clear()
        'saves the name of the file
        nameoffile1 = RName.SelectedItem.ToString
        'read the file and writes its to the lisbox
        'ListBox2.Items.AddRange(IO.File.ReadAllLines("C:\Users\Administrator\Documents\Visual Studio 2013\Projects\TillSales\" & nameoffile))
        Content.Items.AddRange(IO.File.ReadAllLines("TillSalesOnHold\" & nameoffile1))
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RName.Items.Count - 1 Then
            Me.Close()
            MainWindow.Show()
        End If
        MainWindow.Receipt.Items.AddRange(IO.File.ReadAllLines("TillSalesOnHold\" & nameoffile1))
        MainWindow.Receipt.Items.RemoveAt(MainWindow.Receipt.Items.Count - 1)
        Me.Close()
        IO.File.Delete("TillSalesOnHold\" & nameoffile1)
    End Sub
End Class