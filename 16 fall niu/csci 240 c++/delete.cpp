/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: 

Purpose: 
***************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime> 
#include <cstdlib>

using namespace std;
#define LOW 32
#define HIGH 212
#define EXIT -99

int main()
{
int userVal, betweenCnt = 0, extremeCnt = 0, sum = 0;
double avg;

//get the first number from the user

cout << "Enter a number (" << EXIT << " to quit):";
cin >> userVal;


//while the user has not entered the exit value

while( userVal != EXIT )
  {
  //if the user's value is an extreme, then increment the count of
  //extreme values. Otherwise, add the user's value to the running
  //total and increment the count of the valid values

  if( userVal < LOW || userVal > HIGH )
    extremeCnt++;

  else
    {
    sum += userVal;
    betweenCnt++;
    }


  //get the next number from the user

  cout << "Enter a number (" << EXIT << " to quit):";
  cin >> userVal;
  }


//If the user entered at least 1 valid number, calculate the average
//and then display it and the number of extreme values that were
//entered.

if ( betweenCnt > 0 )
  {
  avg = (double) sum / betweenCnt;
  
  cout << endl << endl << "Average is: "
       << setiosflags(ios::fixed) << setprecision(2) << avg
       << endl << "There were " << extremeCnt << " extreme values";
  }

return 0;
}
