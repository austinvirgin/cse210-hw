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
    Obstacle obstacle = new Obstacle();
    PhysicsManager physicsManager = new PhysicsManager();
    Pipe pipe = new Pipe();
    Player player = new Player();
    PowerUp powerUp = new PowerUp();
    ScoreManager scoreManager = new ScoreManager();
    //SoundManager soundManager = new SoundManager();
    UIManager uIManager = new UIManager();

    public void StartGame()
    {
        gameController.StartGame(uIManager, inputHandler);
        GameGoing();
    }

    public void GameGoing(){
        int turnsGone = 0;
        obstacle.CreateObstacle();
        obstacles.Add(obstacle);
        while (!collisionManager.CheckCollision(bird, obstacles))
        {
            if (turnsGone == 20)
            {
                obstacle.CreateObstacle();
                obstacles.Add(obstacle);
                turnsGone = 0;
            }
            turnsGone += 1;
            // Task<bool> spacebar = inputHandler.SpaceBarPress();
            // if (spacebar.Result == true){
            //     player.Jump();
            // }
            graphicsManager.MoveEverything(bird, obstacles);
            graphicsManager.DrawDisplay(uIManager, obstacles, bird);
            Thread.Sleep(100);
            Console.Clear();
        }
    }
}
