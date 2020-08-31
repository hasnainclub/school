#!/bin/bash

index=1
file="logFile"

if [ -f logFile ]
then
	index=$(tail $file)
	echo $(find . -maxdepth 1 -not -type d | head -$index | tail +$index)
	index=$((index + 1))
	echo $index > logFile
else
	echo $(ls | head -$index | tail +$index)
	echo $index > logFile
fi
#index=$ [ $index + 1 ] why doens't this work??
index=$((index + 1))
