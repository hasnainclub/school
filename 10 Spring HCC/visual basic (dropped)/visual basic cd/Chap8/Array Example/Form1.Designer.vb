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
        Me.lstCities = New System.Windows.Forms.ListBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.lblResult = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstCities
        '
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.Items.AddRange(New Object() {"Chicago", "San Franciso", "Miami", "Phoenix", "New York", "Philadelphia"})
        Me.lstCities.Location = New System.Drawing.Point(17, 26)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(75, 95)
        Me.lstCities.TabIndex = 0
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(123, 23)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(120, 20)
        Me.txtCity.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(123, 58)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(105, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find a City"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(120, 111)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 139)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lstCities)
        Me.Name = "Form1"
        Me.Text = "Searching for Cities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstCities As System.Windows.Forms.ListBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
