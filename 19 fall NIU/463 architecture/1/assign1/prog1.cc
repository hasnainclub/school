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

using namespace std;

// Add your function prototypes here
void processLinePairs(string v1, string v2);
string computeSum(string v1, string v2, bool *signedO, bool *unsignedO);
string computeDiff(string v1, string v2, bool *signedO, bool *unsignedO);
int fullAdder(char c1, char c2, int *carryIn);
string find2sComplement(string v1);
bool isEven(string s);
bool isZeros(string v1);

// Driver code 
int main() 
{ 
  string v1, v2;
  
  ifstream in("testdata.txt");
  if(!in)
  {
    cout << "Cannot open input file.\n";
    return 1;
  }

  while(in.good())
  {
    getline(in, v1);  // delim defaults to '\n aka end of line'
    if (v1 == "") break;
    getline(in, v2);

    processLinePairs(v1,v2);

  }

  in.close();
  return 0;
}

void processLinePairs(string v1,string v2){
  string even1 = isEven(v1)?"even    " : "odd     ";
  string even2 = isEven(v2)?"even    " : "odd     ";

  bool sumU = 0;
  bool sumS = 0; 
  string sumStr = computeSum(v1,v2,&sumS,&sumU);
  string evenSumStr = isEven(sumStr)?"even " : "odd  ";
  bool sumZ = isZeros(sumStr);

  string sumSStr = (sumS)?"S":" ";
  string sumUStr = (sumU)?"U":" ";
  string sumZStr = (sumZ)?"Z":" ";

  bool diffU = 0; 
  bool diffS = 0; 
  string diffStr = computeDiff(v1,v2,&diffS,&diffU);
  string evenDiffStr = isEven(diffStr)?"even " : "odd  ";
  bool diffZ = isZeros(diffStr);

  string diffSStr = (diffS)?"S":" ";
  string diffUStr = (diffU)?"U":" ";
  string diffZStr = (diffZ)?"Z":" ";

  cout << "v1   " << even1 << " " << v1 << endl;
  cout << "v2   " << even2 << " " << v2 << endl;
  cout << "sum  " << evenSumStr << sumSStr << sumUStr << sumZStr << " " <<  sumStr << endl;
  cout << "diff " << evenDiffStr << diffSStr << diffUStr << diffZStr << " " << diffStr << endl;

  cout << endl ;
}

bool isEven(string s) {

  int total=0;
  for (int i = 0 ; i < (int)s.length(); i++) {
    if (s[i]=='1') total++;
  }
  return ( total % 2 == 0);
}

string computeSum(string v1,string v2, bool *signedO, bool *unsignedO) {

  // initialize outStr with same length
  string outStr(v1.length(),' ');

  int carryIn = 0;
  int prevCarryIn;
  *signedO = 0;
  *unsignedO = 0;

  for (int i = (int)v1.length()-1; i>=0;i--) {
    prevCarryIn = carryIn;
    int add = fullAdder(v1[i],v2[i],&carryIn);
    outStr[i] = (add==1)?'1':'0';   // construct the outStr one digit at a time
  }

  // signed overflow status is set when the carry-out of the MSB is different from
  // the carry-in of the MSB
  if (prevCarryIn != carryIn) {
    *signedO = 1;
  }

  // unsigned overflow status is set when there is a carry-out of the MSB.
  if (carryIn == 1) {
    *unsignedO = 1;
  }

  return outStr;
}

string computeDiff(string v1,string v2, bool *signedO, bool *unsignedO) {

  // initialize outStr with same length
  string outStr(v1.length(),' ');

  int carryIn = 0;
  *signedO    = 0;
  *unsignedO  = 0;

  string twoComplement = find2sComplement(v2);

  for (int i = (int)v1.length()-1; i>=0;i--) {
    int add = fullAdder(v1[i],twoComplement[i],&carryIn);
    outStr[i] = (add==1)?'1':'0';   // construct the outStr one digit at a time
  }

  // for diff, unsigned overflow status will be set when there is not a carry-out of the MSB.
  if (carryIn == 0) {
    *unsignedO = 1;
  }

  return outStr;
}

int fullAdder(char c1, char c2, int *carryIn) {
  int a1 = c1 - '0';  // convert char to int for arithmetic
  int a2 = c2 - '0';
  if ((*carryIn + a1 + a2) == 3) {
    *carryIn = 1;
    return 1;
  }
  else if ((*carryIn + a1 + a2) == 2) {
    *carryIn = 1;
    return 0;
  }
  else if ((*carryIn + a1 + a2) == 1) {
    *carryIn = 0;
    return 1;
  }
  else {
    *carryIn = 0;
    return 0;
  }
}

string find2sComplement(string v1){
  bool oneFound = 0;
  string outStr(v1.length(),' ');
  for (int i = (int)v1.length()-1; i>=0;i--) {
    if (v1[i] == '1') {
      if (oneFound) {
        outStr[i] = (v1[i] == '1')?'0':'1';
      }
      else {
        outStr[i] = v1[i];
      }
      oneFound = 1;
    }
    else {
      if (oneFound) {
        outStr[i] = (v1[i] == '1')?'0':'1';
      }
      else {
        outStr[i] = v1[i];
      }
    }
  }
  return outStr;
}

bool isZeros(string v1) {
  for (int i = (int)v1.length()-1; i>=0;i--) {
    if (v1[i] == '1') {
      return 0;
    }
  }
  return 1;
}
