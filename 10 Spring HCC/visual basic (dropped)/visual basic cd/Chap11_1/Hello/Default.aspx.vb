
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        lblMessage.Text = "Thank you for registering, " & txtFirst.Text & " " & txtLast.Text
    End Sub


End Class
