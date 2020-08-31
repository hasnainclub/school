#ifndef BOOKSTORE_H
   #define BOOKSTORE_H

#include "Book.h"
#include <iostream>
#include <string>
#include <cstring>
   //*****************************************************************
   // FILE:      BookStore.h
   // AUTHOR:    Hasnain Attarwala
   // LOGON ID:  z1697740
   // DUE DATE:  Feb 13 2018
   // 
   // PURPOSE:   Contains the declaration for the Book class.
   //*****************************************************************
   
   /*
   The BookStore class should have the following two private data members:

An array of 30 Book objects
An integer that specifies the number of Book objects actually stored in the array
   */
    class BookStore 
    {
      private:
     	Book bookArray[30];
     	int numBookObjects;
      public:
      	BookStore();  					//BookStore default constructor - This "default" constructor for the BookStore class takes no parameters. 
 										//Like all C++ constructors, it does not have a return data type.
 		BookStore(const std::string&); // alt constructor a reference to a constant string object (data type const string&), 
		 						//that will contain the name of an existing database file.
 		
		void print(); // print stuff
		void sortByISBN(); 	//This will be a method, not a function. Change the parameters for the method to 
							// those described above.
		int searchForISBN(const char*) const; //searching for isbn method
		void processOrders(const std::string& ) ;//passing filename wishing to open, because it's in string

    };	

   
   
   
  #endif
