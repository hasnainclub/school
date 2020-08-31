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
    Public WithEvents btnShowMessage As System.Windows.Forms.Button
    Public WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnShowMessage = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(176, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        '
        'btnShowMessage
        '
        Me.btnShowMessage.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowMessage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowMessage.Location = New System.Drawing.Point(80, 177)
        Me.btnShowMessage.Name = "btnShowMessage"
        Me.btnShowMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowMessage.Size = New System.Drawing.Size(81, 33)
        Me.btnShowMessage.TabIndex = 4
        Me.btnShowMessage.Text = "Show Message"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(12, 57)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(313, 33)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(336, 222)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnShowMessage, Me.lblMessage})
        Me.Name = "Form1"
        Me.Text = "Hello World?"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnShowMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMessage.Click
        ' Store the Hello World message in
        ' the label's Text property.
        lblMessage.Text = Hello World
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the application.
        End
    End Sub
End Class
