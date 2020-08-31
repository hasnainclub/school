
/*********************************************************************
   PROGRAM:    CSCI 340 Assignment 5
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   oct 11th 2018

The problem is known as the Josephus problem and postulates a group of people of size
N are standing in a circle waiting to be eliminated. Counting begins at a specified point
in the circle and proceeds around the circle in a specified direction. After a specified
number of M people are skipped, the next person is eliminated. The procedure is
repeated with the remaining people, starting with the next person, going in the same
direction and skipping the same number of people, until only one person remains.
For example, suppose that M = 3 and there are N = 5 people named A, B, C, D and
E. We count three people starting at A, so that C is eliminated first. We then begin at D
and count D, E and back to A, so that A is eliminated next. Then we count B, D and E,
and finally B, D and B, so that D is the one who remains last.
For this computer assignment, you are to write and implement a C++ program to
simulate and solve the Josephus problem. The input to the program is the number M
and a list of N names, which is clockwise ordering of the circle, beginning with the
person from whom the count is to start. After each removal, the program should print
the names of all people in the circle until only one person remains. However, to save the
printing space, print the names of the remaining people only after K elimination, where
K = 1 is also an input argument to the program. The input arguments N, M and K can
be entered from the stdin in the given order.
******************************************************************/
#include "prog5.h"
//#include “/home/cs340/progs/18f/p5/prog5.h”


void init_vals(list<string>& list, args& args)
{
	cout << "Number of people? ";
	cin >> args.N;
	cout << args.N << endl;

	cout << "Index for elimination? ";
	cin >> args.M;
	cout << args.M << endl;

	cout << "Index for printing? ";
	cin >> args.K;
	cout << args.K << endl;

	list.resize(args.N);

	SEQ nameGen;
	generate(list.begin(), list.end(), nameGen);
}

void print_list(const list<string>& list, const size_t& remove)
{
	// header for list
	string header;

	if (remove == 0)
		header = "Initial group of people";
	else
		header = "After eliminating " + to_string(remove) + "th person";

	// to get the -- based on the header. 
	cout << endl << header << endl;
	cout << string(header.length(), '-');

	// num ppl left
	int column = 0;

	for (string person : list)
	{
		if (column++ % 12 == 0)
			cout << endl;
		else
			cout << ' ';

		cout << person;
	}

	cout << endl;
}

int main()
{
	list<string> list;
	args config;
	init_vals(list, config);

	size_t remove = 0;
	print_list(list, remove);
	
	int pos = 0;

	while (list.size() > 1)
	{
		pos = (pos + config.M - 1) % list.size();

		// person in current position
		auto person = list.begin();
		advance(person, pos);

		// remove the person and point remove to next
		list.erase(person);
		remove++;

		// if num people is divisible by k then print
		if (remove % config.K == 0)
			print_list(list, remove);
	}

	// Print the final person.
	print_list(list, remove);

	return 0;
}
