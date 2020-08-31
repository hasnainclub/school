/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: Nov 18 2016

Purpose: classes
***************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime>
using namespace std;

//Place the class definition after this line

class myInt 
{
public:
  myInt (); // default constructor
  myInt (long long);//constuctor
  
  void print();
  long long getInt();
  void setInt( long long );
  int sumDigits();
  int reverse();
  int oddDigitCount();
  int evenDigitCount();
  int zeroCount();
   
private:
	long long number;
};

int main()
{
// give seed to randomFunction
srand(815);

for (int i = 0; i<10; i++)
{
//testing shit, needs to be commented out
myInt num1;
myInt num2 (1);

//num1.print();
num2.print();
num2.sumDigits();
num2.reverse();
num2.oddDigitCount();
num2.evenDigitCount();
num2.zeroCount();

} 

//extra credit 
/*
Finally, add code to main that will create a new myInt object with the value 90237104628012645. 
Call the sumDigits, reverse, oddDigitCount, evenDigitCount, and zeroCount methods for the new object and display 
the values that are returned with labels. Use the setInt method to try to change the value to -5058675309. 
Call the 5 methods again and display the new results. */

cout << endl << endl << endl << "Extra Credit" << endl;
myInt extraCreditObject(90237104628012645);

extraCreditObject.print();
extraCreditObject.setInt(90237104628012645);
extraCreditObject.sumDigits();
extraCreditObject.reverse();
extraCreditObject.oddDigitCount();
extraCreditObject.evenDigitCount();
extraCreditObject.zeroCount();

myInt extraCreditObject2(-5058675309);

extraCreditObject2.print();
extraCreditObject2.setInt(-5058675309);
extraCreditObject2.sumDigits();
extraCreditObject2.reverse();
extraCreditObject2.oddDigitCount();
extraCreditObject2.evenDigitCount();
extraCreditObject2.zeroCount();

return 0;
system ("pause"); //pausing for debugging
}

//The first constructor is a default constructor (i.e. one that takes no arguments). It should simply initialize the integer data member to 0.
myInt::myInt()
{
	number = 0;
}

/*The second constructor takes one argument: an integer that will be used to initialize the integer data member. 
Call the setInt method that is described below to do the initialization.*/ 
myInt::myInt(long long newNumber)
{
	setInt(newNumber);
} 

/*
This method displays the integer data member. It takes no arguments and returns nothing.
*/
void myInt::print()
{
	cout << endl << endl << "The number is " << number << endl;
	cout << "----------------------------------------------------" << endl;
}

/*
This accessor method returns the value of the integer data member. It takes no arguments and returns an integer.
*/
long long myInt::getInt()
{
	return number;
}

/*
This accessor method is used to change the value of the integer data member. 
It takes one argument: an integer that will potentially be used to update the value of the integer data member. It returns nothing.
If the passed in value is non-negative, use it to update the value of the integer data member. If the passed in value is negative, 
use the absolute value of the passed in value to update the value of the integer data member.
The cmath library has a function called abs that takes one integer as its argument. It returns the absolute value of the integer.
*/
void myInt::setInt( long long newNumber)
{
	
	number = rand();
	if (number <0 )
	{
		number = abs (newNumber);
	}
	if (newNumber < -2000000000 || newNumber > 2000000000)
	{
		number = newNumber;
			if (newNumber <0 )
		{
		number = abs (newNumber);
		}
	}
}

/*
This method will calculate and return the sum of adding the individual digits of the integer data member. 
For example, if an object contains an integer data member with the value 641, the method should return 11 (the sum of 6 + 4 + 1).
The method takes no arguments and returns an integer: the sum of the digits.
To isolate each of the digits in an integer number, use modulus division by 10. For example, 641 % 10 = 1. 
To remove a digit from an integer number, use integer division by 10. For example, 641 / 10 = 64. 
Therefore, to calculate the sum of the digits in an integer number, the logic that is described above can be put inside of a loop that executes 
until there are no longer any digits to remove from the integer number. Each iteration of the loop should take each isolated number and add it to a 
running total.
One final not about sumDigits, the value in the integer data member should not be changed.
*/
int  myInt::sumDigits()
{
	long long newNum = number;
	int sum = 0;
	
	while (newNum > 0)
	{
		sum += newNum % 10;
		newNum = newNum / 10;
	}
	
	cout << "Adding the digits result"<< right << setw(28) << sum << endl;
	return sum;
}

/*
This method will reverse the digits in the integer data member. 
For example, if an object contains an integer data member with the value 641, the method should return 146.
The method takes no argument and returns an integer that has a value equal to the reversed number.
To reverse the digits in a number, take advantage of the two properties that were described in the description of the sumDigits method. 
Namely, that modulus division by 10 can be used to isolate a number and integer division by 10 can be used to remove a number. 
The reversed number can then be calculated by using simple addition.
To start the process, initialize a variable (say reverseNum) to 0. This will be the variable that holds the reversed number. 
Inside of a loop that executes as long as the integer number has digits to be removed:
multiply reverseNum by 10
isolate a digit from the number
add the isolated digit to reverseNum
remove a digit from the number
For example, assuming the original value is 641, following the process described above results in:
*/
int myInt::reverse()
{	
	long long newNum = number;
    long long reverseNum = 0;
    
    
    while(newNum > 0)
    {
            reverseNum = reverseNum*10 + (newNum % 10);
            newNum = newNum/10;
    }
    cout << "Reversing the digits result "<< right << setw(24) << reverseNum << endl << endl;

    return reverseNum;
}

/*
This method will count the number of odd digits that are part of the value in the integer data member. 
It takes no argument and returns an integer: the count of the odd digits.
To count the number of odd digits in a number, take advantage of the two properties that have been used in the sumDigits and reverse methods.
The value in the integer data member should not be changed.
*/
int myInt::oddDigitCount()
{

	long long newNum = number;
    int oddDigits = 0;
    
    while (newNum > 0 )
    {
        if (newNum % 2==1)
        {
        	oddDigits++;
		}
	newNum = newNum/10;      
    }

	cout << "Odd digits"<< right << setw(42) << oddDigits << endl;
	return oddDigits;
}

/*
This method will count the number of even digits that are part of the value in the integer data member. 
It takes no argument and returns an integer: the count of the even digits.
To count the number of even digits in a number, take advantage of the two properties that have been used in the sumDigits and reverse methods.
The value in the integer data member should not be changed.
Note: zero is considered an even number.
*/
int myInt::evenDigitCount()
{
	
	long long newNum = number;
    int evenDigits = 0;
    
    while (newNum > 0 )
    {
        if (newNum % 2==0)
        {
        	evenDigits++;
		}
	newNum = newNum/10;      
    }

	cout << "Even digits"<< right << setw(41) << evenDigits << endl;
	return evenDigits;
}

/*
This method will count the number of zeroes that are part of the value in the integer data member. 
It takes no argument and returns an integer: the count of the zeroes.
To count the number of zeroes in a number, take advantage of the two properties that have been used in the sumDigits and reverse methods.
The value in the integer data member should not be changed.
*/
int myInt::zeroCount()
{
	long long newNum = number;
    int zeros = 0;
    
    while (newNum > 0 )
    {
        if (newNum %10 ==0)
        {
        	zeros++;
		}
	newNum = newNum/10;      
    }

	cout << "Zeroes"<< right << setw(46) << zeros << endl;
	return zeros;
}
