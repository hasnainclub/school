/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: Sep 16th

Purpose: Loops and Decision Statements
***************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime> 
#include <cstdlib>

using namespace std;
int main()
{
	
	//define variables
	int noDaysWorked, noBonus = 0;
	double startingSalary, bonus = 0, totalPay = 0, addSalary, amtEarned = 0;
	
	// give seed to randomFunction
	srand(1);
	
	//Generate a random number between 1 and 5. This will be used to determine the user's starting salary.
	// A value of 1 sets the starting salary to $0.01, 2 sets the starting salary to $0.02, 3 to $0.03, etc...
	
	//srand(1); not sure what this does. 
	
	startingSalary = rand() % 5 + 1; //Ggenerates a randomNumberBetween 1-5
	startingSalary = startingSalary / 100;
	
	//Generate another random number. This time is should be between 1 and 30. It will represent the number of days to be worked.
	//
	noDaysWorked = rand() % 30 + 1;


	//Display the starting salary and the number of days to be worked.
	
	cout << "Starting salary: " << startingSalary << endl;
	cout << "Number of days to work: " << noDaysWorked << endl << endl;

	addSalary = startingSalary;
	
	//header
	cout <<  setw(17) <<"Daily Salary" <<  setw(19) << "Amount Earned" << endl; 
	
	//In a loop that executes exactly one time for each day to be worked, calculate and display the user's salary for each day, 
	//update the user's total pay, and, if necessary, add the user's bonus to the total pay and keep track of the number of bonuses that are earned. 
	//A reminder -- the user's bonus is 10 times the starting pay and it's earned every 5th day.
	for (int i = 1; i <= noDaysWorked; i++)
	{
		//Day  1:          0.01
		amtEarned += startingSalary;
		cout << "Day " << setw(2) << i << ":"<< fixed << setprecision (2) << setw(10)<< startingSalary
			<< fixed << setprecision (2) << setw(10)<< amtEarned <<endl;
		
		
		if (i % 5 == 0)
		{
			bonus = (addSalary*10);
			amtEarned += bonus;		
			noBonus++;
		}
		
		startingSalary += startingSalary;
	}
	
	//After the loop has finished executing, display the user's total pay and if bonuses were earned, the number of bonuses that were earned and the 
	//amount of a bonus. If the number of bonuses is to be displayed, make sure it is grammatically correct. If only 1 bonus is earned, 
	//then something like "... and earned 1 bonus of ..." should be displayed. If more than 1 bonus was earned, then something like "... 
	//and earned 3 bonuses of ..." should be displayed.

	//for grammar correction if singular
	if (noBonus <= 1)
	{
		totalPay += (startingSalary - addSalary) + (bonus*noBonus);
		cout << endl << endl << "You made $" << totalPay << " and earned " << noBonus << " bonus of $" << bonus;
	}
	else
	{
		totalPay += (startingSalary - addSalary) + (bonus*noBonus);
		cout << endl << endl << "You made $" << totalPay << " and earned " << noBonus << " bonuses of $" << bonus;
	}

	



	
return 0;
system ("pause"); //pausing for debugging
}
