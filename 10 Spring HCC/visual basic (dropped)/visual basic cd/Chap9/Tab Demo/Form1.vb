Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add("012345678901234567890")
            .Add("X" & vbTab & "X")
            .Add("XXXXXXXXXXXX" & vbTab & "X")
            .Add(vbTab & vbTab & "X")
        End With
    End Sub
End Class
