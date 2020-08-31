#
# PROGRAM:    Assign4
# PROGRAMMER: Hasnain Attarwala
# LOGON ID:   Z1697740
# DATE DUE:   March 18, 2020
#

# Compiler variables
CCFLAGS = -Wall -std=c++11

# Rule to link object code files to create executable file
Assign4: Assign4.cc
	g++ $(CCFLAGS) Assign4.cc -o Assign4

# Pseudo-target to remove object code and executable files
clean: 
	rm -f *.tar
	rm -f *.o
	rm -f Assign4

tar:
#	Check if a directory does not exist
	if [ ! -d "Z1697740_A4_dir" ]; \
	then \
		mkdir Z1697740_A4_dir; \
	fi
#	copy the 2 files into the directory
#	tar -cvf Z1697740_A4.tar makefile Assign4.cc
	cp  makefile Assign4.cc data4.txt Z1697740_A4_dir
	tar -cvf Z1697740_A4.tar Z1697740_A4_dir

#	Delete the tar and executable file
deltar:
	-rm *.tar Assign4

#	Delete the entire directory 
deldir:
	rm -r Z1697740_A4_dir
