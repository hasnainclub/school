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
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
	Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
	Friend WithEvents lblResult As System.Windows.Forms.Label
	Friend WithEvents lblOperation As System.Windows.Forms.Label
	Friend WithEvents btnPlus As System.Windows.Forms.Button
	Friend WithEvents btnMinus As System.Windows.Forms.Button
	Friend WithEvents btnMultiply As System.Windows.Forms.Button
	Friend WithEvents btnExponent As System.Windows.Forms.Button
	Friend WithEvents btnDivide As System.Windows.Forms.Button
	Friend WithEvents btnIntegerDivide As System.Windows.Forms.Button
	Friend WithEvents btnMod As System.Windows.Forms.Button
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumber1 = New System.Windows.Forms.TextBox
        Me.txtNumber2 = New System.Windows.Forms.TextBox
        Me.lblResult = New System.Windows.Forms.Label
        Me.lblOperation = New System.Windows.Forms.Label
        Me.btnPlus = New System.Windows.Forms.Button
        Me.btnMinus = New System.Windows.Forms.Button
        Me.btnMultiply = New System.Windows.Forms.Button
        Me.btnExponent = New System.Windows.Forms.Button
        Me.btnDivide = New System.Windows.Forms.Button
        Me.btnIntegerDivide = New System.Windows.Forms.Button
        Me.btnMod = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operation:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number 2:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Result:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumber1
        '
        Me.txtNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber1.Location = New System.Drawing.Point(80, 16)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(96, 21)
        Me.txtNumber1.TabIndex = 4
        '
        'txtNumber2
        '
        Me.txtNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber2.Location = New System.Drawing.Point(80, 112)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(96, 21)
        Me.txtNumber2.TabIndex = 5
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(80, 160)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(96, 23)
        Me.lblResult.TabIndex = 6
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOperation
        '
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.Location = New System.Drawing.Point(102, 55)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(51, 32)
        Me.lblOperation.TabIndex = 7
        Me.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(200, 16)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(32, 25)
        Me.btnPlus.TabIndex = 8
        Me.btnPlus.Text = "+"
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(240, 16)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(32, 25)
        Me.btnMinus.TabIndex = 9
        Me.btnMinus.Text = "-"
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(280, 16)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(32, 25)
        Me.btnMultiply.TabIndex = 10
        Me.btnMultiply.Text = "*"
        '
        'btnExponent
        '
        Me.btnExponent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExponent.Location = New System.Drawing.Point(200, 48)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(32, 25)
        Me.btnExponent.TabIndex = 11
        Me.btnExponent.Text = "^"
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(240, 48)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(32, 25)
        Me.btnDivide.TabIndex = 12
        Me.btnDivide.Text = "/"
        '
        'btnIntegerDivide
        '
        Me.btnIntegerDivide.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntegerDivide.Location = New System.Drawing.Point(280, 48)
        Me.btnIntegerDivide.Name = "btnIntegerDivide"
        Me.btnIntegerDivide.Size = New System.Drawing.Size(32, 25)
        Me.btnIntegerDivide.TabIndex = 13
        Me.btnIntegerDivide.Text = "\"
        '
        'btnMod
        '
        Me.btnMod.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(232, 80)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(48, 25)
        Me.btnMod.TabIndex = 14
        Me.btnMod.Text = "MOD"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(216, 120)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        '
        'CalculateForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 198)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIntegerDivide)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculateForm"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

	Private Sub btnPlus_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnPlus.Click

		' Perform addition
		Dim dblResult As Double
		lblOperation.Text = "+"
		dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)
        lblResult.Text = CStr(dblResult)

	End Sub

	Private Sub btnMinus_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnMinus.Click

		' Perform subtraction
		Dim dblResult As Double
		lblOperation.Text = "-"
		dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)
        lblResult.Text = CStr(dblResult)

	End Sub

	Private Sub btnMultiply_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnMultiply.Click

		' Perform multiplication
		Dim dblResult As Double
		lblOperation.Text = "*"
		dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)
        lblResult.Text = CStr(dblResult)

	End Sub

	Private Sub btnExponent_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnExponent.Click

		' Raise a number to a power
		Dim dblResult As Double
		lblOperation.Text = "^"
		dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)
        lblResult.Text = CStr(dblResult)

	End Sub

	Private Sub btnDivide_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnDivide.Click

		' Perform floating-point division
		Dim dblResult As Double
		lblOperation.Text = "/"
		dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)
        lblResult.Text = CStr(dblResult)

	End Sub

	Private Sub btnIntegerDivide_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnIntegerDivide.Click

		' Perform integer division
		Dim intResult As Integer
		lblOperation.Text = "\"
		intResult = CInt(txtNumber1.Text) \ CInt(txtNumber2.Text)
        lblResult.Text = CStr(intResult)

	End Sub

	Private Sub btnMod_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnMod.Click

		' Perform modulus division with integers
		Dim intResult As Integer
		lblOperation.Text = "MOD"
		intResult = CInt(txtNumber1.Text) Mod CInt(txtNumber2.Text)
        lblResult.Text = CStr(intResult)

	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnClear.Click

		' Clear the numbers
		txtNumber1.Clear()
		txtNumber2.Clear()
		lblResult.Text = String.Empty

		' Clear the operation label
		lblOperation.Text = String.Empty

		' Reset the focus
		txtNumber1.Focus()

	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnExit.Click

		' End the application by closing the window
		Me.Close()

	End Sub

End Class
