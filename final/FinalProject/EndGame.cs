public class EndGame
{
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Game Over");
        Console.WriteLine("1. Save Progress");
        Console.WriteLine("2. Load High Score");
        Console.WriteLine("3. Play a New Game");
        Console.WriteLine("4. Quit");
    }

    public int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
        }
        return choice;
    }
}
