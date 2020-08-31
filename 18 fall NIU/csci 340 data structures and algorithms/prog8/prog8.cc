/*
 NAME: Hasnain Attarwala
 ASSIGNMENT: 8
DUE: 11/16/2018
*/

#include "/home/cs340/progs/18f/p8/prog8.h"
//#include "prog8.h"
#include <iomanip> 

int main ( )
{	// part given to us
    vector < int >    v1;   // heap of integers
    vector < float >  v2;   // heap of floating-pt nums
    vector < string > v3;   // heap of strings

    // print header message
    cout << "\t\t\t*** CSCI 340: Program 8 - Output ***\n\n";

    // first heap

    cout << "first heap - ascending order:\n\n"; 
    get_list ( v1, D1 ); 
    construct_heap ( v1, less < int > ( ) ); 
    print_list < int > print1 ( v1.size ( ), INT_SZ, INT_LN ); 
    for_each ( v1.begin ( ), v1.end ( ), print1 );

    cout << "first heap - descending order:\n\n";
    get_list ( v1, D1 );
    construct_heap ( v1, greater < int > ( ) );
    for_each ( v1.begin ( ), v1.end ( ), print1 ); 

    // second heap

    cout << "second heap - ascending order:\n\n";
    get_list ( v2, D2 );
    construct_heap ( v2, less < float > ( ) );
    print_list < float > print2 ( v2.size ( ), FLT_SZ, FLT_LN );
    for_each ( v2.begin ( ), v2.end ( ), print2 );

    cout << "second heap - descending order:\n\n";
    get_list ( v2, D2 );
    construct_heap ( v2, greater < float > ( ) );
    for_each ( v2.begin ( ), v2.end ( ), print2 );

    // third heap

    cout << "third heap - ascending order:\n\n";
    get_list ( v3, D3 );
    construct_heap ( v3, less < string > ( ) );
    print_list < string > print3 ( v3.size ( ), STR_SZ, STR_LN );
    for_each ( v3.begin ( ), v3.end ( ), print3 );

    cout << "third heap - descending order:\n\n";
    get_list ( v3, D3 );
    construct_heap ( v3, greater < string > ( ) );
    for_each ( v3.begin ( ), v3.end ( ), print3 );
 
    // print termination message
    cout << "\t\t\t*** end of program execution ***\n\n";
    return 0;
}
    // opens input file for reading & inserts items into vector
template <class T>
void get_list ( vector <T>& v, const char* path )
{
	v.clear();
	T temp;                     // Temp data to read into
	ifstream inFile;
	inFile.open( path );        // Open file
	if (!inFile)
	{
		cout << "Error, Unable to open file." << endl;
		exit(1);
	}
	inFile >> temp;             // Read first entry
	while (!inFile.eof())       //read in until end of file
	{
		v.push_back(temp);      // Insert in vector
		inFile >> temp;         // read next entry
	}
	inFile.close();            // Close file
}

// construct heap while comparing elements with pred
template <class T, class P>
void construct_heap ( vector <T>& v, P pred )
{
	make_heap(v.begin(), v.end(), pred);
	sort_heap(v.begin(), v.end(), pred);
}

/*
The constructor of the
print_list class, where s is the heap size, w is the minimum number of chars
written in printout, l is the maximum number of items printed in a single line,
and c is used as a counter with the default value 0 that can be used to insert the
newline characters in printout.
*/
template < class T > 
print_list < T > :: print_list ( const unsigned& s, const
unsigned& w, const unsigned& l, const unsigned& c )
{
	sz = s;
	wid = w;
	len = l;
	cnt = c;
}
/*
It can be used to print the item x of a heap on stdout. For proper printout, insert the
following statements at the beginning of this function:

*/
template < class T > 
void print_list < T > :: operator ( ) ( const T& x )
{
	/*
	sz,  // heap size
             wid, // min num of chars written in printout
             len, // max num of items printed in single line
             cnt; // counter for printout
	*/
	
	cout.width ( wid ); cout.precision ( 2 );
	cout << fixed << showpoint;
	
	if ( cnt <= sz )
	{
		if (cnt % len == 0)
		{
			cout << endl;
		}
		cout << fixed << setprecision(2) << setw(wid) << x << " ";
		cnt++;
	}
	if (cnt == sz)
		cout << endl << endl;
}
