using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string stop;
            do
            {
                Game game = new Game();
                game.StartGame();
                Console.Clear();
                Console.Write("Please enter quit to exit the game if you still want to play just press enter: ");
                stop = Console.ReadLine();
                stop = stop.ToLower();
            } while (stop != "quit");
        }
        
    }