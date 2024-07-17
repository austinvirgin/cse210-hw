using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class UIManager
{
    Pipe pipe = new Pipe();
    public void GameDisplay(List<Obstacle> obstacles, Bird bird)
{
    for (int y = 0; y < 25; y++)
    {
        for (int x = 0; x < 100; x++)
        {
            bool drawn = false;

            foreach (Obstacle obstacle in obstacles)
            {
                if (x == obstacle.GetPositionTop().X && y <= obstacle.GetPositionTop().Y)
                {
                    Console.Write(pipe.pipeWidth);
                    x += 3;
                    drawn = true;
                }
                else if (x == obstacle.GetPositionBottom().X && y >= obstacle.GetPositionBottom().Y)
                {
                    Console.Write(pipe.pipeWidth);
                    x += 3; // Adjusted from y += 4 to x += 3
                    drawn = true;
                }
            }

            if (!drawn)
            {
                Vector2 birdPos = bird.GetPosition();
                if (x == (int)birdPos.X - 1 && y == (int)birdPos.Y)
                {
                    Console.Write("\\");
                    drawn = true;
                }
                else if (x == (int)birdPos.X && y == (int)birdPos.Y)
                {
                    Console.Write("( >");
                    x += 2; // Adjusted from y += 3 to x += 2
                    drawn = true;
                }
                else if (x == (int)birdPos.X + 1 && y == (int)birdPos.Y)
                {
                    Console.Write("/");
                    drawn = true;
                }
            }

            if (!drawn)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
    public void ShowScore(int score){

    }

    public void ShowGameOver(){
        
    }

     public void StartScreen()
    {
        // Draw the start screen with instructions
        for (int x = 0; x < 25; x++)
        {
            for (int y = 0; y <100; y++)
            {
                if (x == 12 && y == 41){
                    Console.Write("Welcome to the game");
                    y += 19;
                }
                if (x == 13 && y == 40){
                    Console.Write("Press enter to start!");
                    y += 21;
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
