/*
   PROGRAM:    CSCI 340 Assignment 9
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   Nov 27 2018
   */
#include "/home/cs340/progs/18f/p9/hTable.h"
//#include "hTable.h"


bool pred(Entry*, Entry*);

//constructor
HT::HT(const unsigned &s)
{
    hTable.resize(s);
    pTable.resize(s);
    
    hsize = SZ_TBL;
    psize = 0;
    
    for (unsigned int i = 0; i != s; i++)
    {
        hTable[i].key = FREE;
    }
}

// destructor
HT::~HT()
{
    pTable.clear();
    hTable.clear();
}

/***************************************************************
 insert
 Use: inserts values into the hash table
 Parameters: 1. entry: reference to an entry
 Returns: nothing
 ***************************************************************/
void HT::insert(const Entry &entry)
{
    int index = hash(entry.key);
    unsigned int i;
    
    for(i = 0; i < hsize; i++)
    {
        if(hTable[(index + i) % hsize].key == FREE)
        {
            //print out the entry index
            cout << " entry = " << (index + i) % hsize << endl;
            //put entry into hash table
            hTable[(index + i) % hsize] = entry;
            //put entry into pointer table
            pTable[psize] = &hTable[(index + i) % hsize];
            //increment the pointer table
            psize++;
            
            break;
        }
        
        else if(hTable[(index + i) % hsize].key == entry.key)
        {
            cout << " not inserted - duplicate key!!!" << endl;
            break;
        }
    }
    
    if(i == hsize)
    {
        cout << " not inserted - table full!!!" << endl;
    }
    /*: This public member function is to insert the record
     for an item (key, desc, num) in the hash table. If the key already exists in the
     table, the function prints an error message; if the table is full, it also prints an
     error message; otherwise, it prints the index value of the inserted record in
     the hash table and inserts the address of the record in the hash table into the
     pointer table.*/
}

/***************************************************************
 search
 Use: searches the hash table for a record with a given key
 Parameters: 1. str: reference to a string
 Returns: nothing
 ***************************************************************/
void HT::search(const string &str)
{
    int index = hash(str);
    unsigned int i;
    
    for(i = 0; i < hsize; i++)
    {
        i++;
        if(hTable[(index + i) % hsize].key == str)
        {
            cout << " ==> number: " << setw(4) << hTable[(index + i) % hsize].num << " - item: " << hTable[(index + i) % hsize].desc << endl;
            break;
        }
    }
    if(hTable[(index + i) % hsize].key != str)
    {
        cout << " not in table!!" << endl;
    }
    /*: This public member function is to search the hash
     table for a record with a given key. If the search is successful, the function
     prints the item information for the record; otherwise, it prints an error
     message.*/
}

/***************************************************************
 hTable_print
 Use: prints the hash table
 Returns: nothing
 ***************************************************************/
void HT::hTable_print()
{
    bool lastEmpty = false;
    for(unsigned int i = 0; i < hsize; i++)
    {
        if(hTable[i].key != FREE)
        {
            if(lastEmpty)
            {
                cout << endl;
            }
            cout << setw(4) << i << ":  " << hTable[i].key << " - " << setw(5) << hTable[i].num << "   -  " << hTable[i].desc << endl;
            
            lastEmpty = false;
        }
        else
        {
            lastEmpty = true;
        }
    }
    cout << endl;
    /*: This public member function is to print the subscript and
     the contents of all (and only) the active records in the hash table.*/
}

/***************************************************************
 pTable_print
 Use: prints the hash table in sorted order
 Returns: nothing
 ***************************************************************/
void HT::pTable_print()
{
    sort(pTable.begin(), pTable.end(), pred);
    
    for(unsigned int i = 0; i < psize; i++)
    {
        cout << "   " << pTable[i]->key << " - " << right << setw(4) << pTable[i]->num << " - " << left << pTable[i]->desc << endl;
    }
    
    cout << endl;
    /*: This public member function is to print the contents of all
     (and only) the active records in the hash table in ascending order with the
     keys of the records.*/
}

//predicate for pointer table sort function
bool pred(Entry* left, Entry* right)
{
    if (right == NULL)
        return true;
    else if (left == NULL)
        return false;
    else
        return (left -> key < right -> key);
}
