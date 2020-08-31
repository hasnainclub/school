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
		Me.btnGo = New System.Windows.Forms.Button
		Me.lblResult = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'btnGo
		'
		Me.btnGo.Location = New System.Drawing.Point(25, 12)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.Size = New System.Drawing.Size(75, 23)
		Me.btnGo.TabIndex = 0
		Me.btnGo.Text = "Go"
		Me.btnGo.UseVisualStyleBackColor = True
		'
		'lblResult
		'
		Me.lblResult.Location = New System.Drawing.Point(22, 47)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(242, 50)
		Me.lblResult.TabIndex = 1
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(286, 122)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.btnGo)
		Me.Name = "Form1"
		Me.Text = "Employee Collection"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnGo As System.Windows.Forms.Button
	Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
