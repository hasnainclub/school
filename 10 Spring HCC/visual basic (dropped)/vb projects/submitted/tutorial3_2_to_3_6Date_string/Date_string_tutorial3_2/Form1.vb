Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '  End the application by closing the form
        Me.Close()
    End Sub

    Private Sub btnShowdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowdate.Click
        '  Concatenate the input and build the date string
        lblDateString.Text = txtDayOfWeek.Text & ", " _
        & txtMonth.Text & " " _
        & txtDayOfMonth.Text & ", " _
        & txtYear.Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '  Clear the text boexws and lbldatestring
        txtDayOfMonth.Clear()
        txtDayOfWeek.Clear()
        txtMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = String.Empty
        '  Return the focus to the txt day of week
        txtDayOfWeek.Focus()

    End Sub
End Class
