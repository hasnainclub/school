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
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblString = New System.Windows.Forms.Label
		Me.txtToFind = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.btnGo = New System.Windows.Forms.Button
		Me.lblResults = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.btnClose = New System.Windows.Forms.Button
		Me.Label2 = New System.Windows.Forms.Label
		Me.txtStartIndex = New System.Windows.Forms.TextBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(26, 20)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(125, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Contents of String:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblString
		'
		Me.lblString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblString.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString.ForeColor = System.Drawing.Color.Blue
		Me.lblString.Location = New System.Drawing.Point(28, 45)
		Me.lblString.Name = "lblString"
		Me.lblString.Size = New System.Drawing.Size(416, 20)
		Me.lblString.TabIndex = 1
		Me.lblString.Text = "abcABC00123573@ 123 ABC 98ABC123"
		'
		'txtToFind
		'
		Me.txtToFind.Location = New System.Drawing.Point(205, 117)
		Me.txtToFind.Name = "txtToFind"
		Me.txtToFind.Size = New System.Drawing.Size(102, 22)
		Me.txtToFind.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(29, 120)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(173, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Character or string to find:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnGo
		'
		Me.btnGo.Location = New System.Drawing.Point(344, 141)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.Size = New System.Drawing.Size(62, 27)
		Me.btnGo.TabIndex = 4
		Me.btnGo.Text = "Go"
		'
		'lblResults
		'
		Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResults.Location = New System.Drawing.Point(28, 188)
		Me.lblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblResults.Name = "lblResults"
		Me.lblResults.Size = New System.Drawing.Size(411, 22)
		Me.lblResults.TabIndex = 5
		Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(29, 65)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(415, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "0123456789012345678901234567890123456"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(377, 231)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(62, 23)
		Me.btnClose.TabIndex = 7
		Me.btnClose.Text = "Close"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(40, 151)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(157, 17)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Start searching at index"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtStartIndex
		'
		Me.txtStartIndex.Location = New System.Drawing.Point(205, 148)
		Me.txtStartIndex.Name = "txtStartIndex"
		Me.txtStartIndex.Size = New System.Drawing.Size(35, 22)
		Me.txtStartIndex.TabIndex = 8
		Me.txtStartIndex.Text = "0"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(124, 83)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(26, 17)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "10"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(225, 83)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(26, 17)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "20"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(325, 83)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(26, 17)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "30"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(466, 266)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtStartIndex)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.lblResults)
		Me.Controls.Add(Me.btnGo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtToFind)
		Me.Controls.Add(Me.lblString)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "String Finder"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblString As System.Windows.Forms.Label
    Friend WithEvents txtToFind As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStartIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
