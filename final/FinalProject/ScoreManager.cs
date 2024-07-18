public class ScoreManager
{
    private int score;

    public ScoreManager()
    {
        // Constructor for ScoreManager
        score = 0;
    }

    public void IncrementScore()
    {
        // Method to increment the score
        score++;
    }

    public int GetScore()
    {
        // Method to get the current score
        return score;
    }
}
