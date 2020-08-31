/*********************************************************************
   PROGRAM:    CSCI 340 Assignment 4
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   oct 2nd 2018

For this computer assignment, you are to write and implement an interactive C++
program to scan and process a stream of words of a plain text.
Your program should start with an empty list of words. (Combinations of blanks, tabs,
and newline characters to separate words.) After reading each word from the input
stream, do the followings:
Check the word for punctuation marks. If the first letter of the word is preceded or its
last letter is followed by punctuation marks, delete them from the word; however, if a
word contains punctuation marks in the middle, ignore the letters beyond these
punctuation marks. For example, if the word is fish, then the resulting word should be
fish; however, if the word is fish_net then the resulting word should still be fish.
******************************************************************/
#include "prog4.h"

/*
The main ( ) routine calls the subroutine: get_words ( ) to get words from the
input stream, and to clean an individual word from its punctuation marks,
get_words ( ) calls the subroutine: clean_entry ( ).s
*/
int main ()
{


	//ifstream fileObject("prog4.d");
	/*
	ifstream fileObject;
	fileObject.open("~cs340/progs/18f/p4/prog4.d", ios::in);
	
	
	  this is cstdlib stuff
	fileObject.open("words.txt");
	
	if(!fileObject.is_open())
	{
		exit(EXIT_FAILURE);
	} 
	
   //fileObject
   if (!fileObject)
      {
      cout << "Error - unable to your input file " << endl;
      exit(1);
      }
*/
	
    map<string, int> m; //from lecturenotes

    get_words(m); //send your map

    //fileObject.close();

    print_words( m );

	
	return 0;
}


/*
: It gets a word from the input
stream and removes its punctuation marks.
*/
void get_words( map<string, int>& m)
{
	
    string rawWord; //word from file
   
    string cleanedWord; //duhh...
//while (cin >> [your_string_name] ).

	/*idk wtf is this shit still not kept being opened wtf!!!!! 
	//prof said to add the ifstream parameter.  and pass the file
   if (!infile)
   {
   	cout << "haha can't open file in getwords function you're stupid!" << endl;
   	exit(1);
   }
*/
    while (cin >> rawWord)//(!infile.eof()) //from last semester keep reading until u get to end of file
    {
        //store one word seprated by whiteapce in raws
       // infile >> rawWord;

        /*
        For string s, the statement: s.length ( ) returns the total number of characters in s. If the returned length is 0 
		(i.e., the original word contains nothing but punctuation marks),simply ignore the word and read in the next one. 
        */
        if (rawWord.length() == 0)
        {
            rawWord = " ";
            cin >> rawWord;
        }
        else
        {
            clean_entry(rawWord, cleanedWord);
            if (cleanedWord.length() > 0)
            {
                /*
                Use a map container to store the cleaned words (but not the empty words). The statement: m [ s ]++ copies the string s 
				into the map m and updates its frequency. Remember a map keeps only one copy of each individual item (in sorted order) 
				specified in its first argument key and stores its frequency in its second argument value. When key is used as an index 
				to a map, it returns the corresponding value in the map.
                */
                m[cleanedWord]++;
            }

            cleanedWord = "";
        }
    }
}

/*: It prints the final list
of words and their frequencies. It also prints the number of nonempty
words and the number of distinct words in the input stream.*/
void print_words ( const map < string, int >& m)
{
	//stupid modulus not working
    int counter = 0;
	//like a int sum
	int numWordsInInputStream = 0;

	typedef map<string,int> cleanWordMap;
	//NOT modifying data hence the const it
	cleanWordMap::const_iterator mapIt;

	cout << endl;
	for( mapIt = m.begin(); mapIt != m.end(); mapIt++ )
	{
        //Check is the counter is equal to the max allowed items per line
        if (counter == 3)
        {
            cout << endl;  //Start a new line since NO_ITEMS has been met
            counter = 0;   //Reset the counter
        }
        ++counter;

        cout << left << setw(ITEM_W+10) << mapIt->first << ": " << setw(ITEM_W) << mapIt->second;

		//mapIT has the value, so add it to sum
		numWordsInInputStream += mapIt->second;
	}

	cout << endl << endl;
	cout << "no of words in input stream : " << numWordsInInputStream << endl;
	cout << "no of words in output list  : " << m.size() << endl << endl;
}

/*: It cleans a word from its
punctuation marks. The first argument is the original word in the input
stream and the second argument contains the same word after cleaning*/
void clean_entry ( const string& rawWord, string& cleanedWord)
{
	//bunch of counters
	//length compare
    unsigned int charIndex = 0;

    int first_alnum = 0;
    int last_alnum = 0;
    bool found_first_alnum = false;

    //super cool trick, keep doing until u get to end of the word & as long as it's an alnum
    while(rawWord[charIndex] && charIndex < rawWord.length())
    {
        //string or number & not found the first letter/num
        if(isalnum(rawWord[charIndex]) && found_first_alnum == false)
        {
            //found the first letter or number
            first_alnum = charIndex;

            //make counter true
            found_first_alnum = true;
        }
        //next
        charIndex++;

        //not a string or number & found the first letter/num pretty much opposite of upper function
        if(!isalnum(rawWord[charIndex]) && found_first_alnum == true)
        {
            //found last letter or num
            last_alnum = charIndex;

            //get out of loop, nice way to do break!  
            charIndex = rawWord.length();
        }
    }

    //not looking at stuff in the middle
    if (first_alnum == last_alnum)
        cleanedWord = "";

    else
    {
        /*
        Copy the word from the first alphanumeric character until the last one to another string. Use the member function: substr ( ) 
		for this task. For string s, the statement: s.substr ( pos, len ) returns the substring from s, where the index value pos 
		indicates the starting position of the substring and len specifies its size.
        */
        cleanedWord = rawWord.substr(first_alnum, last_alnum-first_alnum);

        /*
		convert all capital letters in the cleaned word to lowercase letters. You
		can convert a character to lowercase by the C library function: tolower ( 
		*/
        for_each(cleanedWord.begin(), cleanedWord.end(), makeLowerCase);
    }
}
void makeLowerCase(char& cleanedWordChar) 
{
    cleanedWordChar = tolower(cleanedWordChar);
}
