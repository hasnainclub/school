/*
name: Hasnain Attarwala
CSCI 340
Section: 1
Program: 9 
*/ 

//#include "/home/cs340/progs/18f/p9/hTable.h"
#include "hTable.h"
bool cmp(Entry*, Entry*);

HT::HT(const unsigned int& x)
{    hTable.resize(x);
     pTable.resize(x);
     hsize = x;
    // psize = 0;   
	 psize=x; }

HT::~HT()
{    pTable.clear();
     hTable.clear();    }

void HT::insert(const Entry& record)
{    
	unsigned int index = hash(record.key);
	
	//cout << record.desc << "   " << record.num << "     " << endl  << endl << endl << endl;
	
     for (unsigned int i = 0; i < hsize; i++)
     {    if (hTable[i].key == FREE && i == index)
          {    cout << "  Entry :  " << i << endl;
               hTable[i] = record;
               pTable[psize] = &hTable[i];
              // psize++;
               break;    }

          if (hTable[i].key == record.key)// && index==i)
          {    cout << "not inserted - duplicate key!!!" << endl;
               break;   }    }
/*
`	 for (unsigned i =0; i<hsize; i++)
	 {
	 	if (hTable[i].key != FREE)
	 	{
	 		break;
		}
		cout << " Hash table full." << endl;
	 } */
}

void HT::search(const string& value)
{    int index = hash(value);
     for (unsigned int i = 0; i < hsize; i++)
     {    if (hTable[(index + i) % hsize].key == value)
          {    cout << "  =>> number :  " << setw(4) << hTable[(index + i) % hsize].num << "  - item :  " << hTable[(index + i) % hsize].desc << endl;    }    }

     unsigned int j =  0;
     if (hTable[(index + j) % hsize].key != value)
     {    cout << "not in table!!" << endl;    }    }

void HT::hTable_print()
{    bool activeRecord = false;

     for (unsigned int i = 0; i < hsize; i++)
     {    if (hTable[i].key != FREE)
          {    if (activeRecord)
               {    cout << setw(4) << i << " : " << hTable[i].key << " - " << setw(5) 
			   << hTable[i].num << " - " << hTable[i].desc << endl;    }
               else
               {    activeRecord = true;    }    }    }

     cout << endl;    }

bool cmp(Entry* l, Entry* r)
{    return (l -> key < r -> key);    }

void HT::pTable_print()
{    sort(pTable.begin(), pTable.end(), cmp);

     for (unsigned int i = 0; i < psize; i++)
     {    cout << "  " << pTable[i] -> key << " - " << right << setw(4) << pTable[i] -> num 
	 			<< " - " << left << pTable[i] -> desc << endl;    }

     cout << endl;    } 

/*HT::~HT()
{     delete &pTable;
      delete &hTable;   }
*/
