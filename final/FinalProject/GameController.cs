class GameController
{
    public void StartGame(UIManager uIManager, InputHandler inputHandler){
        uIManager.StartScreen();
        if (inputHandler.ClickedEnter()){
            Console.Clear();
            Console.WriteLine("Welcome to the game!");
            Thread.Sleep(300);
            Console.Clear();
        }
    }
}