using System;
using System.Collections.Generic;
using System.IO.Pipes;

class Game
{
    //All things will be initalized and started through here
    public List<Obstacle> obstacles = new List<Obstacle>();
    Bird bird = new Bird();
    CollisionManager collisionManager = new CollisionManager();
    GameController gameController = new GameController();
    GraphicsManager graphicsManager = new GraphicsManager();
    InputHandler inputHandler = new InputHandler();
    //Obstacle obstacle = new Obstacle();
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
    public void StartGame()
    {
        gameController.StartGame(uIManager, inputHandler);
        GameGoing();
    }

    public void GameLoop()
    {
        int frameCount = 0; // Frame counter to track when to generate new obstacles
        while (!collisionManager.CheckCollision(bird, obstacles))
        {
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

            // Pause for a short time to control the game speed
            Thread.Sleep(100);
            // Clear the console for the next frame
            //Console.Clear();
            Console.CursorTop= Console.CursorLeft=0;

            frameCount++;
        }

        // Show the game over screen when a collision is detected
        uIManager.ShowGameOver();
    }
}