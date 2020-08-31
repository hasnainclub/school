Public Class Form1

	Private Sub Form1_Load(ByVal sender As System.Object, _
	 ByVal e As System.EventArgs) Handles MyBase.Load

		Dim pickUp As Truck
		pickUp = New Truck

        pickUp.Passengers = 2
        pickUp.MilesPerGallon = 18
        pickUp.MaxCargoWeight = 2000
        pickUp.FourWheelDrive = True

        With ListBox1.Items
            .Add("Passengers: " & pickUp.Passengers)
            .Add("Miles per gallong: " & pickUp.MilesPerGallon)
            .Add("Max cargo weight: " & pickUp.MaxCargoWeight)
            .Add("Four wheel drive: " & pickUp.FourWheelDrive)
        End With

	End Sub
End Class
