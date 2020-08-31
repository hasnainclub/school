/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: Friday, October 7 by 11:59 PM

Purpose: expand on Program 4 (the craps game) by adding in the use of functions and allowing the user to wager on the game.


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

//DEFINE Wager start
const double WAGER_STARTING = 100;
const double MIN_WAGER = 5.00;


//funtion prototyps
int rollDice();
double getWager(double);
void continueChatter(double);
void wagerChatter(double, double);
bool keepPlaying (char, double, double);
void wagerChatter(double, double);
void continueChatter(double);

int main()
{
//Has to play atleast once, so use bottom driven loop and initilize char befor the scope stars. 
char playAgain;

//wager
double balanceAmt = WAGER_STARTING, wagerAmt;

	//have to define this one time and one time only
srand(time(0)); //srand(4);

	do 
	{	
		//call rollDice function to give value to dice
		int dice1 = rollDice(), dice2 = rollDice();
		int sum = dice1+dice2;	
		
		//show Balance
		cout << "You have $" << fixed << setprecision (2) << balanceAmt << " available." << endl;
		
		//ask how much to bet / wager
		cout << "How much would you like to wager (Minimum wager: $" << MIN_WAGER << ")? " ;
		cin >> wagerAmt;
		
		//call wagerChatter for Extra Credit
		wagerChatter(balanceAmt, wagerAmt);
		
		//because example has two blank lines after they ask for wager/bet amt
		cout << endl << endl;
		
		//check for first roll Win
		if (sum == SEVEN || sum == ELEVEN)
		{
			cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum;
			cout<< endl << "You won!" << endl << endl << endl;
			balanceAmt += wagerAmt;
		}
		
		// check for first roll loss
		else if (sum == TWO || sum == THREE || sum == TWELVE)
		{
				cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum;
				cout<< endl << "CRAPS! You Lost" << endl << endl << endl;
				balanceAmt -= wagerAmt;
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
					
					int dice1 = rollDice(), dice2 =rollDice();
					int sum = dice1+dice2;	
					
					cout << "Player rolled: " << dice1 << " + " << dice2 << " = " << sum << endl;
					
					//check to see if the 7'd out or hit thier point, if hit point, then exit out of loop
					if (sum == point)
					{
						cout << endl << "You rolled your point! You won!" << endl << endl << endl;
						point = 0;// (sum+1);
						balanceAmt += wagerAmt;
					}
					
					else if (sum == SEVEN)
					{
						cout << endl << "You seven'd out and lost!" << endl << endl << endl;
						point = 0;//(sum+1);
						balanceAmt -= wagerAmt;
					}
				}
				while (sum == point);	
		}
		
		cout << "Your balance is $" << balanceAmt;
		cout << endl << "Would you like to play again (y for yes)? ";
		cin >> playAgain;
		
		//call continueChatter for extra credit
		continueChatter(balanceAmt);
		cout << endl << endl << endl << "\f" << endl; //the f is for pageBreak, gives a little dot to show newGame started or previous game ended
	}	
	while (keepPlaying(playAgain, balanceAmt, wagerAmt) == true);  // call to check if we can keep playing. 
	
	//display final balance
	cout << "Your final balance is $" << balanceAmt;

return 0;
system ("pause"); //pausing for debugging
}

/***************************************************************/
int rollDice()
{
	//get dice between 1-6 using modulus division then add 1. 
	int	result = rand() % 6+1;
	return result;
}

/***************************************************************/
double getWager( double balanceAmount )
{
	int result;
	return result;
}

/***************************************************************/
bool keepPlaying (char playAgain, double balanceAmt, double wagerAmt)
{
	bool result; 
	
	//to make sure if playing again is valid, user has to enter y and balanceAmt has to be greater than $5
 	if ((playAgain=='y'||playAgain=='Y' )&& balanceAmt >= MIN_WAGER)
 	 {
 	 	result = true;
	 }
	 else
	 {
	 	result = false;
	 }
 	
	return result;
}

/***************************************************************/
void wagerChatter(double balanceAmt, double wagerAmt)
{
	/*For the high extreme, if the player wagers at least 75% of their balance amount, display something like "Oh, you're going for broke, huh?." */
	if (wagerAmt >= (balanceAmt*.75))
	{
		cout << endl << "Oh, you're going for broke, huh?." ;
	}
	
	/*
	For the low extreme, if the player wagers less than 7% of their balance amount, display something like "Aw cmon, take a chance next time!"*/
		if (wagerAmt <= (balanceAmt*.07))
	{
		cout << endl << "Aw cmon, take a chance next time!";
	}
}

/***************************************************************/
void continueChatter(double balanceAmt)
{
	/*
	This function will be called after the player decides to continue the game. 
	It will display a message based on the player's balance. 
	
	/*If the player has a balance of $0.00, display something like "Sorry! You busted! You can't keep playing." */
	if (balanceAmt == 0.00)
	{
		cout << endl << "Sorry! You busted! You can't keep playing.";
	}
	
	/*If the balance is less than the minimum wager, display something like "I'm sorry but you do not have enough money to continue playing." */
	else if (balanceAmt <  MIN_WAGER)
	{
		cout << endl << "I'm sorry but you do not have enough money to continue playing.";
	}
	/*If the balance is more than 5 times the starting balance, 
		display something like "You're up big. You should think about cashing in your chips after this game!" */
	else if ((WAGER_STARTING*5) < balanceAmt)
	{
		cout << endl << "You're up big. You should think about cashing in your chips after this game!";
	}

}
