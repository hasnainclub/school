
/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: Friday, October 21 by 11:59 PM

Purpose:Functions, switch, and Character Processing
***************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime>
#include <fstream>
using namespace std;

//function prototypes
bool isspecial(char);
char changeLower(char);
char changeUpper(char);
char changePunct(char);
char changeDigit(char);
char changeSpecial(char);
int characterCount(int); //extraCredit

int main()
{
	//Create variable to store input file
	ifstream infile; 
	
	//Open the input file and make sure that it opened correctly
	//open file
	infile.open( "encoded_quotes.txt" );
	//if input file fails to open stop execution of program and display a msg; exit, stops program
	if(infile.fail())
  	{
  	cout << "input file did not open" << endl;
  	exit(-1);
  	}
  	
//Read the first character from the input file
	char ch;
	infile >> ch;
	
		//ExtraCredit
int alphabeticcharactersCount = 0, digitCharactersCount = 0,  punctuationCharactersCount = 0, whitespaceCharactersCount = 0, characters;
	
//while there are characters in the file
	while(infile) 
	{
		char decodedChar = ch;
				
   /*  //Process the character by decoding it. A cascading if statement should
      //be used to test the "type" of character (upper case, lower case, digit,
     //punctuation, or special character) and call the appropriate decoding
    //function to change the character to its original value */
  
  	if (isalpha(ch))
  	{
  		if (isupper(ch))
  		{
  		decodedChar = changeUpper(ch);
  		alphabeticcharactersCount++;
		}
		else if (islower(ch))
  		{
  		decodedChar = changeLower(ch);
  		alphabeticcharactersCount++;
		}
	}
	
	if (ispunct(ch))
  	{
  		decodedChar = changePunct(ch);
  		digitCharactersCount++;
	}
	
	if (isdigit(ch))
  	{
  		decodedChar = changeDigit(ch);
  		punctuationCharactersCount++;
	}
	if  (isspecial(ch) == true)
	{
	 	decodedChar = changeSpecial (ch);
	 	whitespaceCharactersCount++;
	}
	

	
   //Display the decoded character
   cout << decodedChar;

   //Read the next character from the input file
   		infile >> ch;
   	
	//end of while loop
	}
	
//Close the input file
infile.close();

//ExtraCredit
//calculate total characters
characters = alphabeticcharactersCount + digitCharactersCount +  punctuationCharactersCount + whitespaceCharactersCount;
cout << endl << endl << endl;
cout << "Characters              = " << characters << endl;
cout << "Alphabets               = "  << alphabeticcharactersCount << endl;
cout << "Digits                  = " << digitCharactersCount << endl;
cout << "Punctuations            = " << punctuationCharactersCount << endl;
cout << "New line & white spaces = " <<  whitespaceCharactersCount << endl;
cout << "--------------" << endl;
cout << "A Christmas Story (1983)";
return 0;
system ("pause"); //pausing for debugging
}

/*This function will be called to test if the passed in character is a special character (ie. is the ASCII value for the character 20 or 22?). 
It takes a single character as its argument: the character to be tested. It returns a boolean value. If the passed in character is one of the two special 
characters, the function should return true. If the passed in character is not one of the two special characters, the function should return false.
*/
bool isspecial(char ch)
{
	if (ch == 20 || ch == 22)
	{
		return true;
	}
	else
	{
		return false; 
	}		
}

/*This function will be called for any character that is a lowercase character. It takes a single character as its argument: the character to be decoded. 
It returns a character: the decoded character.
The function should reverse the process that was detailed in #1 of the Encoding Process above by converting the passed in character to uppercase and adding 1, 
so that, for example, 'd' becomes 'E'. However, there is the one exception to the rule: 'z' should become 'A'.
*/
char changeLower(char ch)
{
	if (ch == 'z' )
	{
		ch = 'A';
	}
	else
	{
	ch = (toupper(ch)) + 1;
	}
	
	return ch;
}

/*This function will be called for any character that is an uppercase character. It takes a single character as its argument: the character to be decoded. 
It returns a character: the decoded character.
The function should reverse the process that was detailed in #2 of the Encoding Process above by converting the passed in character 
to lowercase and subtracting 1, so that, for example, 'D' becomes 'c' and 'E' becomes 'd'. However, there is the one exception to the rule: 
'A' should become 'z'.
*/
char changeUpper(char ch)
{
	if (ch == 'A' )
	{
		ch = 'z';
	}
	else
	{
	ch = (tolower(ch)) - 1;
	}
	
	return ch;
}

/*This function will be called for any character that is a punctuation symbol 
(in C++, that is all type-able characters that are not letters, digits, or whitespace). It takes a single character as its argument: 
the character to possibly be decoded. It returns a character: the decoded character or the original passed in character.
The function should use a switch statement to check for each of the punctuation symbols that were detailed in #3 of the Encoding Process above and 
convert the passed in character to its original version, so that, for example, '&' becomes '7' or '@' becomes '2'. Don't forget that if the punctuation 
symbol is not listed above, it should be returned unchanged.
*/
char changeDigit(char ch)
{
	switch (ch)
	{
		case '0':
			ch  = ')';
			break;
		
		case '1':
			ch  = '!';
			break;
			
		case '2':
			ch  = '@';
			break;
			
		case '3':
			ch  = '#';
			break;
			
		case '4':
			ch  = '$';
			break;
			
		case '5':
			ch  = '%';
			break;
			
		case '6':
			ch  = '^';
			break;
			
		case '7':
			ch  = '&';
			break;
			
		case '8':
			ch  = '*';
			break;
			
		case '9':
			ch  = '(';
			break;
		default:
			return ch;
	}
	return ch;
}

/*
This function will be called for any character that is a digit character. It takes a single character as its argument: the character to be decoded. 
It returns a character: the decoded character.
The function should reverse the process that was detailed in #4 of the Encoding Process above by converting the passed in character to its 
original value, so that, for example, '6' becomes ';' and '2' becomes ')'.
*/
char changePunct(char ch)
{
	switch (ch)
	{
		case ',':
			ch  = '9';
			break;
		
		case '"':
			ch  = '8';
			break;
			
		case '!':
			ch  = '7';
			break;
			
		case ';':
			ch  = '6';
			break;
			
		case '?':
			ch  = '5';
			break;
			
		case '\'':
			ch  = '4';
			break;
			
		case '(':
			ch  = '3';
			break;
			
		case ')':
			ch  = '2';
			break;
			
		case '.':
			ch  = '1';
			break;
			
		case '-':
			ch  = '0';
			break;
		default:
			return ch;
	}
	return ch;
}



/*
This function will be called for any character that is not an uppercase, lowercase, digit, or punctuation character. 
It takes a single character as its argument: the character to possibly be decoded. It returns a character: the decoded character or the 
original passed in character.
The function should reverse the process that was detailed in #5 of the Encoding Process above by only changing the passed in character 
if it has ASCII value 20 or 22. If the passed in character has an ASCII value of 20, then it will return a newline character. If the passed in 
character has ASCII value 22, then it will return a space character. Anything else will be returned unchanged.
*/
char changeSpecial(char ch)
{
	if (ch == 20)
	{
		ch = '\n';
		return ch;
	}
	else if (ch == 22)
	{
		ch = ' ';
		return ch;
	}
		
	return ch;
}

/*
Extra credit.  Caluculate number of characters passed through it. 
*/
int characterCount(int)
{
	
}
