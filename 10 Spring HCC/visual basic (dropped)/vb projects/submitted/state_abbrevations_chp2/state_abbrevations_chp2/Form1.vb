Public Class Form1

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSC.Click

    End Sub

    Private Sub btnVirgina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVirgina.Click
        '  Make the respective state visible
        lblVA.Visible = True

    End Sub

    Private Sub btnNorthCarolina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorthCarolina.Click
        '  Make the respective state visible
        lblNC.Visible = True
    End Sub

    Private Sub btnSouthCarolina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSouthCarolina.Click
        '  Make the respective state visible
        lblSC.Visible = True
    End Sub

    Private Sub btnGeorgia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeorgia.Click
        '  Make the respective state visible
        lblGA.Visible = True
    End Sub

    Private Sub btnAlabama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlabama.Click
        '  Make the respective state visible
        lblAL.Visible = True
    End Sub

    Private Sub btnFlorida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlorida.Click
        '  Make the respective state visible
        lblFL.Visible = True
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        ' To hide the shown states
        lblAL.Visible = False
        lblFL.Visible = False
        lblGA.Visible = False
        lblNC.Visible = False
        lblSC.Visible = False
        lblVA.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '  To close the application
        Me.Close()
    End Sub
End Class
