/***********************************************************
  CSCI 480 - Assignment 1 - Spring 2020
  Progammer:	Hasnain Attarwala
  Z-ID:			z1697740
  Section:		2
  TA:			Jingwan Li
  Date Due:		January 24th, 2020
  Purpose:		This assignment involves using the LINUX system function pipe() as well as fork().
				We will have three processes which communicate with each other using pipes.  The three processes will be parent, child and grandchild.
				Their communication will run in a ring like this:


									Pipe A            Pipe B 
					  <-- Parent <---------- Child <---------- Grandchild <----
					  |                                                       |
					  --------------->------------->-------------->------------
										  Pipe C
										  


           <--PC[1] Parent PA[0] <----- PA[1] Child PB[0] <------ PB[1] GrandChild PC[0]<-
					 |                                                                              |
					 ----------------------------------->------------->-------------->---------------

************************************************************/ 

#include <iostream>		// IO
#include <iomanip>		// setw
#include <unistd.h>     // fork, pipe
#include <sys/wait.h>       // wait
#include <stdlib.h>     // system, atoi

using namespace std;
//fd pipes, index 0 = read & 1 = write
int PipeA[2];
int PipeB[2];
int PipeC[2];

//Type of process to be assigned
//'P' for parent
//'C' for child
//'G' for Grandchild
char Type;

//Function Prototypes
void PWork();
void CWork();
void GWork();
void DoWork(int fdread, int fdwrite, string& Buffer, string& Value, long int& M, char Type);

/*
Funtion: Main
Use: Executes program
Parameters: none
Returns: 0: Regular exit
        -5: Failure to fork() or pipe()
*/

int main()
{
	if (pipe(PipeA) == -1) 
	{
		cerr << "Pipe #1 (A) error";
		exit(-5);
	}
	
	if (pipe(PipeB) == -1) 
	{
		cerr << "Pipe #2 (B) error";
		exit(-5);
	}
	
	if (pipe(PipeC) == -1) 
	{
		cerr << "Pipe #1 (C) error";
		exit(-5);
	}

  pid_t   childpid;

  if((childpid = fork()) == -1)
  {
		cerr << "Fork #1 error";
		exit(-5);
  }

  if (childpid == 0) {  // child process

    pid_t   grandchildpid;
    if((grandchildpid = fork()) == -1)
    {
		  cerr << "Fork #2 error";
		  exit(-5);
    }

    if (grandchildpid == 0) {// grand child process
      close(PipeB[0]);
      close(PipeA[0]);
      close(PipeA[1]);
      close(PipeC[1]);
			cout << "The grandchild process is ready to proceed.\n";
			GWork();
    }
    else {
	    close(PipeA[0]);
      close(PipeC[0]);
      close(PipeC[1]);
	    close(PipeB[1]);
			cout << "The child process is ready to proceed.\n";
			CWork();
    }
  }
  else {                // parent process
	  close(PipeA[1]);
    close(PipeB[0]);
    close(PipeB[1]);
    close(PipeC[0]);
		cout << "The parent process is ready to proceed.\n";
		PWork();
  }
	
	return 0;
}

/*
Funtion: Pwork
Use: Starts a Work chain and Initializes Variables for Use in funciton 'DoWork'
Parameters: none
Returns: Nothing
*/

void PWork() 
{
	//initalize
	string Buffer;
	string Value;
	long int M = 1;
	Type = 'P';
	Buffer = to_string(M);
	Buffer += '@';
	
	//Inital Work chain
	write(PipeC[1], Buffer.c_str(), Buffer.length());
	cerr << "Parent:       Value =  " << M << endl;
	
	//Start the work loop
	DoWork(PipeA[0], PipeC[1], Buffer, Value, M, Type);
	
	//wait for child to finish
	wait(NULL);
	
	exit(0);
}

/*
Funtion: CWork
Use: Initializes Variables for Use in funciton 'DoWork'
Parameters: none
Returns: Nothing
*/

void CWork()
{
	//initalize
	string Buffer;
	string Value;
	long int M = 1;
	Type = 'C';
	
	//Start the WorkLoop
	DoWork(PipeB[0], PipeA[1], Buffer, Value, M, Type);
	
	//wait for child to finish
	wait(NULL);
	
	exit(0);
}

/*
Funtion: GWork
Use: Initializes Variables for Use in funciton 'DoWork'
Parameters: none
Returns: Nothing
*/

void GWork()
{
	//initalize
	string Buffer;
	string Value;
	long int M = 1;
	Type = 'G';
	
	//Start the WorkLoop
	DoWork(PipeC[0], PipeB[1], Buffer, Value, M, Type);
	
	exit(0);
}

/*
Funtion: DoWork
Use: Reads numerical data from a File Descriptor, executes a numeric formula, 
     and sends the resulting numeric data to another File Desciptor.
     Finishes execution when the Resulting number is above 99999999999
Parameters: fdRead: A file descriptor where numeric data will be read from
            rfWrite:A file descriptor where numeric data will be written to
            Buffer: A String that will be used to write data to a file descriptor
            Value: A string that will be used to read data from a file descriptor
            M:An long int used to execute the function 'F(M) = 3*M+7'
            Type:A character to represent the calling function's process (P, C, or G)
Returns: Nothing
*/

void DoWork(int fdRead, int fdWrite, string& Buffer, string& Value, long int& M, char Type)
{
	char ReadBufferCharacter = 'A';
	do
	{
		Value = "";
		Buffer = "";
		ReadBufferCharacter = 'A';
		
		//read from previous process, stopping at '@' character
		while (ReadBufferCharacter != '@')
		{
			read(fdRead, &ReadBufferCharacter, 1);
			
			if (ReadBufferCharacter != '@')
				Value += ReadBufferCharacter;
		}
		
		//extract the number, apply the formula, then convert back into string
//		M = stol(Value);
//		M = 3 * M + 7;
//		Buffer = to_string(M);
		
		switch(Type)
		{
			case 'P':
				M = stol(Value);
				M = 200 - 3 * M;
				Buffer = to_string(M);
				cerr << "Parent:       Value =  " << Buffer << endl;
				break;
			case 'C':
				M = stol(Value);
				M = 7 * M - 6;
				Buffer = to_string(M);
				cerr << "Child:        Value =  " << Buffer << endl;
				break;
			case 'G':
				M = stol(Value);
				M = 30 - 4 * M;
				Buffer = to_string(M);
				cerr << "Grandchild:   Value =  " << Buffer << endl;
				break;
			default:
				break;
		}
		
		Buffer += "@";
		
		//write newly calculated value to the next process 
		write(fdWrite, Buffer.c_str(), Buffer.length());
	}
	while (M >= -999999999 && M <= 999999999);
	
	//close File Discriptors
	close(fdRead);
	close(fdWrite);
}
