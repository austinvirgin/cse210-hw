using System;

class Program
{
    static void Main(string[] args)
    {
        string magicNumberStr;
        string userNumberStr;
        int magicNumber;
        int userNumber;
        Console.Write("What is the magic number? ");
        magicNumberStr = Console.ReadLine();
        magicNumber = int.Parse(magicNumberStr);
        do
        {
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
        } while (userNumber != magicNumber);
        Console.WriteLine("You guessed it!");
    }
}