public class ScoreManager
{
    private int score;

    public ScoreManager()
    {
        score = 0;
    }

    public void IncrementScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
