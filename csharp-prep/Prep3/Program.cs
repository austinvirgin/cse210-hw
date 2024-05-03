using System;

class Program
{
    static void Main(string[] args)
    {
        string userNumberStr;
        int magicNumber;
        int userNumber;
        string goAgain = "yes";
        while (goAgain == "yes")
        {
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101);
            int userGuesses = 0;
            do {
                Console.Write("What is your guess? ");
                userNumberStr = Console.ReadLine();
                userNumber = int.Parse(userNumberStr);
                if (userNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                userGuesses++;
            } while (userNumber != magicNumber);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {userGuesses} guesses to find the answer.");
            Console.Write("Would you like to go again? ");
            goAgain = Console.ReadLine();
        }
    }
}