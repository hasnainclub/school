
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lstEvents.Items.Add("Page Load")


    End Sub


    Protected Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

        lstEvents.Items.Add("Text Changed")

    End Sub

End Class
