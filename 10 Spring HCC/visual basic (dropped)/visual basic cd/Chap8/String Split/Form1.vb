Public Class Form1

	Private Sub Form1_Load(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles MyBase.Load

		' Create a comma-delimited string containing numbers
		Dim strTemp As String = "10,20,30,40,50,60"

		' Define an array of separator characters containing
		' a single comma character.
		Dim separators() As Char = {","c}

		' Split the complete string into an array of strings,
		' each containing a separate number.
		Dim strNumbers() As String = strTemp.Split(separators)

		' Insert the numbers into a ListBox.
		For Each value As String In strNumbers
			lstNumbers.Items.Add(value)
		Next

	End Sub

End Class
