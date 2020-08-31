Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btwShowAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btwShowAnswer.Click
        'To make the question dissapear
        lblQuestion.Visible = False
        ' To make the Answer appear
        lblAnswer.Visible = True
    End Sub

    Private Sub btwExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btwExit.Click
        ' To close to application
        Me.Close()
    End Sub
End Class
