Public Class Form1

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        For Each strCity As String In lstCities.Items
            If strCity = txtCity.Text Then
                lblResult.Text = "The city was found!"
            End If
        Next

    End Sub

End Class
