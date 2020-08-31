#
# PROGRAM:    assign7
# PROGRAMMER: hasnain
# LOGON ID:   Z1697740
# DATE DUE:   April 18, 2018
#

# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
assign6: assign7.o
	g++ $(CCFLAGS) -o assign7 assign7.o

# Rules to compile source code files to object code
assign6.o: assign7.cpp Queue.h
	g++ $(CCFLAGS) -c assign7.cpp

# Pseudo-target to remove object code and executable files
clean:
	-rm *.o assign7

