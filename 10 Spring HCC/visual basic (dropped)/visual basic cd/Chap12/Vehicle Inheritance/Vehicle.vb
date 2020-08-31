Public Class Vehicle

	' Private member variables
	Private intPassengers As Integer		' Number of passengers
	Private sngMPG As Single				' Miles per gallon

	' Passengers property
	Public Overridable Property Passengers() As Integer
		Get
			Return intPassengers
		End Get
		Set(ByVal value As Integer)
			intPassengers = value
		End Set
	End Property

	' MilesPerGallon property
	Public Property MilesPerGallon() As Single
		Get
			Return sngMPG
		End Get
		Set(ByVal value As Single)
			sngMPG = value
		End Set
	End Property

	' Overriden ToString method
	Public Overrides Function ToString() As String

        ' Return a string representation of a vehicle.
		Dim str As String
		str = "Passengers: " & intPassengers.ToString & _
		  " MPG: " & sngMPG.ToString
		Return str
	End Function

End Class
