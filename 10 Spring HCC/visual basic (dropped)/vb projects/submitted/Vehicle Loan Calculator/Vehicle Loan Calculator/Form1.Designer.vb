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
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.txtDownPayment = New System.Windows.Forms.TextBox
        Me.txtMonths = New System.Windows.Forms.TextBox
        Me.radNew = New System.Windows.Forms.RadioButton
        Me.radUsed = New System.Windows.Forms.RadioButton
        Me.lblAnnInt = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(144, 19)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(114, 20)
        Me.txtCost.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCost, "Enter the cost of the vehicle here")
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(144, 64)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(114, 20)
        Me.txtDownPayment.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtDownPayment, "Enter the amount of the down payment here")
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(144, 106)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(114, 20)
        Me.txtMonths.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtMonths, "Enter the number of months of the loan here")
        '
        'radNew
        '
        Me.radNew.Location = New System.Drawing.Point(42, 40)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(187, 24)
        Me.radNew.TabIndex = 0
        Me.radNew.TabStop = True
        Me.radNew.Text = "&New"
        Me.ToolTip1.SetToolTip(Me.radNew, "Click here if the vehicle is new")
        Me.radNew.UseVisualStyleBackColor = True
        '
        'radUsed
        '
        Me.radUsed.Location = New System.Drawing.Point(42, 81)
        Me.radUsed.Name = "radUsed"
        Me.radUsed.Size = New System.Drawing.Size(187, 24)
        Me.radUsed.TabIndex = 1
        Me.radUsed.TabStop = True
        Me.radUsed.Text = "&Used"
        Me.ToolTip1.SetToolTip(Me.radUsed, "Click here if the vehicle is used")
        Me.radUsed.UseVisualStyleBackColor = True
        '
        'lblAnnInt
        '
        Me.lblAnnInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnInt.Location = New System.Drawing.Point(337, 16)
        Me.lblAnnInt.Name = "lblAnnInt"
        Me.lblAnnInt.Size = New System.Drawing.Size(192, 23)
        Me.lblAnnInt.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.lblAnnInt, "Annual Interest Rate")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(51, 462)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click here to calculate the payment data")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.CausesValidation = False
        Me.btnClear.Location = New System.Drawing.Point(214, 462)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click here to clear the form")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.CausesValidation = False
        Me.btnExit.Location = New System.Drawing.Point(393, 462)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.txtDownPayment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMonths)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle && Loan Information"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cost of &Vehicle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount of &Down Payment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of &Months"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUsed)
        Me.GroupBox2.Controls.Add(Me.radNew)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New or Used Vehicle"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstOutput)
        Me.GroupBox3.Controls.Add(Me.lblAnnInt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(535, 295)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interest and Principal Payments"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(6, 43)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(523, 251)
        Me.lstOutput.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(209, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Annual Intereest Rate"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 493)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtDownPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents radUsed As System.Windows.Forms.RadioButton
    Friend WithEvents radNew As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents lblAnnInt As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
