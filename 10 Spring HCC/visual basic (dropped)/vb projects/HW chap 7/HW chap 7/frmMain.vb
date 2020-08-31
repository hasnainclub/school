Public Class frmMain
    '  Attarwala lab_7
    '  due april 1st 10
    ' homework cellphones 

    Private Sub btnIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndividual.Click
        frmIndividual.ShowDialog()  '  to open the appropriate form


    End Sub

    Private Sub btnFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamily.Click
        frmFamily.ShowDialog() ' to open the appropriate form

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() ' to close the app

    End Sub
End Class
