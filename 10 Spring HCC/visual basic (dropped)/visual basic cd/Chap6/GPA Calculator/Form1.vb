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
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblGPA As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents txtCreditHours4 As System.Windows.Forms.TextBox
	Public WithEvents txtCreditHours3 As System.Windows.Forms.TextBox
	Public WithEvents txtCreditHours2 As System.Windows.Forms.TextBox
	Public WithEvents txtCreditHours1 As System.Windows.Forms.TextBox
	Public WithEvents txtGrade4 As System.Windows.Forms.TextBox
	Public WithEvents txtGrade3 As System.Windows.Forms.TextBox
	Public WithEvents txtGrade2 As System.Windows.Forms.TextBox
	Public WithEvents txtGrade1 As System.Windows.Forms.TextBox
	Public WithEvents lblGradePoints4 As System.Windows.Forms.Label
	Public WithEvents lblGradePoints3 As System.Windows.Forms.Label
	Public WithEvents lblGradePoints2 As System.Windows.Forms.Label
	Friend WithEvents lblMessage As System.Windows.Forms.Label
	Public WithEvents lblGradePoints1 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.btnExit = New System.Windows.Forms.Button
		Me.btnClear = New System.Windows.Forms.Button
		Me.btnCalculate = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtCreditHours4 = New System.Windows.Forms.TextBox
		Me.txtCreditHours3 = New System.Windows.Forms.TextBox
		Me.txtCreditHours2 = New System.Windows.Forms.TextBox
		Me.txtCreditHours1 = New System.Windows.Forms.TextBox
		Me.txtGrade4 = New System.Windows.Forms.TextBox
		Me.txtGrade3 = New System.Windows.Forms.TextBox
		Me.txtGrade2 = New System.Windows.Forms.TextBox
		Me.txtGrade1 = New System.Windows.Forms.TextBox
		Me.lblGradePoints4 = New System.Windows.Forms.Label
		Me.lblGradePoints3 = New System.Windows.Forms.Label
		Me.lblGradePoints2 = New System.Windows.Forms.Label
		Me.lblGradePoints1 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblGPA = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.lblMessage = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.SystemColors.Control
		Me.btnExit.CausesValidation = False
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnExit.Location = New System.Drawing.Point(224, 244)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnExit.Size = New System.Drawing.Size(81, 33)
		Me.btnExit.TabIndex = 5
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.SystemColors.Control
		Me.btnClear.CausesValidation = False
		Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClear.Location = New System.Drawing.Point(128, 244)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClear.Size = New System.Drawing.Size(81, 33)
		Me.btnClear.TabIndex = 4
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'btnCalculate
		'
		Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
		Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCalculate.Location = New System.Drawing.Point(13, 244)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCalculate.Size = New System.Drawing.Size(102, 33)
		Me.btnCalculate.TabIndex = 3
		Me.btnCalculate.Text = "&Calculate GPA"
		Me.btnCalculate.UseVisualStyleBackColor = False
		'
		'Frame1
		'
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.txtCreditHours4)
		Me.Frame1.Controls.Add(Me.txtCreditHours3)
		Me.Frame1.Controls.Add(Me.txtCreditHours2)
		Me.Frame1.Controls.Add(Me.txtCreditHours1)
		Me.Frame1.Controls.Add(Me.txtGrade4)
		Me.Frame1.Controls.Add(Me.txtGrade3)
		Me.Frame1.Controls.Add(Me.txtGrade2)
		Me.Frame1.Controls.Add(Me.txtGrade1)
		Me.Frame1.Controls.Add(Me.lblGradePoints4)
		Me.Frame1.Controls.Add(Me.lblGradePoints3)
		Me.Frame1.Controls.Add(Me.lblGradePoints2)
		Me.Frame1.Controls.Add(Me.lblGradePoints1)
		Me.Frame1.Controls.Add(Me.Label7)
		Me.Frame1.Controls.Add(Me.Label6)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label3)
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Controls.Add(Me.Label1)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(10, 12)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(313, 161)
		Me.Frame1.TabIndex = 0
		Me.Frame1.TabStop = False
		Me.Frame1.Text = "Enter Course Information"
		'
		'txtCreditHours4
		'
		Me.txtCreditHours4.AcceptsReturn = True
		Me.txtCreditHours4.AutoSize = False
		Me.txtCreditHours4.BackColor = System.Drawing.SystemColors.Window
		Me.txtCreditHours4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCreditHours4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditHours4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCreditHours4.Location = New System.Drawing.Point(160, 128)
		Me.txtCreditHours4.MaxLength = 0
		Me.txtCreditHours4.Name = "txtCreditHours4"
		Me.txtCreditHours4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCreditHours4.Size = New System.Drawing.Size(57, 19)
		Me.txtCreditHours4.TabIndex = 17
		Me.txtCreditHours4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCreditHours3
		'
		Me.txtCreditHours3.AcceptsReturn = True
		Me.txtCreditHours3.AutoSize = False
		Me.txtCreditHours3.BackColor = System.Drawing.SystemColors.Window
		Me.txtCreditHours3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCreditHours3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditHours3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCreditHours3.Location = New System.Drawing.Point(160, 104)
		Me.txtCreditHours3.MaxLength = 0
		Me.txtCreditHours3.Name = "txtCreditHours3"
		Me.txtCreditHours3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCreditHours3.Size = New System.Drawing.Size(57, 19)
		Me.txtCreditHours3.TabIndex = 13
		Me.txtCreditHours3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCreditHours2
		'
		Me.txtCreditHours2.AcceptsReturn = True
		Me.txtCreditHours2.AutoSize = False
		Me.txtCreditHours2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCreditHours2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCreditHours2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditHours2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCreditHours2.Location = New System.Drawing.Point(160, 80)
		Me.txtCreditHours2.MaxLength = 0
		Me.txtCreditHours2.Name = "txtCreditHours2"
		Me.txtCreditHours2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCreditHours2.Size = New System.Drawing.Size(57, 19)
		Me.txtCreditHours2.TabIndex = 9
		Me.txtCreditHours2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCreditHours1
		'
		Me.txtCreditHours1.AcceptsReturn = True
		Me.txtCreditHours1.AutoSize = False
		Me.txtCreditHours1.BackColor = System.Drawing.SystemColors.Window
		Me.txtCreditHours1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCreditHours1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditHours1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCreditHours1.Location = New System.Drawing.Point(160, 56)
		Me.txtCreditHours1.MaxLength = 0
		Me.txtCreditHours1.Name = "txtCreditHours1"
		Me.txtCreditHours1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCreditHours1.Size = New System.Drawing.Size(57, 19)
		Me.txtCreditHours1.TabIndex = 5
		Me.txtCreditHours1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtGrade4
		'
		Me.txtGrade4.AcceptsReturn = True
		Me.txtGrade4.AutoSize = False
		Me.txtGrade4.BackColor = System.Drawing.SystemColors.Window
		Me.txtGrade4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGrade4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrade4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGrade4.Location = New System.Drawing.Point(88, 128)
		Me.txtGrade4.MaxLength = 0
		Me.txtGrade4.Name = "txtGrade4"
		Me.txtGrade4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrade4.Size = New System.Drawing.Size(57, 19)
		Me.txtGrade4.TabIndex = 16
		Me.txtGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtGrade3
		'
		Me.txtGrade3.AcceptsReturn = True
		Me.txtGrade3.AutoSize = False
		Me.txtGrade3.BackColor = System.Drawing.SystemColors.Window
		Me.txtGrade3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGrade3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrade3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGrade3.Location = New System.Drawing.Point(88, 104)
		Me.txtGrade3.MaxLength = 0
		Me.txtGrade3.Name = "txtGrade3"
		Me.txtGrade3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrade3.Size = New System.Drawing.Size(57, 19)
		Me.txtGrade3.TabIndex = 12
		Me.txtGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtGrade2
		'
		Me.txtGrade2.AcceptsReturn = True
		Me.txtGrade2.AutoSize = False
		Me.txtGrade2.BackColor = System.Drawing.SystemColors.Window
		Me.txtGrade2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGrade2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrade2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGrade2.Location = New System.Drawing.Point(88, 80)
		Me.txtGrade2.MaxLength = 0
		Me.txtGrade2.Name = "txtGrade2"
		Me.txtGrade2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrade2.Size = New System.Drawing.Size(57, 19)
		Me.txtGrade2.TabIndex = 8
		Me.txtGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtGrade1
		'
		Me.txtGrade1.AcceptsReturn = True
		Me.txtGrade1.AutoSize = False
		Me.txtGrade1.BackColor = System.Drawing.SystemColors.Window
		Me.txtGrade1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGrade1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrade1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGrade1.Location = New System.Drawing.Point(88, 56)
		Me.txtGrade1.MaxLength = 0
		Me.txtGrade1.Name = "txtGrade1"
		Me.txtGrade1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrade1.Size = New System.Drawing.Size(57, 19)
		Me.txtGrade1.TabIndex = 4
		Me.txtGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblGradePoints4
		'
		Me.lblGradePoints4.BackColor = System.Drawing.SystemColors.Control
		Me.lblGradePoints4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGradePoints4.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGradePoints4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGradePoints4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGradePoints4.Location = New System.Drawing.Point(232, 128)
		Me.lblGradePoints4.Name = "lblGradePoints4"
		Me.lblGradePoints4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGradePoints4.Size = New System.Drawing.Size(57, 17)
		Me.lblGradePoints4.TabIndex = 18
		Me.lblGradePoints4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblGradePoints3
		'
		Me.lblGradePoints3.BackColor = System.Drawing.SystemColors.Control
		Me.lblGradePoints3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGradePoints3.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGradePoints3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGradePoints3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGradePoints3.Location = New System.Drawing.Point(232, 104)
		Me.lblGradePoints3.Name = "lblGradePoints3"
		Me.lblGradePoints3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGradePoints3.Size = New System.Drawing.Size(57, 17)
		Me.lblGradePoints3.TabIndex = 14
		Me.lblGradePoints3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblGradePoints2
		'
		Me.lblGradePoints2.BackColor = System.Drawing.SystemColors.Control
		Me.lblGradePoints2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGradePoints2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGradePoints2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGradePoints2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGradePoints2.Location = New System.Drawing.Point(232, 80)
		Me.lblGradePoints2.Name = "lblGradePoints2"
		Me.lblGradePoints2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGradePoints2.Size = New System.Drawing.Size(57, 17)
		Me.lblGradePoints2.TabIndex = 10
		Me.lblGradePoints2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblGradePoints1
		'
		Me.lblGradePoints1.BackColor = System.Drawing.SystemColors.Control
		Me.lblGradePoints1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGradePoints1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGradePoints1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGradePoints1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGradePoints1.Location = New System.Drawing.Point(232, 56)
		Me.lblGradePoints1.Name = "lblGradePoints1"
		Me.lblGradePoints1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGradePoints1.Size = New System.Drawing.Size(57, 17)
		Me.lblGradePoints1.TabIndex = 6
		Me.lblGradePoints1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(232, 24)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(65, 24)
		Me.Label7.TabIndex = 2
		Me.Label7.Text = "Grade Points"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(160, 24)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(65, 24)
		Me.Label6.TabIndex = 1
		Me.Label6.Text = "Credit Hours"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(80, 24)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(65, 24)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Letter Grade"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(16, 128)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "Course #&4"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(16, 104)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Course #&3"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(16, 80)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Course #&2"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(16, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Course #&1"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblGPA
		'
		Me.lblGPA.BackColor = System.Drawing.SystemColors.Control
		Me.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGPA.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGPA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGPA.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGPA.Location = New System.Drawing.Point(242, 188)
		Me.lblGPA.Name = "lblGPA"
		Me.lblGPA.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGPA.Size = New System.Drawing.Size(57, 17)
		Me.lblGPA.TabIndex = 2
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(98, 188)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(129, 17)
		Me.Label8.TabIndex = 1
		Me.Label8.Text = "Grade Point Average"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblMessage
		'
		Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
		Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMessage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.ForeColor = System.Drawing.Color.Red
		Me.lblMessage.Location = New System.Drawing.Point(13, 214)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMessage.Size = New System.Drawing.Size(292, 17)
		Me.lblMessage.TabIndex = 6
		'
		'Form1
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(332, 288)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.Frame1)
		Me.Controls.Add(Me.lblGPA)
		Me.Controls.Add(Me.Label8)
		Me.Name = "Form1"
		Me.Text = "GPA Calculator"
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

#End Region

	' This application calculates a student's grade point average (GPA).
	' It demonstrates how to use Function procedures.

	Dim defaultTextboxColor As Color

	Private Sub Form1_Load(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles MyBase.Load

		'Get the default text box color.
		defaultTextboxColor = txtCreditHours1.BackColor

	End Sub

	Private Sub btnCalculate_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnCalculate.Click

		' This event procedure displays the quality points for
		' each course and the GPA.

		Dim intGradePoints As Integer
		Dim dblGradePointAvg As Double

		' Display the quality points for course 1.
		intGradePoints = CalcGradePoints(txtGrade1.Text)
		lblGradePoints1.Text = intGradePoints.ToString()

		' Display the quality points for course 2.
		intGradePoints = CalcGradePoints(txtGrade2.Text)
		lblGradePoints2.Text = intGradePoints.ToString()

		' Display the quality points for course 3.
		intGradePoints = CalcGradePoints(txtGrade3.Text)
		lblGradePoints3.Text = intGradePoints.ToString()

		' Display the quality points for course 4.
		intGradePoints = CalcGradePoints(txtGrade4.Text)
		lblGradePoints4.Text = intGradePoints.ToString()

		' Get the grade point average and display 
		' it with 2 decimal places.
		dblGradePointAvg = CalculateGradeAverage()
		lblGPA.Text = dblGradePointAvg.ToString("n")

	End Sub


	Function CalcGradePoints(ByVal strGrade As String) As Integer

		' This function accepts a letter grade as an argument
		' and returns the number of grade points for that grade.

		Dim intPoints As Integer

		Select Case strGrade.ToUpper()
			Case "A"
				intPoints = 4
			Case "B"
				intPoints = 3
			Case "C"
				intPoints = 2
			Case "D"
				intPoints = 1
			Case "F"
				intPoints = 0
		End Select

		' Returns the number of grade points.
		Return intPoints

	End Function

	Function CalculateGradeAverage() As Double

		' This function calculates and returns the student's 
		' Grade Point Average (GPA).

		Dim intHours1, intHours2, intHours3, intHours4 As Integer
		intHours1 = CInt(txtCreditHours1.Text)
		intHours2 = CInt(txtCreditHours2.Text)
		intHours3 = CInt(txtCreditHours3.Text)
		intHours4 = CInt(txtCreditHours4.Text)

		Dim intPoints1, intPoints2, intPoints3, _
		 intPoints4 As Integer

		intPoints1 = CInt(lblGradePoints1.Text)
		intPoints2 = CInt(lblGradePoints2.Text)
		intPoints3 = CInt(lblGradePoints3.Text)
		intPoints4 = CInt(lblGradePoints4.Text)

		' Get the total credit hours.
		Dim intTotalCreditHours As Integer = _
		 intHours1 + intHours2 + intHours3 + intHours4

		' Calculate the total quality points.
		Dim intTotalQualityPoints As Integer = _
		 (intHours1 * intPoints1) + (intHours2 * intPoints2) + _
		 (intHours3 * intPoints3) + (intHours4 * intPoints4)

		' Divide the total quality points by the total credit
		' hours, producing the grade point average.
		Return (intTotalQualityPoints / intTotalCreditHours)

	End Function

	Function ValidateHours(ByVal tbox As TextBox) As Boolean

		' Return True if the text box contains a valid integer. 
		' If not, display an error message, change the TextBox
		' color and return False.

		Dim int As Integer

		If Integer.TryParse(tbox.Text, int) Then
			tbox.BackColor = defaultTextboxColor
			lblMessage.Text = String.Empty
			Return True
		Else
			lblMessage.Text = "Invalid Credit Hours. Please " _
			 & "enter an integer"
			tbox.BackColor = Color.Aqua
			Return False
		End If

	End Function

	Private Sub txtCreditHours1_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtCreditHours1.Validating

		If ValidateHours(txtCreditHours1) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub txtCreditHours2_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtCreditHours2.Validating

		If ValidateHours(txtCreditHours2) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If

	End Sub

	Private Sub txtCreditHours3_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtCreditHours3.Validating

		If ValidateHours(txtCreditHours3) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If

	End Sub

	Private Sub txtCreditHours4_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtCreditHours4.Validating

		If ValidateHours(txtCreditHours4) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If

	End Sub


	Function ValidateGrade(ByVal tbox As TextBox) As Boolean

		' Return True if the text box contains a valid grade letter
		' (A,B,C,D, or F). If not, display an error message, change 
		' the TextBox color, and return False.

		Dim grade As String = tbox.Text.ToUpper()

		If grade = "A" Or grade = "B" Or grade = "C" Or grade = "D" _
		 Or grade = "F" Then
			tbox.BackColor = defaultTextboxColor
			Return True
		Else
			lblMessage.Text = "Invalid Grade. Please enter A, B, C, D or F"
			tbox.BackColor = Color.Aqua
			Return False
		End If

	End Function

	Private Sub txtGrade1_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtGrade1.Validating

		If ValidateGrade(txtGrade1) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If

	End Sub

	Private Sub txtGrade2_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtGrade2.Validating

		If ValidateGrade(txtGrade2) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub txtGrade3_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtGrade3.Validating

		If ValidateGrade(txtGrade3) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub txtGrade4_Validating(ByVal sender As Object, _
	 ByVal e As System.ComponentModel.CancelEventArgs) _
	 Handles txtGrade4.Validating

		If ValidateGrade(txtGrade4) Then
			e.Cancel = False
		Else
			e.Cancel = True
		End If
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnClear.Click

		' Clear the text boxes
		txtGrade1.Clear()
		txtGrade2.Clear()
		txtGrade3.Clear()
		txtGrade4.Clear()
		txtCreditHours1.Clear()
		txtCreditHours2.Clear()
		txtCreditHours3.Clear()
		txtCreditHours4.Clear()
		' Clear the labels
		lblGradePoints1.Text = ""
		lblGradePoints2.Text = ""
		lblGradePoints3.Text = ""
		lblGradePoints4.Text = ""
		lblGPA.Text = ""
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnExit.Click

		' End the application
		Me.Close()
	End Sub

End Class
