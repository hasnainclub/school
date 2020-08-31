Public Class Form1

  
    '  Define valid month ranges
    Const intMIN_MONTHS As Integer = 6
    Const intMAX_MONTHS As Integer = 48
    Const sngMonths_YEAR As Single = 12.0 '  Months per year

    '  define annual interest rates for new and used cars
    Const dblNEW_RATE As Double = 0.089 ' new car interest
    Const dblUSED_RATE As Double = 0.095 ' used cars interest

    Dim dblAnnualRate As Double = dblNEW_RATE  '  annual interest rate

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '  Calculate and display the loan payment information
        Dim intCount As Integer '  counter for the loop
        Dim intMonths As Integer  '  No of months for the loan
        Dim dblLoan As Double '  amount of the loan
        Dim dblPayment As Double '  monthly payment
        Dim dblInterest As Double  '  interest paid for the period
        Dim dblPrincipal As Double  '  principal paid for the period


        '  get the number of months and calculate the loan amount 
        Try
            intMonths = CInt(txtMonths.Text)
            dblLoan = CDec(txtCost.Text) - CDec(txtDownPayment.Text)
        Catch
            MessageBox.Show("Please enter numeric Values")
            Return

        End Try

        '  calculate the monthly payment
        dblPayment = Pmt(dblAnnualRate / sngMonths_YEAR, intMonths, -dblLoan)

        '  clear the list box
        lstOutput.Items.Clear()

        For intCount = 1 To intMonths
            '  holds list box output
            Dim strOut As String = String.Empty
            '  calculate the interest for the period
            dblInterest = IPmt(dblAnnualRate / sngMonths_YEAR, intCount, intMonths, -dblLoan)
            '  calculate and display the principal for the period
            dblPrincipal = PPmt(dblAnnualRate / sngMonths_YEAR, intCount, intMonths, -dblLoan)

            '  add the month to the output string
            strOut &= "Mounth:  " & intCount.ToString()
            '  add payment amount to the output string
            strOut &= " Payment:  " & dblPayment.ToString("c")
            '  add the interest amount to the output string
            strOut &= " Interest: " & dblInterest.ToString("c")
            '  add the principal for the period
            strOut &= " Principal: " & dblPrincipal.ToString("c")

            '  add the output string to the list box
            lstOutput.Items.Add(strOut)

        Next intCount


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '  reset the interest rate, clear the text boxes
        ' and clear the lis box
        txtCost.CausesValidation = False
        txtDownPayment.CausesValidation = False
        txtMonths.CausesValidation = False
        radNew.Checked = True
        dblAnnualRate = dblNEW_RATE
        lblAnnInt.Text = dblNEW_RATE.ToString("p")
        

        txtCost.Clear()
        txtDownPayment.Clear()
        txtMonths.Clear()
        lstOutput.Items.Clear()
        '  reset the focus
        txtCost.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        txtCost.CausesValidation = False
        txtDownPayment.CausesValidation = False
        txtMonths.CausesValidation = False
        ' end the application
        Me.Close()

    End Sub

    Private Sub radNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNew.CheckedChanged
        '  if the new radio button is checked then
        '  the user has selected a new car loan
        If radNew.Checked = True Then
            dblAnnualRate = dblNEW_RATE
            lblAnnInt.Text = dblNEW_RATE.ToString("p")

        End If
    End Sub

    Private Sub radUsed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUsed.CheckedChanged
        '  user selected the used car radio button set the interest rate accordingly
        If radUsed.Checked = True Then
            dblAnnualRate = dblUSED_RATE
            lblAnnInt.Text = dblUSED_RATE.ToString("p")

        End If
    End Sub

    Private Sub txtCost_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCost.Validating
        '  validates that a number has been entered into txtcost
        If Not IsNumeric(txtCost.Text) Then
            MessageBox.Show("Cost must be a number, Invalid vehicle cost")
            '  select the existing text in the text box
            txtCost.SelectAll()
            '  select the existing text in the text box
            txtCost.SelectAll()
            '  set e.cacnel to true so the focus will stay in this control
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtDownPayment_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDownPayment.Validating
        '  validates tha a number has been entered into txt down payment
        If Not IsNumeric(txtDownPayment.Text) Then
            MessageBox.Show("Down payment must be a number", "Invalid Down Payment")

            '  select the existing text in the text box
            txtDownPayment.SelectAll()
            '  set e.cancell to true so the focus will stay in this control 
            e.Cancel = True
        Else
            e.Cancel = False

        End If
    End Sub

    Private Sub txtMonths_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMonths.Validating
        '  validates that is numeric and is within a valid range
        If Not IsNumeric(txtMonths.Text) Then
            MessageBox.Show("Months must be a number", "Error")
            '  select the existing text in the text box
            txtMonths.SelectAll()
            '  set e.cancel to true so the focus will stay in this control
            e.Cancel = True
        Else
            Dim intmonths As Integer = CInt(txtMonths.Text)
            If intmonths < intMIN_MONTHS Or intmonths > intMAX_MONTHS Then
                MessageBox.Show("Months must be in a valid range " & intMIN_MONTHS & " - " & intMAX_MONTHS, "Error")
                txtMonths.SelectAll()


                '  set e.cancel to true so the focus will stay in this control
                e.Cancel = True
            Else
                e.Cancel = False
            End If

        End If
    End Sub
End Class
