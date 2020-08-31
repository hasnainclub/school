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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnEnterSales As System.Windows.Forms.Button
    Public WithEvents lblTotal As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEnterSales = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(120, 72)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnterSales
        '
        Me.btnEnterSales.BackColor = System.Drawing.SystemColors.Control
        Me.btnEnterSales.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnterSales.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterSales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnterSales.Location = New System.Drawing.Point(16, 72)
        Me.btnEnterSales.Name = "btnEnterSales"
        Me.btnEnterSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEnterSales.Size = New System.Drawing.Size(81, 33)
        Me.btnEnterSales.TabIndex = 4
        Me.btnEnterSales.Text = "&Enter Sales"
        Me.btnEnterSales.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(104, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(97, 25)
        Me.lblTotal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Sales:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(216, 118)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterSales)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Total Sales"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This application demonstrates how to use a loop with an accumulator
    ' to keep a running total.

    Private Sub btnEnterSales_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnEnterSales.Click
        '  get the daily sales from the user and calculate the total
        Dim intCount As Integer '  loop the counter
        Dim decSales As Decimal '  to hold the daily sales
        Dim decTotal As Decimal  '  use as an accumalator
        Dim strInput As String ' to get the user input

        '  sttore the correct starting values in the counter and accumalator
        intCount = 1
        decTotal = 0
        ' the following loot gets the sales for each day
        Do While intCount <= 5
            strInput = InputBox("Enter the sales for day " & intCount.ToString(), "Sales amount needed")
            If strInput <> String.Empty Then
                If IsNumeric(strInput) Then
                    decSales = CDec(strInput) '  strong input in sales
                    decTotal += decSales '  add sales to total 
                    intCount += 1
                Else
                    MessageBox.Show("Please enter a valid number for the sales amount", "Error")


                End If
            Else
                Exit Do
            End If
        Loop

        '  display the running total
        lblTotal.Text = decTotal.ToString("c")

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the Application by closing the window.
        Me.Close()
    End Sub
End Class
