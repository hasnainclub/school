/********************************************************************
 * CSCI 463 - Assignment 1 - Fall 2019
 *
 * Progammer: Elizabeth Harasymiw
 * Section:   
 * TA:        
 * Date Due:  09/24/2019 
 *
 * Purpose:   
 *
 *********************************************************************/

#include <iostream>
#include <fstream>
#include <string>

#define MAX_SIZE 512

using std::string;
using std::cout;
using std::endl;
using std::cin;

/**
 * Function to check and print the pairty of a binary number stored in a char*
 * (Number of 1's in a binary string)
 * @param num: the char* array
 * @param num_length: Length of the string stored in the char* 
 */
void printPairty(string num){
	//count number of 1's
	int count = 0;
	for(int i = 0; i < num.size(); i++){
		if(num[i] == '1')
			count++;
	}

	if((count % 2) == 0)
		cout << "even ";
	else
		cout << "odd  ";	
}

/**
 *
 */
void printFlags(bool signedOverflowFlag, bool unsignedOverflowFlag, bool zeroFlag){
	if(signedOverflowFlag){
		cout << "S";
	}
	else
		cout << " ";

	if(unsignedOverflowFlag){
		cout << "U";
	}
	else
		cout << " ";

	if(zeroFlag){
		cout << "Z ";
	}
	else
		cout << "  ";
}

/**
 *
 */
string sum(string num1, string num2, int length){
	bool carry = false;
	string temp;
	for(int i = length; i > 0; i++){
		if(carry){
			if(num1[i] == '1' && num2[i] == '1'){
				temp[i] = '1';
				carry = true;
			}
			if(num1[i] == '0' && num2[i] == '1'){
				temp[i] = '0';
				carry = true;
			}
			if(num1[i] == '1' && num2[i] == '0'){
				temp[i] = '0';
				carry = true;
			}
			if(num1[i] == '0' && num2[i] == '0'){
				temp[i] = '1';
				carry = false;
			}
		}
		else{
			if(num1[i] == '1' && num2[i] == '1'){
				temp[i] = '0';
				carry = true;
			}
			if(num1[i] == '0' && num2[i] == '1'){
				temp[i] = '1';
				carry = false;
			}
			if(num1[i] == '1' && num2[i] == '0'){
				temp[i] = '1';
				carry = false;
			}
			if(num1[i] == '0' && num2[i] == '0'){
				temp[i] = '0';
				carry = false;
			}
		}
	}
	//sum
	//change flags as needed
	return temp;
}

/**
 *
 */
string diff(string num1, string num2, int length){
	//1's complement num1
	//1's complement num2
	string temp = sum(num1, num2, length);
	//change flags as needed
	return temp;
}

int main(){
	string num1 = "";
	string num2 = "";
	string mySum = "";
	string myDiff = "";

	int num_lengths = 0;

	//might make flags global later
	bool signedOverflowFlag = false; 
	bool unsignedOverflowFlag = false;
	bool zeroFlag = false;

	cin >> num1;
	cin >> num2;

	mySum = sum(num1, num2, num_lengths);
	myDiff = diff(num1, num2, num_lengths);

	cout << "v1   ";
	printPairty(num1);
	printFlags(signedOverflowFlag, unsignedOverflowFlag, zeroFlag);
	cout << num1;
	cout << endl;

	cout << "v2   ";
	printPairty(num2);
	printFlags(signedOverflowFlag, unsignedOverflowFlag, zeroFlag);
	cout << num2;
	cout << endl;

	
	std::cout << "sum  ";
	printPairty(mySum, num_lengths);
	printFlags(signedOverflowFlag, unsignedOverflowFlag, zeroFlag);
	printCharArray(mySum, num_lengths);
	std::cout << "\n";

	std::cout << "diff ";
	printPairty(myDiff, num_lengths);
	printFlags(signedOverflowFlag, unsignedOverflowFlag, zeroFlag);
	printCharArray(myDiff, num_lengths);
	std::cout << "\n";
	

	return 0;
}
