#!/bin/bash
# This script takes two arguments: a file and a number. It will show the
#earliest line of the file where the number appears.

# functions
# isInList: This function takes as argument a number followed 
# by a set of at least one other number
isInList()
{
	arr=($1)			# convert to array
	# we going to search arr[0] in the rest of the array
	value=${arr[0]}
	length=${#arr[@]}	# get the length of the array
	# now loop starting at 1
	for (( i=1; i<${length}; i++ ));
	do
  		if [ $value == ${arr[$i]} ]; then
			return 1	# means found
		fi
	done
	return 0			# not found
}

# takes two arguments: a file and a number
# return the line number where the number is found in the file

getsLine()
{
	file=$1
	number=$2
	declare -a content
	let i=0
	while IFS=$'\n' read -r line; do
		content[i]="${line}"
		let "i = i + 1"
	done < $file
	# Search the number
	len=${#content[@]}
	for (( idx=0; idx < $len; idx++ ));
	do
		# concatenate with the number we're looking for
		thisline="$number ${content[idx]}"
		isInList "$thisline"
		if [ "$?" -eq 1 ]; then
			let "idx = idx + 1"
			echo $idx
			exit
		fi
	done
}
 
if [ "$#" -ne 2 ]; then
	echo "USAGE: earliestLine.sh file number"
	exit
fi
file=$1
number=$2
# ensure that the file exists
if [ ! -f $file ]; then
	echo "File doesn't exist"
	exit
fi
#isInList "37 2 3 4 1 4 37"
getsLine $file $number


