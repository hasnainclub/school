#!/bin/bash
# returns the next port that is not assigned to anything.
if [ "$#" -ne 1 ]; then
	echo "USAGE: nextPort port"
	exit
fi
port=$1
# check this port exits already
cat /etc/services | grep -q "$port"
if [ $? -eq 1 ];then
	echo $port
	exit # done
fi
quit=0
while [ $quit -eq 0 ] 
	do
	ports=`cat /etc/services | sed -e 's/[^0-9]/ /g' | sed 's/ /\n/g' | sed '/^\s*$/d' | sort -g | awk -v port="$port" '$1 >= port {print $1}' | head -1`
	newport="${ports[0]}"
	let "newport=newport + 1"
	cat /etc/services | grep -q "$newport"
	if [ $? -eq 0 ];then
    	port=$newport
	else
    	quit=1
	fi
done
echo $newport
