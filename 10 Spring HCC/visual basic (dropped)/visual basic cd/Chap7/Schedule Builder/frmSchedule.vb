Public Class frmSchedule
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
    Public WithEvents btnOK As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents lblProfessor5 As System.Windows.Forms.Label
    Public WithEvents lblProfessor4 As System.Windows.Forms.Label
    Public WithEvents lblProfessor3 As System.Windows.Forms.Label
    Public WithEvents lblProfessor2 As System.Windows.Forms.Label
    Public WithEvents lblProfessor1 As System.Windows.Forms.Label
    Public WithEvents lblCourse5 As System.Windows.Forms.Label
    Public WithEvents lblCourse4 As System.Windows.Forms.Label
    Public WithEvents lblCourse3 As System.Windows.Forms.Label
    Public WithEvents lblCourse2 As System.Windows.Forms.Label
    Public WithEvents lblCourse1 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.btnOK = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblProfessor5 = New System.Windows.Forms.Label
		Me.lblProfessor4 = New System.Windows.Forms.Label
		Me.lblProfessor3 = New System.Windows.Forms.Label
		Me.lblProfessor2 = New System.Windows.Forms.Label
		Me.lblProfessor1 = New System.Windows.Forms.Label
		Me.lblCourse5 = New System.Windows.Forms.Label
		Me.lblCourse4 = New System.Windows.Forms.Label
		Me.lblCourse3 = New System.Windows.Forms.Label
		Me.lblCourse2 = New System.Windows.Forms.Label
		Me.lblCourse1 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnOK
		'
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Location = New System.Drawing.Point(176, 208)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.Size = New System.Drawing.Size(81, 33)
		Me.btnOK.TabIndex = 1
		Me.btnOK.Text = "&OK"
		Me.btnOK.UseVisualStyleBackColor = False
		'
		'Frame1
		'
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Controls.Add(Me.lblProfessor5)
		Me.Frame1.Controls.Add(Me.lblProfessor4)
		Me.Frame1.Controls.Add(Me.lblProfessor3)
		Me.Frame1.Controls.Add(Me.lblProfessor2)
		Me.Frame1.Controls.Add(Me.lblProfessor1)
		Me.Frame1.Controls.Add(Me.lblCourse5)
		Me.Frame1.Controls.Add(Me.lblCourse4)
		Me.Frame1.Controls.Add(Me.lblCourse3)
		Me.Frame1.Controls.Add(Me.lblCourse2)
		Me.Frame1.Controls.Add(Me.lblCourse1)
		Me.Frame1.Controls.Add(Me.Label8)
		Me.Frame1.Controls.Add(Me.Label7)
		Me.Frame1.Controls.Add(Me.Label6)
		Me.Frame1.Controls.Add(Me.Label5)
		Me.Frame1.Controls.Add(Me.Label4)
		Me.Frame1.Controls.Add(Me.Label3)
		Me.Frame1.Controls.Add(Me.Label2)
		Me.Frame1.Controls.Add(Me.Label1)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(9, 9)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(425, 183)
		Me.Frame1.TabIndex = 0
		Me.Frame1.TabStop = False
		Me.Frame1.Text = "Your Schedule"
		'
		'lblProfessor5
		'
		Me.lblProfessor5.BackColor = System.Drawing.SystemColors.Control
		Me.lblProfessor5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfessor5.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProfessor5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfessor5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProfessor5.Location = New System.Drawing.Point(280, 144)
		Me.lblProfessor5.Name = "lblProfessor5"
		Me.lblProfessor5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProfessor5.Size = New System.Drawing.Size(121, 17)
		Me.lblProfessor5.TabIndex = 20
		'
		'lblProfessor4
		'
		Me.lblProfessor4.BackColor = System.Drawing.SystemColors.Control
		Me.lblProfessor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfessor4.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProfessor4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfessor4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProfessor4.Location = New System.Drawing.Point(280, 120)
		Me.lblProfessor4.Name = "lblProfessor4"
		Me.lblProfessor4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProfessor4.Size = New System.Drawing.Size(121, 17)
		Me.lblProfessor4.TabIndex = 19
		'
		'lblProfessor3
		'
		Me.lblProfessor3.BackColor = System.Drawing.SystemColors.Control
		Me.lblProfessor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfessor3.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProfessor3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfessor3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProfessor3.Location = New System.Drawing.Point(280, 96)
		Me.lblProfessor3.Name = "lblProfessor3"
		Me.lblProfessor3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProfessor3.Size = New System.Drawing.Size(121, 17)
		Me.lblProfessor3.TabIndex = 18
		'
		'lblProfessor2
		'
		Me.lblProfessor2.BackColor = System.Drawing.SystemColors.Control
		Me.lblProfessor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfessor2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProfessor2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfessor2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProfessor2.Location = New System.Drawing.Point(280, 72)
		Me.lblProfessor2.Name = "lblProfessor2"
		Me.lblProfessor2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProfessor2.Size = New System.Drawing.Size(121, 17)
		Me.lblProfessor2.TabIndex = 17
		'
		'lblProfessor1
		'
		Me.lblProfessor1.BackColor = System.Drawing.SystemColors.Control
		Me.lblProfessor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfessor1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProfessor1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfessor1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProfessor1.Location = New System.Drawing.Point(280, 48)
		Me.lblProfessor1.Name = "lblProfessor1"
		Me.lblProfessor1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProfessor1.Size = New System.Drawing.Size(121, 17)
		Me.lblProfessor1.TabIndex = 16
		'
		'lblCourse5
		'
		Me.lblCourse5.BackColor = System.Drawing.SystemColors.Control
		Me.lblCourse5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCourse5.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCourse5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCourse5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCourse5.Location = New System.Drawing.Point(112, 144)
		Me.lblCourse5.Name = "lblCourse5"
		Me.lblCourse5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCourse5.Size = New System.Drawing.Size(145, 17)
		Me.lblCourse5.TabIndex = 14
		'
		'lblCourse4
		'
		Me.lblCourse4.BackColor = System.Drawing.SystemColors.Control
		Me.lblCourse4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCourse4.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCourse4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCourse4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCourse4.Location = New System.Drawing.Point(112, 120)
		Me.lblCourse4.Name = "lblCourse4"
		Me.lblCourse4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCourse4.Size = New System.Drawing.Size(145, 17)
		Me.lblCourse4.TabIndex = 13
		'
		'lblCourse3
		'
		Me.lblCourse3.BackColor = System.Drawing.SystemColors.Control
		Me.lblCourse3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCourse3.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCourse3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCourse3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCourse3.Location = New System.Drawing.Point(112, 96)
		Me.lblCourse3.Name = "lblCourse3"
		Me.lblCourse3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCourse3.Size = New System.Drawing.Size(145, 17)
		Me.lblCourse3.TabIndex = 12
		'
		'lblCourse2
		'
		Me.lblCourse2.BackColor = System.Drawing.SystemColors.Control
		Me.lblCourse2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCourse2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCourse2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCourse2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCourse2.Location = New System.Drawing.Point(112, 72)
		Me.lblCourse2.Name = "lblCourse2"
		Me.lblCourse2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCourse2.Size = New System.Drawing.Size(145, 17)
		Me.lblCourse2.TabIndex = 11
		'
		'lblCourse1
		'
		Me.lblCourse1.BackColor = System.Drawing.SystemColors.Control
		Me.lblCourse1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCourse1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCourse1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCourse1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCourse1.Location = New System.Drawing.Point(112, 48)
		Me.lblCourse1.Name = "lblCourse1"
		Me.lblCourse1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCourse1.Size = New System.Drawing.Size(145, 17)
		Me.lblCourse1.TabIndex = 10
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(8, 144)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(81, 17)
		Me.Label8.TabIndex = 8
		Me.Label8.Text = "12:00 - 12:50"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(8, 120)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(81, 17)
		Me.Label7.TabIndex = 7
		Me.Label7.Text = "11:00 - 11:50"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(8, 96)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "10:00 - 10:50"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(8, 72)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "9:00 - 9:50"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(8, 48)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "8:00 - 8:50"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(280, 24)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(121, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Professor"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(112, 24)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(145, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Course"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(8, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Time Block"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'frmSchedule
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(443, 254)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.Frame1)
		Me.Name = "frmSchedule"
		Me.Text = "Schedule"
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
