#!/bin/bash

# calculate the number of lines of the three files
if [ $(cat $1 $2 $3 | wc -l) -gt 100 ] ; then echo "Too long" 
else 
	cat $1 $2 $3 > done 
fi


