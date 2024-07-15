public class UIManager
{
    Pipe pipe = new Pipe();

    public void GameDisplay(List<Obstacle> obstacles, Bird bird)
    {
        // Draw the game elements on the screen
        for (int x = 1; x < 26; x++)
        {
            for (int y = 1; y < 101; y++)
            {
                bool isObstacleDrawn = false; // Flag to check if an obstacle has been drawn in the current position
                foreach (Obstacle obstacle in obstacles)
                {
                    // Check if the current position is within the bounds of an obstacle
                    if (y >= obstacle.GetPositionBottom().Y && y <= obstacle.GetPositionTop().Y)
                    {
                        // Draw the obstacle
                        Console.Write(pipe.pipeWidth);
                        y += pipe.pipeWidth.Length - 1; // Skip the width of the pipe
                        isObstacleDrawn = true;
                        break;
                    }
                }

                if (!isObstacleDrawn)
                {
                    // Draw the bird if it's in the current position
                    if (y == bird.GetPosition().Y && x == bird.GetPosition().X)
                    {
                        Console.Write(bird.birdLook);
                        y += bird.birdLook.Length - 1; // Skip the width of the bird
                    }
                    else
                    {
                        // Draw an empty space if there's no obstacle or bird
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }

    public void ShowScore(int score)
    {
        // Logic to display the score on the screen (not implemented here)
    }

    public void ShowGameOver()
    {
        // Display the game over message
        Console.WriteLine("Game Over!");
    }

    public void StartScreen()
    {
        // Draw the start screen with instructions
        for (int x = 0; x < 25; x++)
        {
            for (int y = 0; y < 100; y++)
            {
                if (x == 12 && y == 41)
                {
                    Console.Write("Welcome to the game");
                    y += 19;
                }
                if (x == 13 && y == 40)
                {
                    Console.Write("Press enter to start!");
                    y += 21;
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
