Public Class Form1

    '  Attarwala Hasnain
    ' Lab_6
    ' due 03/25/2010






    'find out if input is whol no

    Function WholesaleIsValid() As Boolean
        'Declaring variables 
        Dim dblTempValue As Double





        'If the value entered by the user is a negative then, display an error message
        'Return back so the user can enter the right value
        If dblTempValue < 0 Then
            MessageBox.Show("Please enter a Positive Value")
            Return False
        End If









        '  try to conver into dec else show eerror
        If Not Double.TryParse(txtWholesale.Text, dblTempValue) Then
            MessageBox.Show("Please enter a Number")
            Return False
            txtWholesale.Focus()
        End If
        Return True
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' to declare variables
        Dim dblWholesale As Double
        Dim dblMarkup As Double
        Dim dblRetail As Double

        'to get wholesalecost, markup %, and the retail price
        If WholesaleIsValid() And MarkupIsValid() Then
            Double.TryParse(txtWholesale.Text, dblWholesale)
            Double.TryParse(txtMarkup.Text, dblMarkup)
            dblRetail = CalculateRetail(dblWholesale, dblMarkup)
            lblRetailPrice.Text = dblRetail.ToString("c")
        End If
    End Sub
    'To find out if the Markup precentage number entered by the user is correct.

    Function MarkupIsValid() As Boolean
        'Declare variables
        Dim dblTempValue As Double
        ' try to covert else show error msg





        If Not Double.TryParse(txtMarkup.Text, dblTempValue) Then
            MessageBox.Show("Make sure all the values are Numeric.")
            Return False
        End If




        ' to make sure input is not negative else return
        If dblTempValue < 0 Then
            MessageBox.Show("Please enter only positve numbers")
            Return False
        End If
        Return True
    End Function


    Function CalculateRetail(ByVal dblWholesale As Double, ByVal dblMarkup As Double) As Double
        '  to declare vaeriable
        Dim dblMarkupAmount As Double
        Dim dblRetail As Double
        'calculating markup
        dblMarkupAmount = dblWholesale * (dblMarkup * 0.01)
        ' calcualting retail
        dblRetail = dblWholesale + dblMarkupAmount

        Return dblRetail
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '  to close the prgoram 
        Me.Close()
    End Sub
End Class