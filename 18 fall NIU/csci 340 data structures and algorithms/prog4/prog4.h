#ifndef PROG4_H // should not be defined any place else
#define PROG4_H  //if not defined, then define

#include <iostream> //input output
#include<string> //we have strings 
#include <map> // in your header file, and to use the functions in the STL, you also need to insert the statement: 
#include <algorithm>
#include<fstream> //input out file
#include<iomanip> //for setw
//#include<cstdlib> //when file doesn't open exit
#include <cctype> //alnum in cleanentry 

const int NO_ITEMS = 16; //primes per line
const int ITEM_W = 4 ;//spaces allocated for each prime

using namespace std;

/*
: It gets a word from the input
stream and removes its punctuation marks.
*/
void get_words( map<string, int>& m);

/*: It prints the final list
of words and their frequencies. It also prints the number of nonempty
words and the number of distinct words in the input stream.*/
void print_words ( const map < string, int >& );

/*: It cleans a word from its
punctuation marks. The first argument is the original word in the input
stream and the second argument contains the same word after cleaning*/
void clean_entry ( const string&, string& );

void makeLowerCase(char& cleanedWordChar);

#endif //end
