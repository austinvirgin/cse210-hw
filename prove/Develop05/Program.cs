using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Globalization;
using System.Dynamic;

class Program
{
    public List<Goal> goals = new List<Goal>();
    int totalScore;

    static void Main(string[] args)
    {
        Program program = new Program();
        int userResponse;
        do
        {
            userResponse = program.GetUserResponse();
            program.DoChoice(userResponse);
            program.TotalScore();
            Console.WriteLine($"\nYou have {program.totalScore} points.\n");
            int level = program.GetLevel();
            Console.WriteLine($"You are level {level}\n");
        } while (userResponse != 6);
    }

    int GetUserResponse(){
        int userResponse;
        Console.WriteLine("Menu Options: \n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
        Console.Write("Select a choice from the menu: ");
        userResponse = int.Parse(Console.ReadLine());
        return userResponse;
    }

    void DoChoice(int userResponse){
        switch (userResponse)
        {
            case 1:
                NewGoal();
                break;
            case 2:
                DisplayGoals();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("That was invalid please try again.");
                break;
        }
    }

    void NewGoal(){
        Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());
        MakeGoal(goalChoice);
    }

    void MakeGoal(int goalChoice){
        switch (goalChoice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                GoalSetup(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal();
                GoalSetup(eternalGoal);
                break;
            case 3: 
                ChecklistGoal checklistGoal = new ChecklistGoal();
                GoalSetup(checklistGoal);
                break;
            default:
                Console.WriteLine("The number you used was invalid.");
                break;
        }
    }

    void GoalSetup(Goal goal){
    goal.CreateGoal();
    goals.Add(goal);
    }

    void DisplayGoals(){
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            Console.Write($"{count}. ");
            goal.Display();
            totalScore += goal.GetScore();
            count += 1;
        }
        Console.WriteLine();
    }

    void SaveGoals(){
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                string stringrep = goal.GetStringRepresentation();
                outputfile.WriteLine(stringrep);
            }
        }
        Console.WriteLine($"{filename} has been saved.\n");
    }

    void LoadGoals(){
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            if (goalType == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal();
                AddGoal(checklistGoal, parts);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                AddGoal(eternalGoal, parts);
            }
            else
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                AddGoal(simpleGoal, parts);
            }
        }
        Console.WriteLine($"{filename} has been loaded up.");
    }
    void AddGoal(Goal goal, string[] parts){
        goal.SetGoal(parts[1]);
        goals.Add(goal);
    }
    void RecordEvent(){
        int number = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"\t{number}. {goal.GetGoalName()}");
            number += 1;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine());
        goalAccomplished -= 1;
        Goal goal1 = goals[goalAccomplished];
        goal1.ScoreUp();
        TotalScore();
        Console.WriteLine($"You now have {totalScore} points.");
    }
    void TotalScore(){
        totalScore = 0;
        foreach (Goal goal in goals)
        {
            totalScore += goal.GetScore();
        }
    }
    int GetLevel(){
        if (totalScore < 500){
            return 1;
        }
        else if (totalScore < 2000){
            return 2;
        }
        else if (totalScore < 5000){
            return 3;
        }
        else{
            return 4;
        }
    }
}