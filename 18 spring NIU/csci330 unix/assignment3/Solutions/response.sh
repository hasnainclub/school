#!/bin/bash
# start 128 process (we don't want to break the cpu)
# execute stressing operation on the hard disk.
# over few days this disk will fail
idx=0
cnt=128
while [ $idx -lt $cnt ] 
do
	stress --timeout 10s --hdd 1024 --hdd 1024 &
	let "idx = idx + 1"
done

