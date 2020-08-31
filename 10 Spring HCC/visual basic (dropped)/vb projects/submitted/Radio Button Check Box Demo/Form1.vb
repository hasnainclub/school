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
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents chkChoice6 As System.Windows.Forms.CheckBox
    Public WithEvents chkChoice5 As System.Windows.Forms.CheckBox
    Public WithEvents chkChoice4 As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents radChoice1 As System.Windows.Forms.RadioButton
    Public WithEvents radChoice2 As System.Windows.Forms.RadioButton
    Public WithEvents radChoice3 As System.Windows.Forms.RadioButton
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnOk As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.chkChoice6 = New System.Windows.Forms.CheckBox
        Me.chkChoice5 = New System.Windows.Forms.CheckBox
        Me.chkChoice4 = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.radChoice1 = New System.Windows.Forms.RadioButton
        Me.radChoice2 = New System.Windows.Forms.RadioButton
        Me.radChoice3 = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.chkChoice6)
        Me.Frame2.Controls.Add(Me.chkChoice5)
        Me.Frame2.Controls.Add(Me.chkChoice4)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(128, 8)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(105, 129)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Check Boxes"
        '
        'chkChoice6
        '
        Me.chkChoice6.BackColor = System.Drawing.SystemColors.Control
        Me.chkChoice6.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkChoice6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChoice6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkChoice6.Location = New System.Drawing.Point(16, 96)
        Me.chkChoice6.Name = "chkChoice6"
        Me.chkChoice6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkChoice6.Size = New System.Drawing.Size(73, 25)
        Me.chkChoice6.TabIndex = 2
        Me.chkChoice6.Text = "Choice 6"
        Me.chkChoice6.UseVisualStyleBackColor = False
        '
        'chkChoice5
        '
        Me.chkChoice5.BackColor = System.Drawing.SystemColors.Control
        Me.chkChoice5.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkChoice5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChoice5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkChoice5.Location = New System.Drawing.Point(16, 64)
        Me.chkChoice5.Name = "chkChoice5"
        Me.chkChoice5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkChoice5.Size = New System.Drawing.Size(73, 17)
        Me.chkChoice5.TabIndex = 1
        Me.chkChoice5.Text = "Choice 5"
        Me.chkChoice5.UseVisualStyleBackColor = False
        '
        'chkChoice4
        '
        Me.chkChoice4.BackColor = System.Drawing.SystemColors.Control
        Me.chkChoice4.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkChoice4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChoice4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkChoice4.Location = New System.Drawing.Point(16, 32)
        Me.chkChoice4.Name = "chkChoice4"
        Me.chkChoice4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkChoice4.Size = New System.Drawing.Size(72, 17)
        Me.chkChoice4.TabIndex = 0
        Me.chkChoice4.Text = "Choice 4"
        Me.chkChoice4.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.radChoice1)
        Me.Frame1.Controls.Add(Me.radChoice2)
        Me.Frame1.Controls.Add(Me.radChoice3)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(105, 129)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Radio Buttons"
        '
        'radChoice1
        '
        Me.radChoice1.BackColor = System.Drawing.SystemColors.Control
        Me.radChoice1.Checked = True
        Me.radChoice1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radChoice1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChoice1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radChoice1.Location = New System.Drawing.Point(16, 24)
        Me.radChoice1.Name = "radChoice1"
        Me.radChoice1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radChoice1.Size = New System.Drawing.Size(81, 33)
        Me.radChoice1.TabIndex = 0
        Me.radChoice1.Text = "Choice 1"
        Me.radChoice1.UseVisualStyleBackColor = False
        '
        'radChoice2
        '
        Me.radChoice2.BackColor = System.Drawing.SystemColors.Control
        Me.radChoice2.Cursor = System.Windows.Forms.Cursors.Default
        Me.radChoice2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChoice2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radChoice2.Location = New System.Drawing.Point(16, 56)
        Me.radChoice2.Name = "radChoice2"
        Me.radChoice2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radChoice2.Size = New System.Drawing.Size(81, 33)
        Me.radChoice2.TabIndex = 1
        Me.radChoice2.Text = "Choice 2"
        Me.radChoice2.UseVisualStyleBackColor = False
        '
        'radChoice3
        '
        Me.radChoice3.BackColor = System.Drawing.SystemColors.Control
        Me.radChoice3.Cursor = System.Windows.Forms.Cursors.Default
        Me.radChoice3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChoice3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radChoice3.Location = New System.Drawing.Point(16, 88)
        Me.radChoice3.Name = "radChoice3"
        Me.radChoice3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radChoice3.Size = New System.Drawing.Size(81, 33)
        Me.radChoice3.TabIndex = 2
        Me.radChoice3.Text = "Choice 3"
        Me.radChoice3.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(128, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(32, 152)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(248, 190)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Radio Button Check Box Demo"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnOk_Click(ByVal eventSender As System.Object, _
        ByVal eventArgs As System.EventArgs) Handles btnOk.Click
        '  Declare string vairable to hold a message
        Dim strmessage As String = String.Empty

        '  The following If....ElseIf statement tests the group of radio buttongs and copies the 
        ' first part of the message to strMessage

        If radChoice1.Checked = True Then
            strmessage = "You selected choice 1"
        ElseIf radChoice2.Checked = True Then
            strmessage = "You selected choice 2"
        ElseIf radChoice3.Checked = True Then
            strmessage = "You selected choice 3"
        End If




        '  The following if.... then statements tests the check boxes and concatenates another part
        '  of the message to strmessage

        If chkChoice4.Checked = True Then
            strmessage &= " and choice4"
        End If
        If chkChoice5.Checked = True Then
            strmessage &= " and choice5"
        End If
        If chkChoice6.Checked = True Then
            strmessage &= " and choice 6"
        End If

        '  Now display the message
        MessageBox.Show(strmessage)




    End Sub

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click

		Me.Close()
    End Sub
End Class
