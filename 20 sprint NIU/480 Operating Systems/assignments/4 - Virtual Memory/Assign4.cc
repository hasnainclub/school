/***********************************************************
  CSCI 480 - Assignment 4 - Spring 2020
  Progammer: Hasnain Attarwala
  Z-ID: z1697740
  Section: 2
  TA: Jingwan Li
  Date Due: Mar 18th, 2020
  Purpose: Simulation of virtual memory on a very small hypothetical computer and looking at page replacement algorithms. 
  ***think about this in car parking lot terms.  Makes life much easier to understnad programe.  we have a bunch of cars coming in but a limited sized lot.  how do we assess it.  fifo or lifo.  
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

struct PageInfo {
  int frame;
  int modified;
};

struct FrameInfo {
  int frameNumber;
  int page;
};

// modes
int fifo=0;
int prepage=0;

#define NUMFRAMES 15  // which is physical memory in computer from nums are also not consequtive starts at 101 - 105 to 201 0 305.  3 batches of 5 each hence 15
#define NUMPAGES  25  //5000 bytest of processor divded by it is 25 how do you fit 25 pages in 15 frames.  think if u have 15 spots and 25 cars.  so once each leaves we juggle 
struct PageInfo pages[NUMPAGES];
struct FrameInfo frames[NUMFRAMES];
int fifoPointer = 0;
int lifoPointer = 0;


/*
Funtion: printUsage
Use: Prints 1st line
Parameters: Program Name
Returns:NA
*/
void printUsage(char* programName) {
  printf("Usage: %s arg1 arg2\nwhere arg1 = F or L and arg2 = P or D\n",programName);
}


/*
Funtion: printPageTable
Use: Print's page table
Parameters: none
Returns: NA
*/
void printPageTable() {
  printf("Page Number  Frame Number  Modified?\n");
  for (int i=0;i<NUMPAGES;i++) {
    int c = pages[i].frame;
    /*
    if (c != -1) {
      c = frames[pages[i].frame].frameNumber;
    }
    */
    printf("  %2d           %3d             %s\n",i,c,(pages[i].modified == 0)?"No":"Yes");
  }
}


/*
Funtion: pushLifoStack
Use: Pushes last in first out onto stack 
Parameters: none
Returns: na
*/
void pushLifoStack() {
  lifoPointer++;
  //printLifoStack();
}

/*
Funtion: lifoRead
Use: Reads lifo
Parameters: none
Returns: pointer to lifo
*/
int lifoRead() {
  lifoPointer--;
  int f = lifoPointer;
  return f;
}

/*
Funtion: fifoRead
Use: Reads fifo
Parameters: none
Returns: pointer to fifo
*/
int fifoRead() {
  int f = fifoPointer;
  fifoPointer++;
  if (fifoPointer == NUMFRAMES) {
    fifoPointer = 0;
  }
  return f;
}

/*
Funtion: initDataStructures
Use: the main function where laod number of frames for pre paging, 
Parameters: none
Returns: na
*/
void initDataStructures() {

  for (int i=0;i<NUMPAGES;i++) {
    pages[i].frame   = -1;
    pages[i].modified = 0;
  }

  int f=101;
  for (int i=0;i<NUMFRAMES;i++) {
    frames[i].page   = -1;
    frames[i].frameNumber = f++;

    // load first NUMFRAMES pages into frames for pre-paging
    if (prepage == 1) {
      frames[i].page = i;
      pages[i].frame = frames[i].frameNumber;

      if (fifo == 0) {
        pushLifoStack();
      }

      //printf("PRPA %d) %d %d \n",i,frames[i].page,pages[i].frame);
    }

    if (f == 106) {
      f = 201;
    }
    else if (f == 206) {
      f = 301;
    }
  }

  //printPageTable();

}


/*
Funtion: findFrame
Use: to find frame based upon which DS
Parameters: int page
Returns: int i found or not found existing frame.  recycledFrame is the recycled frmae. 
*/          
int findFrame(int page) { 

  // first search for existing page  //if page found, return it else go ln 130
  for (int i=0;i<NUMFRAMES;i++) {
    if (frames[i].page == page) {
      ////printf("found existing frame %d %d \n",page,i);
      return i; 
    }
  }

  // now look for the first empty
  for (int i=0;i<NUMFRAMES;i++) { //finding empty parking lot
    if (frames[i].page == -1) {  //if -1 then empty
      ////printf("found empty frame %d %d \n",page,i);
      // for lifo manage stack
      if (fifo == 0) {  
        pushLifoStack();
      }
      return i;  //found empty frame, return it
    }
  }


  int recyledFrame = 0;  //now all parking lot is full, fit it new page
  if (fifo == 1) {  //if fifo kick out first guy
    recyledFrame = fifoRead(); //who do i remove
    ////printf("FIFO %d  recyledFrame for page %d\n ",recyledFrame,page );
  }
  else { // LIFO
    recyledFrame = lifoRead();  //last in first out.  guy who came in last, remove him. 
    ////printf("LIFO %d  recyledFrame %d\n",recyledFrame,page );
  }

  int prevPage = frames[recyledFrame].page;
  ////printf("Page fault %d ----- \n", prevPage);
  if (pages[prevPage].modified == 1) {   //when we dont have space anymore its called a page fault. now we have to swap pages
      printf("Write page %d from frame %d to the disk\n",prevPage,frames[recyledFrame].frameNumber);
  }
  printf("Read page %d from the disk into frame %d\n",page,frames[recyledFrame].frameNumber); //when we dont have space anymore its called a page fault. now we have to swap pages

  pages[prevPage].frame = -1;
  pages[prevPage].modified = 0;

  if (fifo==0) {
    pushLifoStack();
  }

  return recyledFrame;
}

/*
Funtion: readAndProcess
Use: read and process file.  call print table if need to rpiont
Parameters: int page
Returns: exit failure.  or 1
*/   
int readAndProcess() {
  FILE *fp;
  fp = fopen("data4.txt", "r"); 
 // char line[256];

  int address;
  char rw_flag[2];

  if (fp == NULL) {
    perror("Error while opening the file.\n");
    exit(EXIT_FAILURE);
  }

  int page;
  int counter=0;

  while (fscanf(fp, "%d %s", &address, rw_flag) == 2)  {  //read on line at a time
    page = (address/200);  //read adresa and divide by 200 for page num
    ////printf("%d %s %d\n",address,rw_flag,page);

    int f = findFrame(page);  //is parkign lot available? 
    if (f != -1) {


      frames[f].page = page;
      pages[page].frame = frames[f].frameNumber;
      if (rw_flag[0]=='R') {
        pages[page].modified = 0;
      }
      else if (rw_flag[0]=='W') {
        pages[page].modified = 1;
      }
    }
    else {
      // should not come here
    }

    if ((counter++ % 10) == 9) {  //****is this 5 0r 10  lectures notes conflicting****
      printPageTable();
    }

  }

  return 1;

}

/*
Funtion: main
Use: Main body of code to call other functions and also verify args are valid
Parameters: comamnd line
Returns: 0 for success end
*/   
int main(int argc, char **argv) {


  // check for valid arguments // demand paging, is whwere page comes u do it then.  pre page is put the first 15 then shuffle rest of them around. 
  if (argc != 3) {
    printf("Error: wrong number of arguments\n");
    printUsage(argv[0]);
    return 1;
  }
  else {
    if (!strcmp(argv[1],"F")) {
      fifo = 1;
    }
    else if (!strcmp(argv[1],"L")) {
      fifo = 0;
    }
    else {
      printf("Error: first wrong argument\n");
      printUsage(argv[0]);
      return 1;
    }

    if (!strcmp(argv[2],"P")) {
      prepage = 1;
    }
    else if (!strcmp(argv[2],"D")) {
      prepage = 0;
    }
    else {
      printf("Error: second wrong argument\n");
      printUsage(argv[0]);
      return 1;
    }

    // print confirmation before start
    if (fifo == 0) {
      printf("\n---------------Starting program with LIFO and ");
    }
    else {
      printf("\n---------------Starting program with FIFO and ");
    }
    if (prepage == 0) {
      printf("Demand Paging----------------\n\n");
    }
    else {
      printf("Pre Paging----------------\n\n");
    }

    //printf("arguments valid %d %d \n",fifo,prepage);
    initDataStructures(); //calling intial data structures
    readAndProcess();  //main action happens

    printPageTable();
  }

  return 0;
}
