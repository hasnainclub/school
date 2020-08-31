Public Class Form1


	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'SalesStaffDataSet.SalesStaff' table. You can move, or remove it, as needed.
		Me.SalesStaffTableAdapter.Fill(Me.SalesStaffDataSet.SalesStaff)
		'TODO: This line of code loads data into the 'SalesStaffDataSet.SalesStaff' table. You can move, or remove it, as needed.
		Me.SalesStaffTableAdapter.Fill(Me.SalesStaffDataSet.SalesStaff)

	End Sub

	Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
		Me.Validate()
		Me.SalesStaffBindingSource.EndEdit()
		Me.SalesStaffTableAdapter.Update(Me.SalesStaffDataSet.SalesStaff)

	End Sub
End Class
