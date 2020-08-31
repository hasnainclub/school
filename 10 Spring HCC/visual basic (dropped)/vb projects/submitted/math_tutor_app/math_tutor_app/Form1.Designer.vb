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
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.btwShowAnswer = New System.Windows.Forms.Button
        Me.btwExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(45, 51)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(168, 47)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "18 + 64 = ?"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnswer
        '
        Me.lblAnswer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(45, 51)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(168, 47)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.Text = "18 + 64 = 82"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnswer.Visible = False
        '
        'btwShowAnswer
        '
        Me.btwShowAnswer.Location = New System.Drawing.Point(12, 160)
        Me.btwShowAnswer.Name = "btwShowAnswer"
        Me.btwShowAnswer.Size = New System.Drawing.Size(102, 23)
        Me.btwShowAnswer.TabIndex = 2
        Me.btwShowAnswer.Text = "Show Answer"
        Me.btwShowAnswer.UseVisualStyleBackColor = True
        '
        'btwExit
        '
        Me.btwExit.Location = New System.Drawing.Point(120, 160)
        Me.btwExit.Name = "btwExit"
        Me.btwExit.Size = New System.Drawing.Size(93, 23)
        Me.btwExit.TabIndex = 3
        Me.btwExit.Text = "Exit"
        Me.btwExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 244)
        Me.Controls.Add(Me.btwExit)
        Me.Controls.Add(Me.btwShowAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btwShowAnswer As System.Windows.Forms.Button
    Friend WithEvents btwExit As System.Windows.Forms.Button

End Class
