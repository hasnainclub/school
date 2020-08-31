#!/bin/bash

dir1=$1
dir2=$2
dir3=$3
filename=$4

if [ -d "$dir1" ] && [ -d "$dir2" ] && [ -d "$dir3" ] && [ -f "$filename" ]
then
	count1=$(ls $dir1 | wc -l)
	count2=$(ls $dir2 | wc -l)
	count3=$(ls $dir3 | wc -l)

	if [ "$count1 " -lt "$count2" ] && [ "$count1" -lt "$count3" ]
	then mv $filename $dir1
	fi
else
	echo "please give proper arguments"
fi
#count1=$[$count1 -1] 

