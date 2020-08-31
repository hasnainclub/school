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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnCalculate As System.Windows.Forms.Button
    Public WithEvents lblLaborHours As System.Windows.Forms.Label
    Public WithEvents lblTotalPayroll As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstPayData As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstPayData = New System.Windows.Forms.ListBox()
        Me.lblLaborHours = New System.Windows.Forms.Label()
        Me.lblTotalPayroll = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(216, 232)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "E&xit"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(120, 232)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "C&lear"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(24, 232)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.TabIndex = 30
        Me.btnCalculate.Text = "&Calculate"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstPayData})
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(289, 152)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll Data"
        '
        'lstPayData
        '
        Me.lstPayData.ItemHeight = 14
        Me.lstPayData.Location = New System.Drawing.Point(8, 24)
        Me.lstPayData.Name = "lstPayData"
        Me.lstPayData.Size = New System.Drawing.Size(272, 116)
        Me.lstPayData.TabIndex = 0
        '
        'lblLaborHours
        '
        Me.lblLaborHours.BackColor = System.Drawing.SystemColors.Control
        Me.lblLaborHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLaborHours.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLaborHours.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaborHours.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLaborHours.Location = New System.Drawing.Point(208, 192)
        Me.lblLaborHours.Name = "lblLaborHours"
        Me.lblLaborHours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLaborHours.Size = New System.Drawing.Size(73, 17)
        Me.lblLaborHours.TabIndex = 36
        '
        'lblTotalPayroll
        '
        Me.lblTotalPayroll.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalPayroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPayroll.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalPayroll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayroll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalPayroll.Location = New System.Drawing.Point(208, 168)
        Me.lblTotalPayroll.Name = "lblTotalPayroll"
        Me.lblTotalPayroll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPayroll.Size = New System.Drawing.Size(73, 17)
        Me.lblTotalPayroll.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(96, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(104, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Total Labor Hours"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(120, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Total Payroll"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(307, 270)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnClear, Me.btnCalculate, Me.GroupBox1, Me.lblLaborHours, Me.lblTotalPayroll, Me.Label11, Me.Label10})
        Me.Name = "Form1"
        Me.Text = "Pizza Payroll"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This application demonstrates parallel arrays.

    ' Class-level Constants.
    Const intNUMBER_OF_EMPLOYEES As Integer = 2
	Const intMAX_EMPLOYEE As Integer = intNUMBER_OF_EMPLOYEES - 1
	Const decHOURLY_PAY_RATE As Decimal = 6D

    ' Class-level variables.
	Private strNames(intMAX_EMPLOYEE) As String		  ' Employee names
	Private intHours(intMAX_EMPLOYEE) As Integer	  ' Hours worked
	Private decGrossPay(intMAX_EMPLOYEE) As Decimal	  ' Gross pay
    Private decTotalGrossPay As Decimal            ' Total gross pay
    Private intTotalHours As Integer               ' Total hours worked

    Private Sub btnCalculate_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnCalculate.Click

        ' Call the Sub procedures to calculate
        ' and display each employee's gross pay, the
        ' total payroll, and the total labor hours worked.

        GetData()
        CalcPay()
        DisplayPayrollData()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click

        ' Clear the list box and labels
		Dim intCount As Integer			' Loop counter.

        ' Clear the list box
        lstPayData.Items.Clear()

        ' Clear labels for total payroll and labor hours.
        lblTotalPayroll.Text = ""
        lblLaborHours.Text = ""

        ' Set the array elements to 0
		For intCount = 0 To intMAX_EMPLOYEE
			intHours(intCount) = 0
			decGrossPay(intCount) = 0
		Next intCount

        ' Clear the totals.
        decTotalGrossPay = 0
        intTotalHours = 0

    End Sub

    Sub GetData()
        ' Get the names of the employees and the 
        ' hours worked by each.
        Dim intCount As Integer    ' Loop counter

		For intCount = 0 To intMAX_EMPLOYEE

            strNames(intCount) = InputBox( _
                "Enter the name of employee " _
                & "number " & (intCount + 1).ToString, _
                "Employee Name")

			intHours(intCount) = GetEmployeeHours(strNames(intCount))
        Next intCount

    End Sub

    Function GetEmployeeHours(ByVal strName As String) As Integer

        ' Ask the user to enter the hours worked by a single 
        ' employee. If the value is not a valid integer, display 
        ' an error message and use a loop to ask again.
        Dim intHours As Integer
        Dim blnFinished As Boolean = False
        Do Until blnFinished
            blnFinished = Integer.TryParse(InputBox( _
               "Enter the hours worked by " _
               & strName, "Hours Worked"), intHours)

            If Not blnFinished Then
                MessageBox.Show("Please enter an integer", "Error")
            End If
        Loop
        Return intHours
    End Function

    Sub CalcPay()
        ' This procedure calculates and displays each
        ' employee's gross pay.

        Dim intCount As Integer         ' Loop counter
        Dim decGross As Decimal         ' Gross pay

        ' Calculate the gross pay for each person, the total 
        ' of all gross pay values, and the total hours worked.

		For intCount = 0 To intMAX_EMPLOYEE
			decGross = intHours(intCount) * decHOURLY_PAY_RATE
			decGrossPay(intCount) = decGross
			decTotalGrossPay += decGross
			intTotalHours += intHours(intCount)
        Next

    End Sub

    Sub DisplayPayrollData()
        ' Displays the payroll data for each employee
        ' and the total gross pay and total hours worked.

        ' Display each employee's data.
        Dim count As Integer

		For count = 0 To intMAX_EMPLOYEE
			lstPayData.Items.Add("Name: " & strNames(count) _
			  & "  Hours: " & intHours(count) & "  Gross Pay: " _
			  & FormatCurrency(decGrossPay(count)))
		Next count

        ' Display the total gross pay and total hours for 
        ' all employees.
        lblTotalPayroll.Text = FormatCurrency(decTotalGrossPay)
        lblLaborHours.Text = intTotalHours.ToString

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

End Class
