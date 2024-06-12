using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int activityChoice;
        do
        {
            Console.Write("Which activity would you like to do (1. Breathing Activity 2. Reflection Activity 3. Lister Activity 4. Quit)");
            activityChoice = int.Parse(Console.ReadLine());
            switch (activityChoice)
            {
                case 1:
                    BreathingChoice();
                    break;

                case 2:
                    ReflectionChoice();
                    break;

                case 3:
                    ListerChoice();
                    break;

                case 4:
                    EndingChoice();
                    break;

                default:
                    Console.WriteLine("Please try again the choice you made is invalid.");
                    break;
            }
        } while (activityChoice != 4);

        void BreathingChoice(){
            Timer timer = new Timer();
            Welcome("Breathing Activity");
            int userDuration = UserDuration();
            BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Breathing Activity", userDuration);
        }

        void ReflectionChoice(){
            Timer timer = new Timer();
        }  

        void ListerChoice(){
            Timer timer = new Timer();
        }

        void EndingChoice(){
            Console.WriteLine("Thank you for taking some time to be mindful.");
        }

        void Welcome(string type){
            Console.WriteLine($"Welcome to the {type}");
        }

        int UserDuration(){
            Console.Write("How long would you like to be in this activity? ");
            int userDuration = int.Parse(Console.ReadLine());
            return userDuration;
        }

    }
}