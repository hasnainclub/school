Namespace Calendar

Partial Class ShowTours
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

	Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		With calTours.SelectedDates
			.Add(New Date(2004, 5, 1))
			.Add(New Date(2004, 5, 4))
			.Add(New Date(2004, 5, 6))
			.Add(New Date(2004, 5, 8))
			.Add(New Date(2004, 6, 12))
		End With

	End Sub

End Class

End Namespace
