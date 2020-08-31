Public Class frmGeneral
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
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents radSectionC As System.Windows.Forms.RadioButton
	Public WithEvents radSectionB As System.Windows.Forms.RadioButton
	Public WithEvents radSectionA As System.Windows.Forms.RadioButton
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnCalculate As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents lblTickets As System.Windows.Forms.Label
	Public WithEvents lblTax As System.Windows.Forms.Label
	Public WithEvents lblTotal As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtNumTickets As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.radSectionC = New System.Windows.Forms.RadioButton
        Me.radSectionB = New System.Windows.Forms.RadioButton
        Me.radSectionA = New System.Windows.Forms.RadioButton
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTickets = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtNumTickets = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.radSectionC)
        Me.Frame3.Controls.Add(Me.radSectionB)
        Me.Frame3.Controls.Add(Me.radSectionA)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(16, 88)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(105, 105)
        Me.Frame3.TabIndex = 1
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Section"
        '
        'radSectionC
        '
        Me.radSectionC.BackColor = System.Drawing.SystemColors.Control
        Me.radSectionC.Cursor = System.Windows.Forms.Cursors.Default
        Me.radSectionC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSectionC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radSectionC.Location = New System.Drawing.Point(15, 73)
        Me.radSectionC.Name = "radSectionC"
        Me.radSectionC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radSectionC.Size = New System.Drawing.Size(73, 25)
        Me.radSectionC.TabIndex = 2
        Me.radSectionC.Text = "Section C"
        Me.radSectionC.UseVisualStyleBackColor = False
        '
        'radSectionB
        '
        Me.radSectionB.BackColor = System.Drawing.SystemColors.Control
        Me.radSectionB.Cursor = System.Windows.Forms.Cursors.Default
        Me.radSectionB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSectionB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radSectionB.Location = New System.Drawing.Point(15, 45)
        Me.radSectionB.Name = "radSectionB"
        Me.radSectionB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radSectionB.Size = New System.Drawing.Size(73, 25)
        Me.radSectionB.TabIndex = 1
        Me.radSectionB.Text = "Section B"
        Me.radSectionB.UseVisualStyleBackColor = False
        '
        'radSectionA
        '
        Me.radSectionA.BackColor = System.Drawing.SystemColors.Control
        Me.radSectionA.Checked = True
        Me.radSectionA.Cursor = System.Windows.Forms.Cursors.Default
        Me.radSectionA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSectionA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radSectionA.Location = New System.Drawing.Point(15, 18)
        Me.radSectionA.Name = "radSectionA"
        Me.radSectionA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radSectionA.Size = New System.Drawing.Size(73, 25)
        Me.radSectionA.TabIndex = 0
        Me.radSectionA.TabStop = True
        Me.radSectionA.Text = "Section A"
        Me.radSectionA.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(145, 214)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(58, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calcula&te"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.lblTickets)
        Me.Frame2.Controls.Add(Me.lblTax)
        Me.Frame2.Controls.Add(Me.lblTotal)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(128, 88)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(145, 105)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Total Cost"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tickets:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tax:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTickets
        '
        Me.lblTickets.BackColor = System.Drawing.SystemColors.Control
        Me.lblTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTickets.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTickets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTickets.Location = New System.Drawing.Point(72, 25)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTickets.Size = New System.Drawing.Size(57, 17)
        Me.lblTickets.TabIndex = 1
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.Control
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTax.Location = New System.Drawing.Point(72, 49)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTax.Size = New System.Drawing.Size(57, 17)
        Me.lblTax.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(72, 73)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(57, 17)
        Me.lblTotal.TabIndex = 5
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtNumTickets)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(257, 65)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "How Many Tickets?"
        '
        'txtNumTickets
        '
        Me.txtNumTickets.AcceptsReturn = True
        Me.txtNumTickets.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumTickets.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumTickets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTickets.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumTickets.Location = New System.Drawing.Point(184, 33)
        Me.txtNumTickets.MaxLength = 0
        Me.txtNumTickets.Name = "txtNumTickets"
        Me.txtNumTickets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumTickets.Size = New System.Drawing.Size(48, 19)
        Me.txtNumTickets.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(78, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number of tickets:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmGeneral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 249)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGeneral"
        Me.Text = "Public Ticket Sales"
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

	' This form processes ticket sales to the general public.

	' Price per seat for each seating section.
	Const decSECTION_A As Decimal = 20
	Const decSECTION_B As Decimal = 15
	Const decSECTION_C As Decimal = 10

	Private Sub btnCalculate_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnCalculate.Click

		' Calculate and display the ticket costs.
		Dim intNumTickets As Integer	 ' Number of tickets purchased
		Dim decTicketCost As Decimal	 ' Ticket price
		Dim decSalesTax As Decimal		 ' Sales tax
		Dim decTotal As Decimal			 ' Total cost

        ' Calculate the cost.
        intNumTickets = CInt(txtNumTickets.Text)
        decTicketCost = intNumTickets * PriceEachTicket()
		decSalesTax = CalcTax(decTicketCost)
		decTotal = decTicketCost + decSalesTax

		' Display the cost.
		lblTickets.Text = decTicketCost.ToString("c")
		lblTax.Text = decSalesTax.ToString("c")
		lblTotal.Text = decTotal.ToString("c")

	End Sub

	Private Function PriceEachTicket() As Decimal

		' Returns the price of each ticket, based on 
		' the seating section chosen by the user.

		Dim decPrice As Decimal

		If radSectionA.Checked = True Then
			decPrice = decSECTION_A
		ElseIf radSectionB.Checked = True Then
			decPrice = decSECTION_B
		ElseIf radSectionC.Checked = True Then
			decPrice = decSECTION_C
		End If

		Return decPrice

	End Function

	Private Sub txtNumTickets_Validating(ByVal sender As Object, _
		 ByVal e As System.ComponentModel.CancelEventArgs) _
		 Handles txtNumTickets.Validating

		' Ensure that the user entered a number.

		If Not IsNumeric(txtNumTickets.Text) Then
			MessageBox.Show("Enter a numeric value for " & _
								 "the number of tickets.")
			With txtNumTickets
				.SelectionStart = 0
				.SelectionLength = .Text.Length
				.Focus()
			End With
			e.Cancel = True
		Else
			e.Cancel = False
		End If

	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnClose.Click

		' Close the form
		Me.Close()

	End Sub

End Class
