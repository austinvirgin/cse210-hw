using System;

class Program
{
    static void Main(string[] args)
    {
        string gradePercentageStr;
        int gradePercentage;
        Console.Write("What is your grade percentage? ");
        gradePercentageStr = Console.ReadLine();
        gradePercentage = int.Parse(gradePercentageStr);
        string gradeLetter;
        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else if (gradePercentage < 60)
        {
            gradeLetter = "F";
        }
        else
        {
            gradeLetter = "impossible";
        }
        Console.WriteLine($"You have a {gradeLetter} in the class.");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats you passed the class.");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}