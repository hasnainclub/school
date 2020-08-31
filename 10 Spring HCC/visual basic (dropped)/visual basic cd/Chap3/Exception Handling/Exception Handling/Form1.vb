Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click


        Try
            Dim decSalary As Decimal
            decSalary = CDec(txtSalary.Text)
            MessageBox.Show("Your salary is " & decSalary.ToString() _
                & " dollars")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Salary input error")
            'MessageBox.Show("Please try again, and enter a number")
        End Try

    End Sub


End Class
