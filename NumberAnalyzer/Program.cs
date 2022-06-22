
Console.WriteLine("Welcome to the number analyzer, What is your name?");
string name = Console.ReadLine();
bool runAgain = true;

while (runAgain == true)
{
    Console.WriteLine("Please enter a whole number between 1-100");
    int userInput = int.Parse(Console.ReadLine());

    Console.WriteLine("You entered the number " + userInput + ", ");

    if (userInput < 60 && userInput % 2 == 1)
    {
        Console.WriteLine(name + ", " + userInput + " is Odd and less than 60");
    }
    else if ((2 <= userInput) && (userInput <= 24) && (userInput % 2 == 0))
    {
        Console.WriteLine(name + ", that number is even and less than 25");
    }
    else if ((userInput % 2 == 0) && (userInput <= 60) && (userInput >= 26))
    {
        Console.WriteLine(name + ", that number is even and between 26 and 60 inclusive");
    }
    else if ((userInput % 2 == 0) && (userInput > 60) && (userInput < 100))
    {
        Console.WriteLine(name + ", " + userInput + " is even and greater than 60");
    }
    else if ((userInput % 2 == 1) && (userInput > 60) && (userInput < 100))
    {
        Console.WriteLine(name + ", " + userInput + " is odd and greater than 60");
    }
    else if ((userInput > 100) || (userInput < 1))
    {
        Console.WriteLine(name + ", Please enter a whole number between 1 and 100");
    }
    Console.WriteLine("Would you like to run again? y/n");
    string response = Console.ReadLine().ToLower();
    if (response == "y")
    {
        runAgain = true;
    }
    else if (response == "n")
    {
        Console.WriteLine("Thanks for using the number analyzer, " + name + ", have a great day!");
        runAgain = false;
    }
    else
    {
        Console.WriteLine("I see that you think you're too good to tpye out 'y' or 'n', " + name);
        Console.WriteLine("Fine. I'll end the program if you don't want to take it seriously.");
        runAgain = false;
    }
}
