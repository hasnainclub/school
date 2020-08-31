/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due:oct 28	 2016

Purpose:Arrays: building and searching
***************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime>
#include <fstream>
using namespace std;

//function prototypes
int buildArray(string []);
int numWins(string [], int, string );
void displayYears(string [], int, string);

int const MAX_TEAM = 120;
int main()
{
	string array [MAX_TEAM];
  	
  	//declare Variables
  	int numTeams = buildArray(array), numOfWins;
  	string search_team;
  	
  	cout <<  "Enter a team: ";
  	//because teams have a space in the middle
	getline(cin, search_team);
  	
  	//call numWins function and return the number of times that team has won to numOfWins integer
  	numOfWins = numWins(array, numTeams, search_team);
  	
  	cout << endl << endl << "The " << search_team << " have won the World Series "<< numOfWins << " time(s).";
  	
  	//ExtraCredit
  	if (numWins > 0)
  	{
  	displayYears(array, numTeams, search_team );
	}
  	
  	/* //NEVER MIND there are 113 teams 112 subscribts
  	cout << "no of teams is " << numTeams << endl << endl;
  	
  	int i = 0;
  	
  	while (i < numTeams)
  	{
  	
  		cout << "team " << i+1 << " is " << array[i] << "     sub " << i << endl;
  		i++;
	}
	*/


return 0;
system ("pause"); //pausing for debugging
}

/*
This function will place the values from the input file into the passed in array of strings.

It takes one argument: an array of strings that will be filled with the names of the teams that have won the World Series. 
It returns an integer: the number of teams that were placed into the array.

This function should use a standard read loop pattern to read the data from the file and place it into the array. Read the first team name from the file. 
In a loop that executes while there is data in the file, put the team name that was read into the array, 
update the array subscript, and get another name from the file.

Once all of the data has been read from the file, return the number of teams that were placed into the array.
*/
int buildArray(string team_array[])
{
	
	int i;
	string str;
	
	//Create variable to store input file
	ifstream infile; 
	//Open the input file and make sure that it opened correctly
	//open file
	infile.open( "WorldSeriesWinners.txt" );
	//if input file fails to open stop execution of program and display a msg; exit, stops program
	if(infile.fail())
  	{
  	cout << "input file did not open" << endl;
  	exit(-1);
  	}
	
	for (i=0 ; getline(infile, str); i++)
	{
		team_array[i] = {str};
	}
	
	return (i);
}

/*
This function will search the array of World Series winning teams to determine the number of times that a specific team has won the World Series.

It takes three arguments: an array of strings that will be searched, an integer that represents the number of teams that are in the array 
(ie. the number of teams to be searched), and a string that represents the specific team to search for in the array. 
It returns an integer: the number of times that the specified team was found in the array.

In a loop that executes exactly one time for the number of teams that are in the array (ie. numTeams number of times), 
check to see if the specific team to search for in the array (ie. search_team) is found in the array of strings that will be searched (ie. team_array). 
If the specific team is found, increment a counter by 1.

Once the loop is finished executing, return the counter.
*/
int numWins(string team_array[], int numTeams, string search_team )
{
	int returnVal = 0;
	for (int sub = 0; sub <= numTeams; sub++)
	{
		if (team_array[sub] == search_team)
		{
			returnVal++;
		}
	}
	
	return returnVal;
}

/*
This function will search the array of World Series winning teams to determine and display the exact years that a specific team has won the World Series.

It takes three arguments: an array of strings that will be searched, an integer that represents the number of teams that are in the array 
(ie. the number of teams to be searched), and a string that represents the specific team to search for in the array. It returns nothing.

The years should be displayed with a maximum of 7 values per line of output.
*/
void displayYears( string team_array[], int numTeams, string search_team )
{
	int sub = 0;
	cout << endl << endl << "The World Series was won in: " << endl;
	
	for (int sub = 0; sub <= numTeams; sub++)
	{
		if (team_array[sub] == search_team)
		{
			
			cout << sub+1903 << " \t";
		}
	}
	
}

