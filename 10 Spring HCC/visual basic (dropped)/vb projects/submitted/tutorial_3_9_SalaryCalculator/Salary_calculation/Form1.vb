Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, _
                                   ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal ' annual salary
        Dim intpayperiods As Integer ' no of pay periods per year
        Dim decSalary As Decimal ' salary pay period
        Try
            decAnnualSalary = CDec(txtAnnualSalary.Text)
            intpayperiods = CInt(txtPayPeriods.Text)
        

            decSalary = decAnnualSalary / intpayperiods
            Label4.Text = decSalary.ToString("c")
        Catch
            MessageBox.Show(" The input fields must contain " _
                             & "non zero numberic values", "error")
        End Try


    End Sub
End Class
