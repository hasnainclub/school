Public Class frmFamily

    '  Attarwala lab_7
    '  due april 1st 10
    ' homework cellphones 
    ' to set validation
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
        Dim intNumberOfphone As Integer
        Dim decSubtotalHolder As Decimal
        ' to get the number of phone
        intNumberOfphone = txtNumberOfPhones.Text


        '  to price according to phne selected * no of plans
        If radModel1.Checked = True Then
            decSubtotalHolder = decMODEL_100.ToString * intNumberOfphone
        End If
        If radModel2.Checked = True Then
            decSubtotalHolder = decMODEL_110.ToString * intNumberOfphone
        End If
        If radModel3.Checked = True Then
            decSubtotalHolder = decMODEL_200.ToString * intNumberOfphone
        End If

        ' to convert the phone selected money into tax
        lblSubTotal.Text = decSubtotalHolder.ToString("c")
        decTaxHolder = (lblSubTotal.Text)
        ' math for converting phone money into tax and * it to the const .06 = *6/100
        decTaxCalculator = decTaxHolder * decTAX
        lblTax.Text = decTaxCalculator.ToString("c")
        ' to get phone total price = tax + phone gross amount
        decPhoneTotalHolder = CDec(decTaxCalculator) + CDec(lblSubTotal.Text)
        lblPhoneTotal.Text = decPhoneTotalHolder.ToString("c")

        '  to set validations
        Dim intTxtMailHolder As Integer
        Dim decOptionsHolder As Decimal
        Dim intVcMailHolder As Integer

        decOptionsHolder = 0
        '  to check if user wants to have voicemail and charge him accrodingcle
        '  but also to ask him on hom many plans does he want vcmail on
        If chkTxtMail.Checked = True Then

            intTxtMailHolder = InputBox("Please Enter number of phones in which you require text", _
                                        "Enter a positive numeric number")




            ' to add the txt amount in options columb
            decOptionsHolder = +(decTXT_MSG * intTxtMailHolder)

        End If
        '  to check if user wants to have text , and charge him accrodingcle
        '  but also to ask him on hom many plans does he want text on


        If chkVcMail.Checked = True Then
            intVcMailHolder = InputBox("Please Enter the number of phones you want vcmail in", _
                                        "Enter a positive numeric number")
            ' to add the txt amount in options columb
            decOptionsHolder = +(decVOICE_MAIL * intVcMailHolder)

        End If

        ' to put the amt of options in options label

        lblOptions.Text = decOptionsHolder.ToString("c")




        ' to set validations

        Dim decMinutesHolder As Decimal
        Dim decPackageChargeHolder As Decimal
        Dim decTotalHolder As Decimal
        ' to get the amout of money and * to no of plans wanted
        If radMinsThree.Checked = True Then
            decMinutesHolder = decTHREEHUNRED_MINS * intNumberOfphone
        End If
        If radMinsEight.Checked = True Then
            decMinutesHolder = decEIGHTHUNDRED_Mins * intNumberOfphone
        End If
        If radMinsSixteen.Checked = True Then
            decMinutesHolder = decSIXTEENHUNDRED_MINS * intNumberOfphone
        End If
        ' package would be equal to first months bill (mins and options) + phone money
        decPackageChargeHolder = decPhoneTotalHolder + decMinutesHolder + decOptionsHolder

        lblPackageCharge.Text = decPackageChargeHolder.ToString("c")
        decTotalHolder = decMinutesHolder + decOptionsHolder
        '  monthly bill user will recieve
        lblTotalMonthly.Text = decTotalHolder.ToString("c")
    End Sub

    Private Sub txtNumberOfPhones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumberOfPhones.Validating
        ' to check if the input is valid
        If Not IsNumeric(txtNumberOfPhones.Text) Then
            MessageBox.Show("Please enter a number", "Error")
            ' select contents and set the focus back to textbox if there is an error
            txtNumberOfPhones.SelectAll()
            txtNumberOfPhones.Focus()
            e.Cancel = True


            ' to check if no is higher than 0
        ElseIf txtNumberOfPhones.Text <= 0 Then
            MessageBox.Show("Please enter a number higher than 0", "Error")
            ' select contents and set the focus back to textbox if there is an error
            txtNumberOfPhones.SelectAll()
            txtNumberOfPhones.Focus()
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

End Class