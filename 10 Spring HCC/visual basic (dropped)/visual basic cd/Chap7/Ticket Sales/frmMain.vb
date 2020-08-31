Public Class frmMain
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
	Public WithEvents btnStudent As System.Windows.Forms.Button
	Public WithEvents btnGeneral As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.btnExit = New System.Windows.Forms.Button
		Me.btnStudent = New System.Windows.Forms.Button
		Me.btnGeneral = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.SystemColors.Control
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnExit.Location = New System.Drawing.Point(204, 166)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'btnStudent
		'
		Me.btnStudent.BackColor = System.Drawing.SystemColors.Control
		Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnStudent.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnStudent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnStudent.Location = New System.Drawing.Point(204, 102)
		Me.btnStudent.Name = "btnStudent"
		Me.btnStudent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnStudent.Size = New System.Drawing.Size(81, 43)
		Me.btnStudent.TabIndex = 2
		Me.btnStudent.Text = "&Student Sales"
		Me.btnStudent.UseVisualStyleBackColor = False
		'
		'btnGeneral
		'
		Me.btnGeneral.BackColor = System.Drawing.SystemColors.Control
		Me.btnGeneral.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGeneral.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnGeneral.Location = New System.Drawing.Point(204, 38)
		Me.btnGeneral.Name = "btnGeneral"
		Me.btnGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnGeneral.Size = New System.Drawing.Size(81, 41)
		Me.btnGeneral.TabIndex = 1
		Me.btnGeneral.Text = "&General Sales"
		Me.btnGeneral.UseVisualStyleBackColor = False
		'
		'Frame1
		'
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Controls.Add(Me.Label1)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(12, 14)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(289, 137)
		Me.Frame1.TabIndex = 0
		Me.Frame1.TabStop = False
		Me.Frame1.Text = "Select the Type of Ticket Sales"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(24, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(145, 43)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Select Student Sales for all student ticket sales."
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(24, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(145, 41)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Select General Sales for all ticket sales to the general public."
		'
		'frmMain
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(312, 206)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnStudent)
		Me.Controls.Add(Me.btnGeneral)
		Me.Controls.Add(Me.Frame1)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmMain"
		Me.Text = "University Concert Hall"
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub btnGeneral_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnGeneral.Click

		' Display the general ticket sales form
		Dim generalForm As New frmGeneral()	' Declare an instance

		generalForm.ShowDialog()				' Display the form
	End Sub

	Private Sub btnStudent_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnStudent.Click

		' Display the student ticket sales form
		Dim studentForm As New frmStudent()	' Declare an instance

		studentForm.ShowDialog()				' Display the form

	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, _
		 ByVal e As System.EventArgs) Handles btnExit.Click

		' End the application
		Me.Close()
	End Sub
End Class
