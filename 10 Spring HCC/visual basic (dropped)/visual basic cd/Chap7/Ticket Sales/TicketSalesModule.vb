Module TicketSalesModule

    ' This module contains the CalcTax function.

	Const decTAXRATE As Decimal = 0.06D		 ' Sales Tax Rate

    Public Function CalcTax(ByVal cost As Decimal) As Decimal

        ' This function calculates and returns the
        ' sales tax on ticket sales. The ticket cost is
        ' passed as an argument.
		Return cost * decTAXRATE
    End Function

End Module
