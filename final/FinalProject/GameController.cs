class GameController
{
    public void StartGame(){
        UIManager uIManager = new UIManager();
        uIManager.StartScreen();
        InputHandler inputHandler = new InputHandler();
        if (inputHandler.ClickedEnter()){
            Console.WriteLine("Welcome to the game!");
        }
    }
}