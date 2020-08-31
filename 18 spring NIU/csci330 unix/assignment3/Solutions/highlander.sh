#!/bin/bash

if [ "$#" -ne 1 ]; then
echo "USAGE: highlander.sh process-name"
exit
fi

# get the process pid only
# don't pay attention to process using the grep command or the script itself
pids=( $(ps ax  | grep "$1" | grep -v "grep" | grep -v "highlander.sh" | awk '{ print $1, "\n"; }'))
# start with the second process and renice the first
idx=1
cnt=${#pids[@]}
while [ $idx -lt $cnt ] 
do
	kill -9 "${pids[$idx]}"
	renice 10 -p ${pids[0]}
	let "idx = idx + 1"
done

