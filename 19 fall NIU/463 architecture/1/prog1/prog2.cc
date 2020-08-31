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
bool isEven(string s);
void processLinePairs(string v1, string v2);
string computeSumAndIsEven(string v1, string v2);
int fullAdder(int a1, int a2, int *carryIn);
string find2sComplement(string v1);

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
  string even1 = isEven(v1)?"even " : "odd  ";
  string even2 = isEven(v2)?"even " : "odd  ";

  string sumStr = computeSumAndIsEven(v1,v2);
  string evenSumStr = isEven(sumStr)?"even " : "odd  ";

  string twoComplement = find2sComplement(v2);
  string diffStr = computeSumAndIsEven(v1,twoComplement);
  string evenDiffStr = isEven(diffStr)?"even " : "odd  ";

  cout << "v1   " << even1 << v1 << endl;
  cout << "v2   " << even2 << v2 << endl;
  cout << "sum  " << evenSumStr << sumStr << endl;
  cout << "diff " << evenDiffStr << diffStr << endl;

  cout << endl ;
}

bool isEven(string s) {

  int total=0;
  for (int i = 0 ; i < (int)s.length(); i++) {
    if (s[i]=='1') total++;
  }
  return ( total % 2 == 0);
}

string computeSumAndIsEven(string v1,string v2){
  int carryIn = 0;
  string outStr(v1.length(),' ');

  for (int i = (int)v1.length()-1; i>=0;i--) {
    int a1 = v1[i] - '0';  // convert char to int
    int a2 = v2[i] - '0';
    int add = fullAdder(a1,a2,&carryIn);
    outStr[i] = (add==1)?'1':'0';   // construct the outStr one digit at a time
  }

  return outStr;
}

int fullAdder(int a1, int a2, int *carryIn) {
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
