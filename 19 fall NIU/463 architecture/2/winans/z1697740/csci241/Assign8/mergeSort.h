
/*********************************************************************
   PROGRAM:    CSCI 241 Assignment 8
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   04/26/2018

   FUNCTION:   This is a file for the protoypes and function definitions
               for merge sorting part of the template classes
*********************************************************************/
#ifndef MERGESORT_H
#define MERGESORT_H

//prototype
template <class T>
void mergeSort(vector<T>&, bool (*compare)(const T&, const T&));
template <class T>
void mergeSort(vector<T>&, int, int, bool (*compare)(const T&, const T&));
template <class T>
void merge(vector<T>&, int, int, int, bool (*compare)(const T&, const T&));

//function defintions
/***************************************************************
Function: mergeSort

Use: sorts the vecotr object using the merge sort algorithim

Arguments: set,boollean value

Returns: none

Note:
***************************************************************/
template <class T>
void mergeSort(vector<T>& set, bool (*compare)(const T&, const T&)){
mergeSort(set, 0, set.size()-1, compare);
}

/***************************************************************
Function: mergeSort

Use: divides the vector into two subvectors then merges the two
sorted subvectors

Arguments: set, low, high, boollean value

Returns: none

Note:
***************************************************************/
template <class T>
void mergeSort(vector<T>& set, int low, int high, bool (*compare)(const T&, const T&)){
int mid;

if(low < high){
mid = (low + high) / 2;
//divide and conquer
mergeSort(set, low, mid, compare);
mergeSort(set, mid+1, high, compare);
//combine
merge(set, low, mid, high, compare);
}
}

/***************************************************************
Function: merge

Use: merges the two sorted sub vectors

Arguments: set, low, mid, high, boollean value

Returns: none

Note:
***************************************************************/
template <class T>
void merge(vector<T>& set, int low, int mid, int high, bool (*compare)(const T&, const T&)){
// Create temporary vector to hold merged subvectors
vector<T> temp(high - low + 1);

int l = low;      // Subscript for start of left sorted subvector
int m = mid+1;    // Subscript for start of right sorted subvector
int k = 0;        // Subscript for start of merged vector

// While not at the end of either subvector
while (l <= mid && m <= high){
  if (compare(set[m], set[l])){
    temp[k] = set[m];
    m++;
    k++;
    }
  else{
    temp[k] = set[l];
    l++;
    k++;
    }
}
   // Copy over any remaining elements of left subvector
   while (l <= mid){
      temp[k] = set[l];
      l++;
      k++;
      }

   // Copy over any remaining elements of right subvector
   while (m <= high){
      temp[k] = set[m];
      m++;
      k++;
      }

   // Copy merged elements back into original vector
   for (l = 0, m = low; m <= high; l++, m++)
      set[m] = temp[l];
}
#endif /*MERGESORT_H*/

