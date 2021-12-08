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

# # creating this variable, and initially assign it to false
# exit=false

while [ true ]
do
    # if answer variable is 'y' then execute the following block
    if [ $answer = 'y' ]
    then 
        echo "Say something"
        read word
        echo "You typed $word"
        echo "Continue speaking?"
        read answer
    # != compares two strings for inequality 
        if [ $answer != 'y' ]
        then
            echo "goodbye!"
            break
        fi
    # elif [ condition ]
    # then
    #     whatever you want to execute here
    else
        echo "goodbye!"
        break
    fi
done

#Loops: While, Until, For in

# while loop executes as long as the condition evaluates to true
# while [ condition ]
# do
# #commands here
# done

# until loop executes as long as the condition evaluates to false
# until [ condition ]
# do
# #commands go here
# done

# for-in loop loops through a collection (ie array)
# for elem in array
# do
# # Execute some stuff
# done