using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class UIManager
{
    Pipe pipe = new Pipe();
    public void GameDisplay(List<Obstacle> obstacles, Bird bird){
        for (int x = 1; x < 26; x++)
        {
            for (int y = 1; y <101; y++)
            {
                foreach (Obstacle obstacle in obstacles)
                {
                   if (y == obstacle.GetPositionTop().Y && x >= obstacle.GetPositionTop().X){
                        Console.Write(pipe.pipeWidth);
                        y += 4;
                   }
                   else if (y == obstacle.GetPositionBottom().Y && x <= obstacle.GetPositionBottom().X){
                        Console.Write(pipe.pipeWidth);
                        y += 4;
                   }

                   else if (y == bird.GetPosition().Y && x == bird.GetPosition().X){
                        Console.Write(bird.birdLook);
                        y += 1;
                   }
                   
                }
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
    public void ShowScore(int score){

    }

    public void ShowGameOver(){
        
    }

    public void StartScreen(){
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
