Public Class Form1


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim strinput As String '  holds selected month and yr
        If lstMonths.SelectedIndex = -1 And lstYears.SelectedIndex = -1 Then
            '  No month and yr is selected
            MessageBox.Show("You forgot to select a month and a year, please select")
        ElseIf lstMonths.SelectedIndex = -1 Then
            '  no month is selected
            MessageBox.Show("You forgot to seeect a month")
        ElseIf lstYears.SelectedIndex = -1 Then
            '  no yr is selected
            MessageBox.Show("you forgot to select a year")
        Else
            '  get the selected month & yr
            strinput = lstMonths.SelectedItem.ToString() & " " & lstYears.SelectedItem.ToString()
            MessageBox.Show("you selected " & strinput)



        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        '  resete the list boxes
        lstMonths.SelectedIndex = -1
        lstYears.SelectedIndex = -1

    End Sub
End Class
