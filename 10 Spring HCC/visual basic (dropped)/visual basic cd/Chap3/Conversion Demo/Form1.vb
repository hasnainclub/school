Public Class Form1

	Private Sub btnGo_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnGo.Click

		Try
			If btnDate.Checked Then

				Dim dat As Date = CDate(txtInput.Text)
				lblResult.Text = "Conversion successful: " & dat.ToString()

			ElseIf btnDouble.Checked Then

				Dim dbl As Double = CDbl(txtInput.Text)
				lblResult.Text = "Conversion successful: " & dbl.ToString()

			ElseIf btnDecimal.Checked Then

				Dim dec As Decimal = CDec(txtInput.Text)
				lblResult.Text = "Conversion successful: " & dec.ToString()

			ElseIf btnInteger.Checked Then

				Dim int As Integer = CInt(txtInput.Text)
				lblResult.Text = "Conversion successful: " & int.ToString()

			ElseIf btnString.Checked Then

				Dim str As String = CStr(txtInput.Text)
				lblResult.Text = "Conversion successful: " & str.ToString()

			Else
				lblResult.Text = "Please select a conversion function"

			End If


		Catch ex As Exception
			lblResult.Text = "Conversion failed"

		End Try

	End Sub

End Class
