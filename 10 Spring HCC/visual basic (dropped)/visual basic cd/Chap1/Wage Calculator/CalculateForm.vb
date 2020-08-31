Option Strict Off

Public Class CalculateForm
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
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnCalcGrossPay As System.Windows.Forms.Button
	Public WithEvents txtPayRate As System.Windows.Forms.TextBox
	Public WithEvents txtHoursWorked As System.Windows.Forms.TextBox
	Public WithEvents lblGrossPay As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.btnClose = New System.Windows.Forms.Button
		Me.btnCalcGrossPay = New System.Windows.Forms.Button
		Me.txtPayRate = New System.Windows.Forms.TextBox
		Me.txtHoursWorked = New System.Windows.Forms.TextBox
		Me.lblGrossPay = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.SystemColors.Control
		Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClose.Location = New System.Drawing.Point(171, 139)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClose.Size = New System.Drawing.Size(81, 40)
		Me.btnClose.TabIndex = 23
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'btnCalcGrossPay
		'
		Me.btnCalcGrossPay.BackColor = System.Drawing.SystemColors.Control
		Me.btnCalcGrossPay.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCalcGrossPay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalcGrossPay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCalcGrossPay.Location = New System.Drawing.Point(83, 139)
		Me.btnCalcGrossPay.Name = "btnCalcGrossPay"
		Me.btnCalcGrossPay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCalcGrossPay.Size = New System.Drawing.Size(81, 40)
		Me.btnCalcGrossPay.TabIndex = 22
		Me.btnCalcGrossPay.Text = "Calculate Gross Pay"
		Me.btnCalcGrossPay.UseVisualStyleBackColor = False
		'
		'txtPayRate
		'
		Me.txtPayRate.AcceptsReturn = True
		Me.txtPayRate.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayRate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayRate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayRate.Location = New System.Drawing.Point(171, 51)
		Me.txtPayRate.MaxLength = 0
		Me.txtPayRate.Name = "txtPayRate"
		Me.txtPayRate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayRate.Size = New System.Drawing.Size(73, 25)
		Me.txtPayRate.TabIndex = 19
		'
		'txtHoursWorked
		'
		Me.txtHoursWorked.AcceptsReturn = True
		Me.txtHoursWorked.BackColor = System.Drawing.SystemColors.Window
		Me.txtHoursWorked.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHoursWorked.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHoursWorked.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHoursWorked.Location = New System.Drawing.Point(171, 11)
		Me.txtHoursWorked.MaxLength = 0
		Me.txtHoursWorked.Name = "txtHoursWorked"
		Me.txtHoursWorked.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHoursWorked.Size = New System.Drawing.Size(73, 25)
		Me.txtHoursWorked.TabIndex = 17
		'
		'lblGrossPay
		'
		Me.lblGrossPay.BackColor = System.Drawing.SystemColors.Control
		Me.lblGrossPay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGrossPay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrossPay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGrossPay.Location = New System.Drawing.Point(171, 99)
		Me.lblGrossPay.Name = "lblGrossPay"
		Me.lblGrossPay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGrossPay.Size = New System.Drawing.Size(73, 17)
		Me.lblGrossPay.TabIndex = 21
		Me.lblGrossPay.Text = "$ 0.00"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(59, 99)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(96, 17)
		Me.Label3.TabIndex = 20
		Me.Label3.Text = "Gross Pay Earned"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(59, 59)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(96, 17)
		Me.Label2.TabIndex = 18
		Me.Label2.Text = "Hourly Pay Rate"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(35, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(129, 17)
		Me.Label1.TabIndex = 16
		Me.Label1.Text = "Number of Hours Worked"
		'
		'Form1
		'
		Me.ClientSize = New System.Drawing.Size(286, 193)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnCalcGrossPay)
		Me.Controls.Add(Me.txtPayRate)
		Me.Controls.Add(Me.txtHoursWorked)
		Me.Controls.Add(Me.lblGrossPay)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Wage Calculator"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub btnCalcGrossPay_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnCalcGrossPay.Click

		' Declare variables we will use in the calculations.
		Dim dblHoursWorked As Double
		Dim dblPayRate As Double
		Dim dblGrossPay As Double

		' Get the hours worked from the TextBox control.
		dblHoursWorked = txtHoursWorked.Text

		' Get the hourly pay rate from the TextBox control.
		dblPayRate = txtPayRate.Text

		' Calculate the employee's gross pay.
		dblGrossPay = dblHoursWorked * dblPayRate

		' Assign the gross pay to a Label control,
		' with currency formatting.
		lblGrossPay.Text = dblGrossPay.ToString("c")

	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnClose.Click

		' End the application by closing its window.
		Me.Close()

	End Sub

End Class
