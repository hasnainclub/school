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
    Public WithEvents btnCheckQual As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtYearsOnJob As System.Windows.Forms.TextBox
    Public WithEvents txtSalary As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCheckQual = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtYearsOnJob = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(256, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(136, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(81, 33)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        '
        'btnCheckQual
        '
        Me.btnCheckQual.BackColor = System.Drawing.SystemColors.Control
        Me.btnCheckQual.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheckQual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckQual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCheckQual.Location = New System.Drawing.Point(16, 168)
        Me.btnCheckQual.Name = "btnCheckQual"
        Me.btnCheckQual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCheckQual.Size = New System.Drawing.Size(81, 33)
        Me.btnCheckQual.TabIndex = 2
        Me.btnCheckQual.Text = "Check &Qualifications"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtYearsOnJob, Me.txtSalary, Me.Label2, Me.Label1})
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(337, 113)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Enter the Following Information"
        '
        'txtYearsOnJob
        '
        Me.txtYearsOnJob.AcceptsReturn = True
        Me.txtYearsOnJob.AutoSize = False
        Me.txtYearsOnJob.BackColor = System.Drawing.SystemColors.Window
        Me.txtYearsOnJob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYearsOnJob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearsOnJob.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYearsOnJob.Location = New System.Drawing.Point(144, 72)
        Me.txtYearsOnJob.MaxLength = 0
        Me.txtYearsOnJob.Name = "txtYearsOnJob"
        Me.txtYearsOnJob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYearsOnJob.Size = New System.Drawing.Size(89, 19)
        Me.txtYearsOnJob.TabIndex = 3
        Me.txtYearsOnJob.Text = ""
        '
        'txtSalary
        '
        Me.txtSalary.AcceptsReturn = True
        Me.txtSalary.AutoSize = False
        Me.txtSalary.BackColor = System.Drawing.SystemColors.Window
        Me.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSalary.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSalary.Location = New System.Drawing.Point(144, 32)
        Me.txtSalary.MaxLength = 0
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSalary.Size = New System.Drawing.Size(89, 19)
        Me.txtSalary.TabIndex = 1
        Me.txtSalary.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of &Years at Your Current Job:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(56, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Annual Salary:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(8, 128)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(337, 25)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 214)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnClear, Me.btnCheckQual, Me.Frame1, Me.lblMessage})
        Me.Name = "Form1"
        Me.Text = "Loan Qualifier"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCheckQual_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCheckQual.Click

        '  retrieve and convert the salary and years
        '  from the text boxes

        Dim sngSalary As Single
        Dim intYearsOnJob As Integer

        Try
            sngSalary = CSng(txtSalary.Text)
            intYearsOnJob = CInt(txtYearsOnJob.Text)

        Catch ex As Exception
            MessageBox.Show("Salary and years on job must be valid numbers", "Error")
            Return

        End Try



        '  determine whether the applicant qualifies
        '  for the special loan

        If sngsalary > 30000 Then
            If intYearsOnJob > 2 Then
                lblMessage.Text = "The applicant qualifies"
            Else

                lblMessage.Text = "the applicant does not qualify"
            End If

        Else
            If intYearsOnJob > 5 Then
                lblMessage.Text = "the applicant qualifies"
            Else
                lblMessage.Text = "the applicant does not qualify"
            End If

        End If








    End Sub

	Private Sub btnClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClear.Click

		' Clear the Form's fields.
		txtSalary.Clear()
		txtYearsOnJob.Clear()
		lblMessage.Text = String.Empty
		txtSalary.Focus()
	End Sub

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click

		Me.Close()
    End Sub
End Class
