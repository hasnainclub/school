Option Strict On

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
	Public WithEvents txtAdvancePayAmount As System.Windows.Forms.TextBox
	Public WithEvents btnClear As System.Windows.Forms.Button
	Public WithEvents btnExit As System.Windows.Forms.Button
	Public WithEvents btnCalculate As System.Windows.Forms.Button
	Public WithEvents txtSalesAmount As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents lblNetPay As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents lblCommissionAmount As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lblCommissionRate As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.txtAdvancePayAmount = New System.Windows.Forms.TextBox
		Me.btnClear = New System.Windows.Forms.Button
		Me.btnExit = New System.Windows.Forms.Button
		Me.btnCalculate = New System.Windows.Forms.Button
		Me.txtSalesAmount = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.lblNetPay = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.lblCommissionAmount = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.lblCommissionRate = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblErrorMessage = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'txtAdvancePayAmount
		'
		Me.txtAdvancePayAmount.AcceptsReturn = True
		Me.txtAdvancePayAmount.BackColor = System.Drawing.SystemColors.Window
		Me.txtAdvancePayAmount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAdvancePayAmount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAdvancePayAmount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAdvancePayAmount.Location = New System.Drawing.Point(174, 48)
		Me.txtAdvancePayAmount.MaxLength = 0
		Me.txtAdvancePayAmount.Name = "txtAdvancePayAmount"
		Me.txtAdvancePayAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAdvancePayAmount.Size = New System.Drawing.Size(81, 25)
		Me.txtAdvancePayAmount.TabIndex = 16
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.SystemColors.Control
		Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClear.Location = New System.Drawing.Point(110, 192)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 18
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.SystemColors.Control
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnExit.Location = New System.Drawing.Point(198, 192)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 19
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'btnCalculate
		'
		Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
		Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCalculate.Location = New System.Drawing.Point(22, 192)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
		Me.btnCalculate.TabIndex = 17
		Me.btnCalculate.Text = "&Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = False
		'
		'txtSalesAmount
		'
		Me.txtSalesAmount.AcceptsReturn = True
		Me.txtSalesAmount.BackColor = System.Drawing.SystemColors.Window
		Me.txtSalesAmount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSalesAmount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSalesAmount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSalesAmount.Location = New System.Drawing.Point(174, 16)
		Me.txtSalesAmount.MaxLength = 0
		Me.txtSalesAmount.Name = "txtSalesAmount"
		Me.txtSalesAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSalesAmount.Size = New System.Drawing.Size(81, 25)
		Me.txtSalesAmount.TabIndex = 14
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(110, 156)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(49, 17)
		Me.Label6.TabIndex = 25
		Me.Label6.Text = "Net Pay:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblNetPay
		'
		Me.lblNetPay.BackColor = System.Drawing.SystemColors.Control
		Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNetPay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNetPay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNetPay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNetPay.Location = New System.Drawing.Point(174, 152)
		Me.lblNetPay.Name = "lblNetPay"
		Me.lblNetPay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNetPay.Size = New System.Drawing.Size(81, 25)
		Me.lblNetPay.TabIndex = 24
		Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(14, 51)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(145, 16)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "Advance pay awarded:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblCommissionAmount
		'
		Me.lblCommissionAmount.BackColor = System.Drawing.SystemColors.Control
		Me.lblCommissionAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCommissionAmount.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCommissionAmount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCommissionAmount.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCommissionAmount.Location = New System.Drawing.Point(174, 120)
		Me.lblCommissionAmount.Name = "lblCommissionAmount"
		Me.lblCommissionAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCommissionAmount.Size = New System.Drawing.Size(81, 25)
		Me.lblCommissionAmount.TabIndex = 23
		Me.lblCommissionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(82, 123)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(77, 17)
		Me.Label3.TabIndex = 22
		Me.Label3.Text = "Commission:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblCommissionRate
		'
		Me.lblCommissionRate.BackColor = System.Drawing.SystemColors.Control
		Me.lblCommissionRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCommissionRate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCommissionRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCommissionRate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCommissionRate.Location = New System.Drawing.Point(174, 88)
		Me.lblCommissionRate.Name = "lblCommissionRate"
		Me.lblCommissionRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCommissionRate.Size = New System.Drawing.Size(81, 25)
		Me.lblCommissionRate.TabIndex = 21
		Me.lblCommissionRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(52, 93)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(107, 15)
		Me.Label2.TabIndex = 20
		Me.Label2.Text = "Commission Rate:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(12, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(145, 16)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Sales for the month:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblErrorMessage
		'
		Me.lblErrorMessage.BackColor = System.Drawing.Color.Yellow
		Me.lblErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblErrorMessage.Location = New System.Drawing.Point(14, 222)
		Me.lblErrorMessage.Name = "lblErrorMessage"
		Me.lblErrorMessage.Size = New System.Drawing.Size(262, 20)
		Me.lblErrorMessage.TabIndex = 26
		Me.lblErrorMessage.Visible = False
		'
		'Form1
		'
		Me.AcceptButton = Me.btnCalculate
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.CancelButton = Me.btnExit
		Me.ClientSize = New System.Drawing.Size(288, 250)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblErrorMessage)
		Me.Controls.Add(Me.txtAdvancePayAmount)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.txtSalesAmount)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.lblNetPay)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.lblCommissionAmount)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.lblCommissionRate)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Crazy Al's Commission Calculator"
		Me.ResumeLayout(False)

	End Sub

#End Region

	' This application calculates commission and net pay for
	' salespeople at Crazy Al's Computer Emporium.
	' The commission rate is determined by the amount
	' of sales, according to the following table:
	'
	' Sales                 Commission Rate
	'---------------------------------------
	' less than $10,000     5%
	' $10,000 - $14,999     10%
	' $15,000 - $17,999     12%
	' $18,000 - 21,999      14%
	' $22,000 or more       15%
	'
	' Each salesperson is allowed to take up to $1500 per
	' month as an advance. The net pay is the sales commission
	' minus any advance pay taken.

	Private Sub btnCalculate_Click(ByVal eventSender As System.Object, _
	 ByVal eventArgs As System.EventArgs) Handles btnCalculate.Click

		' Determine the commision rate, commission amount,
		' and net pay.

		Dim decSalesAmount As Decimal			' Monthly sales amount
		Dim decAdvancePayAmount As Decimal		' Advance pay taken
		Dim decCommissionRate As Decimal		' Commission rate
		Dim decCommissionAmount As Decimal		' Commission
		Dim decNetPay As Decimal				' Net pay

		If IsNumeric(txtSalesAmount.Text) = False Then
			lblErrorMessage.Text = "Sales amount must be numeric"
			lblErrorMessage.Visible = True
			Return
		End If

		If IsNumeric(txtAdvancePayAmount.Text) = False Then
			lblErrorMessage.Text = "Advance pay amount must be numeric"
			lblErrorMessage.Visible = True
			Return
		End If

        ' Past this point, the user inputs contain decimal
		' values. Hide the error message label and do the calculations.

		lblErrorMessage.Visible = False

		decSalesAmount = CDec(txtSalesAmount.Text)
		decAdvancePayAmount = CDec(txtAdvancePayAmount.Text)

		' Determine the commission rate. Constants are in Decimal format.
		Select Case decSalesAmount

			Case Is < 10000
				decCommissionRate = 0.05D

			Case 10000 To 14999
				decCommissionRate = 0.1D

			Case 15000 To 17999
				decCommissionRate = 0.12D

			Case 18000 To 21999
				decCommissionRate = 0.14D

			Case Is >= 22000
				decCommissionRate = 0.15D

		End Select

		' Calculate the commission and net pay amounts.
		decCommissionAmount = decSalesAmount * decCommissionRate
		decNetPay = decCommissionAmount - decAdvancePayAmount

		' Display the rate, commission, and net pay.
		lblCommissionRate.Text = FormatPercent(decCommissionRate)
		lblCommissionAmount.Text = FormatCurrency(decCommissionAmount)
		lblNetPay.Text = FormatCurrency(decNetPay)
	End Sub

	Private Sub btnClear_Click(ByVal eventSender As System.Object, _
	 ByVal eventArgs As System.EventArgs) Handles btnClear.Click

		' Reset the Text Box and Labels.
		txtSalesAmount.Clear()
		txtAdvancePayAmount.Clear()
		lblCommissionRate.Text = String.Empty
		lblCommissionAmount.Text = String.Empty
		lblNetPay.Text = String.Empty

		' Reset the focus.
		txtSalesAmount.Focus()
	End Sub

    Private Sub btnExit_Click(ByVal eventSender As System.Object, _
        ByVal eventArgs As System.EventArgs) Handles btnExit.Click

		Me.Close()
    End Sub
End Class
