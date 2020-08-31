#include "Verifier.h"
 #include <string.h>
 #include <iomanip>
#include <fstream>
#include <iostream>
#include <cmath>


   //*****************************************************************
   // FILE:      Verifier.cpp
   // AUTHOR:    Hasnain Attarwala
   // LOGON ID:  z1697740
   // DUE DATE:  Feb 27 2018
   // 
   // PURPOSE:   Contains the verifier class
   //***************************************************************** 
   
using std::cout; using std::cin; using std::cerr; using std::endl;
using std::ifstream; using std::ios;

/*
using std::string; using std::fixed; using std::setw; using std::left; using std::right;
using std::setprecision;using */

//using namespace std; 

/*
Book default constructor - This constructor has no parameters. It should set all of the elements of the grid 
array to 0.
*/
Verifier::Verifier()
{
/*	//reeally neat way to set every element of 2d array to 0. 
	grid[9][9] =
	{
  		{0, 0},
 		{0, 0}
	}; */
	int ROW = 9;
	int COLUMN = 9;
	for (int i = 0; i < ROW; i++)
 		for (int j = 0; j < COLUMN; j++)
 		{	grid[i][j] = 0;
 		//	cout << grid[i][j] << endl;  	//test to see if we got 9 by 9 0's
		 }
   		
   				
}
/*	This method takes one parameter: a pointer to a constant character (data type const char*), 
		which will point to an array of characters that contains the name of a file to use as input. 
		It returns nothing. The method should read the contents of the input file into the elements of the grid array.
		An input file contains exactly 81 numbers, arranged in 9 rows of 9 columns each, separated by whitespace*/
void Verifier::readGrid(const char* fileName)
{
	ifstream inFile;
	inFile.open(fileName, ios::in);
	
	if(inFile.fail())
	{
		std::cerr << "Oops, couldn't open your input file named " << fileName << " bye" << endl;
		exit(-1);
	}
	
	for(int i=0; i<9; i++)
	{
		for (int j=0; j<9; j++)
		{
			inFile >> grid[i][j];
		}
	}
}


void Verifier::printGrid()
{

	/*
	for (int columnIndex = 0; columnIndex < 9; columnIndex++)
	{
		for (int rowIndex = 0; rowIndex < 9; rowIndex++)
		{
			cout << grid[rowIndex][columnIndex];
		
			if ((rowIndex == 3) || (rowIndex % == 3))
				cout << " | " ;
		}
		cout << endl << "-----------" << endl; 
	} */
	
	   cout << "-------------------" << endl;
        for (int row=0; row<9; row++) 
		{
			
			cout << "| ";
			
            for (int column=0; column<9; column++)
            {
                cout << grid[row][column]; 
                
               if (column==2 || column == 5 || column ==9)
					cout << " | "; // whenever there are 3 numbers side by side

			}
            cout << " |"<< endl; // last one
       
       	if (row == 2 || row == 5 || row == 8)
				cout << "-------------------" << endl;
		}	
		//cout << "------------------" << endl;
}

bool Verifier::verifySolution() /* This method takes no arguments. It should return a Boolean value - 
				true if the Sudoku grid array contains a valid solution, false if not.*/
{
	/*
	int i, j;
	    
    bool status;
    
    for (int column = 0; column < 9; column++)
    {
        if (column != j && grid[i] [column] == grid[i] [j])
            status = false;
    }

    for (int row = 0; row < 9; row++)
    {
	
        if (row != i && grid[row] [j] == grid[i] [j])
            status = false;
    }
            
    for (int row = (i / 3) * 3; row < (i / 3) * 3 + 3; row++)
    {
        for (int col = (j / 3) * 3; col < (j / 3) * 3 + 3; col++)
        {
            if (row != i && col != j && grid[row][col] == grid[i][j])
                status = false;
        }
    }

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if (grid[i][j] != 0)
                status = false;
        }
	}
                
    return status; */
   if (checkcolumn()== true && checkrow()== true && checksquare()==true)
     	return true;
   else 
   		return false;
    
}


bool Verifier::checkrow()
{
	
	int k =0;
	int i = grid[k][0];
	cout << " i " << i << endl;
    int j = grid[k][1];
    cout << " j " << j << endl;
    
 for (int row = 0; row < 9; row++) 
	{
    if (row != i && grid[row][j] == grid[i][j]) {
    cout << " row number " << row << " comparing "<< grid[row][j] << " with "<<  grid[row][j] << endl << endl; 
      return false;} 
	}
	return true; 
	


	

	/*
	int subcheck, subcheckWith, row;
	bool returnVal = true;
 
 for (row = 0; row < 9; row++)
 {
 	for( subcheck = 0; subcheck < 9; subcheck++)
    {
         for( subcheckWith = subcheck+1; subcheckWith < 9; subcheckWith++)
         {
         	//	cout << " row number " << column << endl;
         	//	cout << " subcheck " << subcheck << " subcheckWith " << subcheckWith << endl;
         	//	cout << " subcheck val " << grid[row][subcheck] << " subcheckWith val " << grid[row][subcheckWith] 
			//									<< endl << endl << endl;
         		
            if( grid[row][subcheck] == grid[row][subcheckWith] )
            {
            	returnVal = false;
			}
         }
    }
 }

	return returnVal;
	*/
}

bool Verifier::checkcolumn()
{
	
	int k =0;
	int i = grid[k][0];
    int j = grid[k][1];
    
  for (int column = 0; column < 9; column++)
    if (column != j && grid[i][column] == grid[i][j])
      return false;
    else return true; 
    
    /*
	int subcheck, subcheckWith, column;
	bool returnVal = true;
 
 for (column = 0; column < 9; column ++)
 {
 	for( subcheck = 0; subcheck < 9; subcheck++)
    {
         for( subcheckWith = subcheck+1; subcheckWith < 9; subcheckWith++)
         {
         	//	cout << " column number " << column << endl;
         	//	cout << " subcheck " << subcheck << " subcheckWith " << subcheckWith << endl;
         	//	cout << " subcheck val " << grid[column][subcheck] << " subcheckWith val " 
			 //<< grid[column][subcheckWith] << endl << endl << endl;
         		
            if( grid[subcheck][column] == grid[subcheckWith][column] )
            {
            	returnVal = false;
			}
         }
    }
 }

	return returnVal; */
}
bool Verifier::checksquare()
{
	
	int k =0;
	int i = grid[k][0];
    int j = grid[k][1];
	
 for (int row = (i / 3) * 3; row < (i / 3) * 3 + 3; row++)
    for (int col = (j / 3) * 3; col < (j / 3) * 3 + 3; col++)
      if (row != i && col != j && grid[row][col] == grid[i][j])
        return false;
	else return true; 
	/*
//	int zero=0, one = 1 , boxNumber;
	bool returnVal = true;
 //if( grid[subcheck][column] == grid[subcheckWith][column] )
 //already checked row and columb so, just cheque the other 4 critter, loop too complicated hardly anytime, hardCode!
 //there's a pattern!  nice pattern, i'll loop on my own time, assignment needs to submitted
 //technically works. and i did it all on my own!
 
 
 //box1
 	//first digit from left
 	int rowAdd = 0;  //in comparsion to box1,2,3 u can just add stuff
	 // 				for 			box4,5,6
	 				//and 				box7,8,9  This hard code business is too long!
 	
	if (grid[0 + rowAdd][0] == grid[1 + rowAdd][1])
	 	returnVal = false;
	else if (grid[0 + rowAdd][0] == grid[1 + rowAdd][2])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][0] == grid[2 + rowAdd][1])
	 	returnVal = false;
	else if (grid[0 + rowAdd][0] == grid[2 + rowAdd][2])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][1] == grid[1 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][1] == grid[1 + rowAdd][2])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][1] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][1] == grid[2 + rowAdd][2])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][2] == grid[1 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][2] == grid[1 + rowAdd][1])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][2] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][2] == grid[2 + rowAdd][1])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][0] == grid[2 + rowAdd][1])
	 	returnVal = false;
	else if (grid[1 + rowAdd][0] == grid[2 + rowAdd][2])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][1] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[1 + rowAdd][1] == grid[2 + rowAdd][2])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][2] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[1 + rowAdd][2] == grid[2 + rowAdd][1])
	 	returnVal = false;
//dont have to do 789 digit as thats already been checked ei last row

//box2
 	//first digit from left
	if (grid[0 + rowAdd][3] == grid[1 + rowAdd][4])
	 	returnVal = false;
	else if (grid[0 + rowAdd][3] == grid[1 + rowAdd][5])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[0 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][4] == grid[1 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4] == grid[1 + rowAdd][5])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][5] == grid[1 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5] == grid[1 + rowAdd][4])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5] == grid[2 + rowAdd][4])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5] == grid[2 + rowAdd][4])
	 	returnVal = false;
	 	
	 	
//box3
 	//1st digit from left
	if (grid[0 + rowAdd][6] == grid[1 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][6] == grid[1 + rowAdd][5+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][6] == grid[2 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][6] == grid[2 + rowAdd][5+3])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][4+3] == grid[1 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4+3] == grid[1 + rowAdd][5+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][4+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][5+3] == grid[1 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5+3] == grid[1 + rowAdd][4+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][5+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5+3] == grid[2 + rowAdd][4+3])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][3+3] == grid[2 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5+3] == grid[2 + rowAdd][6])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5+3] == grid[2 + rowAdd][7])
	 	returnVal = false;
	 	

//what we found is that in each boxes in row, box1, box2, box3..., 
//columnSub gets+3 and columnCheck also gets+3 if going next adjacent box
//to go to row

//box4 //box lives in 2nd row
	rowAdd = 3;

 	//first digit from left
	if (grid[3][0] == grid[4][1])
	 	returnVal = false;
	else if (grid[3][0] == grid[4][2])
	 	returnVal = false;	
	else if (grid[3][0] == grid[5][1])
	 	returnVal = false;
	else if (grid[3][0] == grid[5][2])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][1] == grid[1 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][1] == grid[1 + rowAdd][2])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][1] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][1] == grid[2 + rowAdd][2])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][2] == grid[1 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][2] == grid[1 + rowAdd][1])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][2] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][2] == grid[2 + rowAdd][1])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5] == grid[2 + rowAdd][4])
	 	returnVal = false;



	 	
	 	
//box5  
rowAdd = 3;

 	//first digit from left
	if (grid[0 + rowAdd][3] == grid[1 + rowAdd][4]) 
	 	returnVal = false;
	else if (grid[0 + rowAdd][3] == grid[1 + rowAdd][5]) 
	 	returnVal = false;	
	else if (grid[0 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[0 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][4] == grid[1 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4] == grid[1 + rowAdd][5])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][5] == grid[1 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5] == grid[1 + rowAdd][4])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5] == grid[2 + rowAdd][4]) 

	//4th digit
	if (grid[1 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5] == grid[2 + rowAdd][4])
	 	returnVal = false;
	 	
//box6	
rowAdd = 3;
 	//1st digit from left
	if (grid[0 + rowAdd][6] == grid[1 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][6] == grid[1 + rowAdd][5+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][6] == grid[2 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][6] == grid[2 + rowAdd][5+3])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][4+3] == grid[1 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4+3] == grid[1 + rowAdd][5+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][4+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][5+3] == grid[1 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5+3] == grid[1 + rowAdd][4+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][5+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5+3] == grid[2 + rowAdd][4+3])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][3+3] == grid[2 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5+3] == grid[2 + rowAdd][6])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5+3] == grid[2 + rowAdd][7])
	 	returnVal = false;
	 	
	 	
//box 7, equivalent class of box1 + rowAdd = 6
rowAdd = 6;
 	
	if (grid[0 + rowAdd][0] == grid[1 + rowAdd][1])
	 	returnVal = false;
	else if (grid[0 + rowAdd][0] == grid[1 + rowAdd][2])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][0] == grid[2 + rowAdd][1])
	 	returnVal = false;
	else if (grid[0 + rowAdd][0] == grid[2 + rowAdd][2])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][1] == grid[1 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][1] == grid[1 + rowAdd][2])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][1] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][1] == grid[2 + rowAdd][2])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][2] == grid[1 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][2] == grid[1 + rowAdd][1])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][2] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[0 + rowAdd][2] == grid[2 + rowAdd][1])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][0] == grid[2 + rowAdd][1])
	 	returnVal = false;
	else if (grid[1 + rowAdd][0] == grid[2 + rowAdd][2])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][1] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[1 + rowAdd][1] == grid[2 + rowAdd][2])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][2] == grid[2 + rowAdd][0])
	 	returnVal = false;
	else if (grid[1 + rowAdd][2] == grid[2 + rowAdd][1])
	 	returnVal = false;


//box8
rowAdd = 6;
	//first digit from left
	if (grid[0 + rowAdd][3] == grid[1 + rowAdd][4])
	 	returnVal = false;
	else if (grid[0 + rowAdd][3] == grid[1 + rowAdd][5])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[0 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][4] == grid[1 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4] == grid[1 + rowAdd][5])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][5] == grid[1 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5] == grid[1 + rowAdd][4])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5] == grid[2 + rowAdd][4])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][3] == grid[2 + rowAdd][4])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3] == grid[2 + rowAdd][5])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4] == grid[2 + rowAdd][5])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5] == grid[2 + rowAdd][3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5] == grid[2 + rowAdd][4])
	 	returnVal = false;


//box9
rowAdd=6;
//1st digit from left
	if (grid[0 + rowAdd][6] == grid[1 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][6] == grid[1 + rowAdd][5+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][6] == grid[2 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][6] == grid[2 + rowAdd][5+3])
	 	returnVal = false;
	 	
	//2nd digit
	if (grid[0 + rowAdd][4+3] == grid[1 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4+3] == grid[1 + rowAdd][5+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][4+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][4+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;
	 	
	//3rd digit
	if (grid[0 + rowAdd][5+3] == grid[1 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5+3] == grid[1 + rowAdd][4+3])
	 	returnVal = false;	
	else if (grid[0 + rowAdd][5+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[0 + rowAdd][5+3] == grid[2 + rowAdd][4+3])
	 	returnVal = false;

	//4th digit
	if (grid[1 + rowAdd][3+3] == grid[2 + rowAdd][4+3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][3+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;	

	//5th digit
	if (grid[1 + rowAdd][4+3] == grid[2 + rowAdd][3+3])
	 	returnVal = false;
	else if (grid[1 + rowAdd][4+3] == grid[2 + rowAdd][5+3])
	 	returnVal = false;	 	
	
	//6th digit
	if (grid[1 + rowAdd][5+3] == grid[2 + rowAdd][6])
	 	returnVal = false;
	else if (grid[1 + rowAdd][5+3] == grid[2 + rowAdd][7])
	 	returnVal = false;

return returnVal;
	 	*/
}







