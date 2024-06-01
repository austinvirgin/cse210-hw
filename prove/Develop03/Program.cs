using System;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Refrence refrence = new Refrence(11, 12);
        string answer;
        bool alreadyHidden;
        do
        {
            ClearConsole();
            DisplayScripture();
            answer = GetAnswer();
            if (AllNonHiddenNum() >= 3){
                HideWords();
            }
            else{
                HideWords(AllNonHiddenNum());
            }
        } while (answer != "quit" && AllHidden() == false);

        void DisplayScripture(){
            Console.WriteLine($"{refrence.GetBook()}:{refrence.GetChapter()}");
            refrence.DisplayVerse();
        }

        static string GetAnswer(){
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string answer = Console.ReadLine();
            return answer;
        };

        static void ClearConsole(){
            Console.Clear();
        }

        void HideWords(int hidden = 3){
            for (int i = 0; i < hidden; i++)
            {
                do{
                    Random random = new Random();
                    int randInt = random.Next(0, refrence.Count());
                    List<Verse> versenum = refrence._verses;
                    Verse numindex = versenum[randInt];
                    Random random1 = new Random();
                    int randInt1 = random1.Next(0, numindex.Count());
                    alreadyHidden = numindex._words[randInt1].AllHidden();
                    numindex._words[randInt1].SetHidden(true);
                } while (alreadyHidden == true);

            } 
        }

        bool AllHidden(){
            return refrence.AllHidden();
        }

        int AllNonHiddenNum(){
            return refrence.AllNonHiddenNum();
        }
    }
}