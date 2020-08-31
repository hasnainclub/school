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
    Public WithEvents btnAverage As System.Windows.Forms.Button
    Public WithEvents btnSum As System.Windows.Forms.Button
    Public WithEvents txtNum3 As System.Windows.Forms.TextBox
    Public WithEvents txtNum2 As System.Windows.Forms.TextBox
    Public WithEvents txtNum1 As System.Windows.Forms.TextBox
    Public WithEvents lblAverage As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblSum As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(200, 160)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.SystemColors.Control
        Me.btnAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAverage.Location = New System.Drawing.Point(104, 160)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAverage.Size = New System.Drawing.Size(81, 33)
        Me.btnAverage.TabIndex = 20
        Me.btnAverage.Text = "Show &Average"
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.SystemColors.Control
        Me.btnSum.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSum.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSum.Location = New System.Drawing.Point(8, 160)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSum.Size = New System.Drawing.Size(81, 33)
        Me.btnSum.TabIndex = 19
        Me.btnSum.Text = "Show &Sum"
        '
        'txtNum3
        '
        Me.txtNum3.AcceptsReturn = True
        Me.txtNum3.AutoSize = False
        Me.txtNum3.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum3.Location = New System.Drawing.Point(8, 96)
        Me.txtNum3.MaxLength = 0
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum3.Size = New System.Drawing.Size(81, 19)
        Me.txtNum3.TabIndex = 14
        Me.txtNum3.Text = ""
        '
        'txtNum2
        '
        Me.txtNum2.AcceptsReturn = True
        Me.txtNum2.AutoSize = False
        Me.txtNum2.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum2.Location = New System.Drawing.Point(8, 64)
        Me.txtNum2.MaxLength = 0
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum2.Size = New System.Drawing.Size(81, 19)
        Me.txtNum2.TabIndex = 13
        Me.txtNum2.Text = ""
        '
        'txtNum1
        '
        Me.txtNum1.AcceptsReturn = True
        Me.txtNum1.AutoSize = False
        Me.txtNum1.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum1.Location = New System.Drawing.Point(8, 32)
        Me.txtNum1.MaxLength = 0
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum1.Size = New System.Drawing.Size(81, 19)
        Me.txtNum1.TabIndex = 12
        Me.txtNum1.Text = ""
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverage.Location = New System.Drawing.Point(176, 72)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverage.Size = New System.Drawing.Size(81, 17)
        Me.lblAverage.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(112, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Average:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSum
        '
        Me.lblSum.BackColor = System.Drawing.SystemColors.Control
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSum.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSum.Location = New System.Drawing.Point(176, 32)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSum.Size = New System.Drawing.Size(81, 17)
        Me.lblSum.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(112, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sum:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter 3 numbers"
        '
        'Form1
        '
        'Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 206)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnAverage, Me.btnSum, Me.txtNum3, Me.txtNum2, Me.txtNum1, Me.lblAverage, Me.Label4, Me.lblSum, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Find the Error"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        Dim sum As Single

        sum = Val(txtNum1.Text) + Val(txtNum2.Text) + Val(txtNum3.Text)
        lblSum.Text = sum.ToString
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim average As Single

        'Note: sum is not declared
        average = sum / 3

        lblAverage.Text = average.ToString
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
