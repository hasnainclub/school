Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnGo.Click
        '  Value returned by IndexOf when a search fails
        Const intNOT_FOUND As Integer = -1

        '  make sure the starting index is numeric
        '  They get the starting index of the search

        Dim intstart As Integer

        If Not IsNumeric(txtStartIndex.Text) Then
            MessageBox.Show("The starting index must be numeric", "Error")
            Return
        Else
            intstart = CInt(txtStartIndex.Text)

        End If



        '  before searching, check for a possible emty string
        '  exit the suboutine if the string is emty
        If txtToFind.Text.Length = 0 Then
            lblResults.Text = "There is nothing to find"
            Return
        End If




        '  perform the search, returning the index of the first marching string

        Dim intPos As Integer = lblString.Text.IndexOf(txtToFind.Text, intstart)


        '  output a message based on the search results if the string was found, display its index position
        '  string was found, display its index position

        If intPos = intNOT_FOUND Then
            lblResults.Text = "The string was not found"
        Else
            lblResults.Text = "The string was found at index " & intPos
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()
    End Sub

End Class
