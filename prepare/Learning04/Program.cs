using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto Rodriguez", "Fractions");
        string homeworkList = assignment1.GetHomeworkList();
        string summary = assignment1.GetSummary();
        Console.WriteLine($"{summary}\n{homeworkList}");

        WritingAssignment writingAssignment1 = new WritingAssignment("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        string writingassignment = writingAssignment1.GetWritingInformation();
        string summary1 = writingAssignment1.GetSummary();
        Console.WriteLine($"{summary1}\n{writingassignment}");
    }
}