/***********************************************************
  CSCI 480 - Assignment 1 - Spring 2020
  Progammer: Hasnain Attarwala
  Z-ID: z1697740
  Section: 2
  TA: Jingwan Li
  Date Due: January 24th, 2020
  Purpose: This assignment involves using LINUX system functions such as fork(), getpid(), getppid(), sleep(), wait() and system().
************************************************************/ 

#include <stdio.h>
#include <iostream>
#include <iomanip>
#include <unistd.h>
#include <sys/wait.h>
#include <string>

using namespace std;


int main()
{	
	/* 1. Print a message identifying the process as the original process 
	   and providing its PID and its parent's PID.	*/
	cerr << "\nI am the original process and my PID is: " + to_string(getpid());
    cerr << " and my parent's pid is: " + to_string(getppid()) + "\n";
    cerr << "\nNow we have the first fork.\n";
	
	/* 2. Call fork() after printing a message saying you are about to do   
		so	*/
    int child_process = fork();
    
    
	/* 3. If fork() fails, print an error message ("The first fork failed.") 
   and exit with a status of -1. */
    if (child_process < 0)
    {
        cerr << "The first fork has failed.";
        return -1;
	}
	
	
	if (child_process == 0) // if fork succeeds, do a, b, c or d
    {
     	/* (a) Print a message identifying it as the child and providing its 
       PID and its parent's PID.  */
        cerr << "\nI am the child. My PID is " + to_string(getpid());
        cerr << " and my parent's PID is " + to_string(getppid());
         
         
        /* (b) Call fork() a second time after printing a message saying you 
       are about to do so. */
        cerr << "\nNow we have the second fork.\n";
        int grandchild_process = fork();

		/* (c) If fork() fails, print an error message ("The second fork 
       failed.") and exit as above. */
    	if (grandchild_process < 0)
        {
        	cerr << "The second fork has failed.";
        	return -1;
		}

		/* (d) If fork() succeeds, we now have three processes:  one parent, 
       one child and one grandchild. */
		if (grandchild_process == 0) //in grandchild
		{
			/* (i) Print a message identifying it as the grandchild and 
           providing its PID and its parent's PID. */
			cerr << "\nI am the granchild. My PID is " + to_string(getpid());
			cerr << " and my parent's PID is " + to_string(getppid());
			
			//(ii) Call the sleep() function to sleep for 3 seconds.
			sleep(3);

			/*(iii) Print a message saying the grandchild should now be an  
             orphan and providing its PID and its parent's PID. */
			cerr << "\nI am the grandchild.  I should now be an orphan.\n";
			cerr << "My PID is " + to_string(getpid());
			cerr << " and my parent's PID is " + to_string(getppid());
			cerr << "\nI will now call ps.\n\n";
		
			/*(iv) Use system() to execute the "ps" command after printing 
            a message saying it is about to do so */
			system("ps");

			//(vi) Print a message saying it is about to exit.
			cerr << "\n\nI am the grandchild, about to exit.";
			
			//(iv) Exit with a status of 0.
			return 0;
        }

		else //in child process
        {
 			/*(a) Print a message identifying it as the child and providing its 
			PID and its parent's PID.  */
        	cerr << "\nI am the child. My PID is " + to_string(getpid());
			cerr << " and my parent's PID is " + to_string(getppid());
			
			//(ii) Call the sleep() function to sleep for 2 seconds.
		    sleep(2);
			
			//(iii) Print a message saying it is about to exit
			cerr << "\n\nThe child is about to exit\n";
			
			//(iv) Exit with a status of 0.
			return 0;
        }
	}

		else //in parent process
        {
        	/*(a) Print a message identifying it as the parent and providing 
	 	       its PID and its parent's PID. */
			cerr << "\n\nI am the parent. My PID is " + to_string(getpid());
			cerr << " and my parent's PID is " + to_string(getppid());

			//(b) Call the sleep() function to sleep for 2 seconds.
			sleep(2);
			
			/*(c) Print a message saying it is about to call ps and that the 
       			child should appear as a zombie. */
			cerr << "\n\nI am the parent, about to call ps.  The child should appear as a zombie.\n\n";

			//(d) Use system() to execute the "ps" command.
			system("ps");

			//(e) Call the sleep function to sleep for 3 seconds.   
			sleep(3);
			
			// (f) Use wait(0) to wait for the child to terminate.
			wait(0);

			/* (g) Print a message saying that having waited on the child, it is 
     		   to call ps again. */
			cerr << "\n\nI am the parent, having waited on the child, about to call ps again.\n\n";

			// (h) Use system() to execute the "ps" command.
			system("ps");

			/* (h) Print a message saying it is about to terminate. */
			cerr << "\n\nI am the parent, about to exit.\n";
	
			// (i) Exit with a status of 0.
			return 0;
		}
   	// 5. The overall program should return a value of 0.
	return 0;
}
