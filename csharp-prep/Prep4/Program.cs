using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber;
        int userSum = 0;
        float userAverage;
        do {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);
        foreach (int number in numbers)
        {
           userSum += number; 
        }
        userAverage = ((float)userSum)/numbers.Count;
        int largest = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        int smallest = largest;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (0 < numbers[i] && numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {userSum}");
        Console.WriteLine($"The average is: {userAverage}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}