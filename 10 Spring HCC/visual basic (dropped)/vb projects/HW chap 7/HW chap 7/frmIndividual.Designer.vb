<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividual
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radModel1 = New System.Windows.Forms.RadioButton
        Me.radModel2 = New System.Windows.Forms.RadioButton
        Me.radModel3 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radMinsThree = New System.Windows.Forms.RadioButton
        Me.radMinsEight = New System.Windows.Forms.RadioButton
        Me.radMinsSixteen = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkTxtMail = New System.Windows.Forms.CheckBox
        Me.chkVcMail = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblPackageCharge = New System.Windows.Forms.Label
        Me.lblTotalMonthly = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblOptions = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPhoneTotal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radModel1)
        Me.GroupBox1.Controls.Add(Me.radModel2)
        Me.GroupBox1.Controls.Add(Me.radModel3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a phone"
        '
        'radModel1
        '
        Me.radModel1.AutoSize = True
        Me.radModel1.Location = New System.Drawing.Point(6, 19)
        Me.radModel1.Name = "radModel1"
        Me.radModel1.Size = New System.Drawing.Size(75, 17)
        Me.radModel1.TabIndex = 0
        Me.radModel1.TabStop = True
        Me.radModel1.Text = "Model 100"
        Me.radModel1.UseVisualStyleBackColor = True
        '
        'radModel2
        '
        Me.radModel2.AutoSize = True
        Me.radModel2.Location = New System.Drawing.Point(6, 42)
        Me.radModel2.Name = "radModel2"
        Me.radModel2.Size = New System.Drawing.Size(75, 17)
        Me.radModel2.TabIndex = 1
        Me.radModel2.TabStop = True
        Me.radModel2.Text = "Model 110"
        Me.radModel2.UseVisualStyleBackColor = True
        '
        'radModel3
        '
        Me.radModel3.AutoSize = True
        Me.radModel3.Location = New System.Drawing.Point(6, 65)
        Me.radModel3.Name = "radModel3"
        Me.radModel3.Size = New System.Drawing.Size(75, 17)
        Me.radModel3.TabIndex = 2
        Me.radModel3.TabStop = True
        Me.radModel3.Text = "Model 200"
        Me.radModel3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radMinsThree)
        Me.GroupBox2.Controls.Add(Me.radMinsEight)
        Me.GroupBox2.Controls.Add(Me.radMinsSixteen)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a package"
        '
        'radMinsThree
        '
        Me.radMinsThree.AutoSize = True
        Me.radMinsThree.Location = New System.Drawing.Point(6, 19)
        Me.radMinsThree.Name = "radMinsThree"
        Me.radMinsThree.Size = New System.Drawing.Size(103, 17)
        Me.radMinsThree.TabIndex = 3
        Me.radMinsThree.TabStop = True
        Me.radMinsThree.Text = "300 Mins/Month"
        Me.radMinsThree.UseVisualStyleBackColor = True
        '
        'radMinsEight
        '
        Me.radMinsEight.AutoSize = True
        Me.radMinsEight.Location = New System.Drawing.Point(6, 42)
        Me.radMinsEight.Name = "radMinsEight"
        Me.radMinsEight.Size = New System.Drawing.Size(103, 17)
        Me.radMinsEight.TabIndex = 4
        Me.radMinsEight.TabStop = True
        Me.radMinsEight.Text = "800 Mins/Month"
        Me.radMinsEight.UseVisualStyleBackColor = True
        '
        'radMinsSixteen
        '
        Me.radMinsSixteen.AutoSize = True
        Me.radMinsSixteen.Location = New System.Drawing.Point(6, 65)
        Me.radMinsSixteen.Name = "radMinsSixteen"
        Me.radMinsSixteen.Size = New System.Drawing.Size(109, 17)
        Me.radMinsSixteen.TabIndex = 5
        Me.radMinsSixteen.TabStop = True
        Me.radMinsSixteen.Text = "1600 Mins/Month"
        Me.radMinsSixteen.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTxtMail)
        Me.GroupBox3.Controls.Add(Me.chkVcMail)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Options"
        '
        'chkTxtMail
        '
        Me.chkTxtMail.AutoSize = True
        Me.chkTxtMail.Location = New System.Drawing.Point(17, 57)
        Me.chkTxtMail.Name = "chkTxtMail"
        Me.chkTxtMail.Size = New System.Drawing.Size(101, 17)
        Me.chkTxtMail.TabIndex = 1
        Me.chkTxtMail.Text = "Text Messaging"
        Me.chkTxtMail.UseVisualStyleBackColor = True
        '
        'chkVcMail
        '
        Me.chkVcMail.AutoSize = True
        Me.chkVcMail.Location = New System.Drawing.Point(17, 19)
        Me.chkVcMail.Name = "chkVcMail"
        Me.chkVcMail.Size = New System.Drawing.Size(72, 17)
        Me.chkVcMail.TabIndex = 0
        Me.chkVcMail.Text = "VoiceMail"
        Me.chkVcMail.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPackageCharge)
        Me.GroupBox4.Controls.Add(Me.lblTotalMonthly)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lblOptions)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblPhoneTotal)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lblSubTotal)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(228, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 188)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totals"
        '
        'lblPackageCharge
        '
        Me.lblPackageCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageCharge.Location = New System.Drawing.Point(155, 106)
        Me.lblPackageCharge.Name = "lblPackageCharge"
        Me.lblPackageCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblPackageCharge.TabIndex = 1
        '
        'lblTotalMonthly
        '
        Me.lblTotalMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMonthly.Location = New System.Drawing.Point(155, 129)
        Me.lblTotalMonthly.Name = "lblTotalMonthly"
        Me.lblTotalMonthly.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalMonthly.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Total Monthly Charge"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Package Charge"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(155, 80)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(100, 23)
        Me.lblOptions.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Options"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Location = New System.Drawing.Point(155, 57)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPhoneTotal.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(155, 35)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tax"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(155, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubTotal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phone Subtotal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(123, 328)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(348, 328)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 398)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmIndividual"
        Me.Text = "frmIndividual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radModel1 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel2 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel3 As System.Windows.Forms.RadioButton
    Friend WithEvents radMinsThree As System.Windows.Forms.RadioButton
    Friend WithEvents radMinsEight As System.Windows.Forms.RadioButton
    Friend WithEvents radMinsSixteen As System.Windows.Forms.RadioButton
    Friend WithEvents chkTxtMail As System.Windows.Forms.CheckBox
    Friend WithEvents chkVcMail As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPhoneTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPackageCharge As System.Windows.Forms.Label
    Friend WithEvents lblTotalMonthly As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
