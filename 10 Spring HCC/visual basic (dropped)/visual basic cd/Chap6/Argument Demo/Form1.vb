Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnDemo3 As System.Windows.Forms.Button
    Public WithEvents btnDemo2 As System.Windows.Forms.Button
    Public WithEvents btnDemo1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDemo3 = New System.Windows.Forms.Button
        Me.btnDemo2 = New System.Windows.Forms.Button
        Me.btnDemo1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(88, 56)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDemo3
        '
        Me.btnDemo3.BackColor = System.Drawing.SystemColors.Control
        Me.btnDemo3.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDemo3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemo3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDemo3.Location = New System.Drawing.Point(168, 24)
        Me.btnDemo3.Name = "btnDemo3"
        Me.btnDemo3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDemo3.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo3.TabIndex = 6
        Me.btnDemo3.Text = "Demo &3"
        Me.btnDemo3.UseVisualStyleBackColor = False
        '
        'btnDemo2
        '
        Me.btnDemo2.BackColor = System.Drawing.SystemColors.Control
        Me.btnDemo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDemo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDemo2.Location = New System.Drawing.Point(88, 24)
        Me.btnDemo2.Name = "btnDemo2"
        Me.btnDemo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDemo2.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo2.TabIndex = 5
        Me.btnDemo2.Text = "Demo &2"
        Me.btnDemo2.UseVisualStyleBackColor = False
        '
        'btnDemo1
        '
        Me.btnDemo1.BackColor = System.Drawing.SystemColors.Control
        Me.btnDemo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDemo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDemo1.Location = New System.Drawing.Point(8, 24)
        Me.btnDemo1.Name = "btnDemo1"
        Me.btnDemo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDemo1.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo1.TabIndex = 4
        Me.btnDemo1.Text = "Demo &1"
        Me.btnDemo1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(248, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDemo3)
        Me.Controls.Add(Me.btnDemo2)
        Me.Controls.Add(Me.btnDemo1)
        Me.Name = "Form1"
        Me.Text = "Argument Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region


	Private Sub btnDemo1_Click(ByVal sender As System.Object, _
	  ByVal e As System.EventArgs) Handles btnDemo1.Click

		' This procedure passes an argument to the
		' DisplayValue procedure.

		DisplayValue(5)
	End Sub

	Private Sub btnDemo2_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnDemo2.Click

		' This procedure calls the DisplayValue procedure
		' several times, passing different arguments.
		DisplayValue(5)
		DisplayValue(10)
		DisplayValue(2)
		DisplayValue(16)

		' The value of an expression is passed to the
		' DisplayValue procedure.
		DisplayValue(3 + 5)
	End Sub

	Private Sub btnDemo3_Click(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles btnDemo3.Click

		' This procedure uses a loop to call the DisplayValue
		' procedure, passing a variable as the argument.
		Dim intCount As Integer

		For intCount = 1 To 10
			DisplayValue(intCount)
        Next intCount
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, _
	   ByVal e As System.EventArgs) Handles btnExit.Click

		Me.Close()
	End Sub

	Private Sub DisplayValue(ByRef intNumber As Short)

		' This procedure displays a value in a message box.
		MessageBox.Show(intNumber.ToString())
	End Sub

End Class
