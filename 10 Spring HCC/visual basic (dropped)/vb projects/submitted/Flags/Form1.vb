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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picUSA As System.Windows.Forms.PictureBox
    Friend WithEvents picCanada As System.Windows.Forms.PictureBox
    Friend WithEvents picUK As System.Windows.Forms.PictureBox
    Friend WithEvents picAustralia As System.Windows.Forms.PictureBox
    Friend WithEvents picBrazil As System.Windows.Forms.PictureBox
    Friend WithEvents picItaly As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.picUSA = New System.Windows.Forms.PictureBox
        Me.picCanada = New System.Windows.Forms.PictureBox
        Me.picUK = New System.Windows.Forms.PictureBox
        Me.picAustralia = New System.Windows.Forms.PictureBox
        Me.picBrazil = New System.Windows.Forms.PictureBox
        Me.picItaly = New System.Windows.Forms.PictureBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.picUSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAustralia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrazil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picItaly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click a Flag to Learn Its Country"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picUSA
        '
        Me.picUSA.Image = CType(resources.GetObject("picUSA.Image"), System.Drawing.Image)
        Me.picUSA.Location = New System.Drawing.Point(40, 40)
        Me.picUSA.Name = "picUSA"
        Me.picUSA.Size = New System.Drawing.Size(32, 32)
        Me.picUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUSA.TabIndex = 1
        Me.picUSA.TabStop = False
        '
        'picCanada
        '
        Me.picCanada.Image = CType(resources.GetObject("picCanada.Image"), System.Drawing.Image)
        Me.picCanada.Location = New System.Drawing.Point(40, 80)
        Me.picCanada.Name = "picCanada"
        Me.picCanada.Size = New System.Drawing.Size(32, 32)
        Me.picCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCanada.TabIndex = 2
        Me.picCanada.TabStop = False
        '
        'picUK
        '
        Me.picUK.Image = CType(resources.GetObject("picUK.Image"), System.Drawing.Image)
        Me.picUK.Location = New System.Drawing.Point(40, 120)
        Me.picUK.Name = "picUK"
        Me.picUK.Size = New System.Drawing.Size(32, 32)
        Me.picUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUK.TabIndex = 3
        Me.picUK.TabStop = False
        '
        'picAustralia
        '
        Me.picAustralia.Image = CType(resources.GetObject("picAustralia.Image"), System.Drawing.Image)
        Me.picAustralia.Location = New System.Drawing.Point(136, 40)
        Me.picAustralia.Name = "picAustralia"
        Me.picAustralia.Size = New System.Drawing.Size(32, 32)
        Me.picAustralia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAustralia.TabIndex = 4
        Me.picAustralia.TabStop = False
        '
        'picBrazil
        '
        Me.picBrazil.Image = CType(resources.GetObject("picBrazil.Image"), System.Drawing.Image)
        Me.picBrazil.Location = New System.Drawing.Point(136, 80)
        Me.picBrazil.Name = "picBrazil"
        Me.picBrazil.Size = New System.Drawing.Size(32, 32)
        Me.picBrazil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrazil.TabIndex = 5
        Me.picBrazil.TabStop = False
        '
        'picItaly
        '
        Me.picItaly.Image = CType(resources.GetObject("picItaly.Image"), System.Drawing.Image)
        Me.picItaly.Location = New System.Drawing.Point(136, 120)
        Me.picItaly.Name = "picItaly"
        Me.picItaly.Size = New System.Drawing.Size(32, 32)
        Me.picItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picItaly.TabIndex = 6
        Me.picItaly.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(16, 160)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(176, 20)
        Me.lblMessage.TabIndex = 7
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(67, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 222)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picItaly)
        Me.Controls.Add(Me.picBrazil)
        Me.Controls.Add(Me.picAustralia)
        Me.Controls.Add(Me.picUK)
        Me.Controls.Add(Me.picCanada)
        Me.Controls.Add(Me.picUSA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Flags"
        CType(Me.picUSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAustralia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrazil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picItaly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        ' close the window
        Me.Close()
    End Sub

    Private Sub picsUSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUSA.Click
        '  Display the country name
        lblMessage.Text = "United States of America"
    End Sub

    Private Sub picUK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUK.Click
        '  Display the country name
        lblMessage.Text = "UK"
    End Sub

    Private Sub picBrazil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBrazil.Click
        '  Display the country name
        lblMessage.Text = "Brazil"
    End Sub

    Private Sub picCanada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCanada.Click
        '  Display the country name
        lblMessage.Text = "Canada"
    End Sub

    Private Sub picAustralia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAustralia.Click
        '  Display the country name
        lblMessage.Text = "Australia"
    End Sub

    Private Sub picItaly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picItaly.Click
        '  Display the country name
        lblMessage.Text = "Italy"
    End Sub
End Class
