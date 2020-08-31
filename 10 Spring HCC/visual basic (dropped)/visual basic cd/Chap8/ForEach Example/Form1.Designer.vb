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
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnLargest = New System.Windows.Forms.Button
        Me.btnSum = New System.Windows.Forms.Button
        Me.lblResult = New System.Windows.Forms.Label
        Me.lstShow = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 21)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(200, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print the array"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnLargest
        '
        Me.btnLargest.Location = New System.Drawing.Point(12, 61)
        Me.btnLargest.Name = "btnLargest"
        Me.btnLargest.Size = New System.Drawing.Size(200, 23)
        Me.btnLargest.TabIndex = 1
        Me.btnLargest.Text = "Find largest"
        Me.btnLargest.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(12, 102)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(200, 23)
        Me.btnSum.TabIndex = 2
        Me.btnSum.Text = "Calculate sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(19, 146)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 3
        '
        'lstShow
        '
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.Location = New System.Drawing.Point(239, 12)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(46, 147)
        Me.lstShow.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 185)
        Me.Controls.Add(Me.lstShow)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnLargest)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "Form1"
        Me.Text = "ForEach Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnLargest As System.Windows.Forms.Button
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lstShow As System.Windows.Forms.ListBox

End Class
