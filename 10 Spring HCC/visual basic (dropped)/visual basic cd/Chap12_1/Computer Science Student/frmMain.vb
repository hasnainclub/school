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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtIdNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHum As System.Windows.Forms.TextBox
    Friend WithEvents txtComm As System.Windows.Forms.TextBox
    Friend WithEvents txtMath As System.Windows.Forms.TextBox
    Friend WithEvents txtCompSci As System.Windows.Forms.TextBox
    Friend WithEvents txtElect As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.txtIdNumber = New System.Windows.Forms.TextBox
		Me.txtFirstName = New System.Windows.Forms.TextBox
		Me.txtLastName = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.txtCompSci = New System.Windows.Forms.TextBox
		Me.txtElect = New System.Windows.Forms.TextBox
		Me.txtHum = New System.Windows.Forms.TextBox
		Me.txtComm = New System.Windows.Forms.TextBox
		Me.txtMath = New System.Windows.Forms.TextBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.btnAdd = New System.Windows.Forms.Button
		Me.btnExit = New System.Windows.Forms.Button
		Me.btnDisplay = New System.Windows.Forms.Button
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtIdNumber)
		Me.GroupBox1.Controls.Add(Me.txtFirstName)
		Me.GroupBox1.Controls.Add(Me.txtLastName)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(200, 112)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Student Data"
		'
		'txtIdNumber
		'
		Me.txtIdNumber.Location = New System.Drawing.Point(88, 80)
		Me.txtIdNumber.Name = "txtIdNumber"
		Me.txtIdNumber.Size = New System.Drawing.Size(100, 20)
		Me.txtIdNumber.TabIndex = 7
		'
		'txtFirstName
		'
		Me.txtFirstName.Location = New System.Drawing.Point(88, 56)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
		Me.txtFirstName.TabIndex = 6
		'
		'txtLastName
		'
		Me.txtLastName.Location = New System.Drawing.Point(88, 32)
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(100, 20)
		Me.txtLastName.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(16, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 16)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "ID Number"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(16, 56)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(64, 16)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "First Name"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(16, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(64, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Last Name"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txtCompSci)
		Me.GroupBox2.Controls.Add(Me.txtElect)
		Me.GroupBox2.Controls.Add(Me.txtHum)
		Me.GroupBox2.Controls.Add(Me.txtComm)
		Me.GroupBox2.Controls.Add(Me.txtMath)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Location = New System.Drawing.Point(216, 8)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(192, 152)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Hours Completed"
		'
		'txtCompSci
		'
		Me.txtCompSci.Location = New System.Drawing.Point(128, 120)
		Me.txtCompSci.Name = "txtCompSci"
		Me.txtCompSci.Size = New System.Drawing.Size(48, 20)
		Me.txtCompSci.TabIndex = 24
		'
		'txtElect
		'
		Me.txtElect.Location = New System.Drawing.Point(128, 96)
		Me.txtElect.Name = "txtElect"
		Me.txtElect.Size = New System.Drawing.Size(48, 20)
		Me.txtElect.TabIndex = 23
		'
		'txtHum
		'
		Me.txtHum.Location = New System.Drawing.Point(128, 72)
		Me.txtHum.Name = "txtHum"
		Me.txtHum.Size = New System.Drawing.Size(48, 20)
		Me.txtHum.TabIndex = 22
		'
		'txtComm
		'
		Me.txtComm.Location = New System.Drawing.Point(128, 48)
		Me.txtComm.Name = "txtComm"
		Me.txtComm.Size = New System.Drawing.Size(48, 20)
		Me.txtComm.TabIndex = 21
		'
		'txtMath
		'
		Me.txtMath.Location = New System.Drawing.Point(128, 24)
		Me.txtMath.Name = "txtMath"
		Me.txtMath.Size = New System.Drawing.Size(48, 20)
		Me.txtMath.TabIndex = 20
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(16, 120)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(104, 16)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "Computer Science"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(16, 96)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(104, 16)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "Electives"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(16, 72)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 16)
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "Humanities"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(16, 48)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(104, 16)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "Communications"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(16, 24)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(104, 16)
		Me.Label6.TabIndex = 14
		Me.Label6.Text = "Math"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(8, 128)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(93, 43)
		Me.btnAdd.TabIndex = 3
		Me.btnAdd.Text = "&Add Record"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(8, 177)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(93, 32)
		Me.btnExit.TabIndex = 4
		Me.btnExit.Text = "E&xit"
		'
		'btnDisplay
		'
		Me.btnDisplay.Location = New System.Drawing.Point(107, 128)
		Me.btnDisplay.Name = "btnDisplay"
		Me.btnDisplay.Size = New System.Drawing.Size(89, 43)
		Me.btnDisplay.TabIndex = 5
		Me.btnDisplay.Text = "&Display Students"
		'
		'frmMain
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(416, 217)
		Me.Controls.Add(Me.btnDisplay)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmMain"
		Me.Text = "Computer Science Student Status"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

#End Region


End Class
