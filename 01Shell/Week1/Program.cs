//Going to do this using While loops 

//creating random number
Random random = new Random();

int randomNum = random.Next(1,101);
int counter = 0;

//to read the number put in

string input = Console.ReadLine();
int num = int.Parse(input);

do
{
    Console.WriteLine("Let's play! Please enter a positive integer between 0 and 100");
    input = Console.ReadLine();
    num = int.Parse(input);
    if(num <0 || num >100)
    {
        Console.WriteLine("The number should be between 0 and 100");
    }
} while(num <0 || num >100);

int diff = Math.Abs(num - randomNum);

while(num != randomNum)
{
    counter++;
    if(num > randomNum)
    {
        Console.WriteLine( "Incorrect! " + num + " is greater than the number.");
        if(diff <=15)
        {
            Console.WriteLine("You are getting warmer");
        }
        else if(diff >15 || diff <=30 )
        {
            Console.WriteLine("You are warm.");
        }
        else if(diff >30 || diff <=50)
        {
            Console.WriteLine("You are cold");
        }
        else if(diff >=51)
            Console.WriteLine("You are getting colder");
        }
    else if (num < randomNum)
    {
        Console.WriteLine("Incorrect! " + num + " is less than the number.");
        if(diff <=15)
        {
            Console.WriteLine("You are getting warmer");
        }
        else if(diff >15 || diff <=30)
        {
            Console.WriteLine("You are warm");
        }
        else if(diff >30 || diff <=50)
        {
            Console.WriteLine("You are cold");
        }
        else if(diff >=51)
        {
            Console.WriteLine("You are getting colder");
        }
    }
    Console.WriteLine("Try again. Please enter a number between 0 and 100.");
    input = Console.ReadLine();
    num = int.Parse(input);
}

//for how many times it was guessed

if (num == randomNum)
{
    Console.WriteLine("Congratulations!! You got the number! It took you " + counter + " tries");
}