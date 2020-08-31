/*********************************************************************
   PROGRAM:    CSCI 340 Assignment 2
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   Sep 14 2018

   FUNCTION:   you are to write and implement a C++ program to
implement two search algorithms ( a linear search and a binary search) on randomly
generated integers stored in vectors.
*********************************************************************/  
#include "prog2.h"



void Vectors ( vector < int >& v1, vector < int >& v2, int s1, int s2 )
{

	//vector<int> v1; 
	srand(s1);
	for (int i=0; i < ARR_SIZE; i++)
	{
		v1[i]=rand() % (HIGH-LOW +1) +LOW;
	}
	
	//vector<int> v2; 
	srand(s2);
	for (int i=0; i < TEST_ARR_SIZE; i++)
	{
		v2[i]=rand() % (HIGH-LOW +1) +LOW;
	}
}

bool linearSearch ( const vector < int >& v, int x ) 
{
	if(find(v.begin(), v.end(), x) ==v.end())
	{
		return false;
	}
	else 
	{
		return true;
	}
	
}


bool binarySearch ( const vector < int >& v, int x )
{
	if(binary_search(v.begin(), v.end(), x)) //if that's true
	{
		return true; //end the stupid thing
	}
	else
	{
		return false; //we didnt find it end it
	}
}
int search ( const vector < int >& v1, const vector < int >& v2, bool (*p ) ( const vector < int >&, int ) )
{
	int found=0;
	for (int i=0;i<ARR_SIZE; i++)
	{
		if (p(v1, v2[i])==true)
		{
			found++;
		}
	}
	return found;
}

void sortVector ( vector < int >& v ) 
{
	sort(v.begin(), v.end());
}

void printVector ( const vector < int >& v )
{
	
	for (unsigned int i=0; i<v.size(); i++)
	{
		cout << setw(ITEM_W) << v[i];
		if ((i+1)% NO_ITEMS ==0) //every 12TH'S line do an endlline
		{
			cout << endl;
		}
	}
}

void printStat ( int totalSucCnt, int vectorSz )
{
	float percent;
	vectorSz=TEST_ARR_SIZE;
	
	percent = ((float)totalSucCnt/vectorSz);
	cout << fixed << setprecision (2) << "Percentage of successful searches: " << (percent*100) << "%" << endl;
}
