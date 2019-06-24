'Imports System.Data.OleDb
Public Class UpdateInfo
    'Dim connection As OleDb.OleDbConnection
    'Dim query As String
    'Dim dataset As New DataSet
    'Dim dataadapter As New OleDb.OleDbDataAdapter()
    Sub ConnectToDataBase()

        'Build a connection String
        'connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " &
        '"Data Source=SystemDB.accdb;")
        'open the connection
        ' connection.Open()

    End Sub

    Sub DisconnectFromDataBase()
        'closes connection
        'connection.Close()
    End Sub
    Sub GetProducts()

        'buil query
        'query = "SELECT * FROM Products ORDER BY Barcode"

        ' pass the sql string and connection object to the data adapter
        'dataadapter = New OleDb.OleDbDataAdapter(query, connection)
        'fill the dataset with records of from the database table
        'dataadapter.Fill(dataset, "SystemDB")

    End Sub
    Private Sub UpdateInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDBDataSet.Products' table. You can move, or remove it, as needed.
        'ConnectToDataBase()
        'GetProducts()
        'dataGridViewProducts.DataSource = dataset.Tables(0)
        ' dataset = Nothing
        'dataadapter = Nothing
        ' DisconnectFromDataBase()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dataGridViewProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewProducts.CellContentClick
        'Dim row As DataGridViewRow = dataGridViewProducts.CurrentRow
        'txtName.Text = row.Cells(1).Value.ToString
        'txtBP.Text = row.Cells(2).Value.ToString
        'txtSP.Text = row.Cells(3).Value.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Dim row1 As DataGridViewRow = dataGridViewProducts.CurrentRow
    End Sub
End Class