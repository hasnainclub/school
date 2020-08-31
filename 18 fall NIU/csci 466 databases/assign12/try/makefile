#
# PROGRAM:    assignment12
# PROGRAMMER: Hasnain Attarwala
#
#
#
# LOGON ID:   z1697740
# DATE DUE:   12/7/18
#

# Compiler variables
COMPILE = g++ -Wall -std=c++11

# Rule to link object code files to create executable file
hasnainProg.exe: hasnainProg.o
	$(COMPILE) -o hasnainProg.exe hasnainProg.o -L /usr/lib/mysql -l mysqlclient

# Rule to compile source code file to object code
hasnainProg.o: hasnainProg.cpp 
	$(COMPILE) -c hasnainProg.cpp -I /usr/include/mysql

# Pseudo-target to remove object code and executable files
clean:
	-rm *.o hasnainProg.exe
