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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents lblFahrenheit As System.Windows.Forms.Label
	Friend WithEvents lblCentigrade As System.Windows.Forms.Label
	Friend WithEvents vsbCentigrade As System.Windows.Forms.VScrollBar
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents hsbMeters As System.Windows.Forms.HScrollBar
	Friend WithEvents lblFeet As System.Windows.Forms.Label
	Friend WithEvents lblMeters As System.Windows.Forms.Label
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents picBoat As System.Windows.Forms.PictureBox
	Friend WithEvents tbBoat As System.Windows.Forms.TrackBar
	Friend WithEvents btnExit As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.vsbCentigrade = New System.Windows.Forms.VScrollBar
		Me.lblCentigrade = New System.Windows.Forms.Label
		Me.lblFahrenheit = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.hsbMeters = New System.Windows.Forms.HScrollBar
		Me.lblFeet = New System.Windows.Forms.Label
		Me.lblMeters = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.picBoat = New System.Windows.Forms.PictureBox
		Me.tbBoat = New System.Windows.Forms.TrackBar
		Me.btnExit = New System.Windows.Forms.Button
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.picBoat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbBoat, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.vsbCentigrade)
		Me.GroupBox1.Controls.Add(Me.lblCentigrade)
		Me.GroupBox1.Controls.Add(Me.lblFahrenheit)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(232, 128)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Vertical Scroll Bar"
		'
		'vsbCentigrade
		'
		Me.vsbCentigrade.LargeChange = 20
		Me.vsbCentigrade.Location = New System.Drawing.Point(200, 24)
		Me.vsbCentigrade.Minimum = -100
		Me.vsbCentigrade.Name = "vsbCentigrade"
		Me.vsbCentigrade.Size = New System.Drawing.Size(17, 80)
		Me.vsbCentigrade.TabIndex = 4
		Me.vsbCentigrade.Value = -100
		'
		'lblCentigrade
		'
		Me.lblCentigrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCentigrade.Location = New System.Drawing.Point(96, 72)
		Me.lblCentigrade.Name = "lblCentigrade"
		Me.lblCentigrade.Size = New System.Drawing.Size(72, 16)
		Me.lblCentigrade.TabIndex = 3
		'
		'lblFahrenheit
		'
		Me.lblFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblFahrenheit.Location = New System.Drawing.Point(96, 32)
		Me.lblFahrenheit.Name = "lblFahrenheit"
		Me.lblFahrenheit.Size = New System.Drawing.Size(72, 16)
		Me.lblFahrenheit.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(16, 72)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(64, 23)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Centigrade"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(16, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(64, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Fahrenheit"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.hsbMeters)
		Me.GroupBox2.Controls.Add(Me.lblFeet)
		Me.GroupBox2.Controls.Add(Me.lblMeters)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Location = New System.Drawing.Point(248, 8)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(232, 128)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Horizontal Scroll Bar"
		'
		'hsbMeters
		'
		Me.hsbMeters.LargeChange = 20
		Me.hsbMeters.Location = New System.Drawing.Point(96, 96)
		Me.hsbMeters.Name = "hsbMeters"
		Me.hsbMeters.Size = New System.Drawing.Size(80, 17)
		Me.hsbMeters.TabIndex = 4
		'
		'lblFeet
		'
		Me.lblFeet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblFeet.Location = New System.Drawing.Point(96, 72)
		Me.lblFeet.Name = "lblFeet"
		Me.lblFeet.Size = New System.Drawing.Size(72, 16)
		Me.lblFeet.TabIndex = 3
		'
		'lblMeters
		'
		Me.lblMeters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMeters.Location = New System.Drawing.Point(96, 32)
		Me.lblMeters.Name = "lblMeters"
		Me.lblMeters.Size = New System.Drawing.Size(72, 16)
		Me.lblMeters.TabIndex = 2
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(16, 72)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(64, 23)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "Feet"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(16, 32)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(64, 23)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Meters"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.picBoat)
		Me.GroupBox3.Controls.Add(Me.tbBoat)
		Me.GroupBox3.Location = New System.Drawing.Point(8, 144)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(472, 152)
		Me.GroupBox3.TabIndex = 2
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Track Bar"
		'
		'picBoat
		'
		Me.picBoat.Image = CType(resources.GetObject("picBoat.Image"), System.Drawing.Image)
		Me.picBoat.Location = New System.Drawing.Point(16, 24)
		Me.picBoat.Name = "picBoat"
		Me.picBoat.Size = New System.Drawing.Size(40, 40)
		Me.picBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picBoat.TabIndex = 1
		Me.picBoat.TabStop = False
		'
		'tbBoat
		'
		Me.tbBoat.LargeChange = 50
		Me.tbBoat.Location = New System.Drawing.Point(168, 96)
		Me.tbBoat.Maximum = 408
		Me.tbBoat.Minimum = 16
		Me.tbBoat.Name = "tbBoat"
		Me.tbBoat.Size = New System.Drawing.Size(104, 45)
		Me.tbBoat.TabIndex = 0
		Me.tbBoat.TickFrequency = 50
		Me.tbBoat.Value = 16
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(400, 312)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		'
		'Form1
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(488, 342)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "Scrollable Control Demo"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.picBoat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbBoat, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub vsbCentigrade_Scroll(ByVal sender _
	 As System.Object, _
	 ByVal e As System.Windows.Forms.ScrollEventArgs) _
	 Handles vsbCentigrade.Scroll

		' Update the temperatures.
		Dim sngCentigrade As Single
		Dim sngFahrenheit As Single

		' Get the negative of vsbCentigrade.Value because
		' the maximum value is at the bottom of the
		' scroll bar and the minumum is at the top.
		sngCentigrade = -(vsbCentigrade.Value)

		' Calculate fahrenheit temperature.
		sngFahrenheit = CSng((9.0 / 5.0) * sngCentigrade + 32)

		' Display the values.
		lblCentigrade.Text = sngCentigrade.ToString()
		lblFahrenheit.Text = sngFahrenheit.ToString()
	End Sub

	Private Sub hsbMeters_Scroll(ByVal sender As System.Object, _
	 ByVal e As System.Windows.Forms.ScrollEventArgs) _
	 Handles hsbMeters.Scroll

		' Update the distances.
		' 1 meter = 3.281 feet.
		lblMeters.Text = hsbMeters.Value.ToString()
		lblFeet.Text = (hsbMeters.Value * 3.281).ToString()
	End Sub

	Private Sub tbBoat_Scroll(ByVal sender As System.Object, _
		ByVal e As System.EventArgs) Handles tbBoat.Scroll

		' Move the boat by storing tbBoat's Value
		' property in picBoat's Left property.
		picBoat.Left = tbBoat.Value
	End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class
