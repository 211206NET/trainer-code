Console.WriteLine("FizzBuzz");
// Console.WriteLine("Enter a positive integer");

// //This is string variable
// string input = Console.ReadLine();

// //We are taking whatever user typed and printing it back out to the console
// Console.WriteLine("You entered " + input);

// //Next, we are parsing string input into number so we can do arithmetic on it
// int number = int.Parse(input);

// //While Loop (executes 0 or more)
// while (number <= 0)
// {
//     Console.WriteLine("The number should be greater than 0");
//     Console.WriteLine("Enter a positive number");
//     input = Console.ReadLine();
//     number = int.Parse(input);
// }


string input = "";
int number = 0;

//Do While Loop (executes 1 or more times)
do
{
    Console.WriteLine("Enter a positive number");
    input = Console.ReadLine();
    number = int.Parse(input);

    if(number <= 0)
    {
        Console.WriteLine("The number should be greater than 0");
    }
} while(number <= 0);

//Next I'm going to count up to the number and print them in console using while loop
// int counter = 1;
// while(counter <= number)
// {
//     Console.WriteLine(counter);
//     counter++;
// }

//Another way to do this, is by using for loop
for(int i = 1; i <= number; i++)
{
    if(i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}