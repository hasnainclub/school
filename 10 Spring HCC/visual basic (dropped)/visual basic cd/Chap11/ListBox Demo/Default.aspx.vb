
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub lstSalesStaff_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSalesStaff.SelectedIndexChanged

        Label1.Text = "Selected Index: " & lstSalesStaff.SelectedIndex

    End Sub
End Class
