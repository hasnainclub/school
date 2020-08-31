Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button1.Click

        MessageBox.Show("Operation complete.")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        MessageBox.Show("Operation complete.", "Status")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        MessageBox.Show("Do you wish to continue?", "Please Confirm", _
            MessageBoxButtons.YesNo)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        MessageBox.Show("Do you wish to continue?", "Please Confirm", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        MessageBox.Show("This is line 1" & ControlChars.CrLf & _
            "This is line 2")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MessageBox.Show("Are you sure?")

    End Sub
End Class
