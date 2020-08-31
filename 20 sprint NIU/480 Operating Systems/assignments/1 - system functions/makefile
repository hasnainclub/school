#
# PROGRAM:    Assign1
# PROGRAMMER: Hasnain Attarwala
# LOGON ID:   Z1697740
# DATE DUE:   Jan 24, 2020
#

# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
assign1: Assign1.cpp
	g++ $(CCFLAGS) Assign1.cpp -o Assign1

# Pseudo-target to remove object code and executable files
clean:
	-rm  *.tar Assign1 
#	-rm *.tar Assign1
#       -rm *.o *.tar Assign1

tar:
#	instructions say to send a dir, not the 2 files)
#	tar -cvf Z1697740_A1.tar makefile Assign1.cpp
	cp  makefile Assign1.cpp Z1697740_A1_dir
	tar -cvf Z1697740_A1.tar Z1697740_A1_dir

deltar:
	-rm *.tar Assign1
