/***********************************************************
  CSCI 480 - Assignment 1 - Spring 2020
  Progammer: Hasnain Attarwala
  Z-ID: z1697740
  Section: 2
  TA: Jingwan Li
  Date Due: Feb 20th, 2020
  Purpose: In this assignment, you will implement a microshell in C/C++.   

  You will need to use several system calls under Linux including 
  fork(), dup(), waitpid() and execvp().
************************************************************/ 
#include <iostream>
#include <iomanip>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <sys/wait.h>
#include <stdio.h>
#include <cstring>
using namespace std;


/*
Funtion: printPrompt
Use: prints the prompt msg
Parameters: na
Returns: na
*/
void printPrompt() {
	printf("480shell:"); 
}

/*
Funtion: readInput
Use: reads the input data as 1 line.  
Parameters: na
Returns: 0: line is blank return 
         1: line is not blank
*/
int readInput(char* buffer) {
  char buf[1024];
  fgets(buf,1024,stdin);
  if (strlen(buf) != 0) {
    buf[strlen(buf)-1] = 0;
    strcpy(buffer,buf);
    return 0;
  }
  else {
    return 1;
  }
}

/*
Funtion: handleNoRedirection
Use: calls exec vp
Parameters: tokens: pointer to pointer tokens
Returns: na
*/
void handleNoRedirection(char** tokens) {
  pid_t pid = fork();  
  
  if (pid == -1) { //reason we need to fork is, the main loop is the parent process that is the reason we have to fork, in child process we do execVP
    printf("Failed forking child\n"); 
    return; 
  } else if (pid == 0) { 
    if (execvp(tokens[0], tokens) < 0) { //actual exectution hapens in the child process
      printf("Could not execute command\n"); 
    } 
    exit(0); 
  } else { 
    // waiting for child to terminate 
    wait(NULL);  
    return; 
  } 
}


/*
Funtion: handleRedirection
Use: fork call execvp, write to std in or out
Parameters: tokens: pointer to pointer tokens, 
			direction: int which directions 
			fname: pointer to file name
Returns: na
*/
void handleRedirection(char** tokens, int direction, char* fname) {

  int fd;
  if (direction == 1) {  //>+ write into the file open a write file below
    fd = open(fname,O_CREAT|O_RDWR,00666); //ordwr ir read only, or read write mode.  Fd will give you the file descriptor
  }
  else {
    fd = open(fname,O_RDONLY);
  }

  pid_t pid = fork();  
  
  if (pid == -1) {   //if read o
    printf("Failed forking child\n"); 
    return; 
  } else if (pid == 0) { 

    //printf("DEBUG: handling redir %s %d %s %d\n",tokens[0],direction,fname,fd);

    if (direction == 1) {

      // replace standard output with output file
      dup2(fd,1);  //that 1 is a special thing for the standard output.  FD 1 is reserved for std output 0 for input.  instead of standard out we want to write in our file, so dup std output to ourfile
      close(fd);  //child process has 2 pipes by default std out and std in.  assign wants us to put it in our file, which is in token

      if (execvp(tokens[0], tokens) < 0) {   //that means execvp returned -1 to put the error msg.  you give the first token
        printf("Could not execute command\n"); 
      } 
    }
    else if (direction == -1) {

      // replace standard input with input file
      dup2(fd,0); //
      close(fd);

      if (execvp(tokens[0], tokens) < 0) { 
        printf("Could not execute command\n"); 
      } 
    }
    exit(0); 
  } else { 
    // waiting for child to terminate 
    wait(NULL);  
    return; 
  } 
}


/*
Funtion: processString
Use: chop off the entire input line into sections called tokens array to be used later
Parameters:  buffer:  input line
Returns: na
*/
void processString(char* buffer) {
  char* tokens[25];  //shortcut as no one will write over 25 commands for this nonsense assign
  int num_token = 0;
  for (char *p = strtok(buffer, " "); p; p = strtok(NULL, " ")) { //array called token we tokenize with space as a delimintaro.  uses strtok 
    tokens[num_token++] = p; //all words goes in token array 
  }
  tokens[num_token] = NULL; //basically chop off last guy to be null
  
  // detect redirection
  int redirection = 0;
  char redirFile[256];
  redirFile[0] = 0; // init
  for (int i=0;i<num_token;i++) { 
    if (redirection != 0) { //if redirection is not 0 

      if (strlen(redirFile) > 0) { //is we already have a redirection then someone has put an extra thing so we give the extra file was found
        printf("Error!  An extra filename was found.\n");
        return;
      }

      strcpy(redirFile,tokens[i]); //redirection file we store it 
    }

    if (!strcmp(tokens[i],"<+")) { //if token has this special symbol then its a redirection going left & goes -1
      redirection = -1;
      tokens[i] = NULL;  //when we give token to execvp command we dont want <+ and >+ crap in there
    }
    else if (!strcmp(tokens[i],">+")) { //otherwise redirection is 1
      redirection = 1;
      tokens[i] = NULL;  //when we give token to execvp command we dont want <+ and >+ crap in there
    }
  }

  if (redirection == 0) {  //0 is no redirection
    handleNoRedirection(tokens);
  }
  else if (redirection == -1) {
    handleRedirection(tokens,-1,redirFile);
  }
  else if (redirection == 1) {
    handleRedirection(tokens,1,redirFile);
  }
}


/*
Funtion: Main
Use: Executes program
Parameters: none
Returns: 0: Regular exit
*/
int main(void) {

  char buffer[1024];

  while(true) {
    printPrompt();

    // read input buffer
    if (readInput(buffer)) {
      continue;
    }
	
    // handle exit command
    if (!strcmp(buffer,"q") || !strcmp(buffer,"quit")) {
      printf("Good Bye\n");
      return 0;
    }

    if (!strcmp(buffer,"about")) {
      printf("The 480shell is the work of Hasnain Attarwala, 2020.\n");
    }
    else {
      processString(buffer); 
    }
  }
  return 0;
}
