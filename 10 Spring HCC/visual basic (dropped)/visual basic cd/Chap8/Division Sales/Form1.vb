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
    Public WithEvents btnEnterData As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents lblTotalSales As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEnterData = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.lblTotalSales = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(175, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnterData
        '
        Me.btnEnterData.BackColor = System.Drawing.SystemColors.Control
        Me.btnEnterData.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnterData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnterData.Location = New System.Drawing.Point(32, 152)
        Me.btnEnterData.Name = "btnEnterData"
        Me.btnEnterData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEnterData.Size = New System.Drawing.Size(114, 33)
        Me.btnEnterData.TabIndex = 12
        Me.btnEnterData.Text = "&Enter Sales Data"
        Me.btnEnterData.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lstOutput)
        Me.GroupBox1.Controls.Add(Me.lblTotalSales)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(24, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(241, 127)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(8, 24)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(224, 60)
        Me.lstOutput.TabIndex = 9
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSales.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSales.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalSales.Location = New System.Drawing.Point(104, 96)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalSales.Size = New System.Drawing.Size(89, 17)
        Me.lblTotalSales.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Sales"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(289, 198)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Division Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This application inputs and displays sales for a company. It
    ' calculates totals for each division, as well as all divisions.
    ' The values are stored in a two-dimensional array.

    ' Define constants for array and loop counter limits.
	Const intDIVISION_MAX As Integer = 2
	Const intQUARTER_MAX As Integer = 3

    ' Two-dimensional sales array.
	Dim decSales(intDIVISION_MAX, intQUARTER_MAX) As Decimal


    Private Sub btnEnterData_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnEnterData.Click



    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub
End Class
