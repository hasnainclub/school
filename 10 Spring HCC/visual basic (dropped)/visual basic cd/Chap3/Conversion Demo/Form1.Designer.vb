<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.txtInput = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.btnString = New System.Windows.Forms.RadioButton
		Me.btnInteger = New System.Windows.Forms.RadioButton
		Me.btnDecimal = New System.Windows.Forms.RadioButton
		Me.btnDouble = New System.Windows.Forms.RadioButton
		Me.btnDate = New System.Windows.Forms.RadioButton
		Me.lblResult = New System.Windows.Forms.Label
		Me.btnGo = New System.Windows.Forms.Button
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtInput
		'
		Me.txtInput.Location = New System.Drawing.Point(167, 30)
		Me.txtInput.Margin = New System.Windows.Forms.Padding(4)
		Me.txtInput.Name = "txtInput"
		Me.txtInput.Size = New System.Drawing.Size(236, 23)
		Me.txtInput.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(25, 18)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 64)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Type a value that you would like to convert"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnString)
		Me.GroupBox1.Controls.Add(Me.btnInteger)
		Me.GroupBox1.Controls.Add(Me.btnDecimal)
		Me.GroupBox1.Controls.Add(Me.btnDouble)
		Me.GroupBox1.Controls.Add(Me.btnDate)
		Me.GroupBox1.Location = New System.Drawing.Point(28, 86)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(285, 116)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Select a conversion function"
		'
		'btnString
		'
		Me.btnString.AutoSize = True
		Me.btnString.Location = New System.Drawing.Point(47, 81)
		Me.btnString.Margin = New System.Windows.Forms.Padding(4)
		Me.btnString.Name = "btnString"
		Me.btnString.Size = New System.Drawing.Size(53, 21)
		Me.btnString.TabIndex = 4
		Me.btnString.TabStop = True
		Me.btnString.Text = "CStr"
		Me.btnString.UseVisualStyleBackColor = True
		'
		'btnInteger
		'
		Me.btnInteger.AutoSize = True
		Me.btnInteger.Location = New System.Drawing.Point(181, 52)
		Me.btnInteger.Margin = New System.Windows.Forms.Padding(4)
		Me.btnInteger.Name = "btnInteger"
		Me.btnInteger.Size = New System.Drawing.Size(50, 21)
		Me.btnInteger.TabIndex = 3
		Me.btnInteger.TabStop = True
		Me.btnInteger.Text = "CInt"
		Me.btnInteger.UseVisualStyleBackColor = True
		'
		'btnDecimal
		'
		Me.btnDecimal.AutoSize = True
		Me.btnDecimal.Location = New System.Drawing.Point(181, 24)
		Me.btnDecimal.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDecimal.Name = "btnDecimal"
		Me.btnDecimal.Size = New System.Drawing.Size(60, 21)
		Me.btnDecimal.TabIndex = 2
		Me.btnDecimal.TabStop = True
		Me.btnDecimal.Text = "CDec"
		Me.btnDecimal.UseVisualStyleBackColor = True
		'
		'btnDouble
		'
		Me.btnDouble.AutoSize = True
		Me.btnDouble.Location = New System.Drawing.Point(47, 52)
		Me.btnDouble.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDouble.Name = "btnDouble"
		Me.btnDouble.Size = New System.Drawing.Size(56, 21)
		Me.btnDouble.TabIndex = 1
		Me.btnDouble.TabStop = True
		Me.btnDouble.Text = "CDbl"
		Me.btnDouble.UseVisualStyleBackColor = True
		'
		'btnDate
		'
		Me.btnDate.AutoSize = True
		Me.btnDate.Location = New System.Drawing.Point(47, 23)
		Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDate.Name = "btnDate"
		Me.btnDate.Size = New System.Drawing.Size(65, 21)
		Me.btnDate.TabIndex = 0
		Me.btnDate.TabStop = True
		Me.btnDate.Text = "CDate"
		Me.btnDate.UseVisualStyleBackColor = True
		'
		'lblResult
		'
		Me.lblResult.AutoSize = True
		Me.lblResult.Location = New System.Drawing.Point(25, 217)
		Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(53, 17)
		Me.lblResult.TabIndex = 3
		Me.lblResult.Text = "(result)"
		'
		'btnGo
		'
		Me.btnGo.Location = New System.Drawing.Point(328, 128)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.Size = New System.Drawing.Size(75, 31)
		Me.btnGo.TabIndex = 4
		Me.btnGo.Text = "Go"
		Me.btnGo.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(436, 248)
		Me.Controls.Add(Me.btnGo)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtInput)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Conversion Demo"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtInput As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents btnString As System.Windows.Forms.RadioButton
	Friend WithEvents btnInteger As System.Windows.Forms.RadioButton
	Friend WithEvents btnDecimal As System.Windows.Forms.RadioButton
	Friend WithEvents btnDouble As System.Windows.Forms.RadioButton
	Friend WithEvents btnDate As System.Windows.Forms.RadioButton
	Friend WithEvents lblResult As System.Windows.Forms.Label
	Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
