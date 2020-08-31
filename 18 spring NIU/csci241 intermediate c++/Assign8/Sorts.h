
/*********************************************************************
   PROGRAM:    CSCI 241 Assignment 8
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   04/26/2018

   FUNCTION:   This is a file for the protoypes and method definitions
               for sorting part of the template classes
*********************************************************************/
#ifndef SORTS_H
#define SORTS_H
#include <fstream>

using namespace std;

//prototype
template <class T>
void buildList(vector<T>&, const char*);
template <class T>
void printList(const vector<T>&, int, int);
template <class T>
bool lessThan(const T&, const T&);
template <class T>
bool greaterThan(const T&, const T&);

//function definitions
/***************************************************************
Function: buildList

Use: opens the files for use and puts them into the vector object

Arguments: set,filename

Returns: none

Note:
***************************************************************/
template <class T>
void buildList(vector<T>& set, const char* filename){
T item;
ifstream infile;

infile.open(filename);
if(!infile){
cout << "The input file did not open" << endl;
exit(1);
}
infile >> item;
while(infile){
set.push_back(item);
infile >> item;
}
infile.close();
}

/*******************************************************************
Function: printList

Use: uses the files and prints out the contents of the vector object

Arguments: set,itemWidth, numPerLine

Returns: none

Note:
*********************************************************************/
template <class T>
void printList(const vector<T>& set, int itemWidth, int numPerLine){
for(unsigned i = 0; i < set.size(); i++){
cout << setw(itemWidth) << right << set[i] << ' ';
  if((i+1) % numPerLine == 0)
  cout <<endl;
}
}

/***************************************************************
Function: lessThan

Use: compare the contents of the files to see which is less than 
the other

Arguments: item1,item2

Returns: boolean value

Note:
***************************************************************/
template <class T>
bool lessThan(const T& item1, const T& item2){
if(item1 < item2)
  return true;
else
  return false;
}

/***************************************************************
Function: greaterThan

Use: compare the contents of the files to see which is greater
than the other

Arguments: item1,item2

Returns: boolean value

Note:
***************************************************************/
template <class T>
bool greaterThan(const T& item1, const T& item2){
if(item1 > item2)
  return true;
else
  return false;
}

#endif /*SORTS_H*/

