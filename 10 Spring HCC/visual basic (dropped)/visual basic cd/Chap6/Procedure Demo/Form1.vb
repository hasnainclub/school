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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.Location = New System.Drawing.Point(8, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(248, 173)
        Me.lstOutput.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(136, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(48, 196)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "&Go!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 230)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstOutput, Me.btnExit, Me.btnGo})
        Me.Name = "Form1"
        Me.Text = "Sub Procedure Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private Sub btnGo_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnGo.Click

		' This procedure calls the DisplayMessage procedure.
		lstOutput.Items.Add("Hello from the btnGo_Click procedure.")
		lstOutput.Items.Add("Now I am calling the DisplayMessage " _
		  & "procedure.")
		DisplayMessage()
		lstOutput.Items.Add("Now I am back in the btnGo_Click procedure.")
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnExit.Click

		Me.Close()
	End Sub

	Sub DisplayMessage()

		' A general procedure that displays a message.
		lstOutput.Items.Add("")
		lstOutput.Items.Add("Hello from the DisplayMessage procedure.")
		lstOutput.Items.Add("")
	End Sub

End Class
