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
    Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents chkCheckBox As System.Windows.Forms.CheckBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cboPets As System.Windows.Forms.ComboBox
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents lstVegetables As System.Windows.Forms.ListBox
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents radOption1 As System.Windows.Forms.RadioButton
    Public WithEvents radOption3 As System.Windows.Forms.RadioButton
    Public WithEvents radOption2 As System.Windows.Forms.RadioButton
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblPet As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblOption As System.Windows.Forms.Label
    Public WithEvents lblVegetable As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblVScrollValue As System.Windows.Forms.Label
    Public WithEvents lblHScrollValue As System.Windows.Forms.Label
    Friend WithEvents vsbVertical As System.Windows.Forms.VScrollBar
    Public WithEvents hsbHorizontal As System.Windows.Forms.HScrollBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblVScrollValue = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.vsbVertical = New System.Windows.Forms.VScrollBar()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.hsbHorizontal = New System.Windows.Forms.HScrollBar()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkCheckBox = New System.Windows.Forms.CheckBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboPets = New System.Windows.Forms.ComboBox()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.lstVegetables = New System.Windows.Forms.ListBox()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.radOption1 = New System.Windows.Forms.RadioButton()
        Me.radOption3 = New System.Windows.Forms.RadioButton()
        Me.radOption2 = New System.Windows.Forms.RadioButton()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPet = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblHScrollValue = New System.Windows.Forms.Label()
        Me.lblVegetable = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVScrollValue
        '
        Me.lblVScrollValue.BackColor = System.Drawing.SystemColors.Control
        Me.lblVScrollValue.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVScrollValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVScrollValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVScrollValue.Location = New System.Drawing.Point(384, 346)
        Me.lblVScrollValue.Name = "lblVScrollValue"
        Me.lblVScrollValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVScrollValue.Size = New System.Drawing.Size(113, 17)
        Me.lblVScrollValue.TabIndex = 63
        Me.lblVScrollValue.Text = "Move the Scroll Bar"
        Me.lblVScrollValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.vsbVertical})
        Me.GroupBox1.Location = New System.Drawing.Point(400, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 120)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VScrollBar"
        '
        'vsbVertical
        '
        Me.vsbVertical.Location = New System.Drawing.Point(32, 24)
        Me.vsbVertical.Name = "vsbVertical"
        Me.vsbVertical.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(224, 322)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(81, 33)
        Me.btnClose.TabIndex = 60
        Me.btnClose.Text = "Close"
        '
        'hsbHorizontal
        '
        Me.hsbHorizontal.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsbHorizontal.Location = New System.Drawing.Point(204, 212)
        Me.hsbHorizontal.Name = "hsbHorizontal"
        Me.hsbHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsbHorizontal.Size = New System.Drawing.Size(113, 17)
        Me.hsbHorizontal.TabIndex = 52
        Me.hsbHorizontal.TabStop = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkCheckBox})
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(192, 58)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(145, 65)
        Me.Frame1.TabIndex = 47
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "CheckBox"
        '
        'chkCheckBox
        '
        Me.chkCheckBox.BackColor = System.Drawing.SystemColors.Control
        Me.chkCheckBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCheckBox.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCheckBox.Location = New System.Drawing.Point(12, 16)
        Me.chkCheckBox.Name = "chkCheckBox"
        Me.chkCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCheckBox.Size = New System.Drawing.Size(113, 33)
        Me.chkCheckBox.TabIndex = 24
        Me.chkCheckBox.Text = "The Check Box is un-checked"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPets})
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(24, 58)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(129, 73)
        Me.Frame2.TabIndex = 48
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "ComboBox"
        '
        'cboPets
        '
        Me.cboPets.BackColor = System.Drawing.SystemColors.Window
        Me.cboPets.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPets.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPets.Items.AddRange(New Object() {"Dog", "Cat", "Iguana", "Parrot", "Tarantula", "Llama", "Pony"})
        Me.cboPets.Location = New System.Drawing.Point(16, 25)
        Me.cboPets.Name = "cboPets"
        Me.cboPets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPets.Size = New System.Drawing.Size(97, 22)
        Me.cboPets.TabIndex = 25
        Me.cboPets.Text = "Choose a Pet"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstVegetables})
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(376, 58)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(121, 105)
        Me.Frame3.TabIndex = 51
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "ListBox"
        '
        'lstVegetables
        '
        Me.lstVegetables.BackColor = System.Drawing.SystemColors.Window
        Me.lstVegetables.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstVegetables.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVegetables.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstVegetables.ItemHeight = 14
        Me.lstVegetables.Items.AddRange(New Object() {"Beans", "Broccoli", "Carrots", "Lettuce", "Peas", "Squash"})
        Me.lstVegetables.Location = New System.Drawing.Point(16, 22)
        Me.lstVegetables.Name = "lstVegetables"
        Me.lstVegetables.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstVegetables.Size = New System.Drawing.Size(89, 60)
        Me.lstVegetables.Sorted = True
        Me.lstVegetables.TabIndex = 28
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.AddRange(New System.Windows.Forms.Control() {Me.radOption1, Me.radOption3, Me.radOption2})
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(16, 186)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(145, 96)
        Me.Frame4.TabIndex = 54
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "RadioButtons"
        '
        'radOption1
        '
        Me.radOption1.BackColor = System.Drawing.SystemColors.Control
        Me.radOption1.Cursor = System.Windows.Forms.Cursors.Default
        Me.radOption1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOption1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radOption1.Location = New System.Drawing.Point(24, 24)
        Me.radOption1.Name = "radOption1"
        Me.radOption1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radOption1.Size = New System.Drawing.Size(81, 20)
        Me.radOption1.TabIndex = 41
        Me.radOption1.TabStop = True
        Me.radOption1.Text = "Option 1"
        '
        'radOption3
        '
        Me.radOption3.BackColor = System.Drawing.SystemColors.Control
        Me.radOption3.Cursor = System.Windows.Forms.Cursors.Default
        Me.radOption3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOption3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radOption3.Location = New System.Drawing.Point(24, 72)
        Me.radOption3.Name = "radOption3"
        Me.radOption3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radOption3.Size = New System.Drawing.Size(81, 20)
        Me.radOption3.TabIndex = 40
        Me.radOption3.TabStop = True
        Me.radOption3.Text = "Option 3"
        '
        'radOption2
        '
        Me.radOption2.BackColor = System.Drawing.SystemColors.Control
        Me.radOption2.Cursor = System.Windows.Forms.Cursors.Default
        Me.radOption2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOption2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radOption2.Location = New System.Drawing.Point(24, 48)
        Me.radOption2.Name = "radOption2"
        Me.radOption2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radOption2.Size = New System.Drawing.Size(81, 20)
        Me.radOption2.TabIndex = 39
        Me.radOption2.TabStop = True
        Me.radOption2.Text = "Option 2"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(188, 188)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(145, 57)
        Me.Frame5.TabIndex = 59
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "HScrollBar"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(20, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(449, 33)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Experiment with These Controls!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPet
        '
        Me.lblPet.BackColor = System.Drawing.SystemColors.Control
        Me.lblPet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPet.Location = New System.Drawing.Point(40, 154)
        Me.lblPet.Name = "lblPet"
        Me.lblPet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPet.Size = New System.Drawing.Size(97, 17)
        Me.lblPet.TabIndex = 58
        Me.lblPet.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(48, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "You selected:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(40, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "You selected:"
        '
        'lblOption
        '
        Me.lblOption.BackColor = System.Drawing.SystemColors.Control
        Me.lblOption.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOption.Location = New System.Drawing.Point(24, 314)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOption.Size = New System.Drawing.Size(97, 24)
        Me.lblOption.TabIndex = 55
        Me.lblOption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHScrollValue
        '
        Me.lblHScrollValue.BackColor = System.Drawing.SystemColors.Control
        Me.lblHScrollValue.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHScrollValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHScrollValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHScrollValue.Location = New System.Drawing.Point(204, 252)
        Me.lblHScrollValue.Name = "lblHScrollValue"
        Me.lblHScrollValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHScrollValue.Size = New System.Drawing.Size(113, 17)
        Me.lblHScrollValue.TabIndex = 53
        Me.lblHScrollValue.Text = "Move the Scroll Bar"
        Me.lblHScrollValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVegetable
        '
        Me.lblVegetable.BackColor = System.Drawing.SystemColors.Control
        Me.lblVegetable.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVegetable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVegetable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVegetable.Location = New System.Drawing.Point(392, 186)
        Me.lblVegetable.Name = "lblVegetable"
        Me.lblVegetable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVegetable.Size = New System.Drawing.Size(97, 16)
        Me.lblVegetable.TabIndex = 50
        Me.lblVegetable.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(400, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "You selected:"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(512, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblVScrollValue, Me.GroupBox1, Me.btnClose, Me.hsbHorizontal, Me.Frame1, Me.Frame2, Me.Frame3, Me.Frame4, Me.Frame5, Me.Label4, Me.lblPet, Me.Label2, Me.Label3, Me.lblOption, Me.lblHScrollValue, Me.lblVegetable, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "A Tour of Various Controls"
        Me.GroupBox1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cboPets_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPets.SelectedIndexChanged
        lblPet.Text = cboPets.Text
    End Sub

    Private Sub chkCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckBox.CheckedChanged
        If chkCheckBox.CheckState = CheckState.Checked Then
            chkCheckBox.Text = "The Check Box is checked"
        Else
            chkCheckBox.Text = "The Check Box is un-checked"
        End If
    End Sub

    Private Sub lstVegetables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVegetables.SelectedIndexChanged
        lblVegetable.Text = lstVegetables.Text
    End Sub

    Private Sub radOption1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOption1.CheckedChanged
        If radOption1.Checked = True Then
            lblOption.Text = "Option 1"
        End If
    End Sub

    Private Sub radOption2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOption2.CheckedChanged
        If radOption2.Checked = True Then
            lblOption.Text = "Option 2"
        End If
    End Sub

    Private Sub radOption3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOption3.CheckedChanged
        If radOption3.Checked = True Then
            lblOption.Text = "Option 3"
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' End the applicaiton.
        End
    End Sub

    Private Sub hsbHorizontal_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbHorizontal.Scroll
        ' Store the horizontal scroll bar's value in
        ' the Label control.
        lblHScrollValue.Text = hsbHorizontal.Value
    End Sub

    Private Sub vsbVertical_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbVertical.Scroll
        ' Store the horizontal scroll bar's value in
        ' the Label control.
        lblVScrollValue.Text = vsbVertical.Value
    End Sub
End Class
