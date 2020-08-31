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
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLowest As System.Windows.Forms.Label
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblLowest = New System.Windows.Forms.Label
        Me.lblHighest = New System.Windows.Forms.Label
        Me.lblAverage = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(49, 184)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 37)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate Sales Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLowest)
        Me.GroupBox1.Controls.Add(Me.lblHighest)
        Me.GroupBox1.Controls.Add(Me.lblAverage)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Data"
        '
        'lblLowest
        '
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLowest.Location = New System.Drawing.Point(128, 120)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(76, 23)
        Me.lblLowest.TabIndex = 16
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighest.Location = New System.Drawing.Point(128, 88)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(76, 23)
        Me.lblHighest.TabIndex = 15
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(128, 56)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(76, 23)
        Me.lblAverage.TabIndex = 14
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(128, 24)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 23)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Lowest Sales"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Highest Sales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Average Sales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total Sales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(171, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 233)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Sales Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCalculate_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim decSales() As Decimal = Nothing  ' Sales array
        Dim decTotal As Decimal         ' Total sales
        Dim decAverage As Decimal       ' Average sales
        Dim decHighest As Decimal       ' Highest sales
        Dim decLowest As Decimal        ' Lowest sales

        If GetSalesData(decSales) Then
            ' Calculate total, average, highest,
            ' and lowest sales
            decTotal = GetTotal(decSales)
            decAverage = GetAverage(decSales)
            decHighest = GetHighest(decSales)
            decLowest = GetLowest(decSales)

            ' Display the results.
            lblTotal.Text = FormatCurrency(decTotal)
            lblAverage.Text = FormatCurrency(decAverage)
            lblHighest.Text = FormatCurrency(decHighest)
            lblLowest.Text = FormatCurrency(decLowest)
		End If

    End Sub


    Function GetSalesData(ByRef decSales() As Decimal) As Boolean

        ' Prompts the user for sales figures and stores the
        ' values in an array. Returns True if the procedure
        ' was successful, otherwise returns False.

        Dim decSalesData() As Decimal    ' Sales data array
        Dim intNumDays As Integer = 0    ' Number of days
        Dim intCount As Integer          ' Loop counter
        Dim blnSuccess As Boolean        ' Indicates success or failure

        Dim strNumDays As String = InputBox("For how many days do you " _
                   & "have sales?")

        If Not Integer.TryParse(strNumDays, intNumDays) Then
            MessageBox.Show("You entered a nonnumeric value", _
             "Error")
            Return False
        End If

        If intNumDays > 0 Then
            ' Resize the array to the correct number of days.
            ReDim decSalesData(intNumDays - 1)

            ' Input each day's sales from the user.
            For intCount = 0 To (intNumDays - 1)
                Dim blnValid As Boolean

                Do
                    blnValid = Decimal.TryParse(InputBox( _
                        "Enter the sales for " & _
                        "day " & (intCount + 1).ToString), _
                        decSalesData(intCount))

                    If Not blnValid Then
                        MessageBox.Show("Please enter a valid number")
                    End If

                Loop Until blnValid

            Next intCount

            ' Assign the array to the parameter variable.
            decSales = decSalesData
            blnSuccess = True
        Else
            MessageBox.Show("You must enter at least one day " _
             & "of sales.")
            blnSuccess = False
        End If
        Return blnSuccess

    End Function

    Function GetTotal(ByVal decValues() As Decimal) As Decimal

        ' Calculate and return the total of the
        ' values in the array argument.

        Dim decTotal As Decimal = 0    ' Accumulator
        Dim intCount As Integer        ' Loop counter

        For intCount = 0 To (decValues.Length - 1)
            decTotal += decValues(intCount)
        Next
        Return decTotal

    End Function

    Function GetAverage(ByVal decValues() As Decimal) As Decimal
        ' Calculate and return the average of the
        ' values in the array argument.

        Return GetTotal(decValues) / decValues.Length

    End Function

    Function GetHighest(ByVal decValues() As Decimal) As Decimal

        ' Returns the largest value in a Decimal array.
        Dim intCount As Integer             ' Loop counter
        Dim decHighest As Decimal = decValues(0)    ' Largest value

        For intCount = 1 To (decValues.Length - 1)
            If decValues(intCount) > decHighest Then
                decHighest = decValues(intCount)
            End If
        Next
        Return decHighest

    End Function

    Function GetLowest(ByVal decValues() As Decimal) As Decimal

        ' Returns the smallest value in a Decimal array.
        Dim decCount As Integer             ' Loop counter
        Dim decLowest As Decimal = decValues(0)     ' Smallest value

        For decCount = 1 To (decValues.Length - 1)
            If decValues(decCount) < decLowest Then
                decLowest = decValues(decCount)
            End If
        Next
        Return decLowest

    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the applicaiton

        Me.Close()
	End Sub

End Class
