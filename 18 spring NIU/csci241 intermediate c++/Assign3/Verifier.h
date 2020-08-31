#ifndef VERIFIER_H
   #define VERIFIER_H

#include <iostream>
#include <string>
#include <cstring>
  /*********************************************************************
   PROGRAM:    CSCI 241 Assignment 3
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   Feb 27 2018

   FUNCTION:   This file is the .h file, the header file for the verifier class, and verifier cpp will read
   			// from here/ 
*********************************************************************/  
   class Verifier
      {
      	//The Book class should have the following four private data members:

        private:
       		int grid[9][9]; // name of the 2d array
        //	char title[41]; //A title (a character array with room for 40 characters PLUS the null character)
        //	double price; //A price (a double variable)
        //	int quantity; //A quantity in stock (an integer)
        
        public:
        	Verifier();                       // Default constructor Verifier default constructor - 
										//This constructor has no parameters. It should set all of the elements of 
										//the grid array to 0.


  		//	Book(char[11], char[41], double, int);               //alt construsctor
  			
  			void readGrid(const char*); //  v.readGrid(fileName.c_str()); called like this from main
  		/*	This method takes one parameter: a pointer to a constant character (data type const char*), 
		which will point to an array of characters that contains the name of a file to use as input. 
		It returns nothing. The method should read the contents of the input file into the elements of the grid array.
		An input file contains exactly 81 numbers, arranged in 9 rows of 9 columns each, separated by whitespace*/
		
			//bool search(int grid[][9]);
			//int getFreeCellList(int grid[][9], int freeCellList[][2]);
			void printGrid(); /*
			This method takes no arguments and returns nothing. It should print the Sudoku grid array to the 
			screen as 9 rows of 9 columns (the same way the grid appears in the input file). For example: */
			
			//bool isValid(int i, int j, int grid[][9]);
			//bool isValid(int grid[][9]);
			
			bool verifySolution();/* This method takes no arguments. It should return a Boolean value - 
				true if the Sudoku grid array contains a valid solution, false if not.*/
			
			bool checkrow();
			bool checkcolumn();
			bool checksquare();


      };	

   #endif
