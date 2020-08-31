/*********************************************************************
   PROGRAM:    CSCI 463 Assignment 1
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   Sep 24 2019
 
   FUNCTION:   This program adds and subtracts binary with some flags
*********************************************************************/

#include <iostream> // io to screen
#include <fstream> //io files
#include <cstring> //strlen function
#include <string>
#include <sstream>


using namespace std; 
// Add your function prototypes here
string isEven(string v);
string findTwoscomplement(string str);
string fullAdder(string, string, string&, string&);



// Driver code 
int main() 
{ 
	string v1, v2, sum, diff, numOnes;
	
	string carryIn = "0";
		string* inPtr = &carryIn;
	string carryOut = "0";
		string* outPtr = &carryOut;

	ifstream in("testdata");
	if(!in) 
	{
    cout << "Cannot open input file.\n";
    return 1;
	}
		
	while(in.good())
	{
	    getline(in, v1);  // delim defaults to '\n aka end of line'
	    getline(in, v2);
	    
	    if (v1 == "")
			 break; // Skip blank line
	    //print Statement
		cout <<	"v1    " << isEven(v1) << "      " << v1 <<endl;
		cout <<	"v2    " << isEven(v2) << "      " << v2 <<endl;
		/*****************************************************************/
		/*
		int max = v1.length();
		//find total number of 1's 
		
		
		for (int i = 0 ; i < max; i++)
		{
			sum = fullAdder(v1, v2, *inPtr, *outPtr);
		} */
		inPtr = outPtr;
		sum= fullAdder(v1, v2, *inPtr, *outPtr);
		
	//	cout << "inPtr is: " << *inPtr << endl << endl << endl;	
	//	cout << "outPtr is: " << *outPtr << endl << endl << endl;		
		
		cout <<	"sum       " << /*isEven(sum) << */"      " << sum.c_str() << endl;
	//	cout <<	"diff  " <<  "               " 				<< endl << endl;
		cout << endl;
	
		
		v1.clear();
		v2.clear();
		
	//	delete sum.c_str();
		sum.clear();
		sum.erase();
		
		diff.clear();
		
		numOnes.clear();
		}  
		in.close();
	    
	

    return 0;
} 


string isEven(string v) 
{ 
	string isEven = "even";
	int total=0;
	
	int max = v.length();
	
	//find total number of 1's
	for (int i = 0 ; i < max; i++)
	{
		//cout << v[i];
		if (v[i] == '1')
		{
			total ++;
		}
	}
//	cout << "total is  " << total << endl;
    //is the total odd or even?
    if ( total % 2 == 0)
    {
	}
	else
	{
		isEven = "odd ";
	}
	return isEven;
}

// Function to find two's complement 
string findTwoscomplement(string str) 
{ 
    int n = str.length(); 
  
    // Traverse the string to get first '1' from 
    // the last of string 
    int i; 
    for (i = n-1 ; i >= 0 ; i--) 
        if (str[i] == '1') 
            break; 
  
    // If there exists no '1' concatenate 1 at the 
    // starting of string 
    if (i == -1) 
        return '1' + str; 
  
    // Continue traversal after the position of 
    // first '1' 
    for (int k = i-1 ; k >= 0; k--) 
    { 
        //Just flip the values 
        if (str[k] == '1') 
            str[k] = '0'; 
        else
            str[k] = '1'; 
    } 
  
    // return the modified string 
    return str;
} 

//full adder function
string fullAdder(string a, string b, string& inPtr, string& outPtr)
{
	
	string result;// = ""; // Initialize result 
 //   int s = 0;          // Initialize digit sum 
    int max = a.length();
    
  //	inPtr = '1';
  //	outPtr = inPtr;
  	/*
  	A | B | Cin | Cout | S
	0 | 0 |  0  |   0  | 0
	0 | 0 |  1  |   0  | 1
	0 | 1 |  0  |   0  | 1
	0 | 1 |  1  |   1  | 0
	1 | 0 |  0  |   0  | 1
	1 | 0 |  1  |   1  | 0
	1 | 1 |  0  |   1  | 0
	1 | 1 |  1  |   1  | 1 */
	

  	for (int i = max-1; i >= 0; i--)
  	{ 
  	//	cout << "a[i] is:  " << a[i] << " b[i] is:  "<< b[i] << " inPtr[0] is:  " << inPtr[0]<< endl;
  	//	s=0;
  //		cout << "intPtr =" << inPtr << endl;
  		if (a[i] == '0' && b[i] == '0' && inPtr[0] == '0')
  		{
  		//	s = 0;
  			outPtr = '0';
  			result[i] = char('0');
  			result[i] = '0';
		}
		else if (a[i] == '0' && b[i] == '0' && inPtr[0] == '1')
		{
	//		s = 0;
  			outPtr = '0';
  			result[i] = '1';
		}
		else if (a[i] == '0' && b[i] == '1' && inPtr[0] == '0')
		{
	//		s = 1;
  			outPtr = '0';
  			result[i] = ('1');
		}
		else if (a[i] == '0' && b[i] == '1' && inPtr[0] == '1')
		{
	//		s = 2;
  			outPtr = '1';
  			result[i] = ('0');
		}
		else if (a[i] == '1' && b[i] == '0' && inPtr[0] == '0')
		{
	//		s = 1;
  			outPtr = '0';
  			result[i] = ('1');
		}
		else if (a[i] == '1' && b[i] == '0' && inPtr[0] == '1')
		{
	//		s = 2;
  			outPtr = '1';
  			result[i] = ('0');
		} 
		else if (a[i] == '1' && b[i] == '1' && inPtr[0] == '0')
		{ 
	//		s=2;
			outPtr = '1';
			result[i] = ('0');
		} 				
		else if (a[i] == '1' && b[i] == '1' && inPtr[0] == '1')
		{
	//		s = 3;
  			outPtr = '1';
  			result[i] = ('1');
		}
		else 
		{  
			cout << "incorrect data" << endl;
		}
		
//		cout << "i = " << i << endl;
//		cout << "result[i] " << result[i] << endl;//<< ", i = " << i <<endl;
//		cout << "result is " << result << endl;
//		cout << "outPtr =" << outPtr << endl << endl; 

		
//		inPtr = outPtr;
		
//		cout << "value of s     is: " << char(s + '0') << endl;
//	    cout << "value of s % 2 is: " << char(s % 2 + '0') << endl;
	    
	    
	    
//		result = char(s % 2 + '0') + result;

		
		
//		cout << "intPtr =" << inPtr << endl;
//		cout << "outPtr =" << outPtr << endl << endl;
	//	outPtr = '0';
	
	}
	/*
	if(result.length() == a.length() + 1)
        {
        //	outPtr = 1;
          	result = result.substr(1);
          	return result.c_str();
		} */
 // 	cout << "                "<<result.c_str()-1 << endl;
	
    return result; //result.c_str(); 
}
