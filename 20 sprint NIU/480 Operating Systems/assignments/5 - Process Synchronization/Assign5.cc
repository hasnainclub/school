/*******************************************************************************
PROGRAM:	CSCI 480 Assignment 5
PROGRAMMER:	Hasnain Attarwala
LOGON ID:	z1697740
DUE DATE:	3/31/2020
FUNCTION:	in this assignment, we are going to use POSIX threads, semaphores and a mutex to illustrate the Producer-Consumer Problem.
*******************************************************************************/


#include <iostream>
#include <list>
#include <utility>
#include <pthread.h>
#include <semaphore.h>
#include <unistd.h>

using namespace std;

//Function prototypes
void Insert(long, int);
void Remove(long);
void* Produce(void *);
void* Consume(void *);
void PrintBuffer();

#define BUFFER_SIZE 35

//global 
int P_NUMBER;
int C_NUMBER;
int N_P_STEPS;
int N_C_STEPS;

sem_t notFull;
sem_t notEmpty;
pthread_mutex_t buffMut;
list<pair<long, int>> buffer;

/*
Function: Main
Use: Main program entry point
Parameters:none
Returns: 0 on sucess
        -1 on Semaphore or mutex failure
*/

int main(int argc, char **argv) 
{
  if (argc != 5) {
    cout << "Error: wrong number of arguments\n";
    return 1;
  }

  P_NUMBER = atoi(argv[1]);
  N_P_STEPS  = atoi(argv[2]);
  C_NUMBER = atoi(argv[3]);
  N_C_STEPS  = atoi(argv[4]);

	cout << "Simulation of Producer and Consumers\n\n";
	cout << "P_NUMBER = " << P_NUMBER << "\n";
	cout << "P_STEPS  = " << N_P_STEPS << "\n";
	cout << "C_NUMBER = " << C_NUMBER << "\n";
	cout << "C_STEPS  = " << N_C_STEPS << "\n";
	
	//initalizing variables
	int exitVal;
	
	pthread_t conTh[C_NUMBER];
	pthread_t proTh[P_NUMBER];
	
	exitVal = sem_init(&notFull, 0, BUFFER_SIZE);	
	if (exitVal != 0)
	{
		cerr << "sem_init failed with exit code: " << exitVal;
		exit(-1);
	}
	
	exitVal = sem_init(&notEmpty, 0, 0);
	if (exitVal != 0)
	{
		cerr << "sem_init failed with exit code: " << exitVal;
		exit(-1);
	}
	
	exitVal = pthread_mutex_init(&buffMut, nullptr);
	if (exitVal != 0)
	{
		cerr << "pthread_mutex_init failed with exit code: " << exitVal;
		exit(-1);
	}
	
	cout << "The semaphores and mutex have been initialized.\n\n";
	
	//Generating consumer threads
	for (long i = 0; i < C_NUMBER; i++) 
	{
		exitVal = pthread_create(&conTh[i], NULL, Consume, (void *) i);
		if (exitVal != 0)
		{
			cerr << "pthread_create failed with exit code: " << exitVal;
			exit(-1);
		}
	}
	
	//Generating producer Threads
	for (long i = 0; i < P_NUMBER; i++) 
	{
		exitVal = pthread_create(&proTh[i], NULL, Produce, (void *) i);
		if (exitVal != 0)
		{
			cerr << "pthread_create failed with exit code: " << exitVal;
			exit(-1);
		}
	}
	
	//Waiting on all producer threads to be done
	for (int i = 0; i < P_NUMBER; i++) 
	{
		exitVal = pthread_join(proTh[i], NULL);
		if (exitVal != 0)
		{
			cerr << "pthread_join failed with exit code: " << exitVal;
			exit(-1);
		}
	}
	
	//Waiting on all consumer threads to be done
	for (int i = 0; i < C_NUMBER; i++) 
	{
		exitVal = pthread_join(conTh[i], nullptr);
		if (exitVal != 0)
		{
			cerr << "pthread_join failed with exit code: " << exitVal;
			exit(-1);
		}
	}
	
	cout << "\nAll the producer and consumer threads have been closed.\n\n";
	
	//Removing semaphores and mutexes
	exitVal = sem_destroy(&notFull);
	if (exitVal != 0)
	{
		cerr << "sem_destory failed with exit code: " << exitVal;
		exit(-1);
	}
	
	exitVal = sem_destroy(&notEmpty);
	if (exitVal != 0)
	{
		cerr << "sem_destory failed with exit code: " << exitVal;
		exit(-1);
	}
	
	exitVal = pthread_mutex_destroy(&buffMut);
	if (exitVal != 0)
	{
		cerr << "pthread_mutex_destroy failed with exit code: " << exitVal;
		exit(-1);
	}
	
	cout << "The semaphores and mutex have been deleted.\n\n";
	
	return 0;
}

/*
Function: Produce
Use: Produces Widgets
Parameters: pidVoid: the PID of the current Thread
Returns: Nothing (?)
*/

void* Produce(void * pidVoid)
{
	int exitVal;
	long pid = (long) pidVoid;
	
	//Produce N_P_STEPS number of widgets
	for (int i = 0; i < N_P_STEPS; i++)
	{
		//wait on semaphore->Insert wdiget into buffer->update Semaphore
		exitVal = sem_wait(&notFull);
		if (exitVal != 0)
		{
			cerr << "sem_wait failed with exit code: " << exitVal;
			exit(-1);
		}
		
		Insert(pid, i);
		
		exitVal = sem_post(&notEmpty);
		
		if (exitVal != 0)
		{
			cerr << "sem_post failed with exit code: " << exitVal;
			exit(-1);
		}
		sleep(1);
	}
	
	pthread_exit(nullptr);
}

/*
Function: Consume
Use: Consumes Widgets
Parameters: pidVoid: the PID of the current Thread
Returns: Nothing (?)
*/

void* Consume(void * pidVoid)
{
	int exitVal;
	long pid = (long) pidVoid;
	
	//Produce N_P_STEPS number of widgets
	for (int i = 0; i < N_C_STEPS; i++)
	{
		//wait on semaphore->Remove widget from buffer->update Semaphore
		exitVal = sem_wait(&notEmpty);
		if (exitVal != 0)
		{
			cerr << "sem_wait failed with exit code: " << exitVal;
			exit(-1);
		}
		
		Remove(pid);
		
		exitVal = sem_post(&notFull);
		if (exitVal != 0)
		{
			cerr << "sem_post failed with exit code: " << exitVal;
			exit(-1);
		}
		
		sleep(1);
	}
	
	pthread_exit(nullptr);
}

/*
Function: Insert
Use: Inserts a widget into the buffer, respecting locks
Parameters: pid: the PID of the calling Thread
            widgetNo: Current widget number generated by 
                      calling thread
Returns: nothing
*/

void Insert(long pid, int widgetNo)
{
	int exitVal;
	
	//wait and lock mutex
	exitVal = pthread_mutex_lock(&buffMut);
	if (exitVal != 0)
	{
		cerr << "pthread_mutex_lock failed with exit code: " << exitVal;
		exit(-1);
	}
	
	pair<long, int> widget(pid, widgetNo);
	
	//insert new Widget into buffer
	buffer.push_back(widget);
	cout << "Producer " << pid << " inserted one item.  Total is now " << buffer.size() << ". ";
	
	PrintBuffer();
	
	//unlock mutex
	exitVal = pthread_mutex_unlock(&buffMut);
	if (exitVal != 0)
	{
		cerr << "pthread_mutex_unlock failed with exit code: " << exitVal;
		exit(-1);
	}
}

/*
Function: Remove
Use: Removes a widget from the buffer, respecting locks
Parameters: pid: the PID of the calling Thread
Returns: nothing
*/

void Remove(long pid)
{
	int exitVal;
	
	//wait and lock mutex
	exitVal = pthread_mutex_lock(&buffMut);
	if (exitVal != 0)
	{
		cerr << "pthread_mutex_lock failed with exit code: " << exitVal;
		exit(-1);
	}
	
	//remove widget from buffer
	buffer.pop_front();
	cout << "Consumer " << pid << " removed one item.  Total is now " << buffer.size() << ". ";
	
	PrintBuffer();
	
	//unlock mutex
	exitVal = pthread_mutex_unlock(&buffMut);
	if (exitVal != 0)
	{
		cerr << "pthread_mutex_unlock failed with exit code: " << exitVal;
		exit(-1);
	}
}

/*
Function: PrintBuffer
Use: Prints the current contents of the buffer
Parameters: none
Returns: nothing
Data Races: It is assumed that the calling function has
            successfully put the buffer's mutex (buffMut)
            in a lock state
*/

void PrintBuffer()
{
	if (buffer.empty())
		cout << "Buffer is now empty\n";
	else
	{
		cout << "Buffer now conatins: ";
		for (list<pair<long, int>>::iterator it = buffer.begin(); it != buffer.end(); it++)
		{
			cout << 'P' << it->first  << 'W' << it->second << ' ';
		}
		cout << endl;
		
	}
}
