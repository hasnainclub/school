/*********************************************************************
   PROGRAM:    CSCI 241 Assignment 8
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   04/26/2018

   FUNCTION:   This is a file for the protoypes and function definitions
               for quick sorting part of the template classes
*********************************************************************/
#ifndef QUICKSORT_H
#define QUICKSORT_H

using namespace std;

//prototype
template <class T>
void quickSort(vector<T>&, bool (*compare)(const T&, const T&));
template <class T>
void quickSort(vector<T>&, int, int, bool (*compare)(const T&, const T&));
template <class T>
int partition(vector<T>&, int, int, bool (*compare)(const T&, const T&));

//function definition
/***************************************************************
Function: quickSort

Use: sorts the vector object using the quick sort algorithim

Arguments: set,boollean value

Returns: none

Note:
***************************************************************/
template <class T>
void quickSort(vector<T>& set, bool (*compare)(const T&, const T&)){
quickSort(set, 0, set.size()-1, compare);
}

/***************************************************************
Function: quickSort

Use: recursivly calles the quick sort algorthim

Arguments: set, start, end, boollean value

Returns: none

Note:
***************************************************************/
template <class T>
void quickSort(vector<T>& set, int start, int end, bool (*compare)(const T&, const T&)){
int pivotPoint;

if(start < end){
pivotPoint = partition(set, start, end, compare);
quickSort(set, start, pivotPoint - 1, compare);
quickSort(set, pivotPoint + 1, end, compare);
}
}

/***************************************************************
Function: partition

Use: allows us to pivot around an element and the partitions the
vector around the piviot

Arguments: set,start,end,booleanvalue

Returns: pivotIndex

Note:
***************************************************************/
template <class T>
int partition(vector<T>& set, int start, int end, bool (*compare)(const T&, const T&)){
int pivotIndex, mid;
T pivotValue;

mid = (start + end) / 2;

swap(set[start], set[mid]);

pivotIndex = start;
pivotValue = set[start];

for(int scan = start + 1; scan <= end; scan++){
  if(compare(set[scan], pivotValue)){
    pivotIndex++;
    swap(set[pivotIndex], set[scan]);
  }
}
swap(set[start], set[pivotIndex]);

return pivotIndex;
}

#endif /*QUICKSORT_H*/
