class Game
{
    public List<Entity> entities = new List<Entity>(){
        new Bird()
    };
    Bird bird;
    CollisionManager collisionManager = new CollisionManager();
    GameController gameController = new GameController();
    GraphicsManager graphicsManager = new GraphicsManager();
    Player player = new Player();
    ScoreManager scoreManager = new ScoreManager();
    UIManager uIManager = new UIManager();
    EndGame endGame = new EndGame();
    SaveLoad saveLoad = new SaveLoad();

    public Game(){
        bird = (Bird)entities[0];
    }
    private const int gapHeight = 10; // Gap height between the pipes
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

        while (!collisionManager.CheckCollision(bird, entities))
        {
            Console.Clear();
            loopStart = DateTime.Now;

            player.Update();

            // Generate a new obstacle at regular intervals based on the obstacle spacing
            if (frameCount % obstacleSpacing == 0)
            {
                entities.Add(new Obstacle(gapHeight));
            }

            // Remove obstacles that have moved off the screen
            entities.RemoveAll(e => e is Obstacle && ((Obstacle)e).IsOffScreen());

            // Update the positions of all game elements
            foreach (Entity entity in entities){
                entity.Update();
            }

            // Increment score if the bird passes through a pipe
            foreach (var entity in entities)
            {
                if (entity is Obstacle obstacle && obstacle.GetPositionTop().X == bird.GetPosition().X)
                {
                    scoreManager.IncrementScore();
                }
            }

            // Draw the updated game state on the screen
            graphicsManager.DrawDisplay(uIManager, entities);

            // Calculate remaining time for the frame and delay accordingly
            var processingTime = (DateTime.Now - loopStart).TotalMilliseconds;
            var delay = Math.Max(0, frameTime - processingTime);

            await Task.Delay((int)delay);

            Console.CursorTop = Console.CursorLeft = 0;

            frameCount++;
        }
        inputHandler.Stop();
        EndGameSequence();
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
        endGame.ShowMenu(currentScore, highScore);
    }

    public int GetHighScore(){
        return saveLoad.LoadHighScore();
    }
}
