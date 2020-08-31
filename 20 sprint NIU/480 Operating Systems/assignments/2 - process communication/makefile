#
# PROGRAM:    Assign2
# PROGRAMMER: Hasnain Attarwala
# LOGON ID:   Z1697740
# DATE DUE:   Feb 07, 2020
#

# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
Assign2: Assign2.cpp
	g++ $(CCFLAGS) Assign2.cpp -o Assign2

# Pseudo-target to remove object code and executable files
clean: 
	rm -f *.tar
	rm -f *.o
	rm -f Assign2

tar:
#	Check if a directory does not exist
	if [ ! -d "Z1697740_A2_dir" ]; \
	then \
		mkdir Z1697740_A2_dir; \
	fi
#	copy the 2 files into the directory
#	tar -cvf Z1697740_A1.tar makefile Assign2.cpp
	cp  makefile Assign2.cpp Z1697740_A2_dir
	tar -cvf Z1697740_A2.tar Z1697740_A2_dir

#	Delete the tar and executable file
deltar:
	-rm *.tar Assign2

#	Delete the entire directory 
deldir:
	rm -r Z1697740_A2_dir
