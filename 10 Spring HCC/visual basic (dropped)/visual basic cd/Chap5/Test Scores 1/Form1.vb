

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
    Public WithEvents btnCalcAverage As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblAverage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCalcAverage = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAverage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(124, 105)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCalcAverage
        '
        Me.btnCalcAverage.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalcAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalcAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcAverage.Location = New System.Drawing.Point(21, 105)
        Me.btnCalcAverage.Name = "btnCalcAverage"
        Me.btnCalcAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalcAverage.Size = New System.Drawing.Size(96, 43)
        Me.btnCalcAverage.TabIndex = 3
        Me.btnCalcAverage.Text = "Calculate &Average"
        Me.btnCalcAverage.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(233, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the Calculate Average button to enter your test scores."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Average:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverage.Location = New System.Drawing.Point(104, 68)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverage.Size = New System.Drawing.Size(81, 17)
        Me.lblAverage.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(249, 160)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcAverage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAverage)
        Me.Name = "Form1"
        Me.Text = "Test Score Average"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCalcAverage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnCalcAverage.Click

        ' This procedure gets the test scores, then calculates and
        ' displays the average.
        Dim sngTotal As Single          ' Holds the running total of test scores
        Dim intNumScores As Integer     ' The number of test scores
        Dim sngAverage As Single        ' The average of the test scores
        Dim strInput As String          ' To hold user input
        Dim intCount As Integer         ' Counter variable for the loop

        ' Get the number of test scores.
        strInput = InputBox("How many test scores do you want " & _
                            "to average?", "Enter a Value")

        ' Store the starting values in total and count.
        sngTotal = 0
        intCount = 1
        If Not CDec(strInput) And (intNumScores) Then
            Return
        End If
        ' Get the test scores.
        Do Until intCount > intNumScores
            strInput = InputBox("Enter the value for test score " _
                    & intCount.ToString, "Test Score Needed")

            sngTotal += CSng(strInput)
            intCount += 1
        Loop

        ' Calculate and display the average.
        If intNumScores > 0 Then
            sngAverage = sngTotal / intNumScores
        Else
            sngAverage = 0.0
        End If
        lblAverage.Text = sngAverage.ToString
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

End Class
