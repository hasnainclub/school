Public Class frmMain
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
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnShowModeless As System.Windows.Forms.Button
    Public WithEvents btnShowModal As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnShowModeless = New System.Windows.Forms.Button
        Me.btnShowModal = New System.Windows.Forms.Button
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(208, 143)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(88, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(208, 112)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(88, 25)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear List Box"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnShowModeless
        '
        Me.btnShowModeless.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowModeless.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowModeless.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowModeless.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowModeless.Location = New System.Drawing.Point(208, 64)
        Me.btnShowModeless.Name = "btnShowModeless"
        Me.btnShowModeless.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowModeless.Size = New System.Drawing.Size(88, 42)
        Me.btnShowModeless.TabIndex = 5
        Me.btnShowModeless.Text = "Show a Modeless Form"
        Me.btnShowModeless.UseVisualStyleBackColor = False
        '
        'btnShowModal
        '
        Me.btnShowModal.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowModal.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowModal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowModal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowModal.Location = New System.Drawing.Point(208, 16)
        Me.btnShowModal.Name = "btnShowModal"
        Me.btnShowModal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowModal.Size = New System.Drawing.Size(88, 42)
        Me.btnShowModal.TabIndex = 4
        Me.btnShowModal.Text = "Show a Modal Form"
        Me.btnShowModal.UseVisualStyleBackColor = False
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(8, 8)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(184, 160)
        Me.lstOutput.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 184)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowModeless)
        Me.Controls.Add(Me.btnShowModal)
        Me.Location = New System.Drawing.Point(50, 50)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modal Modeless Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnShowModal_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnShowModal.Click
        Dim intCount As Integer ' counter
        Dim anotherForm As New frmAnother  'form instance

        '  show the other form in modal style
        anotherForm.ShowDialog()


        ' display some number in the list box on the main form

        ' because the other form is displayed in modal syle, this
        ' code will not execute until the user closes the other form
        For intCount = 1 To 10

            lstOutput.Items.Add(intCount.ToString())
        Next intCount


    End Sub

    Private Sub btnShowModeless_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnShowModeless.Click
        Dim intCount As Integer ' counter
        Dim anotherForm As New frmAnother
        '  show the other form in modeless syle
        anotherForm.Show()
        '  display some numbers in teh list box
        ' on the main form.  Because the other form is displayed in modeless style, this code
        '  will execute while the other form is on the screen
        For intCount = 1 To 10
            lstOutput.Items.Add(intCount.ToString())

        Next intCount

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click

        ' Clear anything that may be displayed 
        ' in the list box.
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub

End Class
