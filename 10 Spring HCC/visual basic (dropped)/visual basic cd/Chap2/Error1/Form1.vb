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
    Public WithEvents picWorld As System.Windows.Forms.PictureBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'picWorld
        '
        Me.picWorld.Cursor = System.Windows.Forms.Cursors.Default
        Me.picWorld.Image = CType(resources.GetObject("picWorld.Image"), System.Drawing.Bitmap)
        Me.picWorld.Location = New System.Drawing.Point(35, 26)
        Me.picWorld.Name = "picWorld"
        Me.picWorld.Size = New System.Drawing.Size(222, 214)
        Me.picWorld.TabIndex = 3
        Me.picWorld.TabStop = False
        Me.picWorld.Visible = False
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(65, 256)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show World"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(153, 256)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Exit"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(292, 310)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnShow, Me.picWorld})
        Me.Name = "Form1"
        Me.Text = "The World"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ' Show the world.
        picWorld_Visible = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' End the application.
        End
    End Sub
End Class
