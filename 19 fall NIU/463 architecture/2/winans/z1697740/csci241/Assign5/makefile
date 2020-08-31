#
# PROGRAM: Assign 4   
# PROGRAMMER: Hasnain ATtarwala
# LOGON ID: z1697740
# DATE DUE: 03272018 
#


# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
assign5: assign5.o VectorN.o
	g++ $(CCFLAGS) -o assign5 assign5.o VectorN.o
   
# Rules to compile source code files to object code
assign5.o: assign5.cpp VectorN.h
	g++ $(CCFLAGS) -c assign5.cpp
      
VectorN.o: VectorN.cpp VectorN.h
	g++ $(CCFLAGS) -c VectorN.cpp
         
# Pseudo-target to remove object code and executable files
clean:
	-rm *.o assign5
