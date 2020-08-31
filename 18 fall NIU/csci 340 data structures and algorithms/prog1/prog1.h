#ifndef PROG1_H // should not be defined any place else
#define PROG1_H // same const value as for ifndef directive

#include <iostream>
#include <iomanip> //for the setw stuff
#include <algorithm>    // std::sort
#include <vector>
/*
functions in the
Randomly Generated Integers
2
STL such as sort, insert the line #include <algorithm>
*/
#include <algorithm>

#include <cstdlib> //for the srand lib func
#include <time.h> //for time

using namespace std;

/*
 : This routine generates
VEC_SIZE integers and puts them in vector v. Initializes the random number
generator (RNG) by calling the function srand ( SEED ) with the seed value
SEED = 1 and generates random integers by calling the function rand ( )
*/
void genRndNums ( vector < int >& v );

/*
: This routine displays the
contents of vector v on stdout, printing exactly NO_ITEMS = 12 numbers on
a single line, except perhaps the last line. The sorted numbers need to be properly
aligned on the output. For each printed number, allocate ITEM_W = 5 spaces
on stdout.

*/
void printVec ( const vector < int >& v );

#endif
