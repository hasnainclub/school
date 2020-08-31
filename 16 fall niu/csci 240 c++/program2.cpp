/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: Sep 9th

Purpose: For Formatted Output and Integer Division
***************************************************************/

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int hits, doubles, triples, homeRuns, bats, noSingles, noBases; 
	float slugPercent;
	
	cout << "Enter the number of hits: " ;
	cin >> hits; 

	cout << "Enter the number of doubles: ";
	cin >> doubles; 
	
	cout << "Enter the number of triples: ";
	cin >> triples;
	
	
	cout << "Enter the number of home runs: ";
	cin >> homeRuns;
	
	cout << "Enter the number of at bats: ";
	cin >> bats;
	
	//calculate number of singles
	noSingles = hits - doubles - triples - homeRuns;
	
	//calculate number of bases
	noBases = noSingles + (doubles*2) + (triples*3) + (homeRuns*4);

	// taking the total number of bases divided by the number of at bats the player has taken.
	slugPercent = (double) noBases / bats; //typeCasting it to termproarily behave like a double to give us decimal points. 

	
cout << fixed << setprecision (3) << "\n \nSingles: " << noSingles << "\tDoubles: " << doubles << "\tTriples: " << triples << "\tHome Runs: " << homeRuns
	<< endl << "Total Bases: " << noBases
	<< endl << "Slugging Percentage: " << slugPercent; //fixed <<setprecision(numberValue) gives us a 3 fixed decimal points \t for formating add's tab spaces
	
return 0;
system ("pause");
}
