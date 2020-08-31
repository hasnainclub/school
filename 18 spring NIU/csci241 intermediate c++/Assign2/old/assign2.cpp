   //*****************************************************************
   // FILE:      assign2.cpp
   // AUTHOR:    Hasnain Attarwala
   // LOGON ID:  z1697740
   // DUE DATE:  Feb 13 2018
   // 
   // PURPOSE:   Contains the main file for the program
   //*****************************************************************
#include <iostream>
//#include "Book.h"
#include "BookStore.h"
   using std::cout;
   using std::endl;

   int main()
      {
      	/*
      char isbn1[11] = "1111111111";
      char title1[41] = "Learn C++ Now";
      char isbn2[11] = "2222222222";
      char title2[41] = "Learn Java Later";
      int numShipped;

      // Test default constructor
      Book book1;

      // Test alternate constructor
      Book book2(isbn1, title1, 39.99, 5);

      // Test data validation
      Book book3(isbn2, title2, -22.99, -6);

      // Test print() method and whether constructors
      // properly initialized objects
      cout << "Printing book1\n\n";
      book1.print();
      cout << endl << endl;

      cout << "Printing book2\n\n";
      book2.print();
      cout << endl << endl;

      cout << "Printing book3\n\n";
      book3.print();
      cout << endl << endl;

      // Test accessor methods
      cout << book2.getISBN() << endl;
      cout << book2.getTitle() << endl;
      cout << book2.getPrice() << endl;
      cout << book2.getQuantity() << endl;

      // Test the fulfillOrder() method
      numShipped = book2.fulfillOrder(-5);
      cout << "\nShipped " << numShipped << endl;
      cout << "Quantity now " << book2.getQuantity() << endl;
      
      numShipped = book2.fulfillOrder(3);
      cout << "Shipped " << numShipped << endl;
      cout << "Quantity now " << book2.getQuantity() << endl;

      numShipped = book2.fulfillOrder(4);
      cout << "Shipped " << numShipped << endl;
      cout << "Quantity now " << book2.getQuantity() << endl;


	cout << endl << endl << endl << endl;
	BookStore object ("bookdata");
	object.print();
	//searchForISBN(book2.getISBN) or searchForISBN(ISBN1) do with second
	*/


/*
	The main() routine logic will now look like this:

Create a BookStore object using the alternate constructor you wrote. Pass the filename string "bookdata" as
 an argument to the constructor.
Call the print() method for the BookStore object.
Call the processOrders() method for the BookStore object. Pass the filename string "orders.txt" as an argument to 
the method.
Call the print() method for the BookStore object.
	*/
	BookStore object ("bookdata");
	object.print();	
	object.processOrders("orders.txt");
	object.print();
      return 0;
      }
