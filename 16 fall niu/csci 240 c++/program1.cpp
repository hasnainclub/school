/***************************************************************
CSCI 240         Program 1     Fall 2016

Programmer: Hasnain Attarwala

Section: 240 2

Date Due: Sep 2nd

Purpose: This program calculates the number of singles and total
         number of bases for a baseball player.
***************************************************************/

#include <iostream>
#include <iomanip>

int main ()
{

using namespace std;
int noSingles, totalHits, nodoubles, noTrips, noHomeRun, noBases; //defines values

//ask for inputs,obviously ask for appropriate intputs so add cout's
cout << "Enter the number of hits: ";
cin >> totalHits;
cout << "Enter the number of doubles: ";
cin >> nodoubles;
cout << "Enter the number of triples: ";
cin >> noTrips;
cout << "Enter the number of home runs: ";
cin >> noHomeRun;

//number of singles = total number of hits - number of doubles - number of triples - number of home runs
  noSingles = totalHits - nodoubles - noTrips - noHomeRun;
//total number of bases = number of singles + (number of doubles * 2) + (number of triples * 3) + (number of home runs * 4)
noBases = noSingles + (nodoubles*2) + (noTrips*3) + (noHomeRun*4);

/*
Singles: 112   Doubles: 32   Triples: 4   Home Runs: 19
Total Bases: 264
*/
cout << "\n \nSingles: " << noSingles << "     Doubles: " << nodoubles << "     Triples: " << noTrips << "     Home Runs: " << noHomeRun
	 << "\nTotal Bases: " << noBases;


return 0;
}
