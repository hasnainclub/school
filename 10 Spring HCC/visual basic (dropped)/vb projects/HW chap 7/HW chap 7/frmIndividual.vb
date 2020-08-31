Public Class frmIndividual
    '  Attarwala lab_7
    '  due april 1st 10
    ' homework cellphones 
    'to set validations
    Const decTHREEHUNRED_MINS As Decimal = 45  ' if 300 mins is selected
    Const decEIGHTHUNDRED_Mins As Decimal = 65 ' if 800 mins is selected
    Const decSIXTEENHUNDRED_MINS As Decimal = 99 ' if 1600 mins is selected
    Const decVOICE_MAIL As Decimal = 5 ' price of vc mail
    Const decTXT_MSG As Decimal = 10 ' price of text
    Const decMODEL_100 As Decimal = CDec(29.95) ' price of model 1
    Const decMODEL_110 As Decimal = CDec(49.95) ' price of model 2
    Const decMODEL_200 As Decimal = CDec(99.95) ' price of model 3
    Const decTAX As Decimal = 0.06 ' tax rate for phone




    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close() ' to close form

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '  seting validation
        Dim decTaxHolder As Decimal
        Dim decPhoneTotalHolder As Decimal
        Dim decTaxCalculator As Decimal
        '  to price according to phne selected
        If radModel1.Checked = True Then
            lblSubTotal.Text = decMODEL_100.ToString("c")
        End If
        If radModel2.Checked = True Then
            lblSubTotal.Text = decMODEL_110.ToString("c")
        End If
        If radModel3.Checked = True Then
            lblSubTotal.Text = decMODEL_200.ToString("c")
        End If

        ' to convert the phone selected money into tax
        decTaxHolder = CDec(lblSubTotal.Text)
        ' math for converting phone money into tax and * it to the const .06 = *6/100
        decTaxCalculator = decTaxHolder * decTAX
        lblTax.Text = decTaxCalculator.ToString("c")
        ' to get phone total price = tax + phone gross amount
        decPhoneTotalHolder = CDec(decTaxCalculator) + CDec(lblSubTotal.Text)
        lblPhoneTotal.Text = decPhoneTotalHolder.ToString("c")

        '  to set validations
        Dim decOptionsHolder As Decimal
        decOptionsHolder = 0
        '  to check if user wants to have voicemail and text, and charge him accrodingcle
        If chkTxtMail.Checked = True Then
            decOptionsHolder += decTXT_MSG


        End If
        If chkVcMail.Checked = True Then
            decOptionsHolder += decVOICE_MAIL
        End If
        lblOptions.Text = decOptionsHolder.ToString("c")


        '  to see which plan user wants and charge accordingly

        Dim decMinutesHolder As Decimal
        Dim decPackageChargeHolder As Decimal
        Dim decTotalHolder As Decimal

        If radMinsThree.Checked = True Then
            decMinutesHolder = decTHREEHUNRED_MINS
        End If
        If radMinsEight.Checked = True Then
            decMinutesHolder = decEIGHTHUNDRED_Mins
        End If
        If radMinsSixteen.Checked = True Then
            decMinutesHolder = decSIXTEENHUNDRED_MINS
        End If
        ' package would be equal to first months bill (mins and options) + phone money
        decPackageChargeHolder = decPhoneTotalHolder + decMinutesHolder + decOptionsHolder

        lblPackageCharge.Text = decPackageChargeHolder.ToString("c")
        '  monthly bill user will recieve
        decTotalHolder = decMinutesHolder + decOptionsHolder
        lblTotalMonthly.Text = decTotalHolder.ToString("c")

    End Sub
End Class