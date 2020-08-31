Namespace Calendar

Partial Class KayakTour
	Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

	'This call is required by the Web Form Designer.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

	End Sub


	Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
		'CODEGEN: This method call is required by the Web Form Designer
		'Do not modify it using the code editor.
		InitializeComponent()
	End Sub

#End Region

	Private Sub btnAdd_Click(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles btnAdd.Click

		'Skip if either no title was entered or no date was selected.
		If Trim(txtTitle.Text).Length = 0 _
		 Or calTours.SelectedDates.Count = 0 Then
			lblMessage.Text = "Please select a date and enter a " _
			 & "title for the tour"
			Exit Sub
		End If

		lstTours.Items.Add(txtTitle.Text & " - " & calTours.SelectedDate())
	End Sub

End Class

End Namespace
