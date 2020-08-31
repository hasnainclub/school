#
# PROGRAM:    assign2
# PROGRAMMER: Hasnain Attarwala
# LOGON ID:   z1697740
# DATE DUE:   02142018
#
# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
assign2: assign2.o Book.o BookStore.o
	g++ $(CCFLAGS) -o assign2 assign2.o Book.o BookStore.o

# Rule to compile source code file to object code
assign2.o: assign2.cpp BookStore.h
	g++ $(CCFLAGS) -c assign2.cpp

Book.o: Book.cpp Book.h
	g++ $(CCFLAGS) -c Book.cpp

BookStore.o: BookStore.cpp BookStore.h
	g++ $(CCFLAGS) -c BookStore.cpp

BookStore.h: Book.h

# Pseudo-target to remove object code and executable files
clean:
	-rm *.o assign2
