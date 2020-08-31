Public Class Form1
    '  This application calculates the total order for a bagel and
    '  coffee at brandi's bagel house.  The application uses
    '  several functions to calculate the total cost
    Const decTAX_RATE As Decimal = 0.06D     ' sales tax rate
    Function BagelCost() As Decimal
        '  This function Returns the cost of the bagel
        If RadWhite.Checked = True Then
            Return 1.25D
        Else
            Return 1.5D
        End If

    End Function
    Function ToppingCost() As Decimal
        '  This function returns the cost of the toppings
        Dim decCostOfTopping As Decimal = 0
        If chkCreamCheese.Checked = True Then
            decCostOfTopping += 0.5D

        End If

        If chkButter.Checked = True Then
            decCostOfTopping += 0.25D
        End If

        If chkBlueberry.Checked = True Then
            decCostOfTopping += 0.75D
        End If
        If chkRaspBerry.Checked = True Then
            decCostOfTopping += 0.75D
        End If
        If chkPeach.Checked = True Then
            decCostOfTopping += 0.75D
        End If
        Return decCostOfTopping
    End Function
    Function CoffeeCost() As Decimal
        '  this function returns the cost of the selected coffee
        If radNoCoffee.Checked = True Then
            Return 0
        ElseIf radRegCoffee.Checked = True Then
            Return 1.25D
        ElseIf radCappuccino.Checked = True Then
            Return 2
        ElseIf radCafeAuLait.Checked = True Then
            Return 1.7D

        End If
    End Function
    Function CalcTax(ByVal decAmount As Decimal) As Decimal
        ' this function receives the sale amount it calculates and returns the sales tax,
        '  based on the sale amount
        Return decAmount * decTAX_RATE
    End Function
    Private Sub ResetBagels()
        ' this procedure resets the bagels selection
        RadWhite.Checked = True

    End Sub
    Sub resetToppings()
        ' This procedure resets the toppings selection
        chkBlueberry.Checked = False
        chkButter.Checked = False
        chkBlueberry.Checked = False
        chkRaspBerry.Checked = False
        chkPeach.Checked = False

    End Sub
    Sub ResetCoffee()
        ' This procedure resets the coffee selection
        radRegCoffee.Checked = False
    End Sub
    Sub ResetPrice()

        ' this procedure resets the price
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub










    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' This procedure resets the controls to default values.

        ResetBagels()
        resetToppings()
        ResetCoffee()
        ResetPrice()



    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '  This procedure calculates the toal of an order
        Dim decSubtotal As Decimal   ' Holds the order subtotal
        Dim decTax As Decimal  ' Holds the sales tax
        Dim decTotal As Decimal ' Holds the order total

        decSubtotal = BagelCost() + ToppingCost() + CoffeeCost()
        decTax = CalcTax(decSubtotal)
        decTotal = decSubtotal + decTax

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' End the application
        Me.Close()
    End Sub
End Class
