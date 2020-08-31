#!/bin/bash
# Using mkdir -p and tee make a file structure and a few files
mkdir -p CSCI330/lectures/1 CSCI330/lectures/2 CSCI330/assign/mine/1 CSCI330/assign/mine/2
mkdir -p CSCI330/assign/cheating/1 CSCI330/assign/cheating/2 CSCI330/stuff
printf "Lorem ipsum dolor\n\nUt enim ad minim\n\nDuis aute irure" | tee CSCI330/lectures/1/1-a CSCI330/lectures/1/1-b CSCI330/lectures/1/1-c > CSCI330/lectures/2/2-a 
printf "Lorem ipsum dolor\n\nUt enim ad minim\n\nDuis aute irure" | tee CSCI330/assign/mine/1/ques> CSCI330/assign/mine/1/ans 
printf "Lorem ipsum dolor\n\nUt enim ad minim\n\nDuis aute irure" | tee CSCI330/assign/mine/2/ques> CSCI330/assign/mine/2/ans
printf "Lorem ipsum dolor\n\nUt enim ad minim\n\nDuis aute irure" | tee CSCI330/assign/cheating/1/jeff CSCI330/assign/cheating/1/dan> CSCI330/assign/cheating/2/bob
printf "Lorem ipsum dolor\n\nUt enim ad minim\n\nDuis aute irure" > CSCI330/stuff/linuxjokes
