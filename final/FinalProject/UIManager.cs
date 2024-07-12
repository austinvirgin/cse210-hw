using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class UIManager
{
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

    public void CreateObstacle(Obstacle obstacle){
                obstacle.CreateObstacle();
    }
}