Public Class Form1

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  this procedure displays the combo box selections
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = cboPlays.Text
        lblArtist.Text = cboArtists.Text

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '  this procedure clears slelections in the cobmbo boxes and restes the lables to an emty string
        '  reset the combo boxes
        cboCountries.SelectedIndex = -1
        cboCountries.Text = String.Empty
        cboPlays.SelectedIndex = -1
        cboPlays.Text = String.Empty
        cboArtists.SelectedIndex = -1
        '  note cboArtists.text is read only
        '  reset the lables
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
