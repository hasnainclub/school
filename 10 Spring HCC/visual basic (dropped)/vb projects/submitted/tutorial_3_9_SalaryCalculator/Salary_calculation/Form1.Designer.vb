<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAnnualSalary = New System.Windows.Forms.Label
        Me.lblPayPeriodsYear = New System.Windows.Forms.Label
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox
        Me.txtPayPeriods = New System.Windows.Forms.TextBox
        Me.lblSalaryPayPeriod = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblAnnualSalary
        '
        Me.lblAnnualSalary.Location = New System.Drawing.Point(40, 25)
        Me.lblAnnualSalary.Name = "lblAnnualSalary"
        Me.lblAnnualSalary.Size = New System.Drawing.Size(100, 23)
        Me.lblAnnualSalary.TabIndex = 0
        Me.lblAnnualSalary.Text = "Annual Salary"
        '
        'lblPayPeriodsYear
        '
        Me.lblPayPeriodsYear.Location = New System.Drawing.Point(12, 67)
        Me.lblPayPeriodsYear.Name = "lblPayPeriodsYear"
        Me.lblPayPeriodsYear.Size = New System.Drawing.Size(128, 27)
        Me.lblPayPeriodsYear.TabIndex = 1
        Me.lblPayPeriodsYear.Text = "Pay periods per year"
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(151, 18)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualSalary.TabIndex = 2
        '
        'txtPayPeriods
        '
        Me.txtPayPeriods.Location = New System.Drawing.Point(151, 64)
        Me.txtPayPeriods.Name = "txtPayPeriods"
        Me.txtPayPeriods.Size = New System.Drawing.Size(100, 20)
        Me.txtPayPeriods.TabIndex = 3
        '
        'lblSalaryPayPeriod
        '
        Me.lblSalaryPayPeriod.Location = New System.Drawing.Point(12, 116)
        Me.lblSalaryPayPeriod.Name = "lblSalaryPayPeriod"
        Me.lblSalaryPayPeriod.Size = New System.Drawing.Size(128, 22)
        Me.lblSalaryPayPeriod.TabIndex = 4
        Me.lblSalaryPayPeriod.Text = "Salary per pay period"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(151, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(99, 175)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSalaryPayPeriod)
        Me.Controls.Add(Me.txtPayPeriods)
        Me.Controls.Add(Me.txtAnnualSalary)
        Me.Controls.Add(Me.lblPayPeriodsYear)
        Me.Controls.Add(Me.lblAnnualSalary)
        Me.Name = "Form1"
        Me.Text = "Salary Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnnualSalary As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodsYear As System.Windows.Forms.Label
    Friend WithEvents txtAnnualSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtPayPeriods As System.Windows.Forms.TextBox
    Friend WithEvents lblSalaryPayPeriod As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
