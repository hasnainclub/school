 #include "BookStore.h"
 #include <iomanip>
#include <fstream>
 //#include <iostream>
 //#include <cstdlib>
 //#include <stdlib.h>
    //*****************************************************************
   // FILE:      BookStore.cpp
   // AUTHOR:    Hasnain Attarwala
   // LOGON ID:  z1697740
   // DUE DATE:  Feb 13 2018
   // 
   // PURPOSE:   Contains the BookStore class.
   //*****************************************************************
 //put all the namespace std stuff
using std::cout; using std::cin; using std::cerr; using std::endl;
using std::string; using std::ifstream; using std::ios; using std::ifstream; using std::setprecision;
 
 

 
/*default constructor
 BookStore default constructor - This "default" constructor for the BookStore class takes no parameters. 
 Like all C++ constructors, it does not have a return data type.

This constructor is called to create an empty database, so this method should set the number of books data member to 0.

(As with the Book class, if you initialize the number of books data member to 0 when you declare it, this method's
 body can be empty. 
You still need to code the method with an empty body.)
 */
 BookStore::BookStore()
 {
 	numBookObjects = 0;
 }
 
 /*
 Alternate BookStore constructor - Write a second constructor for the BookStore class that takes one parameter: 
 a reference to a constant string object (data type const string&), that will contain the name of an existing
 database file. 
 Like all C++ constructors, this constructor does not have a return data type.

This constructor should do the following:

Declare an input file stream variable (the code below assumes it is named inFile).

Open the file stream for binary input. Check to make sure the file was opened successfully as usual.

Read the database file into your BookStore object. You can do this with a single statement:

   inFile.read((char*) this, sizeof(BookStore));
Close the file stream.
*/
 BookStore::BookStore(const std::string& fileName)
 {
 //	ifstream inFile;
  	
  	
 	//fstream fileName("fileName", ios::in | ios::out | ios::binary);
 	//inFile.open("fileOpenName", ios::binary | ios::in | ios::out);
 //	ifstream inFile(fileName);
 	ifstream inFile(fileName.c_str());
 	if (inFile.fail()) 
 	{
 		cerr << "ERROR!!! Seriously dude? Go check your file  " << endl << fileName;
 		exit (-1);
	}
	
	inFile.read((char*) this, sizeof(BookStore)); 
	inFile.close();
	sortByISBN ();
}
 
 
 /*
 - This method takes no parameters and returns nothing.

This method should first print a descriptive header line (e.g., "Book Inventory Listing"). 
It should then loop through the array of Book objects and print each of the elements that contain book data,
one per line. 
Here we see some of the power of object-oriented programming: since each element of the array is an object,
we can call a method for that object. 
We've already written a print() method for the Book class, so printing an element of the array is as easy as 
calling print() 
for the array element. 
The syntax for calling a method using an array element that is an object is pretty straightforward:

   arrayName[subscript].methodName(arguments);
 */
void BookStore::print()
{
	cout << "Book Inventory Listing" << endl << endl;
	cout << "ISBN          Title                                       Price    Qty." << endl << endl;
	for (int i=0; i< numBookObjects; i++)
	{
		bookArray[i].print(); 
		//cout << endl;
		
		//bookArray[i].getTitle();
		//bookArray[i].getPrice();
		//bookArray[i].getQuantity();
	}
}

/*
sortByISBN() - This method takes no parameters and returns nothing.

This method should sort the array of Book objects in ascending order by ISBN using the insertion sort algorithm.

The sort code linked to above sorts an array of integers called numbers of size size. You will need to make a 
substantial number of changes to that code to make it work in this program:

This will be a method, not a function. Change the parameters for the method to those described above.

In the method body, change the data type of bucket to Book. This temporary storage will be used to swap elements 
of the array of Book objects.

In the method body, change any occurrence of numbers to the name of your array of Book objects and size to numBooks
 (or whatever you called the data member that tracks the number of valid Book objects stored in the array).

The comparison of bookArray[j-1] and bucket will need to use the C string library function strcmp() to perform the 
comparison. Also, you'll need to use the getISBN() method to access the ISBN data member within each Book object. 
The final version of the inner for loop should look something like this:

   for (j = i; (j > 0) && (strcmp(bookArray[j-1].getISBN(), bucket.getISBN()) > 0); j--)
      ...
It is legal to assign one Book object to another; you don't need to write code to copy individual data members.

Add a call to the sortByISBN() method to the end of the alternate constructor you wrote for the BookStore class. 
This will sort the array of Book objects that were read in from the input file.
*/
void BookStore::sortByISBN ()
{
//insertion_sort (bookArray, numBookObjects);
Book bucket;

int j;
for(int i=0;i<numBookObjects;i++)
{
	bucket = bookArray[i];
	
   	for (j=i; (j > 0) && (strcmp(bookArray[j-1].getISBN(), bucket.getISBN()) > 0); j--)
         bookArray[j] = bookArray[j-1];
		
		bookArray[j] = bucket;
}

}



/*
searchForISBN() - This method should take one parameter: a character array containing the ISBN of the 
Book to search for (searchISBN). The method should return an integer.

The logic for this method is a variation of the binary search of a sorted list strategy.
As usual, you'll need to use strcmp() to perform the comparison of ISBNs.
*/
int BookStore::searchForISBN(const char* searchISBN) //char char * searchISBN [] then it refers to data in the array
												//but char* refers to entire array (address of it, better to do it
												//this way
{
	int low = 0;
   int high = numBookObjects - 1;
   int mid;

   while (low <= high)
      {
      mid = (low + high) / 2;

		//searchISBN is equal to ISBN data member of bookArray[mid
      if (strcmp(searchISBN, bookArray[mid].getISBN())==0)
         return mid;
		//searchISBN is less than ISBN data member of bookArray[mid]
      if (strcmp(searchISBN, bookArray[mid].getISBN()) <0) //if returns -ve value, then search 
	  //													isbn is less than book array
         high = mid - 1;
      else
         low = mid + 1;
      }

   return -1;
	
}

/*
processOrders() - This method should take one parameter: a reference to a constant string object that 
contains the name of a file of order records. The method should return nothing.

This method will read a series of order records, each containing an order number, an ISBN, and an order 
quantity. This data is not in binary form, so you can not use the same technique to read it that was used for 
the book data in Part 1. Use the >> operator to read the individual data items into three separate variables.

For each order record, the method should search for the ISBN and, if found, should call the fulfillOrder() method 
for that book, passing it the order quantity. If an ISBN is not found, an error message should be printed.
*/
void BookStore::processOrders(const std::string& fileName) //passing filename wishing to open, because it's in string
//object we are taking it & 
{
	
	cout << endl << endl;
//	ifstream inFile1;
   string orderNumber; //chaned to string for convience char orderNumber[7];
   string isbn;  	//chaned to string for convience char orderNumber[7];
   int orderQuantity;
   int numShipped; 

  // Open inFile using the file name passed in as a parameter
   //Check for successful open
	ifstream inFile1(fileName.c_str());
 	if (inFile1.fail()) 
 	{
 		cerr << "ERROR!!! Seriously dude? Go check your file  " << endl << fileName;
 		exit (-1);
	}
	

   //Read orderNumber from inFile
   while (inFile1 >> orderNumber) //like a CIN statement, as long as its reading stuff in, loop will go
      {
      //Read isbn from inFile
      inFile1 >> isbn;
      //Read orderQuantity from inFile
      inFile1 >> orderQuantity;
      
      int index = searchForISBN(isbn.c_str());
      if (index == -1)
         cout << orderNumber << " that order number wasn't found'" << endl; 
      else
         {
        
        /* Call the fullfillOrder() method for the Book object at element index of the array of Book objects.
           Pass the orderQuantity to the method and store the returned value in numShipped
         Print the results for this order */
         
         //book array's object is accessing that method
         //bookArry object is for book class, and we included book.h in this cpp, so it'll have connection
        numShipped = bookArray[index].fulfillOrder(orderQuantity);
    
        //print order number, isbn, numShipped and order quantity
        
        //Order #101001: ISBN 0203981600, 8 of 8 shipped, order total $191.92
        cout << "Order #" << orderNumber;
        cout << ": ISBN " << isbn;
		cout << ", " << numShipped;
		cout << " of " << orderQuantity;
				
		//double orderTotal = numShipped * bookArray[index].getPrice();
		cout << " shipped, order total of $" << setprecision(2) <<  (numShipped * bookArray[index].getPrice()) << endl;
         }
   		
      //Read orderNumber from inFile
      //inFile1>>orderNumber;
      }   
	cout << endl << endl;
  // Close input file
  inFile1.close();
}
