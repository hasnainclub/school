Public Class Form1
    
    



    Private Sub btnDisplayDirections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayDirections.Click
        '  Make the directions visible.
        lblDirections.Visible = True


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' to make application close
        Me.Close()
    End Sub
End Class
