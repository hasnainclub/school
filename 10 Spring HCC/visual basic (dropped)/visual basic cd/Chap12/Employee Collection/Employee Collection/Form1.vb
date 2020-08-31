Public Class Form1

	Private Sub btnGo_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnGo.Click

		Dim empNumbers As New Collection	  ' Holds employee numbers
        Dim employees As New Collection       ' Holds employee names
        Dim hoursWorked As New Collection     ' Holds hours worked
        Dim payRates As New Collection        ' Holds hourly pay rates

		Dim strEmpNumber As String			  ' Employee ID number
		Dim strEmpName As String			  ' Employee name
		Dim decGrossPay, decHours, decRate As Decimal
        Dim i As Integer                      ' Loop counter

		' Add each employee’s number to the empNumbers collection.

		empNumbers.Add("55678")
		empNumbers.Add("78944")
		empNumbers.Add("84417")

		' Add the employee names to the employees
		' collection, with the employee ID number
		' as the key.

		employees.Add("James Bourne", "55678")
		employees.Add("Jill Davis", "78944")
		employees.Add("Kevin Franklin", "84417")

		' Add each employee’s hours worked to the
		' hoursWorked collection, with the employee 
		' ID number as the key.

		hoursWorked.Add(40, "55678")
		hoursWorked.Add(35, "78944")
		hoursWorked.Add(20, "84417")

		' Add each employee’s hours pay rate to the
		' payRates collection, with the employee 
		' ID number as the key.

		payRates.Add(12.5, "55678")
		payRates.Add(18.75, "78944")
		payRates.Add(9.6, "84417")

		' Compute and display each employee’s
		' gross pay.

		For i = 1 To employees.Count

			' Get an employee ID number to use as a key.
			strEmpNumber = empNumbers(i).ToString()

			' Get this employee’s name.
			strEmpName = employees.Item(strEmpNumber).ToString()

			' Get the hours worked for this employee.
			decHours = CDec(hoursWorked.Item(strEmpNumber))

			' Get the pay rate for this employee.
			decRate = CDec(payRates.Item(strEmpNumber))

			' Calculate this employee’s gross pay.
			decGrossPay = decHours * decRate

			' Display the results for this employee.
			lblResult.Text &= "Gross pay for " & strEmpName & _
			 " is " & FormatCurrency(decGrossPay) & vbCrLf
		Next

















	End Sub
End Class
