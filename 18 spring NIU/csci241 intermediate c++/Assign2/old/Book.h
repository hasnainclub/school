#ifndef BOOK_H
   #define BOOK_H

#include <iostream>
#include <string>
#include <cstring>
   //*****************************************************************
   // FILE:      Book.h
   // AUTHOR:    Hasnain Attarwala
   // LOGON ID:  z1697740
   // DUE DATE:  Feb 13 2018
   // 
   // PURPOSE:   Contains the declaration for the Book class.
   //*****************************************************************

   class Book
      {
      	//The Book class should have the following four private data members:

        private:
        	char ISBN[11]; //An ISBN (a character array with room for 10 characters PLUS the null character)
        	char title[41]; //A title (a character array with room for 40 characters PLUS the null character)
        	double price; //A price (a double variable)
        	int quantity; //A quantity in stock (an integer)
        
        public:
        //	Book();                       // Default constructor with no arguments
  		//	Book(char[11], char[41], double, int);               //alt construsctor
  			
  			void setPrice(double); //This method takes a double argument, a new price. It returns nothing. 
        	void setQuantity(int); //This method takes an integer argument, a new quantity. It returns nothing. 
        	
        	char* getISBN(); //This accessor method takes no parameters. It should return the ISBN data member. 
        	char* getTitle(); // - This accessor method takes no parameters. It should return the title data member.
			double getPrice() const; // getprice method, returns price
			int getQuantity(); //gerquantity method, returns quantity
			int fulfillOrder(int); //This accessor method takes one parameter, an integer that 
														//represents the quantity of this book that has been ordered. 
														//The method returns an integer, which is the quantity of this book that the book store is 
														//actually able to ship at this time.
			void print(); // print stuff

      };	

   #endif
