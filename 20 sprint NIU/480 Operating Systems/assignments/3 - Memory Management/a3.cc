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

void printPrompt() {
	printf("480shell> "); 
}

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

void handleNoRedirection(char** tokens) {
  pid_t pid = fork();  
  
  if (pid == -1) { 
    printf("Failed forking child\n"); 
    return; 
  } else if (pid == 0) { 
    if (execvp(tokens[0], tokens) < 0) { 
      printf("Could not execute command\n"); 
    } 
    exit(0); 
  } else { 
    // waiting for child to terminate 
    wait(NULL);  
    return; 
  } 
}

void handleRedirection(char** tokens, int direction, char* fname) {
  int pipefd[2]; 

  if (pipe(pipefd) < 0) { 
    printf("Pipe could not be initialized\n"); 
    return; 
  } 

  int fd;
  if (direction == 1) {
    fd = open(fname,O_CREAT|O_RDWR,00666);
  }
  else {
    fd = open(fname,O_RDONLY);
  }

  pid_t pid = fork();  
  
  if (pid == -1) { 
    printf("Failed forking child\n"); 
    return; 
  } else if (pid == 0) { 

    printf("DEBUG: handling redir %s %d %s %d\n",tokens[0],direction,fname,fd);

    if (direction == 1) {

      close(pipefd[0]); 
      dup2(pipefd[1], fd); 
      close(pipefd[1]);

      printf("handling <+ %s",tokens[0]);

      if (execvp(tokens[0], tokens) < 0) { 
        printf("Could not execute command\n"); 
      } 
    }
    else if (direction == -1) {

      close(pipefd[1]); 
      dup2(pipefd[0], fd); 
      close(pipefd[0]);

      printf("handling >+ %s",tokens[0]);

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

void processString(char* buffer) {
  char* tokens[25];
  int num_token = 0;
  for (char *p = strtok(buffer, " "); p; p = strtok(NULL, " ")) {
    tokens[num_token++] = p;
  }
  tokens[num_token] = NULL;
  
  // detect redirection
  int redirection = 0;
  char redirFile[256];
  redirFile[0] = 0; // init
  for (int i=0;i<num_token;i++) {
    if (redirection != 0) {

      if (strlen(redirFile) > 0) {
        printf("Error!  An extra filename was found.\n");
        return;
      }

      strcpy(redirFile,tokens[i]);
      tokens[i-1] = NULL;
    }

    if (!strcmp(tokens[i],"<+")) {
      redirection = -1;
    }
    else if (!strcmp(tokens[i],">+")) {
      redirection = 1;
    }
  }

  if (redirection == 0) {
    handleNoRedirection(tokens);
  }
  else if (redirection == -1) {
    handleRedirection(tokens,-1,redirFile);
  }
  else if (redirection == 1) {
    handleRedirection(tokens,1,redirFile);
  }
}

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

    processString(buffer);
  }
  return 0;
}
