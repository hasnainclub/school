/*********************************************************************
   PROGRAM:    CSCI 340 Assignment 2
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   Sep 24 2018

   For this computer assignment, you are to write and implement an interactive C++
program to find and print all prime numbers, which are less than or equal to a given
value of n, using the algorithm known as the Sieve of Eratosthenes.
*********************************************************************/  
#include "prog3.h"

/*The main ( ) routine creates an empty set of integers and prompts the user for an
upper limit and calls the subroutine sieve ( ) to execute the Sieve of Eratosthenes. It
calls the subroutine print_primes ( ) to print the prime numbers on stdout. */
int main ()
{
	
	std::set<int> theSet; // empty set of ints
	int upperLimit;
	
	cout << "upper limit for the set of primes: " ;
	cin >> upperLimit;
	
	//call the difficult function
	sieve(theSet, upperLimit);
	//not print 
	print_primes(theSet);
	return 0;
}

void sieve ( set < int >& s, int n )
{
	std::set<int>::iterator it;
	//enter elements in the set begining at 2
	
	for (int i = 2; i <= n; i++)
	{
		s.insert(i);
	 } 
	 //test what u got in ur set
	  /*
	for (it=s.begin(); it!=s.end(); it++ )
    std::cout << ' ' << *it;
  std::cout << '\n';  */
  
  
//  int m;
 // m=2; //no remove all multiples of 2 from ur set
  
  
  /*
  for(it = s.begin(); it != s.end(); it++)
    {
    	m=2;
    	//cout << *it << " that *s" << endl;
    	//cout << *it%m << " thats *it mod 2" << endl;
    	//if(*it%m==0)
    	if ( (*it%m) == 0)
    	{
    		if (*it != m)
    		{
    			s.erase(*it);
			}
    		 
		}
    	
	} *. */
	
	//CHALLENGE
	// 
	for(it = s.begin(); it != s.end(); it++)
    {
        for(int k = 2; k <= n; k++)
        {
            //deference iterator, * each value in k.  thats not a prime
            int notPrime = (*it * k);

            //prof better way, look notes showed m <= sqrt(n)
            
            if((((*it) * (*it)) <= n))
				{
					s.erase(notPrime);
				}
                
        }
	}
}

void print_primes( const set<int>& s) 
{

    int counter = 0;  //doing counter method, modulus stuff is still confusing.  Ask TA/prof to explain in office hours
    cout << endl;

   // cout << "There are " << s.size() << " prime numbers:" << endl;

    std::set<int>::iterator it; //make the iterator
    
    for(it = s.begin(); it != s.end(); it++)
    {
    	//if squirels == the numitems printed, then do endl and reset the counter.  I wish i can fully understand modulus
        if (counter == NO_ITEMS)
        { 
            cout << endl; 
            counter = 0; 
        }
        ++counter; //better than doing counter++ jon lehuta said so, look at notes
		
		//now whatever the iterator is pointing to, deference it and print that bugger
        cout << setw(ITEM_W) << *it;
    }
    //stupid output which example had
    cout << endl << endl;
}
