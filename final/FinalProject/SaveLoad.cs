using System;
using System.IO;

public class SaveLoad
{
    private const string SaveFilePath = "highscore.txt";

    public void SaveHighScore(int score)
    {
        try
        {
            File.WriteAllText(SaveFilePath, score.ToString());
            Console.WriteLine("Progress saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving progress: " + ex.Message);
        }
    }

    public int LoadHighScore()
    {
        try
        {
            if (File.Exists(SaveFilePath))
            {
                string scoreText = File.ReadAllText(SaveFilePath);
                if (int.TryParse(scoreText, out int highScore))
                {
                    return highScore;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading progress: " + ex.Message);
        }

        return 0; // Return 0 if no high score is found or if an error occurs
    }
}
