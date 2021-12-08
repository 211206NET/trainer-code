#!/usr/bin/bash

# Fizzbuzz is a simple problem where we loop through and display numbers given user input
# However, if the number is divisible by 3, we print "Fizz" instead
# If the number is divisible by 5, we print "Buzz"
# if the number is both divisible by 3 and 5, we print "FizzBuzz"

# 1. Prompt user to enter a positive number (make sure it's greater than 0)
# 2. Loop through the numbers from 1 to the user input
# 3. For each number, check whether the number is divisible by 3 or 5 or both
# and alter the print accordingly

# Expected behavior is
# Enter a number: 10
# 1
# 2
# Fizz (3)
# 4
# Buzz (5)
# Fizz (6)
# 7
# 8
# Fizz (9)
# Buzz (10)

echo "Enter a positive integer"
read number

#input validation to make sure the input we're receiving is a positive integer
#while the input is less than or equal to 0, we will continue to prompt them
# to enter a positive integer
while [ $number -le 0 ]
do
    echo "The number should be greater than 0"
    echo "Enter a positive integer"
    read number
done

echo "You entered $number"

# Create a counter variable which will start at 1 and then continue incrementing by 1 until it is equal to the $number variable
counter=1

# loop while the counter var is less than or equal to number
while [ $counter -le $number ]
do
    # I'm going to check if the number is divisible by 3
    # by using modulo operator
    # -eq compares two numbers for equality
    # If the counter is not divisible by 3
    # if [ $(($counter % 3)) -ne 0 ]
    # then
        # if the counter var is divisible by 5
    #    if [ $(($counter % 5)) -eq 0 ]
    #     then
            #  then echo "Buzz" instead of the number
    #         echo "Buzz"
    #     else
            # if not, print the number
    #         echo $counter
    #     fi
    # else
    #     # If not, which means, the number is indeed divisible by 3
    #     # print Fizz
    #     echo "Fizz"
    # fi

    # if [ $(($counter % 3)) -eq 0 ] && [ $(($counter % 5)) -eq 0 ]
    if [ $(($counter % 15)) -eq 0 ]
    then
        echo "FizzBuzz"
    elif [ $(($counter % 3)) -eq 0 ]
    then
        echo "Fizz"
    elif [ $(($counter % 5)) -eq 0 ]
    then
        echo "Buzz"
    else
        echo $counter
    fi
    # and then, we are incrementing the variable by 1
    counter=$((counter+1))
done