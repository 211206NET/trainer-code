#!/usr/bin/bash

#this is variable, do not insert space around the equal sign
greet="Hello!"

echo $greet

# This is a comment! The lines beginning with # does not get executed
# We can execute bash commands here
# pwd
# cd ..
# pwd
# ls

echo "Say something"
read word
echo "You typed $word"

echo "Do you want to say some more?"
read answer

if [ $answer = 'y' ]
then 
    echo "Say something"
    read word
    echo "You typed $word"
else
    echo "goodbye!"
fi