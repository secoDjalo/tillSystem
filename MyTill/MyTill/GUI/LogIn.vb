Imports System.IO

Public Class LogIn
    'holds the value for the textbox username
    Dim EnteredValue As String

    'holds the value for the textbox password
    Dim teste As String

    'holds a value for the focused textbox
    Dim i As Integer

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.Image = My.Resources.Close3a
    End Sub

    Private Sub btnCancel_MouseHover(sender As Object, e As EventArgs) Handles btnCancel.MouseHover
        btnCancel.Image = My.Resources.Close3b
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "q"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "q"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "w"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "w"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "e"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "e"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "r"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "r"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "t"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "t"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "y"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "y"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "7"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "7"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "8"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "8"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "9"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "9"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "u"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "u"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "i"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "i"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "o"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "o"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "p"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "p"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "a"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "a"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "s"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "s"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "4"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "4"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "5"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "5"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "6"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "6"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "d"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "d"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "f"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "f"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "g"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "g"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "h"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "h"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "j"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "j"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "k"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "k"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "1"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "1"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "2"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "2"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "3"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "3"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "l"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "l"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "z"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "z"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "x"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "x"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "c"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "c"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "v"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "v"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "b"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "b"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "n"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "n"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "m"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "m"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If i = 0 Then
            EnteredValue = EnteredValue + "0"
            txtBoxUserName.Text = EnteredValue
        ElseIf i = 1 Then
            teste = teste + "0"
            txtBoxPassword.Text = teste
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtBoxUserName.Clear()
        txtBoxPassword.Clear()
        EnteredValue = ""
        teste = ""
        txtBoxUserName.Focus()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxUserName.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainWindow.Show()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        'validation of the textboxes
        If txtBoxUserName.Text = "" Then
            MsgBox("Please enter your name", MsgBoxStyle.Information, "Information")
        ElseIf txtBoxPassword.Text = "" Then
            MsgBox("Please enter your password", MsgBoxStyle.Information, "Information")
        Else

            'checking if user exists in the DB
            'connection to the DataBase

            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SystemDB.accdb;"
            Try

                'this variable holds the values from the DB
                Dim sql As String = "SELECT * FROM [User] WHERE UserName='" & txtBoxUserName.Text &
                    "' AND Password = '" & txtBoxPassword.Text & "'"
                Dim sqlCommand As New System.Data.OleDb.OleDbCommand(sql)
                'Open Database connection
                sqlCommand.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCommand.ExecuteReader()

                If sqlRead.Read() Then

                    'Show main window
                    MainWindow.Show()

                    'Hides Log In form(Window)
                    Me.Hide()

                    'Hides button acces system
                    MainWindow.btnATS.Visible = False

                    'Shows All controls of the main window

                    MainWindow.pBoxTransaction.Visible = True
                    MainWindow.GroupBox1.Visible = True
                    MainWindow.btnLogOut.Visible = True
                    MainWindow.tabCdrinkMenu.Visible = True
                    MainWindow.Receipt.Visible = True
                    MainWindow.btnOfferDiscount.Visible = True
                    MainWindow.btnRemove.Visible = True
                    MainWindow.btnClear.Visible = True
                    MainWindow.btnPay.Visible = True
                    MainWindow.lblGBP.Visible = True
                    MainWindow.lblCash.Visible = True
                    MainWindow.lblTotal.Visible = True
                    MainWindow.pbUpdateProducts.Visible = True
                    MainWindow.btnPayLater.Visible = True
                    MainWindow.btnVHistory.Visible = True

                    'clear recipt
                    MainWindow.Receipt.Items.Clear()

                    'Clear label that shows the amount of the sale
                    MainWindow.lblCash.Text = ""

                    'inicialises the variable to 0
                    MainWindow.TotalPrice = 0

                    MainWindow.SelectedItemPrice = 0

                    MainWindow.percentage = 0
                    'selectedItem = ""

                    'Gets the user Name from the DB
                    MainWindow.lblUserName.Text = sqlRead.GetString(1)

                    'This variabale holds the Full name so that it can displayed on the label
                    Dim Uname As String = MainWindow.lblUserName.Text + " " + sqlRead.GetString(2)
                    MainWindow.lblUserName.Text = Uname

                Else
                    'Focus on User Name Field
                    txtBoxUserName.Focus()
                    'if details are incorrect
                    MsgBox("Incorrect details", MsgBoxStyle.OkOnly, "Error")

                    'clear the variables
                    EnteredValue = ""
                    teste = ""

                    'Clears all fields
                    txtBoxUserName.Clear()
                    txtBoxPassword.Clear()

                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database:  " & ex.Message, "Database Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtBoxUserName_Click(sender As Object, e As EventArgs) Handles txtBoxUserName.Click
        i = 0
        txtBoxUserName.BorderStyle = BorderStyle.None
        txtBoxPassword.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub txtBoxPassword_Click(sender As Object, e As EventArgs) Handles txtBoxPassword.Click
        i = 1
        txtBoxPassword.BorderStyle = BorderStyle.None
        txtBoxUserName.BorderStyle = BorderStyle.Fixed3D
    End Sub
End Class


