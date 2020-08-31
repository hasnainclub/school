/***************************************************************
CSCI 240         Program     4  Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due:  Friday, September 23 by 11:59 PM

Purpose: Loops and Symbolic Constants
***************************************************************/


#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime> 
#include <cstdlib>
using namespace std;


//DEFINE constants for loss
#define TWO 2
#define THREE 3
#define TWELVE 12

//DEFINE Constants for win
#define SEVEN 7
#define ELEVEN 11


int main()
{
	//extracredit, has to play atleast once, so use bottom driven loop and initilize char befor the scope stars. 
char playAgain;

	//have to define this one time and one time only
srand(time(0));
	do 
	{	
		//get dice between 1-6 using modulus division then add 1. 
		int dice1 = rand() % 6+1, dice2 =rand() % 6+1;
		int sum = dice1+dice2;	
		
		//check for first roll Win
		if (sum == SEVEN || sum == ELEVEN)
		{
			cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum;
			cout<< endl << "You won!";
		}
		
		// check for first roll loss
		else if (sum == TWO || sum == THREE || sum == TWELVE)
		{
				cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum;
				cout<< endl << "CRAPS! You Lost";
		}
		
		//lets say firstRoll is not direct win/loss then playGame
		else 
		{
				//say what player rolled, assign it to point as that'll be our point which we want to achieve
				cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum;
				int point = sum; 
				cout << endl << endl << "The point is " << point << endl << endl;
				
				//now lets loop check, have to do it atleast once this is in else statement where we know
				do 
				{
					
					int dice1 = rand() % 6+1, dice2 =rand() % 6+1;
					int sum = dice1+dice2;	
					
					cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum << endl;
					
					//check to see if the 7'd out or hit thier point, if hit point, then exit out of loop
					if (sum == point)
					{
						cout << endl << "You rolled your point! You won!";
						point = 0;// (sum+1);
					}
					
					else if (sum == SEVEN)
					{
						cout << endl << "You seven'd out and lost!";
						point = 0;//(sum+1);
					}
				}
				while (sum == point);	
		}
		
		cout << endl << endl << "Would you like to play again (y for yes)? ";
		cin >> playAgain;
		cout << endl << endl << endl;
	}	
	while (playAgain == 'y' || playAgain == 'Y');

return 0;
system ("pause"); //pausing for debugging
}
