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
    Public WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents txtSerialNumber As System.Windows.Forms.TextBox
    Public WithEvents lblMessage As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(168, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(72, 112)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "&Ok"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.AcceptsReturn = True
        Me.txtSerialNumber.AutoSize = False
        Me.txtSerialNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerialNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSerialNumber.Location = New System.Drawing.Point(72, 40)
        Me.txtSerialNumber.MaxLength = 0
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerialNumber.Size = New System.Drawing.Size(177, 20)
        Me.txtSerialNumber.TabIndex = 6
        Me.txtSerialNumber.Text = ""
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(8, 80)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(297, 17)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(297, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the software serial number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(312, 150)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnOk, Me.txtSerialNumber, Me.lblMessage, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Serial Number Registration"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        ' End the application
        End
    End Sub

    Private Sub btnOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOk.Click
        ' This procedure tests the serial number entered by the user.
        ' A message is displayed indicating the validity of the serial
        ' number.

        ' Local Variable Declarations
        Dim serial As String    ' To hold the entered serial number
        Dim group1 As String    ' To hold the 1st group of characters
        Dim group2 As String    ' To hold the 2nd group of characters
        Dim isValid As Boolean  ' To signal the input's validity

        ' Initialize the flag to True
        isValid = True
        ' Get the serial number with spaces trimmed
        serial = txtSerialNumber.Text.Trim
        ' Check the length
        If serial.Length = 10 Then
            ' Extract the first four characters
            group1 = serial.Substring(0, 4)
            ' Extract the rest of the characters
            group2 = serial.Substring(4)
            ' Test group1
            If Not IsNumeric(group1) Then
                isValid = False
            End If
            ' Test group2 for a numeric value
            If IsNumeric(group2) Then
                isValid = False
            End If
        Else
            ' This executes if serial is not 10 characters long.
            isValid = False
        End If

        ' Display a message indicating that the serial number
        ' is valid or invalid.
        If isValid Then
            lblMessage.Text = "The serial number is valid"
        Else
            lblMessage.Text = "The serial number is invalid"
        End If
    End Sub

End Class
