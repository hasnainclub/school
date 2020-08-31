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
		Me.txtValue = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnTryParse = New System.Windows.Forms.Button
		Me.lblResult = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'txtValue
		'
		Me.txtValue.Location = New System.Drawing.Point(109, 21)
		Me.txtValue.Name = "txtValue"
		Me.txtValue.Size = New System.Drawing.Size(91, 20)
		Me.txtValue.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(18, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(85, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Enter an integer:"
		'
		'btnTryParse
		'
		Me.btnTryParse.Location = New System.Drawing.Point(21, 58)
		Me.btnTryParse.Name = "btnTryParse"
		Me.btnTryParse.Size = New System.Drawing.Size(105, 23)
		Me.btnTryParse.TabIndex = 2
		Me.btnTryParse.Text = "Call TryParse"
		Me.btnTryParse.UseVisualStyleBackColor = True
		'
		'lblResult
		'
		Me.lblResult.Location = New System.Drawing.Point(18, 95)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(227, 19)
		Me.lblResult.TabIndex = 3
		Me.lblResult.Text = "(result)"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(297, 137)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.btnTryParse)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtValue)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Using the TryParse Method"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtValue As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnTryParse As System.Windows.Forms.Button
	Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
