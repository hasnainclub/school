Option Strict On

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents lblAverageTime As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblAverageTime = New System.Windows.Forms.Label
        Me.txtRunner3 = New System.Windows.Forms.TextBox
        Me.txtRunner2 = New System.Windows.Forms.TextBox
        Me.txtRunner1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAverageTime)
        Me.GroupBox1.Controls.Add(Me.txtRunner3)
        Me.GroupBox1.Controls.Add(Me.txtRunner2)
        Me.GroupBox1.Controls.Add(Me.txtRunner1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblAverageTime
        '
        Me.lblAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTime.Location = New System.Drawing.Point(104, 120)
        Me.lblAverageTime.Name = "lblAverageTime"
        Me.lblAverageTime.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageTime.TabIndex = 8
        Me.lblAverageTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRunner3
        '
        Me.txtRunner3.Location = New System.Drawing.Point(104, 88)
        Me.txtRunner3.Name = "txtRunner3"
        Me.txtRunner3.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner3.TabIndex = 7
        '
        'txtRunner2
        '
        Me.txtRunner2.Location = New System.Drawing.Point(104, 56)
        Me.txtRunner2.Name = "txtRunner2"
        Me.txtRunner2.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner2.TabIndex = 6
        '
        'txtRunner1
        '
        Me.txtRunner1.Location = New System.Drawing.Point(104, 24)
        Me.txtRunner1.Name = "txtRunner1"
        Me.txtRunner1.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Average Time"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Runner &3"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Runner &2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Runner &1"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(16, 184)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 36)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate &Average"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 36)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 230)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Average Race Times"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCalculate_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnCalculate.Click

        ' This prodecure calculates the average race time of
        ' three runners and displays the average in lblAverageTime.

        ' Variables
        Dim sngRunner1 As Single        ' Runner #1's time
        Dim sngRunner2 As Single        ' Runner #2's time
        Dim sngRunner3 As Single        ' Runner #3's time
        Dim sngAverage As Single        ' Average race time

        ' Get the times entered by the user
        sngRunner1 = CSng(txtRunner1.Text)
        sngRunner2 = CSng(txtRunner2.Text)
        sngRunner3 = CSng(txtRunner3.Text)

        ' Calculate the average time
        sngAverage = sngRunner1 + sngRunner2 + sngRunner3 / 3

        ' Display the average time
        lblAverageTime.Text = FormatNumber(sngAverage, 1)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click

        txtRunner1.Text = ""
        txtRunner2.Text = ""
        txtRunner3.Text = ""
        lblAverageTime.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application by closing the window.
        Me.Close()
    End Sub
End Class
