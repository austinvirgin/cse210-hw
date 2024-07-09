using System;
using System.Collections.Generic;

class Game:UIManager
{
    
}

public enum GameState
{
    NotStarted,
    Running,
    Paused,
    Ended
}

public class Game
{
    private GameState gameState;
    private int score;
    private Player player;
    private List<Obstacle> obstacles;
    private ScoreManager scoreManager;
    private SoundManager soundManager;
    private InputHandler inputHandler;
    private GraphicsManager graphicsManager;
    private PhysicsManager physicsManager;
    private CollisionManager collisionManager;
    private Background background;
    private UIManager uiManager;
    private PowerUp powerUp;
    private GameController gameController;

    public Game()
    {
        gameState = GameState.NotStarted;
        score = 0;
        player = new Player();
        obstacles = new List<Obstacle>();
        scoreManager = new ScoreManager();
        soundManager = new SoundManager();
        inputHandler = new InputHandler();
        graphicsManager = new GraphicsManager();
        physicsManager = new PhysicsManager();
        collisionManager = new CollisionManager();
        background = new Background();
        uiManager = new UIManager();
        powerUp = new PowerUp();
        gameController = new GameController(this);
    }

    public void Start()
    {
        gameState = GameState.Running;
        gameController.StartGame();
    }

    public void Update()
    {
        if (gameState == GameState.Running)
        {
            inputHandler.GetInput();
            player.Update();
            foreach (var obstacle in obstacles)
            {
                obstacle.Update();
            }
            collisionManager.CheckCollision(player.Bird, obstacles);
            physicsManager.ApplyGravity(player.Bird);
            physicsManager.ApplyVelocity(player.Bird);
            scoreManager.IncrementScore();
            graphicsManager.DrawBird(player.Bird);
            graphicsManager.DrawObstacle(obstacles);
            uiManager.ShowScore(score);
        }
    }

    public void Draw()
    {
        // Drawing logic, typically in a game loop
    }
}
