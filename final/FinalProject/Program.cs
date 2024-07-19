using System.Security.Cryptography;

public class Program
{
    EndGame endGame = new EndGame();
    ScoreManager scoreManager = new ScoreManager();
    SaveLoad saveLoad = new SaveLoad();
    static void Main(string[] args)
    {
        Program program = new Program();

        do
        {
            Game game = new Game();
            game.StartGame();
            Console.Clear();
            game.EndGameSequence();
            program.Choices(); 
        } while (true);
    }

    void Choices(){        
        switch (endGame.GetUserChoice())
        {
            case 1:
                saveLoad.SaveHighScore(scoreManager.GetScore());
                break;
            case 2:
                int highScore = saveLoad.LoadHighScore();
                Console.WriteLine("High Score: " + highScore);
                break;
            case 3:
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
    }
}
