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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(175, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.SystemColors.Control
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGo.Location = New System.Drawing.Point(87, 176)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "&Go!"
        '
        'lstOutput
        '
        Me.lstOutput.Location = New System.Drawing.Point(8, 8)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(320, 160)
        Me.lstOutput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstOutput, Me.btnExit, Me.btnGo})
        Me.Name = "Form1"
        Me.Text = "ByVal ByRef Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnGo_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnGo.Click
5:
        Dim intNumber As Integer = 100

        lstOutput.Items.Add("Inside btnGo_Click the value of " & _
            "intNumber is " & intNumber.ToString)
        lstOutput.Items.Add("Now I am calling ChangeArg.")

        ChangeArg(intNumber)
        lstOutput.Items.Add("Now back in btnGo_Click, the " _
            & "value of intNumber is " & intNumber.ToString)
    End Sub


    Sub ChangeArg(ByVal intArg As Integer)

        lstOutput.Items.Add("Inside the ChangeArg procedure, " _
            & "I will change the value of intArg.")
        intArg = 0
        lstOutput.Items.Add("intArg is now " & intArg)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub
End Class
