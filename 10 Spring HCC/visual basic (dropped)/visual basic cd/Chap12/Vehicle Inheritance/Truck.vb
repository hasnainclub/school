Public Class Truck
	Inherits Vehicle

	' Private member variables
	Private sngCargoWeight As Single				' Maximum cargo weight
	Private blnFourWheelDrive As Boolean	 ' Four wheel drive

	' MaxCargoWeight property
	Public Property MaxCargoWeight() As Single
		Get
			Return sngCargoWeight
		End Get
		Set(ByVal value As Single)
			sngCargoWeight = value
		End Set
	End Property

	' FourWheelDrive property
	Public Property FourWheelDrive() As Boolean
		Get
			Return blnFourWheelDrive
		End Get
		Set(ByVal value As Boolean)
			blnFourWheelDrive = value
		End Set
	End Property

	' Passengers property
	Public Overrides Property Passengers() As Integer
		Get
			Return MyBase.Passengers
		End Get
		Set(ByVal value As Integer)
			If value >= 1 And value <= 2 Then
				MyBase.Passengers = value
			Else
				MessageBox.Show("Passengers must be 1 or 2.", "Error")
			End If
		End Set
	End Property

	' Overriden ToString method
	Public Overrides Function ToString() As String

		' Return a string representation 
		' of a vehicle.
		Dim str As String
		str = MyBase.ToString & " Max. Cargo: " & _
		  sngCargoWeight.ToString & " 4WD: " & _
		  blnFourWheelDrive.ToString
		Return str
	End Function

End Class
