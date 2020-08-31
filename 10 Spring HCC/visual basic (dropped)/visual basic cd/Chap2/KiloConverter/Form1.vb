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
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnInches As System.Windows.Forms.Button
    Friend WithEvents btnFeet As System.Windows.Forms.Button
    Friend WithEvents btnYards As System.Windows.Forms.Button
    Friend WithEvents btnMiles As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnInches = New System.Windows.Forms.Button()
        Me.btnFeet = New System.Windows.Forms.Button()
        Me.btnYards = New System.Windows.Forms.Button()
        Me.btnMiles = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(20, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(320, 56)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "1 Kilometer = ?"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInches
        '
        Me.btnInches.Location = New System.Drawing.Point(11, 104)
        Me.btnInches.Name = "btnInches"
        Me.btnInches.TabIndex = 1
        Me.btnInches.Text = "Inches"
        '
        'btnFeet
        '
        Me.btnFeet.Location = New System.Drawing.Point(99, 104)
        Me.btnFeet.Name = "btnFeet"
        Me.btnFeet.TabIndex = 2
        Me.btnFeet.Text = "Feet"
        '
        'btnYards
        '
        Me.btnYards.Location = New System.Drawing.Point(187, 104)
        Me.btnYards.Name = "btnYards"
        Me.btnYards.TabIndex = 3
        Me.btnYards.Text = "Yards"
        '
        'btnMiles
        '
        Me.btnMiles.Location = New System.Drawing.Point(275, 104)
        Me.btnMiles.Name = "btnMiles"
        Me.btnMiles.TabIndex = 4
        Me.btnMiles.Text = "Miles"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(143, 136)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 166)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnMiles, Me.btnYards, Me.btnFeet, Me.btnInches, Me.lblMessage})
        Me.Name = "Form1"
        Me.Text = "Kilometer Converter"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application.
        Me.Close()
    End Sub

    Private Sub btnFeet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeet.Click

        ' Display the conversion to feet.
        lblMessage.Text = "1 Kilometer = 3,281 feet"
    End Sub

    Private Sub btnInches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInches.Click

        ' Display the conversion to inches.
        lblMessage.Text = "1 Kilometer = 39,370 inches"
    End Sub

    Private Sub btnMiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiles.Click

        ' Display the conversion to miles.
        lblMessage.Text = "1 Kilometer = 0.6214 miles"
    End Sub

    Private Sub btnYards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYards.Click

        ' Display the conversion to yards.
        lblMessage.Text = "1 Kilometer = 1,093.6 yards"
    End Sub
End Class
