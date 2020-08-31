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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadWhite = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radNoCoffee = New System.Windows.Forms.RadioButton
        Me.radCappuccino = New System.Windows.Forms.RadioButton
        Me.radRegCoffee = New System.Windows.Forms.RadioButton
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox
        Me.chkButter = New System.Windows.Forms.CheckBox
        Me.chkBlueberry = New System.Windows.Forms.CheckBox
        Me.chkRaspBerry = New System.Windows.Forms.CheckBox
        Me.chkPeach = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadWhite)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Bagel"
        '
        'RadWhite
        '
        Me.RadWhite.AutoSize = True
        Me.RadWhite.Checked = True
        Me.RadWhite.Location = New System.Drawing.Point(6, 28)
        Me.RadWhite.Name = "RadWhite"
        Me.RadWhite.Size = New System.Drawing.Size(89, 17)
        Me.RadWhite.TabIndex = 1
        Me.RadWhite.TabStop = True
        Me.RadWhite.Text = "White ($1.25)"
        Me.ToolTip1.SetToolTip(Me.RadWhite, "Click here to choose a white bagel")
        Me.RadWhite.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 74)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Whole Wheat ($1.50)"
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "Click here to choose a whole wheat bagel")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radNoCoffee)
        Me.GroupBox2.Controls.Add(Me.radCappuccino)
        Me.GroupBox2.Controls.Add(Me.radRegCoffee)
        Me.GroupBox2.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 139)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Want Coffee with that?"
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(6, 28)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(51, 17)
        Me.radNoCoffee.TabIndex = 3
        Me.radNoCoffee.Text = "None"
        Me.ToolTip1.SetToolTip(Me.radNoCoffee, "Click here to choose no coffee")
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(6, 74)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 4
        Me.radCappuccino.Text = "Cappuccino ($2.00)"
        Me.ToolTip1.SetToolTip(Me.radCappuccino, "Click here to choose cappuccino")
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radRegCoffee
        '
        Me.radRegCoffee.AutoSize = True
        Me.radRegCoffee.Checked = True
        Me.radRegCoffee.Location = New System.Drawing.Point(6, 51)
        Me.radRegCoffee.Name = "radRegCoffee"
        Me.radRegCoffee.Size = New System.Drawing.Size(132, 17)
        Me.radRegCoffee.TabIndex = 5
        Me.radRegCoffee.TabStop = True
        Me.radRegCoffee.Text = "Regular Coffee ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radRegCoffee, "Click here to choose regular coffee")
        Me.radRegCoffee.UseVisualStyleBackColor = True
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(6, 97)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(114, 17)
        Me.radCafeAuLait.TabIndex = 6
        Me.radCafeAuLait.Text = "Cafe au lait ($1.75)"
        Me.ToolTip1.SetToolTip(Me.radCafeAuLait, "Click here to choose cafe au lait")
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox3.Controls.Add(Me.chkButter)
        Me.GroupBox3.Controls.Add(Me.chkBlueberry)
        Me.GroupBox3.Controls.Add(Me.chkRaspBerry)
        Me.GroupBox3.Controls.Add(Me.chkPeach)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 182)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pick Your Toppings"
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(6, 19)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(125, 17)
        Me.chkCreamCheese.TabIndex = 1
        Me.chkCreamCheese.Text = "Cream Cheese ($.50)"
        Me.ToolTip1.SetToolTip(Me.chkCreamCheese, "Click here to choose cream cheese")
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(6, 42)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(84, 17)
        Me.chkButter.TabIndex = 2
        Me.chkButter.Text = "Butter ($.25)"
        Me.ToolTip1.SetToolTip(Me.chkButter, "Click here to choose butter")
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(6, 65)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(122, 17)
        Me.chkBlueberry.TabIndex = 3
        Me.chkBlueberry.Text = "Blueberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkBlueberry, "Click here to choose blueberry jam")
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkRaspBerry
        '
        Me.chkRaspBerry.AutoSize = True
        Me.chkRaspBerry.Location = New System.Drawing.Point(6, 88)
        Me.chkRaspBerry.Name = "chkRaspBerry"
        Me.chkRaspBerry.Size = New System.Drawing.Size(126, 17)
        Me.chkRaspBerry.TabIndex = 4
        Me.chkRaspBerry.Text = "Raspberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkRaspBerry, "click here to choose raspberry jam")
        Me.chkRaspBerry.UseVisualStyleBackColor = True
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(6, 111)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(110, 17)
        Me.chkPeach.TabIndex = 5
        Me.chkPeach.Text = "Peach Jelly ($.75)"
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Location = New System.Drawing.Point(264, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 182)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Subtotal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tax"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(138, 18)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 6
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(138, 60)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(138, 119)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(65, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click here to calculate the total of the order")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(205, 345)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click here to clear the form and start over")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(361, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 414)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Brandi's Bagel House"
        Me.ToolTip1.SetToolTip(Me, "click here to choose peach jelly")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadWhite As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radNoCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents radCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radRegCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents radCafeAuLait As System.Windows.Forms.RadioButton
    Friend WithEvents chkCreamCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkButter As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlueberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkRaspBerry As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeach As System.Windows.Forms.CheckBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
