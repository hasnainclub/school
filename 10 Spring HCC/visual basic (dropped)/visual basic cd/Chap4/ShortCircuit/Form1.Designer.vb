<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
		Me.btnOr = New System.Windows.Forms.Button
		Me.lblResult = New System.Windows.Forms.Label
		Me.btnOrElse = New System.Windows.Forms.Button
		Me.btnAndAlso = New System.Windows.Forms.Button
		Me.btnAnd = New System.Windows.Forms.Button
		Me.btnExit = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'btnOr
		'
		Me.btnOr.Location = New System.Drawing.Point(35, 30)
		Me.btnOr.Name = "btnOr"
		Me.btnOr.Size = New System.Drawing.Size(120, 23)
		Me.btnOr.TabIndex = 0
		Me.btnOr.Text = "OR Operator"
		'
		'lblResult
		'
		Me.lblResult.Location = New System.Drawing.Point(12, 112)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(326, 23)
		Me.lblResult.TabIndex = 1
		'
		'btnOrElse
		'
		Me.btnOrElse.Location = New System.Drawing.Point(35, 69)
		Me.btnOrElse.Name = "btnOrElse"
		Me.btnOrElse.Size = New System.Drawing.Size(120, 23)
		Me.btnOrElse.TabIndex = 2
		Me.btnOrElse.Text = "OrElse Operator"
		'
		'btnAndAlso
		'
		Me.btnAndAlso.Location = New System.Drawing.Point(195, 69)
		Me.btnAndAlso.Name = "btnAndAlso"
		Me.btnAndAlso.Size = New System.Drawing.Size(120, 23)
		Me.btnAndAlso.TabIndex = 4
		Me.btnAndAlso.Text = "AndAlso Operator"
		'
		'btnAnd
		'
		Me.btnAnd.Location = New System.Drawing.Point(195, 30)
		Me.btnAnd.Name = "btnAnd"
		Me.btnAnd.Size = New System.Drawing.Size(120, 23)
		Me.btnAnd.TabIndex = 3
		Me.btnAnd.Text = "AND Operator"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(129, 152)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(66, 23)
		Me.btnExit.TabIndex = 5
		Me.btnExit.Text = "Exit"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(350, 187)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnAndAlso)
		Me.Controls.Add(Me.btnAnd)
		Me.Controls.Add(Me.btnOrElse)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.btnOr)
		Me.Name = "Form1"
		Me.Text = "Short Circuit Evaluation"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents btnOr As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnOrElse As System.Windows.Forms.Button
    Friend WithEvents btnAndAlso As System.Windows.Forms.Button
    Friend WithEvents btnAnd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
