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
    Friend WithEvents picPropellerCap As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPropellerCap = New System.Windows.Forms.PictureBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnGo = New System.Windows.Forms.Button
        CType(Me.picPropellerCap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPropellerCap
        '
        Me.picPropellerCap.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picPropellerCap.Image = CType(resources.GetObject("picPropellerCap.Image"), System.Drawing.Image)
        Me.picPropellerCap.Location = New System.Drawing.Point(16, 16)
        Me.picPropellerCap.Name = "picPropellerCap"
        Me.picPropellerCap.Size = New System.Drawing.Size(64, 50)
        Me.picPropellerCap.TabIndex = 0
        Me.picPropellerCap.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(204, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.SystemColors.Control
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGo.Location = New System.Drawing.Point(116, 104)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGo.Size = New System.Drawing.Size(81, 33)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "&Go!"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(400, 150)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picPropellerCap)
        Me.Name = "Form1"
        Me.Text = "For Next Demo 2"
        CType(Me.picPropellerCap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the application
        Me.Close()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        '  run the animation
        Dim intCount As Integer
        For intCount = 16 To 328
            picPropellerCap.Left = intCount
        Next intCount
    End Sub
End Class
