using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Game
{
    public List<Obstacle> obstacles = new List<Obstacle>();
    Bird bird = new Bird();
    CollisionManager collisionManager = new CollisionManager();
    GameController gameController = new GameController();
    GraphicsManager graphicsManager = new GraphicsManager();
    PhysicsManager physicsManager = new PhysicsManager();
    Pipe pipe = new Pipe();
    Player player = new Player();
    PowerUp powerUp = new PowerUp();
    ScoreManager scoreManager = new ScoreManager();
    SoundManager soundManager = new SoundManager();
    UIManager uIManager = new UIManager();

    private const int gapHeight = 10; // Gap height between the pipes
    private const int pipeWidth = 4; // Width of the pipes
    private const int obstacleSpacing = 30; // Distance between consecutive obstacles

    public async void StartGame()
    {
        InputHandler inputHandler = new InputHandler();
        await GameLoop(inputHandler);
    }

    public async Task GameLoop(InputHandler inputHandler)
    {
        int frameCount = 0; // Frame counter to track when to generate new obstacles
        const int targetFps = 60;
        const int frameTime = 1000 / targetFps;

        while (!collisionManager.CheckCollision(bird, obstacles))
        {
            var loopStart = DateTime.Now;
            
            if (inputHandler.IsSpacebarPressed())
            {
                bird.Flap();
            }

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
            
            // Draw the updated game state on the screen
            graphicsManager.DrawDisplay(uIManager, obstacles, bird);

            // Calculate remaining time for the frame and delay accordingly
            var processingTime = (DateTime.Now - loopStart).TotalMilliseconds;
            var delay = Math.Max(0, frameTime - processingTime);

            await Task.Delay((int)delay);

            Console.Clear();
            Console.CursorTop = Console.CursorLeft = 0;

            frameCount++;
        }

        // Show the game over screen when a collision is detected
        uIManager.ShowGameOver();
    }
}
