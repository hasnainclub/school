<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.map = New System.Windows.Forms.PictureBox
        Me.lblDirections = New System.Windows.Forms.Label
        Me.btnDisplayDirections = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.map, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directions to the Highlander hotel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'map
        '
        Me.map.Image = CType(resources.GetObject("map.Image"), System.Drawing.Image)
        Me.map.Location = New System.Drawing.Point(175, 135)
        Me.map.Name = "map"
        Me.map.Size = New System.Drawing.Size(269, 171)
        Me.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.map.TabIndex = 1
        Me.map.TabStop = False
        '
        'lblDirections
        '
        Me.lblDirections.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDirections.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDirections.Location = New System.Drawing.Point(115, 352)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(363, 111)
        Me.lblDirections.TabIndex = 2
        Me.lblDirections.Text = resources.GetString("lblDirections.Text")
        Me.lblDirections.Visible = False
        '
        'btnDisplayDirections
        '
        Me.btnDisplayDirections.Location = New System.Drawing.Point(118, 417)
        Me.btnDisplayDirections.Name = "btnDisplayDirections"
        Me.btnDisplayDirections.Size = New System.Drawing.Size(75, 46)
        Me.btnDisplayDirections.TabIndex = 3
        Me.btnDisplayDirections.Text = "Display Directions"
        Me.btnDisplayDirections.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(403, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 46)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(604, 509)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayDirections)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.map)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Directions"
        CType(Me.map, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents map As System.Windows.Forms.PictureBox
    Friend WithEvents lblDirections As System.Windows.Forms.Label
    Friend WithEvents btnDisplayDirections As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
