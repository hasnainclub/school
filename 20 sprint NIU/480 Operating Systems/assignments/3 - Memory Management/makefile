#
# PROGRAM:    Assign3
# PROGRAMMER: Hasnain Attarwala
# LOGON ID:   Z1697740
# DATE DUE:   Feb 20, 2020
#

# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
Assign3: Assign3.cc
	g++ $(CCFLAGS) Assign3.cc -o Assign3

# Pseudo-target to remove object code and executable files
clean: 
	rm -f *.tar
	rm -f *.o
	rm -f Assign3

tar:
#	Check if a directory does not exist
	if [ ! -d "Z1697740_A3_dir" ]; \
	then \
		mkdir Z1697740_A3_dir; \
	fi
#	copy the 2 files into the directory
#	tar -cvf Z1697740_A3.tar makefile Assign3.cc
	cp  makefile Assign3.cc ourfile Z1697740_A3_dir
	tar -cvf Z1697740_A3.tar Z1697740_A3_dir

#	Delete the tar and executable file
deltar:
	-rm *.tar Assign3

#	Delete the entire directory 
deldir:
	rm -r Z1697740_A3_dir
