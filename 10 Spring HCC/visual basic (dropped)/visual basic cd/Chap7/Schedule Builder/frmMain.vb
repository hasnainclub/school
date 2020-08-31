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
    Public WithEvents btnShow As System.Windows.Forms.Button
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTimeBlocks As System.Windows.Forms.ListBox
    Friend WithEvents cboProfessors As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourses As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblMessage As System.Windows.Forms.Label
	Public WithEvents btnAdd As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lstTimeBlocks = New System.Windows.Forms.ListBox
        Me.cboProfessors = New System.Windows.Forms.ComboBox
        Me.cboCourses = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.Control
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShow.Location = New System.Drawing.Point(29, 247)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShow.Size = New System.Drawing.Size(81, 47)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "&Show Schedule"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(138, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(81, 47)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear Schedule"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(246, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 47)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.lblMessage)
        Me.Frame1.Controls.Add(Me.btnAdd)
        Me.Frame1.Controls.Add(Me.lstTimeBlocks)
        Me.Frame1.Controls.Add(Me.cboProfessors)
        Me.Frame1.Controls.Add(Me.cboCourses)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(10, 10)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(345, 231)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Select Course Information"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(16, 184)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(313, 23)
        Me.lblMessage.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(222, 137)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAdd.Size = New System.Drawing.Size(81, 33)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add Course"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lstTimeBlocks
        '
        Me.lstTimeBlocks.BackColor = System.Drawing.SystemColors.Window
        Me.lstTimeBlocks.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstTimeBlocks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTimeBlocks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstTimeBlocks.FormattingEnabled = True
        Me.lstTimeBlocks.ItemHeight = 14
        Me.lstTimeBlocks.Items.AddRange(New Object() {"8:00 - 8:50", "9:00 - 9:50", "10:00 - 10:50", "11:00 - 11:50", "12:00 - 12:50"})
        Me.lstTimeBlocks.Location = New System.Drawing.Point(208, 48)
        Me.lstTimeBlocks.Name = "lstTimeBlocks"
        Me.lstTimeBlocks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstTimeBlocks.Size = New System.Drawing.Size(121, 74)
        Me.lstTimeBlocks.TabIndex = 5
        '
        'cboProfessors
        '
        Me.cboProfessors.BackColor = System.Drawing.SystemColors.Window
        Me.cboProfessors.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboProfessors.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProfessors.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProfessors.FormattingEnabled = True
        Me.cboProfessors.Items.AddRange(New Object() {"Anderson, Jim", "Freeman, Pat", "Kirk, Susan", "Pike, Gordon", "Rose, Hans", "Smith, Roberta", "Sutherland, Sam", "Williams, Jill"})
        Me.cboProfessors.Location = New System.Drawing.Point(16, 112)
        Me.cboProfessors.Name = "cboProfessors"
        Me.cboProfessors.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboProfessors.Size = New System.Drawing.Size(169, 22)
        Me.cboProfessors.Sorted = True
        Me.cboProfessors.TabIndex = 4
        '
        'cboCourses
        '
        Me.cboCourses.BackColor = System.Drawing.SystemColors.Window
        Me.cboCourses.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCourses.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourses.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCourses.FormattingEnabled = True
        Me.cboCourses.Items.AddRange(New Object() {"CIS-110 Intro to Computers", "CIS-120 Visual Basic", "CIS-134 C++ Programming", "CIS-150 Database Concepts", "CIS-200 Intro to Networking", "CIS-210 Network Admin", "MAT-110 Statistics", "MAT-120 Algebra", "MAT-130 Trigonometry", "MAT-140 Calculus I", "MAT-150 Calculus II"})
        Me.cboCourses.Location = New System.Drawing.Point(16, 48)
        Me.cboCourses.Name = "cboCourses"
        Me.cboCourses.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCourses.Size = New System.Drawing.Size(169, 22)
        Me.cboCourses.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Choose a course:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Choose a professor:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(208, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose a time block:"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(370, 306)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Schedule Builder"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

	' Class-level variables
	Private strCourse1 As String	   ' To hold the 8:00 - 8:50 course
	Private strCourse2 As String	   ' To hold the 9:00 - 8:50 course
	Private strCourse3 As String	   ' To hold the 10:00 - 10:50 course
	Private strCourse4 As String	   ' To hold the 11:00 - 11:50 course
	Private strCourse5 As String	   ' To hold the 12:00 - 12:50 course

	Private strProfessor1 As String	   ' To hold the 8:00 - 8:50 professor
	Private strProfessor2 As String	   ' To hold the 9:00 - 8:50 professor
	Private strProfessor3 As String	   ' To hold the 10:00 - 10:50 professor
	Private strProfessor4 As String	   ' To hold the 11:00 - 11:50 professor
	Private strProfessor5 As String	   ' To hold the 12:00 - 12:50 professor


	Private Sub btnAdd_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnAdd.Click
        ' this procedure adds the selected course
        ' to the schedule, which is kept in the 
        ' class-level variables
        ' determine the time block selected and then add
        ' the course and professor

        Select Case lstTimeBlocks.SelectedIndex.ToString()
            Case "8:00 - 8:50"
                strCourse1 = cboProfessors.Text
                strProfessor1 = cboProfessors.Text
            Case "9:00 - 9:50"
                strCourse2 = cboCourses.Text
                strProfessor2 = cboProfessors.Text
            Case " 10:00 - 10:50"
                strCourse3 = cboCourses.Text
                strCourse3 = cboProfessors.Text
            Case "11:00 - 11:50"
                strCourse4 = cboCourses.Text
                strCourse4 = cboProfessors.Text
            Case "12:00 - 12:50"
                strCourse5 = cboCourses.Text
                strCourse5 = cboProfessors.Text
        End Select

        '  let the user know the course has been added
        lblMessage.Text = "Course added for the  " _
        & lstTimeBlocks.SelectedIndex.ToString() & " time block"

        '  clear the selected course and professor
        cboCourses.Text = String.Empty
        cboProfessors.Text = String.Empty


	End Sub

	Private Sub btnShow_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnShow.Click

		' This procedure displays the schedule on an
		' instance of the frmSchedule form.
		Dim scheduleForm As New frmSchedule()

		' Copy the course and professor for the
		' 8:00 - 8:50 time block to scheduleForm.
        frmSchedule.lblCourse1.Text = strCourse1
        frmSchedule.lblProfessor1.Text = strProfessor1

		' Copy the course and professor for the
		' 9:00 - 9:50 time block to scheduleForm.
        frmSchedule.lblCourse2.Text = strCourse2
        frmSchedule.lblProfessor2.Text = strProfessor2

		' Copy the course and professor for the
		' 10:00 - 10:50 time block to scheduleForm.
        frmSchedule.lblCourse3.Text = strCourse3
        frmSchedule.lblProfessor3.Text = strProfessor3

		' Copy the course and professor for the
		' 11:00 - 11:50 time block to scheduleForm.
        frmSchedule.lblCourse4.Text = strCourse4
        frmSchedule.lblProfessor4.Text = strProfessor4

		' Copy the course and professor for the
		' 12:00 - 12:50 time block to scheduleForm.
        frmSchedule.lblCourse5.Text = strCourse5
        frmSchedule.lblProfessor5.Text = strProfessor5

		' Display the schedule form.
        frmSchedule.ShowDialog()
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnClear.Click

		' This procedure clears the items in the schedule.
		' Clear the course names.
		strCourse1 = String.Empty
		strCourse2 = String.Empty
		strCourse3 = String.Empty
		strCourse4 = String.Empty
		strCourse5 = String.Empty

		' Clear the professor names.
		strProfessor1 = String.Empty
		strProfessor2 = String.Empty
		strProfessor3 = String.Empty
		strProfessor4 = String.Empty
		strProfessor5 = String.Empty

		' Reset the list box and combo boxes.
		lstTimeBlocks.SelectedIndex = -1
		cboCourses.Text = String.Empty
		cboProfessors.Text = String.Empty
	End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
     ByVal e As System.EventArgs) Handles btnExit.Click
        ' end the application with the close method
        ' this allows the form closing event procedure to execute 

        Me.Close()
    End Sub

	Private Sub frmMain_Closing(ByVal sender As Object, _
		ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

		' Confirm that the user wants to quit.
		If MessageBox.Show("Are you sure you want to quit?", "Confirm", _
		   MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
			e.Cancel = True	' Do not quit
		Else
			e.Cancel = False ' Go ahead and quit
		End If
	End Sub


End Class
