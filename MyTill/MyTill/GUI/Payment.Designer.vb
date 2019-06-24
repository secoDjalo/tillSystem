<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.lblPaymentTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalEntered = New System.Windows.Forms.Label()
        Me.lblChangeToBeGiven = New System.Windows.Forms.Label()
        Me.btnTwoP = New System.Windows.Forms.Button()
        Me.btnFiveP = New System.Windows.Forms.Button()
        Me.btnTenP = New System.Windows.Forms.Button()
        Me.btnFifteenP = New System.Windows.Forms.Button()
        Me.btnTwentyP = New System.Windows.Forms.Button()
        Me.btnThirtyP = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancelSale = New System.Windows.Forms.Button()
        Me.txtAmountSelected = New System.Windows.Forms.TextBox()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalToBePaid = New System.Windows.Forms.Label()
        Me.PaymentReceipt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblPaymentTotal
        '
        Me.lblPaymentTotal.AutoSize = True
        Me.lblPaymentTotal.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentTotal.Location = New System.Drawing.Point(12, 409)
        Me.lblPaymentTotal.Name = "lblPaymentTotal"
        Me.lblPaymentTotal.Size = New System.Drawing.Size(124, 21)
        Me.lblPaymentTotal.TabIndex = 1
        Me.lblPaymentTotal.Text = "Amount Paid"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Change"
        '
        'lblTotalEntered
        '
        Me.lblTotalEntered.AutoSize = True
        Me.lblTotalEntered.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntered.Location = New System.Drawing.Point(240, 409)
        Me.lblTotalEntered.Name = "lblTotalEntered"
        Me.lblTotalEntered.Size = New System.Drawing.Size(0, 21)
        Me.lblTotalEntered.TabIndex = 3
        '
        'lblChangeToBeGiven
        '
        Me.lblChangeToBeGiven.AutoSize = True
        Me.lblChangeToBeGiven.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeToBeGiven.Location = New System.Drawing.Point(240, 436)
        Me.lblChangeToBeGiven.Name = "lblChangeToBeGiven"
        Me.lblChangeToBeGiven.Size = New System.Drawing.Size(0, 21)
        Me.lblChangeToBeGiven.TabIndex = 4
        '
        'btnTwoP
        '
        Me.btnTwoP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwoP.Location = New System.Drawing.Point(503, 290)
        Me.btnTwoP.Name = "btnTwoP"
        Me.btnTwoP.Size = New System.Drawing.Size(80, 48)
        Me.btnTwoP.TabIndex = 5
        Me.btnTwoP.Text = "£2"
        Me.btnTwoP.UseVisualStyleBackColor = True
        '
        'btnFiveP
        '
        Me.btnFiveP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiveP.Location = New System.Drawing.Point(331, 290)
        Me.btnFiveP.Name = "btnFiveP"
        Me.btnFiveP.Size = New System.Drawing.Size(80, 48)
        Me.btnFiveP.TabIndex = 5
        Me.btnFiveP.Text = "£5"
        Me.btnFiveP.UseVisualStyleBackColor = True
        '
        'btnTenP
        '
        Me.btnTenP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTenP.Location = New System.Drawing.Point(331, 344)
        Me.btnTenP.Name = "btnTenP"
        Me.btnTenP.Size = New System.Drawing.Size(80, 48)
        Me.btnTenP.TabIndex = 5
        Me.btnTenP.Text = "£10"
        Me.btnTenP.UseVisualStyleBackColor = True
        '
        'btnFifteenP
        '
        Me.btnFifteenP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFifteenP.Location = New System.Drawing.Point(503, 346)
        Me.btnFifteenP.Name = "btnFifteenP"
        Me.btnFifteenP.Size = New System.Drawing.Size(80, 48)
        Me.btnFifteenP.TabIndex = 5
        Me.btnFifteenP.Text = "£15"
        Me.btnFifteenP.UseVisualStyleBackColor = True
        '
        'btnTwentyP
        '
        Me.btnTwentyP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwentyP.Location = New System.Drawing.Point(417, 290)
        Me.btnTwentyP.Name = "btnTwentyP"
        Me.btnTwentyP.Size = New System.Drawing.Size(80, 48)
        Me.btnTwentyP.TabIndex = 5
        Me.btnTwentyP.Text = "£20"
        Me.btnTwentyP.UseVisualStyleBackColor = True
        '
        'btnThirtyP
        '
        Me.btnThirtyP.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThirtyP.Location = New System.Drawing.Point(417, 344)
        Me.btnThirtyP.Name = "btnThirtyP"
        Me.btnThirtyP.Size = New System.Drawing.Size(80, 48)
        Me.btnThirtyP.TabIndex = 5
        Me.btnThirtyP.Text = "£30"
        Me.btnThirtyP.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(589, 349)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(123, 46)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancelSale
        '
        Me.btnCancelSale.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSale.Location = New System.Drawing.Point(718, 348)
        Me.btnCancelSale.Name = "btnCancelSale"
        Me.btnCancelSale.Size = New System.Drawing.Size(117, 46)
        Me.btnCancelSale.TabIndex = 6
        Me.btnCancelSale.Text = "Cancel"
        Me.btnCancelSale.UseVisualStyleBackColor = True
        '
        'txtAmountSelected
        '
        Me.txtAmountSelected.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountSelected.Location = New System.Drawing.Point(589, 290)
        Me.txtAmountSelected.Multiline = True
        Me.txtAmountSelected.Name = "txtAmountSelected"
        Me.txtAmountSelected.Size = New System.Drawing.Size(246, 48)
        Me.txtAmountSelected.TabIndex = 7
        '
        'btnSix
        '
        Me.btnSix.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(756, 128)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(78, 48)
        Me.btnSix.TabIndex = 6
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(756, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 48)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(672, 128)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(78, 48)
        Me.btnFive.TabIndex = 5
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoint.Location = New System.Drawing.Point(672, 236)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(78, 48)
        Me.btnPoint.TabIndex = 5
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(588, 128)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(78, 48)
        Me.btnFour.TabIndex = 5
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(588, 236)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(78, 48)
        Me.btnZero.TabIndex = 5
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(756, 74)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(78, 48)
        Me.btnNine.TabIndex = 5
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(672, 74)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(78, 48)
        Me.btnEight.TabIndex = 5
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(588, 74)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(78, 48)
        Me.btnSeven.TabIndex = 5
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(756, 182)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(78, 48)
        Me.btnThree.TabIndex = 5
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(672, 182)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(78, 48)
        Me.btnTwo.TabIndex = 5
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(588, 182)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(78, 48)
        Me.btnOne.TabIndex = 5
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total"
        '
        'lblTotalToBePaid
        '
        Me.lblTotalToBePaid.AutoSize = True
        Me.lblTotalToBePaid.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalToBePaid.Location = New System.Drawing.Point(240, 374)
        Me.lblTotalToBePaid.Name = "lblTotalToBePaid"
        Me.lblTotalToBePaid.Size = New System.Drawing.Size(0, 21)
        Me.lblTotalToBePaid.TabIndex = 3
        '
        'PaymentReceipt
        '
        Me.PaymentReceipt.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentReceipt.FormattingEnabled = True
        Me.PaymentReceipt.ItemHeight = 22
        Me.PaymentReceipt.Location = New System.Drawing.Point(12, 7)
        Me.PaymentReceipt.Name = "PaymentReceipt"
        Me.PaymentReceipt.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.PaymentReceipt.Size = New System.Drawing.Size(313, 334)
        Me.PaymentReceipt.TabIndex = 8
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.PaymentReceipt)
        Me.Controls.Add(Me.txtAmountSelected)
        Me.Controls.Add(Me.btnCancelSale)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnTenP)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnFiveP)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnThirtyP)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnTwentyP)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFifteenP)
        Me.Controls.Add(Me.btnTwoP)
        Me.Controls.Add(Me.lblChangeToBeGiven)
        Me.Controls.Add(Me.lblTotalToBePaid)
        Me.Controls.Add(Me.lblTotalEntered)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPaymentTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPaymentTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEntered As System.Windows.Forms.Label
    Friend WithEvents lblChangeToBeGiven As System.Windows.Forms.Label
    Friend WithEvents btnTwoP As System.Windows.Forms.Button
    Friend WithEvents btnFiveP As System.Windows.Forms.Button
    Friend WithEvents btnTenP As System.Windows.Forms.Button
    Friend WithEvents btnFifteenP As System.Windows.Forms.Button
    Friend WithEvents btnTwentyP As System.Windows.Forms.Button
    Friend WithEvents btnThirtyP As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancelSale As System.Windows.Forms.Button
    Friend WithEvents txtAmountSelected As System.Windows.Forms.TextBox
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnPoint As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalToBePaid As System.Windows.Forms.Label
    Friend WithEvents PaymentReceipt As System.Windows.Forms.ListBox
End Class
