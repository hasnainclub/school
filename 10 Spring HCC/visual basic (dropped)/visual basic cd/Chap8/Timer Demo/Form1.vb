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
    Public WithEvents tmrSeconds As System.Windows.Forms.Timer
    Public WithEvents btnToggleTimer As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblCounter As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tmrSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.btnToggleTimer = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCounter = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tmrSeconds
        '
        Me.tmrSeconds.Enabled = True
        Me.tmrSeconds.Interval = 1000
        '
        'btnToggleTimer
        '
        Me.btnToggleTimer.BackColor = System.Drawing.SystemColors.Control
        Me.btnToggleTimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnToggleTimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleTimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnToggleTimer.Location = New System.Drawing.Point(9, 84)
        Me.btnToggleTimer.Name = "btnToggleTimer"
        Me.btnToggleTimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnToggleTimer.Size = New System.Drawing.Size(75, 23)
        Me.btnToggleTimer.TabIndex = 7
        Me.btnToggleTimer.Text = "&Stop Timer"
        Me.btnToggleTimer.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(97, 84)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seconds Counter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCounter
        '
        Me.lblCounter.BackColor = System.Drawing.SystemColors.Control
        Me.lblCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCounter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCounter.Location = New System.Drawing.Point(66, 44)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCounter.Size = New System.Drawing.Size(49, 25)
        Me.lblCounter.TabIndex = 4
        Me.lblCounter.Text = "0"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(186, 118)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnToggleTimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCounter)
        Me.Name = "Form1"
        Me.Text = "Timer Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

	' This application demonstrates the Timer control.

    Private intSeconds As Integer       ' To count seconds.

    Private Sub btnToggleTimer_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnToggleTimer.Click

        ' Toggle the timer.
        If tmrSeconds.Enabled = True Then
            tmrSeconds.Enabled = False
            btnToggleTimer.Text = "&Start Timer"
        Else
            tmrSeconds.Enabled = True
            btnToggleTimer.Text = "&Stop Timer"
        End If
    End Sub

    Private Sub tmrSeconds_Tick(ByVal eventSender As System.Object, _
        ByVal eventArgs As System.EventArgs) Handles tmrSeconds.Tick

        ' Update the seconds display by one second.
        intSeconds += 1
		lblCounter.Text = intSeconds.ToString()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub
End Class
