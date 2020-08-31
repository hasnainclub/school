Public Class Form1
    Inherits System.Windows.Forms.Form
    '  Health Club Membership Fee Calculator
    '  This application Calculates the monthly and total membershipo fees for the Bay City Health
    '  and fitness Club.  The base monthly fee are
    ' 
    ' standard adult membership:  $40/Month
    ' Child (12 and under):       $20/Month
    ' student:                    &25/Month
    ' Senior Citizen (65+):       &30/Month
    ' 
    ' The club offers the following ooptional services which inrease the base montly fee:
    '
    ' Yoga lessons:            +$10/month
    ' Karate lessons:          +$30/month
    ' Personal trainer:        +$50/month
    '
    ' Discounts are available, depending on the length of membership.  Here is a list of discounts:
    '
    ' 1-3 mths      No disc
    ' 4-6 mths      5% disc
    ' 7-9 mths      8% disc
    ' 10 or more    10% disc
    ' The following class-level constants are used to calculate discounts

    Const DEC_DISCOUNT4T06 As Decimal = 0.05D ' 4-6 months
    Const DEC_DISCOUNT7TO9 As Decimal = 0.08D ' 7-9 months
    Const DEC_DISCOUNT10OR_MORE As Decimal = 0.1D ' to or more months


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '  this method calculates and displays the membership fees
        '  Declare local variables

        Dim decBaseFee As Decimal ' base monthly fee
        Dim decDiscount As Decimal ' discount
        Dim decTotalFee As Decimal ' Total Membership Fee
        Dim intMonths As Integer ' no of months

        '  Check the no of months and exit if it contains invaled data

        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            MessageBox.Show("Months must be a valid Integer", "Input Error")
            Return
        End If



        '  Check the month range:  must be 1-24
        If (intMonths < 1) Or (intMonths > 24) Then
            MessageBox.Show("Months must be a valid integer", "Input Error")
            Return
        End If






        '  If we reach the pint, we assume the input data is valid
        '  calculate the base monthly fee

        If radAdult.Checked = True Then
            decBaseFee = 40
        ElseIf radChild.Checked = True Then
            decBaseFee = 20
        ElseIf radStudent.Checked = True Then
            decBaseFee = 25
        ElseIf radSenior.Checked = True Then
            decBaseFee = 30
        End If


        '  Look for additional services
        If chkYoga.Checked = True Then
            decBaseFee += 10
        End If
        If chkKarate.Checked = True Then
            decBaseFee += 30
        End If
        If chkTrainer.Checked = True Then
            decBaseFee += 50
        End If


        '  Determine the discount, based on membership months
        Select Case intMonths
            Case Is <= 3
                decDiscount = 0

            Case 4 To 6
                decDiscount = decBaseFee * DEC_DISCOUNT4T06

            Case 7 To 9
                decDiscount = decBaseFee * DEC_DISCOUNT7TO9

            Case Is >= 10
                decDiscount = decBaseFee * DEC_DISCOUNT10OR_MORE

        End Select


        '  Adjust for discounts, calculate total fee
        decBaseFee -= decDiscount
        decTotalFee = decBaseFee * intMonths

        '  display the fee
        lblMonthlyFee.Text = decBaseFee.ToString("c")
        lblTotalFee.Text = decTotalFee.ToString("c")

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '  Clear the form, reset the buttons and check boxes
        radAdult.Checked = True
        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        txtMonths.Clear()
        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '  end the app by closing the window
        Me.Close()


    End Sub
End Class
