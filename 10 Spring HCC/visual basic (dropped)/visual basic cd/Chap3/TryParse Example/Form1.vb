Public Class Form1

	Private Sub btnTryParse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTryParse.Click

		Dim intResult As Integer

		If Integer.TryParse(txtValue.Text, intResult) Then
			lblResult.Text = "The integer value is: " _
			 & intResult.ToString()
		Else
			lblResult.Text = "Not a valid integer!"
		End If

	End Sub

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Dim dtmTemp As Date

		If Date.TryParse("05/15/2008 8:15 PM", dtmTemp) Then

			lblResult.Text = dtmTemp.ToString("D")
		End If

	End Sub

End Class
