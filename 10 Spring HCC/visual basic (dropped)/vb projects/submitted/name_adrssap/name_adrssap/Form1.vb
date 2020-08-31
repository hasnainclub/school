Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStreet.Click

    End Sub

    Private Sub btnShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInfo.Click
        '  Make the info appear
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Exit application by closing the window
        Me.Close()


    End Sub
End Class
