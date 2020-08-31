/*
name: Hasnain Attarwala
CSCI 340
Section: 1
Program: 9
*/

#include "/home/cs340/progs/18f/p9/hTable.h"
//#include "hTable.h"
bool cmp(Entry*, Entry*);

HT::HT(const unsigned int& x)
{   
/*
	for (unsigned i=0; i!= x; i++)
	{
		hTable[i].key = FREE;
	} */
	 hTable.resize(x);
     pTable.resize(x);
     hsize = SZ_TBL;
     psize = 0;    
	 
	for (unsigned i=0; i!= x; i++)
	{
		hTable[i].key = FREE;
	}
}

HT::~HT()
{    pTable.clear();
     hTable.clear();    }

void HT::insert(const Entry& record)
{    unsigned int index = hash(record.key);

     for (unsigned int i = 0; i < hsize; i++)
     {    if (hTable[(index + i) % hsize].key == FREE)
          {    cout << "  Entry :  " << (index + i) % hsize << endl;
               hTable[(index + i) % hsize] = record;
               pTable[psize] = &hTable[(index + i) % hsize];
               psize++;
               break;    }

          if (hTable[(index + i) % hsize].key == record.key)
          {    cout << "not inserted - duplicate key!!!" << endl;
               break;   }    }

     unsigned int j = 0;
     if (j == hsize)
     {    cout << " Hash table full." << endl;    }    }

void HT::search(const string& value)
{    int index = hash(value);
     for (unsigned int i = 0; i < hsize; i++)
     {    if (hTable[(index + i) % hsize].key == value)
          {    cout << "  =>> number :  " << setw(4) << hTable[(index + i) % hsize].num 
		  << "  - item :  " << hTable[(index + i) % hsize].desc << endl;    }    }

     unsigned int j =  0;
     if (hTable[(index + j) % hsize].key != value)
     {    cout << " Key not found." << endl;    }    }

void HT::hTable_print()
{    bool activeRecord = false;

     for (unsigned int i = 0; i < hsize; i++)
     {    if (hTable[i].key != FREE)
          {    if (!activeRecord)
               {    cout << setw(4) << i << " : " << hTable[i].key << " - " << setw(5) 
			   << hTable[i].num << " - " << hTable[i].desc << endl;    }
               else
               {    activeRecord = true;    }    }    }

     cout << endl;    }

bool cmp(Entry* l, Entry* r)
{   
		if (right == NULL)
		return true;
	else if (left == NULL)
		return false; 
	return (l -> key < r -> key);   
}

void HT::pTable_print()
{    sort(pTable.begin(), pTable.end(), cmp);

     for (unsigned int i = 0; i < psize; i++)
     {    cout << "  " << pTable[i] -> key << " - " << right << setw(4) 
	 << pTable[i] -> num << " - " << left << pTable[i] -> desc << endl;    }

     cout << endl;    }

/*HT::~HT()
{     delete &pTable;
      delete &hTable;   }
*/