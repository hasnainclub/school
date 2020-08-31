#!/bin/bash
# display errors if any
exec 3>&2 2>errors
cp $1 $2
if [ $(cat errors | wc -l) -gt 0 ]; then
# stop exec redirection so we can read the use answer
exec 2>&3
read -p "Errors detected. Do you wants to read them (Y/N) > " answer
case "$answer" in
"Y"|"y") cat errors ;;
esac;
fi
