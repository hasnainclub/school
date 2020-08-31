Option Explicit On

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
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnRunDemo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.btnRunDemo = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.Location = New System.Drawing.Point(28, 8)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(168, 160)
        Me.lstOutput.TabIndex = 0
        '
        'btnRunDemo
        '
        Me.btnRunDemo.Location = New System.Drawing.Point(27, 184)
        Me.btnRunDemo.Name = "btnRunDemo"
        Me.btnRunDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnRunDemo.TabIndex = 1
        Me.btnRunDemo.Text = "&Run Demo"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(75, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 254)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRunDemo)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "Form1"
        Me.Text = "Do While Loop Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click

        ' Clear the list box
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub

    Private Sub btnRunDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunDemo.Click
        '  demonstrate the do while lloop
        Dim intCount As Integer = 0
        Do While intCount < 10
            lstOutput.Items.Add("Hello!")
            intCount += 1
        Loop

    End Sub
End Class
