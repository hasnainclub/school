 #include "Book.h"
 #include <string.h>
 #include <iomanip>

   //*****************************************************************
   // FILE:      Book.cpp
   // AUTHOR:    Hasnain Attarwala
   // LOGON ID:  z1697740
   // DUE DATE:  Feb 13 2018
   // 
   // PURPOSE:   Contains the Book class.
   //*****************************************************************
using std::cout; using std::cin; using std::cerr; using std::endl;
using std::string; using std::fixed; using std::setw; using std::left; using std::right;
using std::setprecision;

/*
Book default constructor - This "default" constructor for the Book class takes no parameters. 
Like all C++ constructors, it does not have a return data type.

This method should set the ISBN and title data members to "null strings". 
This can be done by copying a null string literal ("") into the character array using strcpy() 
or by setting the first element of the array to a null character ('\0'). 
The price and quantity data members should be set to 0.
*/
Book::Book()
{
	strcpy(ISBN, "");
	strcpy(title, "");
	price = 0;
	quantity = 0;
}

/*
Alternate Book constructor - Write another constructor for the Book class that takes four parameters: 
1) a character array that contains a new ISBN, 
2) a character array that contains a new title, 
3) a double variable that contains a new price, and 
4) an integer that contains a new quantity. 
DO NOT GIVE THESE PARAMETERS THE SAME NAMES AS YOUR DATA MEMBERS.. Like all C++ constructors, this constructor does not have a return data type.
*/

Book::Book(char NewISBN[11], char Newtitle[41], double Newprice, int Newquantity)
{
	strcpy(ISBN, NewISBN);
	strcpy(title, Newtitle);
/*
Use strcpy() to copy the new ISBN parameter into the ISBN data member and the new title parameter into the title data member. 
Call the setPrice() and setQuantity() methods to set the price and quantity data members to the new price and new quantity passed
 into the constructor.
*/
	setPrice(Newprice);
	setQuantity(Newquantity)
	;
}

/*
 - This accessor method takes no parameters. It should return the ISBN data member. 
In C++, the usual return data type specified when you are returning the name of a character array is char* or "pointer to a character" 
(since returning an array's name will convert the name into a pointer to the first element of the array, which in this case is data type char.
*/

char* Book::getISBN ()
{
	return ISBN;
}

// - This accessor method takes no parameters. It should return the title data member.
char* Book::getTitle()
{
	return title;
}

//- This accessor method takes no parameters. It will have a return data type of double. It should return the price data member.
double Book::getPrice() const
{
	return price;
}

// - This accessor method takes no parameters. It will have a return data type of int. It should return the quantity data member.
int Book::getQuantity()
{
	return quantity;
}

//- This method takes a double argument, a new price. It returns nothing. 
//The method should check if the new price is greater than or equal to 0. If it is, it should set the price data member to the new price. 
//Otherwise, it should set the price data member to 0.
void Book::setPrice(double Newprice) 
{
	if (Newprice >= 0)
	{
		price = Newprice;
	}
	else
	{
		price = 0;
	}
}

//This method takes an integer argument, a new quantity. It returns nothing. 
//The method should check if the new quantity is greater than or equal to 0. 
//If it is, it should set the quantity data member to the new quantity. Otherwise, it should set the quantity data member to 0.
void Book::setQuantity(int newQauntity) 
{
	if (newQauntity >= 0)
	{
		quantity = newQauntity;
	}
	else
	{
		quantity = 0;
	}
}
/*
This accessor method takes one parameter, an integer that represents the quantity of this book that has been ordered. 
The method returns an integer, which is the quantity of this book that the book store is actually able to ship at this time.
The logic for this method should be as follows:
If the order quantity is less than zero, the order is in error. The number shipped should be zero. 
Do not alter the quantity in stock for the book.

If the order quantity is less than or equal to the quantity in stock, the order can be completely filled. 
The number shipped should be the same as the order quantity, and the order quantity should be subtracted from the quantity in stock.

Otherwise, this order can not be completely filled. The number shipped should be the quantity in stock, and 
the quantity in stock should be set to zero.
*/
int Book::fulfillOrder(int orderedQauntity) 
{
	int numShipped;
	if (orderedQauntity < 0)
	{
	numShipped = 0;
	}
	else if(orderedQauntity <= quantity)
	{
		numShipped = orderedQauntity;
		quantity -= orderedQauntity;
		
	}
	else 
	{
	   numShipped = quantity;
		quantity = 0;
		
	}
	return numShipped;
}


/*
- This method takes no parameters and returns nothing. 
The method should print the ISBN, title, price, and quantity members on the console using cout. 
Use setw() to line the printed values up in columns (a width of 14 for the ISBN, 44 for the title, 5 for the price,
and 6 for the quantity will match the sample output). The ISBN and title should be left justified; 
the price and quantity should be right justified. The price should be printed using fixed-point notation with two places after the decimal point.
*/
void Book::print() 
{
/*
	cout << left << setw(14) << ISBN;
	cout << left << setw(44) << title;
	cout << right <<setw(5)  << fixed << setprecision(2) << price; //if not fixed, then total values displayed becomes 5
	cout << right << setw(6) << quantity;
*/	
	cout << left << setw(14) << ISBN 
				 << setw(44) <<title
				 <<fixed     << setprecision(2) <<right <<setw(5) << price 
				 <<setw(6)   <<quantity << endl;
}

