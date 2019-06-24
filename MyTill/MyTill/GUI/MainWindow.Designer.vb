<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnATS = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.pBoxTransaction = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblTimeANDdate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fDrinks = New System.Windows.Forms.TabPage()
        Me.btnFD8 = New System.Windows.Forms.Button()
        Me.btnFD3 = New System.Windows.Forms.Button()
        Me.btnFD2 = New System.Windows.Forms.Button()
        Me.btnFD7 = New System.Windows.Forms.Button()
        Me.btnFD9 = New System.Windows.Forms.Button()
        Me.btnFD6 = New System.Windows.Forms.Button()
        Me.btnFD5 = New System.Windows.Forms.Button()
        Me.btnFD1 = New System.Windows.Forms.Button()
        Me.btnFD4 = New System.Windows.Forms.Button()
        Me.cDrinks = New System.Windows.Forms.TabPage()
        Me.btnCD3 = New System.Windows.Forms.Button()
        Me.btnCD2 = New System.Windows.Forms.Button()
        Me.btnCD6 = New System.Windows.Forms.Button()
        Me.btnCD1 = New System.Windows.Forms.Button()
        Me.btnCD5 = New System.Windows.Forms.Button()
        Me.btnCD4 = New System.Windows.Forms.Button()
        Me.nDrinks = New System.Windows.Forms.TabPage()
        Me.btnND9 = New System.Windows.Forms.Button()
        Me.btnND6 = New System.Windows.Forms.Button()
        Me.btnND3 = New System.Windows.Forms.Button()
        Me.btnND8 = New System.Windows.Forms.Button()
        Me.btnND5 = New System.Windows.Forms.Button()
        Me.btnND2 = New System.Windows.Forms.Button()
        Me.btnND7 = New System.Windows.Forms.Button()
        Me.btnND4 = New System.Windows.Forms.Button()
        Me.btnND1 = New System.Windows.Forms.Button()
        Me.tabCdrinkMenu = New System.Windows.Forms.TabControl()
        Me.Receipt = New System.Windows.Forms.ListBox()
        Me.lblGBP = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.btnOfferDiscount = New System.Windows.Forms.Button()
        Me.btnResetPrices = New System.Windows.Forms.Button()
        Me.pbUpdateProducts = New System.Windows.Forms.PictureBox()
        Me.btnPayLater = New System.Windows.Forms.Button()
        Me.btnVHistory = New System.Windows.Forms.Button()
        CType(Me.pBoxTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.fDrinks.SuspendLayout()
        Me.cDrinks.SuspendLayout()
        Me.nDrinks.SuspendLayout()
        Me.tabCdrinkMenu.SuspendLayout()
        CType(Me.pbUpdateProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.MyTill.My.Resources.Resources.exit_till
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(969, 20)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 73)
        Me.btnExit.TabIndex = 27
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnATS
        '
        Me.btnATS.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnATS.Location = New System.Drawing.Point(544, 28)
        Me.btnATS.Name = "btnATS"
        Me.btnATS.Size = New System.Drawing.Size(131, 43)
        Me.btnATS.TabIndex = 26
        Me.btnATS.Text = "Access the System"
        Me.btnATS.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(978, 593)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(83, 40)
        Me.btnPay.TabIndex = 23
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(880, 593)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 40)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(787, 593)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(87, 40)
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'pBoxTransaction
        '
        Me.pBoxTransaction.BackColor = System.Drawing.Color.Transparent
        Me.pBoxTransaction.Image = CType(resources.GetObject("pBoxTransaction.Image"), System.Drawing.Image)
        Me.pBoxTransaction.Location = New System.Drawing.Point(15, 28)
        Me.pBoxTransaction.Name = "pBoxTransaction"
        Me.pBoxTransaction.Size = New System.Drawing.Size(141, 73)
        Me.pBoxTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxTransaction.TabIndex = 17
        Me.pBoxTransaction.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(193, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 83)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(15, 30)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 18)
        Me.lblUserName.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(420, 28)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(111, 43)
        Me.btnLogOut.TabIndex = 28
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'lblTimeANDdate
        '
        Me.lblTimeANDdate.AutoSize = True
        Me.lblTimeANDdate.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeANDdate.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeANDdate.Location = New System.Drawing.Point(696, 37)
        Me.lblTimeANDdate.Name = "lblTimeANDdate"
        Me.lblTimeANDdate.Size = New System.Drawing.Size(0, 29)
        Me.lblTimeANDdate.TabIndex = 29
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'fDrinks
        '
        Me.fDrinks.Controls.Add(Me.btnFD8)
        Me.fDrinks.Controls.Add(Me.btnFD3)
        Me.fDrinks.Controls.Add(Me.btnFD2)
        Me.fDrinks.Controls.Add(Me.btnFD7)
        Me.fDrinks.Controls.Add(Me.btnFD9)
        Me.fDrinks.Controls.Add(Me.btnFD6)
        Me.fDrinks.Controls.Add(Me.btnFD5)
        Me.fDrinks.Controls.Add(Me.btnFD1)
        Me.fDrinks.Controls.Add(Me.btnFD4)
        Me.fDrinks.Location = New System.Drawing.Point(4, 38)
        Me.fDrinks.Name = "fDrinks"
        Me.fDrinks.Padding = New System.Windows.Forms.Padding(3)
        Me.fDrinks.Size = New System.Drawing.Size(758, 425)
        Me.fDrinks.TabIndex = 2
        Me.fDrinks.Text = "Fizzy Drinks"
        Me.fDrinks.UseVisualStyleBackColor = True
        '
        'btnFD8
        '
        Me.btnFD8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD8.Location = New System.Drawing.Point(281, 312)
        Me.btnFD8.Name = "btnFD8"
        Me.btnFD8.Size = New System.Drawing.Size(206, 93)
        Me.btnFD8.TabIndex = 11
        Me.btnFD8.Text = "Button1"
        Me.btnFD8.UseVisualStyleBackColor = True
        '
        'btnFD3
        '
        Me.btnFD3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD3.Location = New System.Drawing.Point(537, 20)
        Me.btnFD3.Name = "btnFD3"
        Me.btnFD3.Size = New System.Drawing.Size(206, 93)
        Me.btnFD3.TabIndex = 10
        Me.btnFD3.Text = "Button1"
        Me.btnFD3.UseVisualStyleBackColor = True
        '
        'btnFD2
        '
        Me.btnFD2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD2.Location = New System.Drawing.Point(281, 20)
        Me.btnFD2.Name = "btnFD2"
        Me.btnFD2.Size = New System.Drawing.Size(206, 93)
        Me.btnFD2.TabIndex = 6
        Me.btnFD2.Text = "Button66"
        Me.btnFD2.UseVisualStyleBackColor = True
        '
        'btnFD7
        '
        Me.btnFD7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD7.Location = New System.Drawing.Point(31, 312)
        Me.btnFD7.Name = "btnFD7"
        Me.btnFD7.Size = New System.Drawing.Size(206, 93)
        Me.btnFD7.TabIndex = 4
        Me.btnFD7.Text = "Button1"
        Me.btnFD7.UseVisualStyleBackColor = True
        '
        'btnFD9
        '
        Me.btnFD9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD9.Location = New System.Drawing.Point(537, 312)
        Me.btnFD9.Name = "btnFD9"
        Me.btnFD9.Size = New System.Drawing.Size(206, 93)
        Me.btnFD9.TabIndex = 3
        Me.btnFD9.Text = "Button1"
        Me.btnFD9.UseVisualStyleBackColor = True
        '
        'btnFD6
        '
        Me.btnFD6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD6.Location = New System.Drawing.Point(537, 153)
        Me.btnFD6.Name = "btnFD6"
        Me.btnFD6.Size = New System.Drawing.Size(206, 93)
        Me.btnFD6.TabIndex = 3
        Me.btnFD6.Text = "Button1"
        Me.btnFD6.UseVisualStyleBackColor = True
        '
        'btnFD5
        '
        Me.btnFD5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD5.Location = New System.Drawing.Point(281, 153)
        Me.btnFD5.Name = "btnFD5"
        Me.btnFD5.Size = New System.Drawing.Size(206, 93)
        Me.btnFD5.TabIndex = 2
        Me.btnFD5.Text = "Button1"
        Me.btnFD5.UseVisualStyleBackColor = True
        '
        'btnFD1
        '
        Me.btnFD1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD1.Location = New System.Drawing.Point(31, 20)
        Me.btnFD1.Name = "btnFD1"
        Me.btnFD1.Size = New System.Drawing.Size(206, 93)
        Me.btnFD1.TabIndex = 23
        Me.btnFD1.Text = "Button1"
        Me.btnFD1.UseVisualStyleBackColor = True
        '
        'btnFD4
        '
        Me.btnFD4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFD4.Location = New System.Drawing.Point(31, 153)
        Me.btnFD4.Name = "btnFD4"
        Me.btnFD4.Size = New System.Drawing.Size(206, 93)
        Me.btnFD4.TabIndex = 24
        Me.btnFD4.Text = "Button1"
        Me.btnFD4.UseVisualStyleBackColor = True
        '
        'cDrinks
        '
        Me.cDrinks.Controls.Add(Me.btnCD3)
        Me.cDrinks.Controls.Add(Me.btnCD2)
        Me.cDrinks.Controls.Add(Me.btnCD6)
        Me.cDrinks.Controls.Add(Me.btnCD1)
        Me.cDrinks.Controls.Add(Me.btnCD5)
        Me.cDrinks.Controls.Add(Me.btnCD4)
        Me.cDrinks.Location = New System.Drawing.Point(4, 38)
        Me.cDrinks.Name = "cDrinks"
        Me.cDrinks.Padding = New System.Windows.Forms.Padding(3)
        Me.cDrinks.Size = New System.Drawing.Size(758, 425)
        Me.cDrinks.TabIndex = 1
        Me.cDrinks.Text = "Coffee"
        Me.cDrinks.UseVisualStyleBackColor = True
        '
        'btnCD3
        '
        Me.btnCD3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCD3.Location = New System.Drawing.Point(525, 31)
        Me.btnCD3.Name = "btnCD3"
        Me.btnCD3.Size = New System.Drawing.Size(206, 93)
        Me.btnCD3.TabIndex = 1
        Me.btnCD3.Text = "Button1"
        Me.btnCD3.UseVisualStyleBackColor = True
        '
        'btnCD2
        '
        Me.btnCD2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCD2.Location = New System.Drawing.Point(269, 31)
        Me.btnCD2.Name = "btnCD2"
        Me.btnCD2.Size = New System.Drawing.Size(206, 93)
        Me.btnCD2.TabIndex = 1
        Me.btnCD2.Text = "Button1"
        Me.btnCD2.UseVisualStyleBackColor = True
        '
        'btnCD6
        '
        Me.btnCD6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCD6.Location = New System.Drawing.Point(525, 195)
        Me.btnCD6.Name = "btnCD6"
        Me.btnCD6.Size = New System.Drawing.Size(206, 93)
        Me.btnCD6.TabIndex = 1
        Me.btnCD6.Text = "Button1"
        Me.btnCD6.UseVisualStyleBackColor = True
        '
        'btnCD1
        '
        Me.btnCD1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCD1.Location = New System.Drawing.Point(21, 31)
        Me.btnCD1.Name = "btnCD1"
        Me.btnCD1.Size = New System.Drawing.Size(206, 93)
        Me.btnCD1.TabIndex = 1
        Me.btnCD1.Text = "Button1"
        Me.btnCD1.UseVisualStyleBackColor = True
        '
        'btnCD5
        '
        Me.btnCD5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCD5.Location = New System.Drawing.Point(269, 195)
        Me.btnCD5.Name = "btnCD5"
        Me.btnCD5.Size = New System.Drawing.Size(206, 93)
        Me.btnCD5.TabIndex = 1
        Me.btnCD5.Text = "Button1"
        Me.btnCD5.UseVisualStyleBackColor = True
        '
        'btnCD4
        '
        Me.btnCD4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCD4.Location = New System.Drawing.Point(21, 195)
        Me.btnCD4.Name = "btnCD4"
        Me.btnCD4.Size = New System.Drawing.Size(206, 93)
        Me.btnCD4.TabIndex = 1
        Me.btnCD4.Text = "Button1"
        Me.btnCD4.UseVisualStyleBackColor = True
        '
        'nDrinks
        '
        Me.nDrinks.Controls.Add(Me.btnND9)
        Me.nDrinks.Controls.Add(Me.btnND6)
        Me.nDrinks.Controls.Add(Me.btnND3)
        Me.nDrinks.Controls.Add(Me.btnND8)
        Me.nDrinks.Controls.Add(Me.btnND5)
        Me.nDrinks.Controls.Add(Me.btnND2)
        Me.nDrinks.Controls.Add(Me.btnND7)
        Me.nDrinks.Controls.Add(Me.btnND4)
        Me.nDrinks.Controls.Add(Me.btnND1)
        Me.nDrinks.Location = New System.Drawing.Point(4, 38)
        Me.nDrinks.Name = "nDrinks"
        Me.nDrinks.Padding = New System.Windows.Forms.Padding(3)
        Me.nDrinks.Size = New System.Drawing.Size(758, 425)
        Me.nDrinks.TabIndex = 0
        Me.nDrinks.Text = "Natural Drink"
        Me.nDrinks.UseVisualStyleBackColor = True
        '
        'btnND9
        '
        Me.btnND9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND9.Location = New System.Drawing.Point(535, 265)
        Me.btnND9.Name = "btnND9"
        Me.btnND9.Size = New System.Drawing.Size(206, 93)
        Me.btnND9.TabIndex = 0
        Me.btnND9.Text = "Button1"
        Me.btnND9.UseVisualStyleBackColor = True
        '
        'btnND6
        '
        Me.btnND6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND6.Location = New System.Drawing.Point(535, 147)
        Me.btnND6.Name = "btnND6"
        Me.btnND6.Size = New System.Drawing.Size(206, 93)
        Me.btnND6.TabIndex = 0
        Me.btnND6.Text = "Button1"
        Me.btnND6.UseVisualStyleBackColor = True
        '
        'btnND3
        '
        Me.btnND3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND3.Location = New System.Drawing.Point(535, 16)
        Me.btnND3.Name = "btnND3"
        Me.btnND3.Size = New System.Drawing.Size(206, 93)
        Me.btnND3.TabIndex = 0
        Me.btnND3.Text = "Button1"
        Me.btnND3.UseVisualStyleBackColor = True
        '
        'btnND8
        '
        Me.btnND8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND8.Location = New System.Drawing.Point(286, 265)
        Me.btnND8.Name = "btnND8"
        Me.btnND8.Size = New System.Drawing.Size(206, 93)
        Me.btnND8.TabIndex = 0
        Me.btnND8.Text = "Button1"
        Me.btnND8.UseVisualStyleBackColor = True
        '
        'btnND5
        '
        Me.btnND5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND5.Location = New System.Drawing.Point(286, 147)
        Me.btnND5.Name = "btnND5"
        Me.btnND5.Size = New System.Drawing.Size(206, 93)
        Me.btnND5.TabIndex = 0
        Me.btnND5.Text = "Button1"
        Me.btnND5.UseVisualStyleBackColor = True
        '
        'btnND2
        '
        Me.btnND2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND2.Location = New System.Drawing.Point(286, 16)
        Me.btnND2.Name = "btnND2"
        Me.btnND2.Size = New System.Drawing.Size(206, 93)
        Me.btnND2.TabIndex = 0
        Me.btnND2.Text = "Button1"
        Me.btnND2.UseVisualStyleBackColor = True
        '
        'btnND7
        '
        Me.btnND7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND7.Location = New System.Drawing.Point(44, 265)
        Me.btnND7.Name = "btnND7"
        Me.btnND7.Size = New System.Drawing.Size(206, 93)
        Me.btnND7.TabIndex = 0
        Me.btnND7.Text = "Button1"
        Me.btnND7.UseVisualStyleBackColor = True
        '
        'btnND4
        '
        Me.btnND4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND4.Location = New System.Drawing.Point(44, 147)
        Me.btnND4.Name = "btnND4"
        Me.btnND4.Size = New System.Drawing.Size(206, 93)
        Me.btnND4.TabIndex = 0
        Me.btnND4.Text = "Button1"
        Me.btnND4.UseVisualStyleBackColor = True
        '
        'btnND1
        '
        Me.btnND1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnND1.Location = New System.Drawing.Point(44, 16)
        Me.btnND1.Name = "btnND1"
        Me.btnND1.Size = New System.Drawing.Size(206, 93)
        Me.btnND1.TabIndex = 0
        Me.btnND1.Text = "Button1"
        Me.btnND1.UseVisualStyleBackColor = True
        '
        'tabCdrinkMenu
        '
        Me.tabCdrinkMenu.Controls.Add(Me.nDrinks)
        Me.tabCdrinkMenu.Controls.Add(Me.cDrinks)
        Me.tabCdrinkMenu.Controls.Add(Me.fDrinks)
        Me.tabCdrinkMenu.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCdrinkMenu.Location = New System.Drawing.Point(15, 124)
        Me.tabCdrinkMenu.Name = "tabCdrinkMenu"
        Me.tabCdrinkMenu.SelectedIndex = 0
        Me.tabCdrinkMenu.Size = New System.Drawing.Size(766, 467)
        Me.tabCdrinkMenu.TabIndex = 18
        '
        'Receipt
        '
        Me.Receipt.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt.FormattingEnabled = True
        Me.Receipt.ItemHeight = 20
        Me.Receipt.Location = New System.Drawing.Point(793, 162)
        Me.Receipt.Name = "Receipt"
        Me.Receipt.Size = New System.Drawing.Size(274, 324)
        Me.Receipt.TabIndex = 30
        '
        'lblGBP
        '
        Me.lblGBP.AutoSize = True
        Me.lblGBP.BackColor = System.Drawing.Color.Transparent
        Me.lblGBP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGBP.Location = New System.Drawing.Point(995, 138)
        Me.lblGBP.Name = "lblGBP"
        Me.lblGBP.Size = New System.Drawing.Size(52, 21)
        Me.lblGBP.TabIndex = 31
        Me.lblGBP.Text = "GBP"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(787, 531)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 34)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = "Total"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.BackColor = System.Drawing.Color.Transparent
        Me.lblCash.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(982, 539)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(0, 24)
        Me.lblCash.TabIndex = 33
        '
        'btnOfferDiscount
        '
        Me.btnOfferDiscount.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOfferDiscount.Location = New System.Drawing.Point(382, 593)
        Me.btnOfferDiscount.Name = "btnOfferDiscount"
        Me.btnOfferDiscount.Size = New System.Drawing.Size(395, 40)
        Me.btnOfferDiscount.TabIndex = 34
        Me.btnOfferDiscount.Text = "Offer Discount"
        Me.btnOfferDiscount.UseVisualStyleBackColor = True
        '
        'btnResetPrices
        '
        Me.btnResetPrices.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPrices.Location = New System.Drawing.Point(19, 593)
        Me.btnResetPrices.Name = "btnResetPrices"
        Me.btnResetPrices.Size = New System.Drawing.Size(357, 40)
        Me.btnResetPrices.TabIndex = 34
        Me.btnResetPrices.Text = "Reset Prices"
        Me.btnResetPrices.UseVisualStyleBackColor = True
        '
        'pbUpdateProducts
        '
        Me.pbUpdateProducts.BackColor = System.Drawing.Color.Transparent
        Me.pbUpdateProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUpdateProducts.Image = CType(resources.GetObject("pbUpdateProducts.Image"), System.Drawing.Image)
        Me.pbUpdateProducts.Location = New System.Drawing.Point(420, 77)
        Me.pbUpdateProducts.Name = "pbUpdateProducts"
        Me.pbUpdateProducts.Size = New System.Drawing.Size(111, 50)
        Me.pbUpdateProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUpdateProducts.TabIndex = 35
        Me.pbUpdateProducts.TabStop = False
        '
        'btnPayLater
        '
        Me.btnPayLater.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayLater.Location = New System.Drawing.Point(929, 639)
        Me.btnPayLater.Name = "btnPayLater"
        Me.btnPayLater.Size = New System.Drawing.Size(132, 41)
        Me.btnPayLater.TabIndex = 36
        Me.btnPayLater.Text = "Pay Later"
        Me.btnPayLater.UseVisualStyleBackColor = True
        '
        'btnVHistory
        '
        Me.btnVHistory.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVHistory.Location = New System.Drawing.Point(787, 639)
        Me.btnVHistory.Name = "btnVHistory"
        Me.btnVHistory.Size = New System.Drawing.Size(132, 41)
        Me.btnVHistory.TabIndex = 36
        Me.btnVHistory.Text = "View History"
        Me.btnVHistory.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVHistory)
        Me.Controls.Add(Me.btnPayLater)
        Me.Controls.Add(Me.pbUpdateProducts)
        Me.Controls.Add(Me.btnResetPrices)
        Me.Controls.Add(Me.btnOfferDiscount)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblGBP)
        Me.Controls.Add(Me.Receipt)
        Me.Controls.Add(Me.lblTimeANDdate)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnATS)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.tabCdrinkMenu)
        Me.Controls.Add(Me.pBoxTransaction)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TILL SYSTEM"
        CType(Me.pBoxTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.fDrinks.ResumeLayout(False)
        Me.cDrinks.ResumeLayout(False)
        Me.nDrinks.ResumeLayout(False)
        Me.tabCdrinkMenu.ResumeLayout(False)
        CType(Me.pbUpdateProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnATS As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents pBoxTransaction As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lblTimeANDdate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents fDrinks As System.Windows.Forms.TabPage
    Friend WithEvents btnFD8 As System.Windows.Forms.Button
    Friend WithEvents btnFD3 As System.Windows.Forms.Button
    Friend WithEvents btnFD2 As System.Windows.Forms.Button
    Friend WithEvents btnFD7 As System.Windows.Forms.Button
    Friend WithEvents btnFD9 As System.Windows.Forms.Button
    Friend WithEvents btnFD6 As System.Windows.Forms.Button
    Friend WithEvents btnFD5 As System.Windows.Forms.Button
    Friend WithEvents btnFD1 As System.Windows.Forms.Button
    Friend WithEvents btnFD4 As System.Windows.Forms.Button
    Friend WithEvents cDrinks As System.Windows.Forms.TabPage
    Friend WithEvents btnCD3 As System.Windows.Forms.Button
    Friend WithEvents btnCD2 As System.Windows.Forms.Button
    Friend WithEvents btnCD6 As System.Windows.Forms.Button
    Friend WithEvents btnCD1 As System.Windows.Forms.Button
    Friend WithEvents btnCD5 As System.Windows.Forms.Button
    Friend WithEvents btnCD4 As System.Windows.Forms.Button
    Friend WithEvents nDrinks As System.Windows.Forms.TabPage
    Friend WithEvents btnND9 As System.Windows.Forms.Button
    Friend WithEvents btnND6 As System.Windows.Forms.Button
    Friend WithEvents btnND3 As System.Windows.Forms.Button
    Friend WithEvents btnND8 As System.Windows.Forms.Button
    Friend WithEvents btnND5 As System.Windows.Forms.Button
    Friend WithEvents btnND2 As System.Windows.Forms.Button
    Friend WithEvents btnND7 As System.Windows.Forms.Button
    Friend WithEvents btnND4 As System.Windows.Forms.Button
    Friend WithEvents btnND1 As System.Windows.Forms.Button
    Friend WithEvents tabCdrinkMenu As System.Windows.Forms.TabControl
    Friend WithEvents Receipt As System.Windows.Forms.ListBox
    Friend WithEvents lblGBP As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents btnOfferDiscount As System.Windows.Forms.Button
    Friend WithEvents btnResetPrices As System.Windows.Forms.Button
    Friend WithEvents pbUpdateProducts As System.Windows.Forms.PictureBox
    Friend WithEvents btnPayLater As System.Windows.Forms.Button
    Friend WithEvents btnVHistory As System.Windows.Forms.Button

End Class
