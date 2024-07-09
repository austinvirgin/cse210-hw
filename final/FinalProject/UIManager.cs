using System.Runtime.InteropServices;

class UIManager
{
    public void ShowScore(int score){

    }

    public void ShowGameOver(){
        
    }

    public void StartScreen(){
        for (int i = 0; i < 25; i++)
        {
            for (int z = 0; z <100; z++)
            {
                if (i == 12 && z == 41){
                    Console.Write("Welcome to the game");
                    z += 19;
                }
                if (i == 13 && z == 40){
                    Console.Write("Press enter to start!");
                    z += 21;
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}