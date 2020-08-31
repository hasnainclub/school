Public Class Form1

    ' Alternative captions for the button.
    Private strCaption As String() = {"Click here", "Try harder!", _
        "Try again", "Not even close", "Where are you?", _
        "I'm over here!", "Slow, aren't you?"}

    ' Random number generator object.
    Private rand As New Random()

    Private Sub btnCatch_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnCatch.Click

        MessageBox.Show("You got me!", "", MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    Private Sub btnCatch_MouseEnter(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnCatch.MouseEnter

        ' Randomly choose a caption.
        Dim intIndex As Integer = rand.Next(strCaption.Length - 1)
        btnCatch.Text = strCaption(intIndex)

        ' Move to a new horizontal position.
        btnCatch.Left = rand.Next(Me.Width - btnCatch.Width)

        ' Move to a new vertical position.
        btnCatch.Top = rand.Next(Me.Height - btnCatch.Height - 30)
    End Sub

End Class
