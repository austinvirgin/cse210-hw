using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static public Journal journal;
    static void Main(string[] args)
    {
        journal = new Journal();
        int userChoice;
        do {
            Console.WriteLine("Please select one of the following choices: \n 0. Write \n 1. Display \n 2. Load \n 3. Save \n 4. Quit");
            userChoice = GetUserChoice();
            ChoiceDecision(userChoice);
        } while (userChoice != 4);
    }

    static int GetUserChoice(){
        Console.Write("What would you like to do? ");
        int userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }
    
    static void ChoiceDecision(int userChoice){
        switch (userChoice){
            case 0:
                WriteEntry();
                break;
            case 1:
                DisplayJournal();
                break;
            case 2:
                LoadJournal();
                break;
            case 3:
                SaveJournal();
                break;
            case 4:
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Error");
                break;
    }

    static void WriteEntry(){
        journal.AddEntry();
    }

    static void DisplayJournal(){
        journal.DisplayEntries();
    }

    static void LoadJournal(){
        journal.Load();
    }

    static void SaveJournal(){
        journal.Save();
    }
}
}