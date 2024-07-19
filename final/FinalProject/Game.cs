class Game
{
    public List<Obstacle> obstacles = new List<Obstacle>();
    Bird bird = new Bird();
    CollisionManager collisionManager = new CollisionManager();
    GameController gameController = new GameController();
    GraphicsManager graphicsManager = new GraphicsManager();
    Player player = new Player();
    ScoreManager scoreManager = new ScoreManager();
    UIManager uIManager = new UIManager();
    EndGame endGame = new EndGame();
    SaveLoad saveLoad = new SaveLoad();

    private const int gapHeight = 10; // Gap height between the pipes
    private const int pipeWidth = 4; // Width of the pipes
    private const int obstacleSpacing = 30; // Distance between consecutive obstacles

    public async void StartGame()
    {
        gameController.StartGame();
        InputHandler inputHandler = new InputHandler(bird);
        await GameLoop(inputHandler);
    }

    public async Task GameLoop(InputHandler inputHandler)
    {
        int frameCount = 0; // Frame counter to track when to generate new obstacles
        const int targetFps = 60;
        const int frameTime = 1000 / targetFps;

        DateTime loopStart;

        while (!collisionManager.CheckCollision(bird, obstacles))
        {
            Console.Clear();
            loopStart = DateTime.Now;

            player.Update();

            // Generate a new obstacle at regular intervals based on the obstacle spacing
            if (frameCount % obstacleSpacing == 0)
            {
                obstacles.Add(new Obstacle(gapHeight, pipeWidth));
            }

            // Remove obstacles that have moved off the screen
            obstacles.RemoveAll(o => o.IsOffScreen());

            // Update the positions of all game elements
            graphicsManager.MoveEverything(bird, obstacles);

            // Increment score if the bird passes through a pipe
            foreach (var obstacle in obstacles)
            {
                if (obstacle.GetPositionTop().X == bird.GetPosition().X)
                {
                    scoreManager.IncrementScore();
                }
            }

            // Draw the updated game state on the screen
            graphicsManager.DrawDisplay(uIManager, obstacles, bird);

            // Calculate remaining time for the frame and delay accordingly
            var processingTime = (DateTime.Now - loopStart).TotalMilliseconds;
            var delay = Math.Max(0, frameTime - processingTime);

            await Task.Delay((int)delay);

            Console.CursorTop = Console.CursorLeft = 0;

            frameCount++;
        }
        inputHandler.Stop();
        endGame.ShowMenu();
        int choice = endGame.GetUserChoice();
    }
    public void EndGameSequence()
    {
        int highScore = saveLoad.LoadHighScore();
        int currentScore = scoreManager.GetScore();
        
        if (currentScore > highScore)
        {
            saveLoad.SaveHighScore(currentScore);
            highScore = currentScore;
        }
        Console.WriteLine($"Final Score: {currentScore}");
        Console.WriteLine($"High Score: {highScore}");
    }

    public int GetHighScore(){
        return saveLoad.LoadHighScore();
    }
}
