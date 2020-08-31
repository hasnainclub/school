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
        Me.lblHotelNameDisp = New System.Windows.Forms.Label
        Me.lblDateToday = New System.Windows.Forms.Label
        Me.lblTimeToday = New System.Windows.Forms.Label
        Me.lblTodaysDateDisp = New System.Windows.Forms.Label
        Me.lblTodaysTimeDisp = New System.Windows.Forms.Label
        Me.lblMiscDisp = New System.Windows.Forms.Label
        Me.lblTeleDisp = New System.Windows.Forms.Label
        Me.lblRoomServiceDisp = New System.Windows.Forms.Label
        Me.lblNightsDisp = New System.Windows.Forms.Label
        Me.lblNightlyChargeDisp = New System.Windows.Forms.Label
        Me.lblRoomChargesDisp = New System.Windows.Forms.Label
        Me.lblAdditionChargesDisp = New System.Windows.Forms.Label
        Me.lblSubtotalDisp = New System.Windows.Forms.Label
        Me.lblTaxDisp = New System.Windows.Forms.Label
        Me.lblTotalChrgsDisp = New System.Windows.Forms.Label
        Me.lblRoomCharges = New System.Windows.Forms.Label
        Me.lblAddCharges = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox
        Me.txtNights = New System.Windows.Forms.TextBox
        Me.txtMisc = New System.Windows.Forms.TextBox
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.txtRoomService = New System.Windows.Forms.TextBox
        Me.grpAddCharges = New System.Windows.Forms.GroupBox
        Me.grpRoomInfo = New System.Windows.Forms.GroupBox
        Me.grpTotalCharges = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'lblHotelNameDisp
        '
        Me.lblHotelNameDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotelNameDisp.Location = New System.Drawing.Point(112, 9)
        Me.lblHotelNameDisp.Name = "lblHotelNameDisp"
        Me.lblHotelNameDisp.Size = New System.Drawing.Size(241, 25)
        Me.lblHotelNameDisp.TabIndex = 0
        Me.lblHotelNameDisp.Text = "Highlander Hotel"
        Me.lblHotelNameDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateToday
        '
        Me.lblDateToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateToday.Location = New System.Drawing.Point(345, 39)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(155, 23)
        Me.lblDateToday.TabIndex = 2
        '
        'lblTimeToday
        '
        Me.lblTimeToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeToday.Location = New System.Drawing.Point(345, 62)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(155, 23)
        Me.lblTimeToday.TabIndex = 3
        '
        'lblTodaysDateDisp
        '
        Me.lblTodaysDateDisp.Location = New System.Drawing.Point(233, 35)
        Me.lblTodaysDateDisp.Name = "lblTodaysDateDisp"
        Me.lblTodaysDateDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblTodaysDateDisp.TabIndex = 4
        Me.lblTodaysDateDisp.Text = "Today's Date:"
        Me.lblTodaysDateDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTodaysTimeDisp
        '
        Me.lblTodaysTimeDisp.Location = New System.Drawing.Point(233, 58)
        Me.lblTodaysTimeDisp.Name = "lblTodaysTimeDisp"
        Me.lblTodaysTimeDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblTodaysTimeDisp.TabIndex = 5
        Me.lblTodaysTimeDisp.Text = "Time:"
        Me.lblTodaysTimeDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMiscDisp
        '
        Me.lblMiscDisp.Location = New System.Drawing.Point(294, 178)
        Me.lblMiscDisp.Name = "lblMiscDisp"
        Me.lblMiscDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblMiscDisp.TabIndex = 6
        Me.lblMiscDisp.Text = "&Misc:"
        Me.lblMiscDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTeleDisp
        '
        Me.lblTeleDisp.Location = New System.Drawing.Point(294, 155)
        Me.lblTeleDisp.Name = "lblTeleDisp"
        Me.lblTeleDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblTeleDisp.TabIndex = 7
        Me.lblTeleDisp.Text = "&Telephone:"
        Me.lblTeleDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRoomServiceDisp
        '
        Me.lblRoomServiceDisp.Location = New System.Drawing.Point(294, 132)
        Me.lblRoomServiceDisp.Name = "lblRoomServiceDisp"
        Me.lblRoomServiceDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblRoomServiceDisp.TabIndex = 8
        Me.lblRoomServiceDisp.Text = "Room Se&rvice:"
        Me.lblRoomServiceDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNightsDisp
        '
        Me.lblNightsDisp.Location = New System.Drawing.Point(23, 132)
        Me.lblNightsDisp.Name = "lblNightsDisp"
        Me.lblNightsDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblNightsDisp.TabIndex = 9
        Me.lblNightsDisp.Text = "&Nights"
        Me.lblNightsDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNightlyChargeDisp
        '
        Me.lblNightlyChargeDisp.Location = New System.Drawing.Point(23, 155)
        Me.lblNightlyChargeDisp.Name = "lblNightlyChargeDisp"
        Me.lblNightlyChargeDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblNightlyChargeDisp.TabIndex = 10
        Me.lblNightlyChargeDisp.Text = "Nightly Char&ge"
        Me.lblNightlyChargeDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRoomChargesDisp
        '
        Me.lblRoomChargesDisp.Location = New System.Drawing.Point(74, 268)
        Me.lblRoomChargesDisp.Name = "lblRoomChargesDisp"
        Me.lblRoomChargesDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblRoomChargesDisp.TabIndex = 12
        Me.lblRoomChargesDisp.Text = "Room Charges:"
        Me.lblRoomChargesDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdditionChargesDisp
        '
        Me.lblAdditionChargesDisp.Location = New System.Drawing.Point(74, 298)
        Me.lblAdditionChargesDisp.Name = "lblAdditionChargesDisp"
        Me.lblAdditionChargesDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditionChargesDisp.TabIndex = 13
        Me.lblAdditionChargesDisp.Text = "Additional Charges:"
        Me.lblAdditionChargesDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotalDisp
        '
        Me.lblSubtotalDisp.Location = New System.Drawing.Point(74, 331)
        Me.lblSubtotalDisp.Name = "lblSubtotalDisp"
        Me.lblSubtotalDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotalDisp.TabIndex = 14
        Me.lblSubtotalDisp.Text = "Subtotal:"
        Me.lblSubtotalDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxDisp
        '
        Me.lblTaxDisp.Location = New System.Drawing.Point(74, 360)
        Me.lblTaxDisp.Name = "lblTaxDisp"
        Me.lblTaxDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblTaxDisp.TabIndex = 15
        Me.lblTaxDisp.Text = "Tax:"
        Me.lblTaxDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalChrgsDisp
        '
        Me.lblTotalChrgsDisp.Location = New System.Drawing.Point(74, 383)
        Me.lblTotalChrgsDisp.Name = "lblTotalChrgsDisp"
        Me.lblTotalChrgsDisp.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalChrgsDisp.TabIndex = 16
        Me.lblTotalChrgsDisp.Text = "Total Charges:"
        Me.lblTotalChrgsDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCharges.Location = New System.Drawing.Point(180, 267)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblRoomCharges.TabIndex = 17
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCharges.Location = New System.Drawing.Point(180, 297)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblAddCharges.TabIndex = 18
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(180, 330)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 19
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(180, 359)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(180, 382)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 21
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(62, 472)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(220, 472)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(345, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(129, 155)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharge.TabIndex = 1
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(129, 135)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 0
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(397, 175)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 20)
        Me.txtMisc.TabIndex = 4
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(397, 152)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 3
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(397, 129)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomService.TabIndex = 2
        '
        'grpAddCharges
        '
        Me.grpAddCharges.Location = New System.Drawing.Point(300, 101)
        Me.grpAddCharges.Name = "grpAddCharges"
        Me.grpAddCharges.Size = New System.Drawing.Size(200, 111)
        Me.grpAddCharges.TabIndex = 31
        Me.grpAddCharges.TabStop = False
        Me.grpAddCharges.Text = "Additional Charges"
        '
        'grpRoomInfo
        '
        Me.grpRoomInfo.Location = New System.Drawing.Point(12, 101)
        Me.grpRoomInfo.Name = "grpRoomInfo"
        Me.grpRoomInfo.Size = New System.Drawing.Size(240, 130)
        Me.grpRoomInfo.TabIndex = 0
        Me.grpRoomInfo.TabStop = False
        Me.grpRoomInfo.Text = "Room Information"
        '
        'grpTotalCharges
        '
        Me.grpTotalCharges.Location = New System.Drawing.Point(35, 237)
        Me.grpTotalCharges.Name = "grpTotalCharges"
        Me.grpTotalCharges.Size = New System.Drawing.Size(424, 229)
        Me.grpTotalCharges.TabIndex = 0
        Me.grpTotalCharges.TabStop = False
        Me.grpTotalCharges.Text = "Total Charges"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 533)
        Me.Controls.Add(Me.txtRoomService)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtMisc)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.txtNightlyCharge)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblAddCharges)
        Me.Controls.Add(Me.lblRoomCharges)
        Me.Controls.Add(Me.lblTotalChrgsDisp)
        Me.Controls.Add(Me.lblTaxDisp)
        Me.Controls.Add(Me.lblSubtotalDisp)
        Me.Controls.Add(Me.lblAdditionChargesDisp)
        Me.Controls.Add(Me.lblRoomChargesDisp)
        Me.Controls.Add(Me.lblNightlyChargeDisp)
        Me.Controls.Add(Me.lblNightsDisp)
        Me.Controls.Add(Me.lblRoomServiceDisp)
        Me.Controls.Add(Me.lblTeleDisp)
        Me.Controls.Add(Me.lblMiscDisp)
        Me.Controls.Add(Me.lblTodaysTimeDisp)
        Me.Controls.Add(Me.lblTodaysDateDisp)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.lblHotelNameDisp)
        Me.Controls.Add(Me.grpTotalCharges)
        Me.Controls.Add(Me.grpAddCharges)
        Me.Controls.Add(Me.grpRoomInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHotelNameDisp As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents lblTimeToday As System.Windows.Forms.Label
    Friend WithEvents lblTodaysDateDisp As System.Windows.Forms.Label
    Friend WithEvents lblTodaysTimeDisp As System.Windows.Forms.Label
    Friend WithEvents lblMiscDisp As System.Windows.Forms.Label
    Friend WithEvents lblTeleDisp As System.Windows.Forms.Label
    Friend WithEvents lblRoomServiceDisp As System.Windows.Forms.Label
    Friend WithEvents lblNightsDisp As System.Windows.Forms.Label
    Friend WithEvents lblNightlyChargeDisp As System.Windows.Forms.Label
    Friend WithEvents lblRoomChargesDisp As System.Windows.Forms.Label
    Friend WithEvents lblAdditionChargesDisp As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalDisp As System.Windows.Forms.Label
    Friend WithEvents lblTaxDisp As System.Windows.Forms.Label
    Friend WithEvents lblTotalChrgsDisp As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents grpAddCharges As System.Windows.Forms.GroupBox
    Friend WithEvents grpRoomInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpTotalCharges As System.Windows.Forms.GroupBox

End Class
