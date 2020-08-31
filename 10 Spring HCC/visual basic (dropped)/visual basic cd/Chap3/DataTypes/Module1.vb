Module Module1

	Sub CalculateAverage()

		Dim dblTotal As Double = 500.0
		Dim dblCount As Double = 10.2
		Dim dblAverage As Double
		dblAverage = dblTotal / dblCount

	End Sub


	Sub SubOne()

		Dim intCount As Integer
		intCount = 25

	End Sub

	Sub SubTwo()

		intCount = 32			' ERROR

	End Sub




	Sub CollegeCreditsExample()

		Dim intFallCredits, intSpringCredits, intTotalCredits As Integer
		intTotalCredits = intFallCredits + intSpringCredits

	End Sub


	Sub AdditionAndSubtraction()

		Dim dblMarchRain, dblAprilRain As Double
		Dim dblCombined As Double

		dblCombined = dblMarchRain + dblAprilRain

		'Subtraction
		Dim decGrossPay, decTax, decNetPay As Decimal
		decNetPay = decGrossPay - decTax

	End Sub


	Sub Multiplication()

		Dim decItemPrice, decTaxRate, decTaxAmount As Decimal

		decTaxAmount = decItemPrice * decTaxRate

	End Sub

	Sub FloatingDivision()

		Dim dblTotal, dblNumPlayers, dblAverage As Double

		dblAverage = dblTotal / dblNumPlayers

	End Sub

	Sub IntegerDivision()

		Dim intTotalMinutes As Integer
		Dim intHours As Integer
		Dim intMinutes As Integer

		intTotalMinutes = 174
		intHours = intTotalMinutes \ 60
		intMinutes = intTotalMinutes Mod 60

	End Sub

	Sub Exponentiation()

		Dim dblResult As Double
		dblResult = 5.0 ^ 2.0


	End Sub


	Sub Main()

		IntegerDivision()

		Dim bytInches As Byte
		Dim shrtFeet As Short
		Dim intMiles As Integer
		Dim lngNationalDebt As Long

		bytInches = 26
		shrtFeet = 32767
		intMiles = 2100432877
		lngNationalDebt = 4000000000001

		Dim lngCounter As Long
		lngCounter = 10000L

		shrtFeet = 1234S

		Dim sngTemperature As Single
		Dim dblWindSpeed As Double
		Dim decBankBalance As Decimal

		sngTemperature = 98.6
		dblWindSpeed = 4.728197E+104
		decBankBalance = 1234567890.1234567890123456789D

		Dim blnIsRegistered As Boolean
		blnIsRegistered = True

		Dim chrLetter As Char
		chrLetter = "A"c

	End Sub

End Module
