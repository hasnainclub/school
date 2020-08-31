/***********************************************************
  CSCI 480 - Assignment 1 - Spring 2020
  Progammer: Hasnain Attarwala
  Z-ID: z1697740
  Section: 2
  TA: Jingwan Li
  Date Due: January 24th, 2020
  Purpose: This assignment involves using LINUX system functions such as fork(), getpid(), getppid(), sleep(), wait() and system().
************************************************************/ 

#include <sys/types.h>
#include <sys/wait.h> 
#include <unistd.h>
#include <iostream>

using namespace std;

// Logs the PIDs of the current process and its parent,
// using the provided identity string in a call to printf
// to label it in the outout. The optional 'extra' param is
// text to be appended after the label and before the PIDs.

void printProcessId(string identity, string extra = "")
{
	printf("I am the %s process. ", identity.c_str());

	if (extra.length() > 0)
		printf("%s", extra.c_str());
	
	pid_t processId = getpid();
	printf("My PID is %i ", processId);

	pid_t parentId = getppid();
	printf("and my parent's PID is: %i\n", parentId);
}

// Forks the current process with a provided label 
// for the fork, to be printed prior to the fork occurring.
// If the fork fails, an error is logged using the label, 
// and the program exits with exit code: -1

pid_t forkWithLabel(string label)
{
	printf("Now we have the %s fork.\n\n", label.c_str());
	pid_t result = fork();
	
	if (result < 0)
	{
		printf("The %s fork failed.\n", label.c_str());
		exit(-1);
	}

	return result;
}

// Prints the provided message to the output, and performs
// the system call 'ps' to write the "process status" of
// the current process. Some newlines are appended before
// and after the system call to 'ps'.

void printStatus(string message)
{
	printf("%s\n\n", message.c_str());
	system("ps");
	printf("\n");
}

// Logs that the current process is about to exit,
// where "identity" is assumed to be a string labeling
// the current process. The program exits with exit code: 0

void exitWithId(string identity)
{
	printf("I am the %s, about to exit.\n", identity.c_str());
	exit(0);
}

// Main routine of the Assign1 program.
// All of the utility functions declared above are used to
// repeat the assignment instructions with roughly one line
// for each step of the assignment.

int main()
{
	// Log the original process.
	printProcessId("original");

	// Perform the 1st fork.
	pid_t firstFork = forkWithLabel("first");

	if (firstFork > 0)
	{
		// 1st fork is the parent, log it as such!
		printProcessId("parent");

		// Sleep for 2 seconds.
		sleep(2);

		// Print the process status.
		printStatus("I am the parent, about to call ps. The child should appear as a zombie.");
		
		// Sleep for 3 seconds.
		sleep(3);

		// Wait for the child process to exit.
		wait(0);

		// Print the process status.
		printStatus("I am the parent, having waited on the child, about to call ps again.");
		
		// Exit the parent process.
		exitWithId("parent");
	}
	else if (firstFork == 0)
	{
		// 1st fork is the child, log it as such!
		printProcessId("child");

		// Perform the 2nd fork.
		pid_t secondFork = forkWithLabel("second");
		
		if (secondFork > 0)
		{
			// 2nd fork is the child, log it as such!
			printProcessId("child");

			// Sleep for 2 seconds.
			sleep(2);

			// Exit the child process.
			exitWithId("child");
		}
		else if (secondFork == 0)
		{
			// 2nd fork is the grandchild, log it as such!
			printProcessId("grandchild");
			
			// Sleep for 3 seconds
			sleep(3);

			// Log the orphan status of the grandchild.
			printProcessId("grandchild", "I should now be an orphan.\n");

			// Log the process status of the grandchild.
			printStatus("I will now call ps.");

			// Exit the grandchild process.
			exitWithId("grandchild");
		}
	}
	
	return 0;
}
