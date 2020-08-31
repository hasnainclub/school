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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnCalculate As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtScore3 As System.Windows.Forms.TextBox
    Public WithEvents txtScore2 As System.Windows.Forms.TextBox
    Public WithEvents txtScore1 As System.Windows.Forms.TextBox
    Public WithEvents lblAverage As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblgradeDisp As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.lblGrade = New System.Windows.Forms.Label
        Me.lblgradeDisp = New System.Windows.Forms.Label
        Me.txtScore3 = New System.Windows.Forms.TextBox
        Me.txtScore2 = New System.Windows.Forms.TextBox
        Me.txtScore1 = New System.Windows.Forms.TextBox
        Me.lblAverage = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(135, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 23)
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
        Me.btnClear.Location = New System.Drawing.Point(135, 225)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(81, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(27, 238)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(81, 39)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate &Average"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.lblGrade)
        Me.Frame1.Controls.Add(Me.lblgradeDisp)
        Me.Frame1.Controls.Add(Me.txtScore3)
        Me.Frame1.Controls.Add(Me.txtScore2)
        Me.Frame1.Controls.Add(Me.txtScore1)
        Me.Frame1.Controls.Add(Me.lblAverage)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(219, 173)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Enter Three Test Scores"
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(85, 138)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(68, 23)
        Me.lblGrade.TabIndex = 12
        '
        'lblgradeDisp
        '
        Me.lblgradeDisp.Location = New System.Drawing.Point(24, 148)
        Me.lblgradeDisp.Name = "lblgradeDisp"
        Me.lblgradeDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblgradeDisp.TabIndex = 5
        Me.lblgradeDisp.Text = "Grade:"
        '
        'txtScore3
        '
        Me.txtScore3.AcceptsReturn = True
        Me.txtScore3.BackColor = System.Drawing.SystemColors.Window
        Me.txtScore3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore3.Location = New System.Drawing.Point(88, 80)
        Me.txtScore3.MaxLength = 0
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtScore3.Size = New System.Drawing.Size(65, 20)
        Me.txtScore3.TabIndex = 5
        '
        'txtScore2
        '
        Me.txtScore2.AcceptsReturn = True
        Me.txtScore2.BackColor = System.Drawing.SystemColors.Window
        Me.txtScore2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore2.Location = New System.Drawing.Point(88, 56)
        Me.txtScore2.MaxLength = 0
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtScore2.Size = New System.Drawing.Size(65, 20)
        Me.txtScore2.TabIndex = 3
        '
        'txtScore1
        '
        Me.txtScore1.AcceptsReturn = True
        Me.txtScore1.BackColor = System.Drawing.SystemColors.Window
        Me.txtScore1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtScore1.Location = New System.Drawing.Point(88, 32)
        Me.txtScore1.MaxLength = 0
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtScore1.Size = New System.Drawing.Size(65, 20)
        Me.txtScore1.TabIndex = 1
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverage.Location = New System.Drawing.Point(88, 112)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverage.Size = New System.Drawing.Size(65, 17)
        Me.lblAverage.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(24, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Average:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Score &3:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Score &2:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score &1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(29, 184)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(192, 25)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(250, 307)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "Form1"
        Me.Text = "5"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClear_Click(ByVal eventSender As System.Object, _
       ByVal eventArgs As System.EventArgs) Handles btnClear.Click

        ' Clear the Text Boxes and Labels
        txtScore1.Text = ""
        txtScore2.Text = ""
        txtScore3.Text = ""
        lblAverage.Text = ""
        lblMessage.Text = ""
        lblGrade.Text = String.Empty

        ' Reset the focus
        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal eventSender As System.Object, _
        ByVal eventArgs As System.EventArgs) Handles btnExit.Click

        ' End the application by closing the window
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '  this procedure calculates and displays the 
        '  average test score.  If the score is high, it 
        '  Displays a congratulatory message
        Const sngGOOD_SCORE As Single = 95
        Dim sngscore1 As Single
        Dim sngscore2 As Single
        Dim sngscore3 As Single
        Dim sngaverage As Single

        '  copy the scores into the variables
        Try
            sngscore1 = CSng(txtScore1.Text)
            sngscore2 = CSng(txtScore2.Text)
            sngscore3 = CSng(txtScore3.Text)

        Catch Ex As Exception
            MessageBox.Show("Test scores must be numeric", "Error")
            Return
        End Try
        '  calculate and display the avg

        sngaverage = (sngscore1 + sngscore2 + sngscore3) / 3
        lblAverage.Text = sngaverage.ToString("n")

        '  calculate and display the letter grade
        If sngaverage < 60 Then
            lblAverage.Text = "F"
        ElseIf sngaverage < 70 Then
            lblGrade.Text = "D"
        ElseIf sngaverage < 80 Then
            lblGrade.Text = "C"
        ElseIf sngaverage < 90 Then
            lblGrade.Text = "A"
        ElseIf sngaverage <= 100 Then
            lblGrade.Text = "A"
        Else
            lblGrade.Text = "LOL"

        End If



        '  if the score is high give the student a praise
        '  otherwise give the student  some encouragement

        If sngaverage > sngGOOD_SCORE And sngaverage < 101 Then
            lblMessage.Text = "Congratulations!!!  great job!"
        ElseIf sngaverage > 100 Then
            lblMessage.Text = "Lier lier pants on fire!!!"
        Else
            lblMessage.Text = "Keep trying"

        End If

    End Sub
End Class
