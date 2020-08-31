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
		Me.Label1 = New System.Windows.Forms.Label
		Me.rtbMoby = New System.Windows.Forms.RichTextBox
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(205, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Moby Dick by Herman Melville,  Chapter 1"
		'
		'rtbMoby
		'
		Me.rtbMoby.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtbMoby.BackColor = System.Drawing.SystemColors.Window
		Me.rtbMoby.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtbMoby.Location = New System.Drawing.Point(9, 39)
		Me.rtbMoby.Name = "rtbMoby"
		Me.rtbMoby.ReadOnly = True
		Me.rtbMoby.Size = New System.Drawing.Size(676, 383)
		Me.rtbMoby.TabIndex = 2
		Me.rtbMoby.Text = ""
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(697, 434)
		Me.Controls.Add(Me.rtbMoby)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "My.Computer.FileSystem.ReadAllText"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents rtbMoby As System.Windows.Forms.RichTextBox

End Class
