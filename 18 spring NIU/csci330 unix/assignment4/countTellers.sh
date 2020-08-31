#!/bin/bash
# displays the number of busy tellers.
if [ "$#" -ne 1 ]; then
	echo "USAGE: countTeller.sh file"
	exit
fi
file=$1
# get the number of lines in the file
cnt=`wc -l < $file`
# The question description say the file contain
# "...the numbers for the busy tellers (in no specific order)."
# meaning one busy tellers by line.
# means the number of lines in the file is the number of busy tellers
echo "Number of busy tellers: " $cnt
# now display the tellers numbers
declare -a content
let i=0
# read the file and store it content
while IFS=$'\n' read -r line; do
	content[i]="${line}"
	let "i = i + 1"
done < $file
# now display
len=${#content[@]}
for (( idx=0; idx < $len; idx++ ));
do
	printf "${content[idx]} "
done
printf "\n"
