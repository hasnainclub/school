#ifndef PROG3_H // should not be defined any place else
#define PROG3_H // same const value as for ifndef directive

#include <iostream>
#include <iomanip>
#include <set>
#include <iomanip> //for set w stuff

const int NO_ITEMS = 16; //primes per line
const int ITEM_W = 4 ;//spaces allocated for each prime

using namespace std;
void sieve ( set < int >& s, int n ); /*: This routine can be used to apply the
Sieve of Eratosthenes algorithm to remove all nonprime numbers from the
integer set s = { 2, 3, …, n }.
*/


void print_primes ( const set < int >& s ); /*: This routine can be used to
print the elements in the integer set s (NO_ITEMS = 16 primes per line
and ITEM_W = 4 spaces allocated for each prime). */


#endif

