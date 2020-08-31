/*********************************************************************
   PROGRAM:    CSCI 340 Assignment 1
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   Sep 6 2018

   FUNCTION:   For this computer assignment, you are to write a C++ program to generate random
integers in the range [ LOW = 1, HIGH = 10000 ] and to store them in a vector <
int > of size VEC_SIZE = 250. Then, sort the contents of the vector (in ascending
order) and display it on stdout.
*********************************************************************/  

//all #include's and using stuff inside the main header.
#include "prog1.h"


int  main()
{
	//make vector
	vector<int> vect;
	
	//generate random numbers and store in vector, remember to pass as reference as we're changing crap inside the vector and not just copy 
	genRndNums (vect);
	


	//test print
	//printVec (vect);
	
	// now sort
	sort(vect.begin(), vect.end());
	//now print
	printVec (vect);
	//bam done, A+ 
	return 0;
}

/*
 : This routine generates
VEC_SIZE integers and puts them in vector v. Initializes the random number
generator (RNG) by calling the function srand ( SEED ) with the seed value
SEED = 1 and generates random integers by calling the function rand ( )
*/
void genRndNums ( vector < int >& v )
{
	srand(1); //srand(time(NULL)); they want seed value of 1
	//int a = rand() % 20 + 1; //1 to 20    
	
	int VEC_SIZE = 250;
	int HIGH = 10000;
	int LOW = 1;
	
	for (int i =0; i < VEC_SIZE; i++){
        int a = rand() % HIGH + LOW;
        v.push_back(a);
    }
}

/*
: This routine displays the
contents of vector v on stdout, printing exactly NO_ITEMS = 12 numbers on
a single line, except perhaps the last line. The sorted numbers need to be properly
aligned on the output. For each printed number, allocate ITEM_W = 5 spaces
on stdout.

*/
void printVec (const vector<int> &v)
{

	int NO_ITEMS = 12;
	int ITEM_W = 5;
		
	for (unsigned i = 0; i<v.size(); ++i)
	{
		cout << setw(ITEM_W) << v[i];
		if ((i+1) % NO_ITEMS == 0)
		{
			cout << endl;
		}
	}
		
		
	
	/*
	vector<int>::const_iterator it;
	for ( it = v.begin(); it < v.end(); ++it ) {
	cout << setw(5)<<*it;
	}	 
	
	*/

    
}
