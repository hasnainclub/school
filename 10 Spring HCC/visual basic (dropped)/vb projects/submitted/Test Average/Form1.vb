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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtScore3 As System.Windows.Forms.TextBox
    Public WithEvents txtScore2 As System.Windows.Forms.TextBox
    Public WithEvents txtScore1 As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents lblLetterGrade As System.Windows.Forms.Label
    Public WithEvents lblAverage As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnDropLowest As System.Windows.Forms.Button
    Public WithEvents btnShowGrade As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnDropLowest = New System.Windows.Forms.Button
        Me.btnShowGrade = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtScore3 = New System.Windows.Forms.TextBox
        Me.txtScore2 = New System.Windows.Forms.TextBox
        Me.txtScore1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblLetterGrade = New System.Windows.Forms.Label
        Me.lblAverage = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(138, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(71, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(258, 200)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(62, 42)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDropLowest
        '
        Me.btnDropLowest.BackColor = System.Drawing.SystemColors.Control
        Me.btnDropLowest.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDropLowest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDropLowest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDropLowest.Location = New System.Drawing.Point(112, 200)
        Me.btnDropLowest.Name = "btnDropLowest"
        Me.btnDropLowest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDropLowest.Size = New System.Drawing.Size(137, 42)
        Me.btnDropLowest.TabIndex = 2
        Me.btnDropLowest.Text = "Show Grade / &Drop Lowest Score"
        Me.btnDropLowest.UseVisualStyleBackColor = False
        '
        'btnShowGrade
        '
        Me.btnShowGrade.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowGrade.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowGrade.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGrade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowGrade.Location = New System.Drawing.Point(8, 200)
        Me.btnShowGrade.Name = "btnShowGrade"
        Me.btnShowGrade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowGrade.Size = New System.Drawing.Size(97, 42)
        Me.btnShowGrade.TabIndex = 1
        Me.btnShowGrade.Text = "Show &Grade"
        Me.btnShowGrade.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtScore3)
        Me.GroupBox1.Controls.Add(Me.txtScore2)
        Me.GroupBox1.Controls.Add(Me.txtScore1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblLetterGrade)
        Me.GroupBox1.Controls.Add(Me.lblAverage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Data"
        '
        'txtScore3
        '
        Me.txtScore3.AcceptsReturn = True
        Me.txtScore3.AutoSize = False
        Me.txtScore3.BackColor = System.Drawing.SystemColors.Window
        Me.txtScore3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore3.Location = New System.Drawing.Point(160, 80)
        Me.txtScore3.MaxLength = 0
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtScore3.Size = New System.Drawing.Size(81, 19)
        Me.txtScore3.TabIndex = 5
        '
        'txtScore2
        '
        Me.txtScore2.AcceptsReturn = True
        Me.txtScore2.AutoSize = False
        Me.txtScore2.BackColor = System.Drawing.SystemColors.Window
        Me.txtScore2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore2.Location = New System.Drawing.Point(160, 48)
        Me.txtScore2.MaxLength = 0
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtScore2.Size = New System.Drawing.Size(81, 19)
        Me.txtScore2.TabIndex = 3
        '
        'txtScore1
        '
        Me.txtScore1.AcceptsReturn = True
        Me.txtScore1.AutoSize = False
        Me.txtScore1.BackColor = System.Drawing.SystemColors.Window
        Me.txtScore1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore1.Location = New System.Drawing.Point(160, 16)
        Me.txtScore1.MaxLength = 0
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtScore1.Size = New System.Drawing.Size(81, 19)
        Me.txtScore1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(76, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Letter Grade"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.BackColor = System.Drawing.SystemColors.Control
        Me.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLetterGrade.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterGrade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLetterGrade.Location = New System.Drawing.Point(156, 144)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLetterGrade.Size = New System.Drawing.Size(89, 17)
        Me.lblLetterGrade.TabIndex = 9
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverage.Location = New System.Drawing.Point(156, 120)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverage.Size = New System.Drawing.Size(89, 17)
        Me.lblAverage.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(68, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Average Score"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(72, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Test Score &3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(72, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test Score &2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(72, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Score &1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(340, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDropLowest)
        Me.Controls.Add(Me.btnShowGrade)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Average"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This application calculates the intAverage of three test scores.
    ' The intAverage can be calculated with the test scores as is, or
    ' with the lowest score dropped.

    ' Class-level variables.
    Dim intScore1 As Integer        ' Holds test score 1
    Dim intScore2 As Integer        ' Holds test score 2
    Dim intScore3 As Integer        ' Holds test score 3
	Dim intAverage As Integer		' Holds average test score

	Private Sub btnClear_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnClear.Click

		' Clear the fields on the form.
		txtScore1.Clear()
		txtScore2.Clear()
		txtScore3.Clear()
		lblAverage.Text = String.Empty
		lblLetterGrade.Text = String.Empty

		' Set the focus.
		txtScore1.Focus()
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnExit.Click

		' End the application.
		Me.Close()
	End Sub

	Private Sub btnShowGrade_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnShowGrade.Click

		' Calculate the intAverage test score and grade
		' without dropping the lowest score.

        '  call the displayGrade procedure
        GetScores()


		' Calculate the average test score.
		intAverage = CInt((intScore1 + intScore2 + intScore3) \ 3)

		' Call the DisplayGrade procedure here.
        DisplayGrade()
	End Sub

    Private Sub btnDropLowest_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnDropLowest.Click

        ' Drop the lowest test score, calculate the average
        ' score, and determine the letter grade.

        '  Call the displayGrade procedure
        GetScores()


        ' Determine the lowest score (intLowest).
        Dim intLowest As Integer = Math.Min(intScore1, intScore2)
        intLowest = Math.Min(intLowest, intScore3)

        ' Calculate the sum of all three scores.
        Dim intTotal As Integer = intScore1 + intScore2 + intScore3

        ' Calculate the average, dropping the lowest score.
        intAverage = CInt((intTotal - intLowest) / 2)

        ' Call the DisplayGrade procedure here.
        DisplayGrade()
    End Sub

	Sub GetScores()
        '  retrieve the test scores from the text boxes
        '  and store in variables
        intScore1 = CInt(txtScore1.Text)
        intScore2 = CInt(txtScore2.Text)
        intScore3 = CInt(txtScore3.Text)


	End Sub

    Sub DisplayGrade()
        '  display the invAverage score
        lblAverage.Text = intAverage.ToString()
        '  determine and display the letter grade 

        Select Case intAverage
            Case 90 To 100
                lblLetterGrade.Text = "A"
            Case 80 To 89
                lblLetterGrade.Text = "B"
            Case 70 To 79
                lblLetterGrade.Text = "C"
            Case 60 To 69
                lblLetterGrade.Text = "D"
            Case Else
                lblLetterGrade.Text = "F"

        End Select


    End Sub

End Class
