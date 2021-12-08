# Shell Scripting Activity:
# Write a number guessing game where the user has to guess a randomly generated secret number between 0 and 100. After each guess, tell the user if they guessed it right, and if not, tell the user if they were over or under and how far off their guess was using temperature adjectives (hot, warm, cold, etc..). Also in each try, display how many times they have tried so far.

# Hint: Bash has built in function $RANDOM that generates a pseudo random number between 0 and 32767. use Modulo operator to restrict the bounds of the random number (ie, for a random number between 0 and 10, $RANDOM % 10)

# Expected Behavior
# First, generate a random number
# ask user for a guess
# tell them whether they were over or under and how far off they were
# also tell them how many times they've tried so far


randomNum=$(($RANDOM % 100))

echo $randomNum