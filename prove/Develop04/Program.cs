using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListerActivity listerActivity = new ListerActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int activityChoice;
        do
        {
            Console.Write("Which activity would you like to do (1.Breathing Activity 2.Reflection Activity 3.Lister Activity 4.Quit) ");
            activityChoice = int.Parse(Console.ReadLine());
            switch (activityChoice)
            {
                case 1:
                    DoChoiceActions(breathingActivity);
                    break;

                case 2:
                    DoChoiceActions(reflectionActivity);
                    break;

                case 3:
                    DoChoiceActions(listerActivity);
                    break;

                case 4:
                    EndingChoice();
                    break;

                default:
                    Console.WriteLine("Please try again the choice you made is invalid.");
                    break;
            }
        } while (activityChoice != 4);

        void DoChoiceActions(Activity activity){
            activity.StartProgram();
            activity.SetDuration(UserDuration());
            activity.Interact();
            activity.EndProgram();
            activity.ActivityCount();
        }  

        void EndingChoice(){
            Console.WriteLine("Thank you for taking some time to be mindful.");
            breathingActivity.PrintActivityCount();
            reflectionActivity.PrintActivityCount();
            listerActivity.PrintActivityCount();
        }

        int UserDuration(){
            Console.Write("How long, in seconds, would you like to be in this activity? ");
            int userDuration = int.Parse(Console.ReadLine());
            return userDuration;
        }

    }
}