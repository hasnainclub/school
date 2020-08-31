#!/bin/bash
# use case to generate output
read -p "Insert your favorite season> " season

case "$season" in
"Fall"|"fall") echo "A lot of leaves in that season!" ;;
"Spring"|"spring") echo "what I liked the most were the flowers!" ;;
"Summer"|"summer") echo "Too hot for my taste!" ;;
"Winter"|"winter") echo "Great! Snowball fight!" ;;
*) echo "I don't know nothing about that"
esac;

#hasnain is amazing!
