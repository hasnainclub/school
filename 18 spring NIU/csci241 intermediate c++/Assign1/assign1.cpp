/*********************************************************************
   PROGRAM:    CSCI 241 Assignment 1
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   SECTION: 3
   TA: Bhavana Mallineni
   DUE DATE:   Feb 1 2018
 
   FUNCTION:   This program tests functions for manipulating C 
               strings.
*********************************************************************/

#include <iostream>
#include <cstring>
#include <cctype>
#include <iomanip>

using std::cin;
using std::cout;
using std::endl;

using namespace std;


// Add your function prototypes here
bool equals(const char*, const char*);
bool equalsIgnoreCase(const char*, const char*);
int indexOf(const char*, char);
int lastIndexOf(const char*, char);
bool startsWith(const char* str, const char* prefix);
bool endsWith(const char* str, const char* suffix);



int main()
   {
   int index;
   
      // Tests 1a - 1d: Test the equals() function
   cout << "Test 1a: ";
   if (equals("catapult", "catapult"))
      cout << "correct\n";
   else
      cout << "incorrect\n";
      
   cout << "Test 1b: ";
   if (!equals("catapult", "catamaran"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << "Test 1c: ";
   if (!equals("cat", "catamaran"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << "Test 1d: ";
   if (!equals("catapult", "cat"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << endl;

   // Tests 2a - 2d: Test the equalsIgnoreCase() function
   cout << "Test 2a: ";
   if (equalsIgnoreCase("catapult", "CATAPULT"))
      cout << "correct\n";
   else
      cout << "incorrect\n";
      
   cout << "Test 2b: ";
   if (!equalsIgnoreCase("catapult", "Catamaran"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << "Test 2c: ";
   if (!equalsIgnoreCase("Cat", "Catamaran"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << "Test 2d: ";
   if (!equalsIgnoreCase("Catapult", "Cat"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << endl;
   
   // Tests 3a - 3d: Test the indexOf() function
   cout << "Test 3a: ";
   index = indexOf("adamant", 'a');
   if (index == 0)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not 0\n";

   cout << "Test 3b: ";
   index = indexOf("adamant", 'm');
   if (index == 3)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not 3\n";

   cout << "Test 3c: ";
   index = indexOf("adamant", 't');
   if (index == 6)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not 6\n";

   cout << "Test 3d: ";
   index = indexOf("adamant", 'x');
   if (index == -1)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not -1\n";

   cout << endl;

   // Tests 4a - 4d: Test the lastIndexOf() function
   cout << "Test 4a: ";
   index = lastIndexOf("adamant", 't');
   if (index == 6)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not 6\n";

   cout << "Test 4b: ";
   index = lastIndexOf("adamant", 'm');
   if (index == 3)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not 3\n";

   cout << "Test 4c: ";
   index = lastIndexOf("adamant", 'a');
   if (index == 4)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not 4\n";

   cout << "Test 4d: ";
   index = lastIndexOf("adamant", 'x');
   if (index == -1)
      cout << "correct\n";
   else
      cout << "incorrect - index returned was " << index << ", not -1\n";

   cout << endl;

   // Tests 5a - 5c: Test the startsWith() function
   cout << "Test 5a: ";
   if (startsWith("your house", "your"))
      cout << "correct\n";
   else
      cout << "incorrect\n";
      
   cout << "Test 5b: ";
   if (!startsWith("my house", "your"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << "Test 5c: ";
   if (!startsWith("you", "your"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << endl;

   // Tests 6a - 6c: Test the endsWith() function
   cout << "Test 6a: ";
   if (endsWith("your house", "house"))
      cout << "correct\n";
   else
      cout << "incorrect\n";
      
   cout << "Test 6b: ";
   if (!endsWith("your mouse", "house"))
      cout << "correct\n";
   else
      cout << "incorrect\n";

   cout << "Test 6c: ";
   if (!endsWith("use", "house"))
      cout << "correct\n";
   else
      cout << "incorrect\n";


double golden = 1.618;
double* goldenPtr = &golden;

cout << goldenPtr << endl;
   }

// Add your function definitions here

//compares the C string str1 to the C string str2. Two C strings are considered equal if they are of the same length and corresponding characters 
//in the two strings are equal.
bool equals(const char* str1, const char* str2)
{
	//if str1 is not equal to str2 return false
	if(strlen(str1) != strlen (str2))
		return false;
	//make a for loop and check each character, i can be < str2 as str1 and str2 have same length so doesn't matter to check for larger
	//so those two will check for two false categories, remaining is true..  so duh!
	else
	{
	for (unsigned i = 0; i < strlen(str2); i++)
		{ 
		  if (str1[i] != str2[i])
	      return false;
       }
	}
	//else
return true;
}


//Compares the C string str1 to the C string str2, ignoring case considerations. 
//Two C strings are considered equal ignoring case if they are of the same length and corresponding characters in the two 
//strings are equal ignoring case.
bool equalsIgnoreCase(const char* str1, const char* str2)
{
	//if str1 is not equal to str2 return false
	if(strlen(str1) != strlen (str2))
		return false;
	//make a for loop and check each character, i can be < str2 as str1 and str2 have same length so doesn't matter to check for larger
	// also make everything same case up/lowwer
	//so those two will check for two false categories and then we have to make all stuff lower/upper chose 1, remaining is true..  so duh!
	else
	{
	for (unsigned i = 0; i < strlen(str2); i++)
		{ 
		  if (toupper(str1[i]) != (toupper(str2[i])))
	      return false;
       }
	}
	//else
return true;
}


//Returns the index within the C string str of the first occurrence of the character ch. 
//If no such character occurs in the string, then -1 is returned.
int indexOf(const char* str, char ch)
{
	//set index value to 0 and then keep incrementing it, then remember to subract 1 if nothing is found. 
	
		for (int index = 0; index < strlen(str); index++)
		{ 
		  if (str[index] == ch)
	      return index;
       }
	
//default return is -1
return -1;
}

//Returns the index within the C string str of the last occurrence of the character ch. 
//If no such character occurs in the string, then -1 is returned.
int lastIndexOf(const char* str, char ch)
{
		//set index value to max value of str and then keep decrementing it, remember default if not found 	
		for (int index = strlen(str); index > 0; index--)
		{ 
		  if (str[index] == ch)
	      return index;
       }
	return -1;
}

//Tests if the C string str starts with the specified prefix, the C string prefix.
bool startsWith(const char* str, const char* prefix)
{
	//default return type
	bool returnType = true;
	
	//set the for loop to go until the length of prefix, then check each letter starting for index 0 (as it's first and prefix is first)
	//if anything is differnet in the prefix than what found, then change the return type. 
	for (int i = 0; i < strlen(prefix); i++)
	{
		if (str[i] != prefix[i])
			returnType = false;
	}
	//default return is true
return returnType;
}

//Tests if the C string str ends with the specified suffix, the C string suffix
bool endsWith(const char* str, const char* suffix)
{
	//default return type
	bool returnType = true;
	
	//set indexes for suffix and name of the word (string)
	int strIndex = strlen(str);
	int suffixIndex = strlen(suffix);
	
	//now check the last letter of each word string and prefix.  and do it for all the numbers of letters in suffix. 
	//going backwards, go until suffix is greater than 0
	for ( ; suffixIndex > 0; )
	{
		strIndex --;
		suffixIndex--;
		
		if (str[strIndex] != suffix[suffixIndex])
			returnType = false;
	}
	//default return is true
return returnType;
}
