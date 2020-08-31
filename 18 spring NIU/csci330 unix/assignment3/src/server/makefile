CC=g++
CFLAGS=-std=c++11 -Wall -g
LIBS = ../lib/functions.cpp ../lib/rc4.cpp ../lib/sha1.cpp # source files
SRCS = server.cpp # source files
OBJS = $(SRCS:.cpp=.o) # object files

server: $(OBJS)
	 $(CC) $(CFLAGS) -o $@ $(OBJS) $(LIBS)

%.o:    %.cpp
	$(CC) $(CFLAGS) -c $*.cpp

clean:
	rm -f $(OBJS) $(TARG) *~
