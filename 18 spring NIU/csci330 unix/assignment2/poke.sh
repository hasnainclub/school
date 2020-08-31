#!/bin/bash

ls
file=$1
if [ -f "$file" ]
then
	read -p "File $1 already exists, do u want me overwrite? y/n " overwrite
	if  [ "$overwrite = y" ]
	then touch $1
	fi
else
	touch $1
fi
