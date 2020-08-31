#
# PROGRAM:    Assign5
# PROGRAMMER: Hasnain Attarwala
# LOGON ID:   z1697740
# DATE DUE:   March 31, 2020
#

# Compiler variables
CCFLAGS = -Wall -std=c++11 -pthread

# Rule to link object code files to create executable file
Assign5: Assign5.cc
	g++ $(CCFLAGS) Assign5.cc -o Assign5

# Pseudo-target to remove object code and executable files
clean: 
	rm -f *.tar
	rm -f *.o
	rm -f Assign5

tar:
#	Check if a directory does not exist
	if [ ! -d "z1697740_A5_dir" ]; \
	then \
		mkdir z1697740_A5_dir; \
	fi
#	copy the 2 files into the directory
#	tar -cvf z1697740_A5.tar makefile Assign5.cc
	cp  makefile Assign5.cc z1697740_A5_dir
	tar -cvf z1697740_A5.tar z1697740_A5_dir

#	Delete the tar and executable file
deltar:
	-rm *.tar Assign5

#	Delete the entire directory 
deldir:
	rm -r z1697740_A5_dir
