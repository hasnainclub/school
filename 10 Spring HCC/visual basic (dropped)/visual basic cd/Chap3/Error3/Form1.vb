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
    Public WithEvents btnCalculate As System.Windows.Forms.Button
    Public WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Public WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Public WithEvents lblSum As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(128, 160)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(32, 160)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(81, 33)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate &Sum"
        '
        'txtNumber2
        '
        Me.txtNumber2.AcceptsReturn = True
        Me.txtNumber2.AutoSize = False
        Me.txtNumber2.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumber2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumber2.Location = New System.Drawing.Point(144, 48)
        Me.txtNumber2.MaxLength = 0
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumber2.Size = New System.Drawing.Size(81, 25)
        Me.txtNumber2.TabIndex = 11
        Me.txtNumber2.Text = ""
        '
        'txtNumber1
        '
        Me.txtNumber1.AcceptsReturn = True
        Me.txtNumber1.AutoSize = False
        Me.txtNumber1.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumber1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumber1.Location = New System.Drawing.Point(144, 16)
        Me.txtNumber1.MaxLength = 0
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumber1.Size = New System.Drawing.Size(81, 25)
        Me.txtNumber1.TabIndex = 9
        Me.txtNumber1.Text = ""
        '
        'lblSum
        '
        Me.lblSum.BackColor = System.Drawing.SystemColors.Control
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSum.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSum.Location = New System.Drawing.Point(144, 96)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSum.Size = New System.Drawing.Size(81, 25)
        Me.lblSum.TabIndex = 13
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(48, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sum:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter another number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter a number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        'Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(240, 206)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnCalculate, Me.txtNumber2, Me.txtNumber1, Me.lblSum, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Find the Error"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This application contains a very tricky error!

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare some variables
        Dim number1 As Single
        Dim number2 As Single
        Dim sum As Single

        ' Get the 2 numbers
        number1 = Val(txtNumber1.Text)
        number2 = Val(txtNumber2.Text)
        '  Calculate their sum... is the next line working?
        sum = numberl + number2
        ' Display the result
        lblSum.Text = sum.ToString
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the application.
        End
    End Sub
End Class
