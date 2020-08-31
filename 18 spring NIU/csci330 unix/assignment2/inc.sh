#!/bin/bash

# adds 1 to what is sent (either piped or argument)
if [ $# -eq 1 ] ; then
data=$1
else
read data
fi
let "data = data + 1" 
echo "$data"

