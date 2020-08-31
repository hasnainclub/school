/***********************************************************************
CSCI 240         Program 10     Fall 2016

Programmer: Hansain Attarwala

Section: 240	

Date Due: dec 2nd 2016

Purpose: final assignemnt
***********************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <fstream>

using namespace std;

//constants
		const int ROW = 3;
		const int COLUMN = 3;

//Place the class definiion after this line
class LoShuMagicSquare
{
	public:
		LoShuMagicSquare (); // constructor
		
		int square[ROW][COLUMN];
		
		void printSquare();
		void fillSquare( const char [] );
		bool isMagic();
	private:
};



int main()
{
//Create a LoShuMagicSquare object that will be used to test the 4 puzzles
LoShuMagicSquare puzzle;



//Puzzle 1 using loshu_puzzle1.txt. The object will be filled, displayed,
//and then tested to see if it is a valid solution

cout << "Puzzle 1:" << endl << endl;
puzzle.fillSquare( "loshu_puzzle1.txt");

puzzle.printSquare();

cout << endl << "Is it magic? " << ( puzzle.isMagic() ? "Yes": "No" ) << endl << endl << endl;


//Puzzle 2 using loshu_puzzle2.txt. The object will be filled, displayed,
//and then tested to see if it is a valid solution
cout << "Puzzle 2:" << endl << endl;

puzzle.fillSquare( "loshu_puzzle2.txt");

puzzle.printSquare();

cout << endl << "Is it magic? " << ( puzzle.isMagic() ? "Yes": "No" ) << endl << endl << endl;


//Puzzle 3 using loshu_puzzle3.txt. The object will be filled, displayed,
//and then tested to see if it is a valid solution
cout << "Puzzle 3:" << endl << endl;

puzzle.fillSquare( "loshu_puzzle3.txt");

puzzle.printSquare();

cout << endl << "Is it magic? " << ( puzzle.isMagic() ? "Yes": "No" ) << endl << endl << endl;


//Puzzle 4 using loshu_puzzle4.txt. The object will be filled, displayed,
//and then tested to see if it is a valid solution
cout << "Puzzle 4:" << endl << endl;

puzzle.fillSquare( "loshu_puzzle4.txt");

puzzle.printSquare();

cout << endl << "Is it magic? " << ( puzzle.isMagic() ? "Yes": "No" ) << endl << endl << endl;


return 0;
}
//Constructor
/*This class has one constructor that should initialize the two-dimensional array of integers. It takes no arguments.
The array should be initialized to hold 0s in all 9 elements. */
LoShuMagicSquare::LoShuMagicSquare()
{
	//makes the square all 0's;
	for (int columnIndex = 0; columnIndex < COLUMN; columnIndex++)
	{
		for (int rowIndex = 0; rowIndex < ROW; rowIndex++)
		{
			square[rowIndex][columnIndex] = 0;
		}
	}
	
}

//Code the methods below this line
/*

This is a public method that will fill the two-dimensional array data member with information that is read from a file. 
It takes 1 argument: an array of constant characters that represents the name of a file that holds the information to place into the array. 
It returns nothing.

This method should open the file that's name is passed in via the argument and verify that it opened correctly. 
Once the file has been correctly opened, a nested loop should be used to read the values into the array. 
After all of the values have been placed in the array, the file should be closed.

The input file contains exactly 9 numbers, arranged in 3 rows of 3 columns each, and separated by whitespace. For example:

4 9 2
3 5 7
8 1 6 */
void LoShuMagicSquare::fillSquare( const char fileName[] )
{
	//Create variable to store input file
	ifstream infile; 
	
	//Open the input file and make sure that it opened correctly
	//open file
	infile.open(fileName);
	//if input file fails to open stop execution of program and display a msg; exit, stops program
	if(infile.fail())
  	{
  	cout << "input file did not open" << endl;
  	exit(-1);
  	}
  	
  	
  	// put the numbers in the array from infile variable which is the file
  	for (int columnIndex = 0; columnIndex < COLUMN; columnIndex++)
	{
		for (int rowIndex = 0; rowIndex < ROW; rowIndex++)
		{
		infile >> square[rowIndex][columnIndex];
		}
	}
}



/*
This is a public method that will display the two-dimensional array to the screen as 3 rows or 3 columns (the same way the numbers appear in the input file). 
It takes no arguments and returns nothing.

 4 9 2
 3 5 7
 8 1 6
*/

void LoShuMagicSquare::printSquare()
{
	cout << "-----------" << endl; 
	
	for (int columnIndex = 0; columnIndex < COLUMN; columnIndex++)
	{
		for (int rowIndex = 0; rowIndex < ROW; rowIndex++)
		{
			cout << square[rowIndex][columnIndex] << " | ";
		}
		cout << endl << "-----------" << endl; 
	}
}
 
/*
This is a public method that will determine if the two-dimensional array contains a valid Lo Shu Magic Square solution. 
It takes no arguments and returns a boolean: true if the solution is valid or false if the solution is not valid.

As mentioned earlier, a valid solution is one where all 9 digits are used one time and all of the rows, columns, and diagonals add up to the same value.
*/
bool LoShuMagicSquare::isMagic()
{
	int sum = square [0][0] + square [0][1] + square [0][2];  //this is out row 0 so just check if everything else is equal to that.
	
	//compare rows
	for (int i = 1; i < ROW; i++) 
	{
		if ((square[i][0] + square[i][1] + square[i][2]) != sum)
			return false;
	}
	
	//compare columns
	for (int i = 0; i < COLUMN; i++) 
	{
		if ((square[0][i] + square[1][i] + square[2][i]) != sum)
			return false;
	}
	
	//compare diagnol left to right
	if ((square[0][0] + square[1][1] + square[2][2]) != sum)
			return false;
	
	//compare diagnol right to left
		if ((square[0][2] + square[1][1] + square[2][0]) != sum)
			return false;
	
	return true;
}

