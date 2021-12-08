#!usr/bin/bash

# Expected behavior
# generate random number
# ask user for a guess
# tell if they were under or over
# tell how far using hot, cold, warm
#tell them how many times they tri

 try=0 

randomNum=$(($RANDOM % 100))

# echo $randomNum

echo "Let's play! Please enter a number between 0 and 100"
read number

if [ $number -gt $randomNum ]
then
    diff1=$(($number - $randomNum))
fi

if [ $number -lt $randomNum ]
then 
    diff2=$(($randomNum - $number))
fi
while [ $number != $randomNum ]
do
    try=try+1
    if [ $number -gt $randomNum ]
    then
            echo " $number is greater than the number." 
            if [ $diff1 -le 20 ]
            then 
                echo "Incorrect, the number is less than $number. You are getting warmer"
            elif [ $diff1 -le 35 ]
            then 
                 echo "Incorrect, the number is less than $number. You are warm"
            elif [ $diff1 -le 60]
            then    
                echo "Incorrect,the number is less than $number. You are getting cold."
             elif [ $diff1 -le 99 ]
             then 
                echo "Incorrect, the number is less than $number. You are getting colder."21
            fi
    elif [ $number -lt $randomNum ]
    then
        echo " $number is less than the number." 
            if [ $diff2 -le 20 ]
            then 
                echo "Incorrect, the number is greater than $number. You are getting warmer"
            elif [ $diff2 -le 35 ]
            then 
                 echo "Incorrect, the number is greater than $number. You are warm"
            elif [ $diff2 -le 60] 
            then    
                echo "Incorrect,the number is greater than $number. You are getting cold."
             elif [ $diff2 -le 99 ]
             then 
                echo "Incorrect, the number is greater than $number. You are getting colder."
            fi
    fi
echo "Try again. Please enter a number between 0 and 100"
read number
done


#for how many times it was guessed 

if [ $randomNum = $number ]
then
    echo "Congratulations! You got the number it took you $try1 many times!"
fi