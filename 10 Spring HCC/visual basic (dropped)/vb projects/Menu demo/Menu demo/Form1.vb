Public Class Form1

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        ' end the application
        Me.Close()

    End Sub

    Private Sub mnuColorRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColorRed.Click
        '  To change the color of the label according to the name
        lblMessage.ForeColor = Color.Red


    End Sub

    Private Sub mnuColorGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColorGreen.Click
        '  To lchange the color of the label according to the name
        lblMessage.ForeColor = Color.Green
    End Sub

    Private Sub mnuColorBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColorBlue.Click
        '  To change the color of the label according to the name
        lblMessage.ForeColor = Color.Blue
    End Sub

    Private Sub mnuColorBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColorBlack.Click
        '  To change the color of the label according to the name
        lblMessage.ForeColor = Color.Black
    End Sub

    Private Sub mnuColorVisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColorVisible.Click
        '  to make the label visible or hiden

        If mnuColorVisible.Checked = True Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        '  desplay a simple about window
        MessageBox.Show("Menu System Demo" & vbCrLf & _
                         "Designed for Starting Out with Visual Basic", _
                         "About Menu Demo")

    End Sub
End Class
