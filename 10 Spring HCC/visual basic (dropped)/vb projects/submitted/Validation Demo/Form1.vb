Public Class Form1
	Inherits System.Windows.Forms.Form

	' Updated 1/4/06 (Tool tips removed)

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
	Public WithEvents btnCalculate As System.Windows.Forms.Button
	Public WithEvents txtNum2 As System.Windows.Forms.TextBox
    Public WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblMessage As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtNum2 = New System.Windows.Forms.TextBox
        Me.txtNum1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(129, 93)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(32, 93)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click here to add the two numbers")
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtNum2
        '
        Me.txtNum2.AcceptsReturn = True
        Me.txtNum2.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum2.Location = New System.Drawing.Point(129, 56)
        Me.txtNum2.MaxLength = 0
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum2.Size = New System.Drawing.Size(81, 20)
        Me.txtNum2.TabIndex = 6
        '
        'txtNum1
        '
        Me.txtNum1.AcceptsReturn = True
        Me.txtNum1.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum1.Location = New System.Drawing.Point(26, 56)
        Me.txtNum1.MaxLength = 0
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum1.Size = New System.Drawing.Size(81, 20)
        Me.txtNum1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtNum1, "Enter the first number here")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(207, 35)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter two numbers in the range 1 - 10 and I will sum them."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(23, 119)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(187, 26)
        Me.lblMessage.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(248, 154)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Validation Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnCalculate_Click(ByVal eventSender As System.Object, _
     ByVal eventArgs As System.EventArgs) Handles btnCalculate.Click

        ' Display the sum of the two numbers.
        Dim sngSum As Single = CSng(txtNum1.Text) + CSng(txtNum2.Text)
        lblMessage.BackColor = Color.Empty
        lblMessage.Text = "The sum is " + sngSum.ToString()
    End Sub

    Private Sub ErrMessage(ByVal strMsg As String)

        lblMessage.BackColor = Color.Yellow
        lblMessage.Text = strMsg
    End Sub

    Private Sub txtNum1_Validating(ByVal sender As Object, _
     ByVal e As System.ComponentModel.CancelEventArgs) _
     Handles txtNum1.Validating
        '  if Validate the number entered by the user
        If IsNumeric(txtNum1.Text) Then
            Dim sngValue As Single
            sngValue = CSng(txtNum1.Text)
            If sngValue < 1 Or sngValue > 10 Then
                '  desiplay an error message
                lblMessage.BackColor = Color.Yellow
                lblMessage.Text = "Enter a value in the range of 1-10 "
                e.Cancel = True
                txtNum1.SelectAll()

            Else
                e.Cancel = False


            End If



        Else
            ' display an error message
            lblMessage.BackColor = Color.Yellow
            lblMessage.Text = "The first value must be a number"
            e.Cancel = True
            txtNum1.SelectAll()
        End If


    End Sub

    Private Sub txtNum2_Validating(ByVal sender As Object, _
     ByVal e As System.ComponentModel.CancelEventArgs) _
     Handles txtNum2.Validating
        '  VALIDATE THE NUMBER ENTERED BY THE USER
        If IsNumeric(txtNum2.Text) Then
            Dim sngValue As Single
            sngValue = CSng(txtNum2.Text)
            If sngValue < 1 Or sngValue > 10 Then
                '  display an error message
                lblMessage.BackColor = Color.Yellow
                lblMessage.Text = "Enter a value in theh range 1-10"
                e.Cancel = True
                txtNum2.SelectAll()
            Else
                e.Cancel = False

            End If
        Else
            '  display an error msg
            lblMessage.BackColor = Color.Yellow
            lblMessage.Text = " the first value must be a number"
            txtNum2.SelectAll()
            e.Cancel = True

        End If


    End Sub

    Private Sub btnExit_Click(ByVal eventSender As System.Object, _
     ByVal eventArgs As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub


    
End Class
