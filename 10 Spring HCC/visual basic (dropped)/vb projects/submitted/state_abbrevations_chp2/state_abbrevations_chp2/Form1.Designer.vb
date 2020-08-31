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
        Me.lblState = New System.Windows.Forms.Label
        Me.lblAbbreviation = New System.Windows.Forms.Label
        Me.lblVA = New System.Windows.Forms.Label
        Me.lblNC = New System.Windows.Forms.Label
        Me.lblSC = New System.Windows.Forms.Label
        Me.lblGA = New System.Windows.Forms.Label
        Me.lblAL = New System.Windows.Forms.Label
        Me.lblFL = New System.Windows.Forms.Label
        Me.btnVirgina = New System.Windows.Forms.Button
        Me.btnNorthCarolina = New System.Windows.Forms.Button
        Me.btnSouthCarolina = New System.Windows.Forms.Button
        Me.btnGeorgia = New System.Windows.Forms.Button
        Me.btnAlabama = New System.Windows.Forms.Button
        Me.btnFlorida = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnHide = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(49, 32)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(47, 18)
        Me.lblState.TabIndex = 0
        Me.lblState.Text = "State"
        '
        'lblAbbreviation
        '
        Me.lblAbbreviation.AutoSize = True
        Me.lblAbbreviation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbbreviation.Location = New System.Drawing.Point(149, 32)
        Me.lblAbbreviation.Name = "lblAbbreviation"
        Me.lblAbbreviation.Size = New System.Drawing.Size(109, 20)
        Me.lblAbbreviation.TabIndex = 1
        Me.lblAbbreviation.Text = "Abbreviation"
        '
        'lblVA
        '
        Me.lblVA.AutoSize = True
        Me.lblVA.Location = New System.Drawing.Point(190, 67)
        Me.lblVA.Name = "lblVA"
        Me.lblVA.Size = New System.Drawing.Size(21, 13)
        Me.lblVA.TabIndex = 2
        Me.lblVA.Text = "VA"
        Me.lblVA.Visible = False
        '
        'lblNC
        '
        Me.lblNC.AutoSize = True
        Me.lblNC.Location = New System.Drawing.Point(189, 96)
        Me.lblNC.Name = "lblNC"
        Me.lblNC.Size = New System.Drawing.Size(22, 13)
        Me.lblNC.TabIndex = 3
        Me.lblNC.Text = "NC"
        Me.lblNC.Visible = False
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.Location = New System.Drawing.Point(189, 127)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(21, 13)
        Me.lblSC.TabIndex = 4
        Me.lblSC.Text = "SC"
        Me.lblSC.Visible = False
        '
        'lblGA
        '
        Me.lblGA.AutoSize = True
        Me.lblGA.Location = New System.Drawing.Point(188, 159)
        Me.lblGA.Name = "lblGA"
        Me.lblGA.Size = New System.Drawing.Size(22, 13)
        Me.lblGA.TabIndex = 5
        Me.lblGA.Text = "GA"
        Me.lblGA.Visible = False
        '
        'lblAL
        '
        Me.lblAL.AutoSize = True
        Me.lblAL.Location = New System.Drawing.Point(191, 191)
        Me.lblAL.Name = "lblAL"
        Me.lblAL.Size = New System.Drawing.Size(20, 13)
        Me.lblAL.TabIndex = 6
        Me.lblAL.Text = "AL"
        Me.lblAL.Visible = False
        '
        'lblFL
        '
        Me.lblFL.AutoSize = True
        Me.lblFL.Location = New System.Drawing.Point(192, 221)
        Me.lblFL.Name = "lblFL"
        Me.lblFL.Size = New System.Drawing.Size(19, 13)
        Me.lblFL.TabIndex = 7
        Me.lblFL.Text = "FL"
        Me.lblFL.Visible = False
        '
        'btnVirgina
        '
        Me.btnVirgina.Location = New System.Drawing.Point(35, 62)
        Me.btnVirgina.Name = "btnVirgina"
        Me.btnVirgina.Size = New System.Drawing.Size(88, 23)
        Me.btnVirgina.TabIndex = 8
        Me.btnVirgina.Text = "Virgina"
        Me.btnVirgina.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Location = New System.Drawing.Point(35, 91)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(88, 23)
        Me.btnNorthCarolina.TabIndex = 9
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnSouthCarolina
        '
        Me.btnSouthCarolina.Location = New System.Drawing.Point(35, 122)
        Me.btnSouthCarolina.Name = "btnSouthCarolina"
        Me.btnSouthCarolina.Size = New System.Drawing.Size(88, 23)
        Me.btnSouthCarolina.TabIndex = 10
        Me.btnSouthCarolina.Text = "South Carolina"
        Me.btnSouthCarolina.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(35, 154)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(88, 23)
        Me.btnGeorgia.TabIndex = 11
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(35, 186)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(88, 23)
        Me.btnAlabama.TabIndex = 12
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnFlorida
        '
        Me.btnFlorida.Location = New System.Drawing.Point(35, 216)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(88, 23)
        Me.btnFlorida.TabIndex = 13
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(121, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(103, 245)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(108, 23)
        Me.btnHide.TabIndex = 15
        Me.btnHide.Text = "Hide States"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(295, 299)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnSouthCarolina)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirgina)
        Me.Controls.Add(Me.lblFL)
        Me.Controls.Add(Me.lblAL)
        Me.Controls.Add(Me.lblGA)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.lblNC)
        Me.Controls.Add(Me.lblVA)
        Me.Controls.Add(Me.lblAbbreviation)
        Me.Controls.Add(Me.lblState)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "State Abbrevations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblAbbreviation As System.Windows.Forms.Label
    Friend WithEvents lblVA As System.Windows.Forms.Label
    Friend WithEvents lblNC As System.Windows.Forms.Label
    Friend WithEvents lblSC As System.Windows.Forms.Label
    Friend WithEvents lblGA As System.Windows.Forms.Label
    Friend WithEvents lblAL As System.Windows.Forms.Label
    Friend WithEvents lblFL As System.Windows.Forms.Label
    Friend WithEvents btnVirgina As System.Windows.Forms.Button
    Friend WithEvents btnNorthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnSouthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnGeorgia As System.Windows.Forms.Button
    Friend WithEvents btnAlabama As System.Windows.Forms.Button
    Friend WithEvents btnFlorida As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button

End Class
