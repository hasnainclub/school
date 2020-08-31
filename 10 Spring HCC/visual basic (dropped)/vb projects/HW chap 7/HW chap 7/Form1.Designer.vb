<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblFamilyUseless = New System.Windows.Forms.Label
        Me.lblIndividualUseless = New System.Windows.Forms.Label
        Me.btnFamily = New System.Windows.Forms.Button
        Me.btnIndividual = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFamilyUseless)
        Me.GroupBox1.Controls.Add(Me.lblIndividualUseless)
        Me.GroupBox1.Controls.Add(Me.btnFamily)
        Me.GroupBox1.Controls.Add(Me.btnIndividual)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 282)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Plan"
        '
        'lblFamilyUseless
        '
        Me.lblFamilyUseless.Location = New System.Drawing.Point(6, 174)
        Me.lblFamilyUseless.Name = "lblFamilyUseless"
        Me.lblFamilyUseless.Size = New System.Drawing.Size(266, 89)
        Me.lblFamilyUseless.TabIndex = 3
        Me.lblFamilyUseless.Text = "The family plan allows you to purchase multiple cell phones of the same model wit" & _
            "h each phone sharing one montly package"
        '
        'lblIndividualUseless
        '
        Me.lblIndividualUseless.Location = New System.Drawing.Point(6, 48)
        Me.lblIndividualUseless.Name = "lblIndividualUseless"
        Me.lblIndividualUseless.Size = New System.Drawing.Size(266, 89)
        Me.lblIndividualUseless.TabIndex = 2
        Me.lblIndividualUseless.Text = "The Individual plan provides one cell phone and a varity of montly packages"
        '
        'btnFamily
        '
        Me.btnFamily.Location = New System.Drawing.Point(336, 174)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(75, 23)
        Me.btnFamily.TabIndex = 1
        Me.btnFamily.Text = "&Family"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(336, 48)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(75, 23)
        Me.btnIndividual.TabIndex = 0
        Me.btnIndividual.Text = "&Individual"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 342)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFamilyUseless As System.Windows.Forms.Label
    Friend WithEvents lblIndividualUseless As System.Windows.Forms.Label
    Friend WithEvents btnFamily As System.Windows.Forms.Button
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
