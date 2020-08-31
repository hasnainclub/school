Public Class Form1

	Private Sub Form1_Load(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles MyBase.Load

		' Read the file into a RichTextBox control.
		' The following statement assumes that the file "moby.1" 
		' is located in te project's \bin folder.

		Dim strTemp As String = My.Computer.FileSystem.ReadAllText("..\moby.1")

		rtbMoby.Text = strTemp

	End Sub
End Class
