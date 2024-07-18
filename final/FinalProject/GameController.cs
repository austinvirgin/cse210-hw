class GameController
{
    Bird bird = new();
    private InputHandler _inputHandler;

    public GameController()
    {
        // Constructor for GameController
        _inputHandler = new InputHandler(bird);
    }

    public void StartGame()
    {
        // Method to start the game
        UIManager uIManager = new UIManager();
        uIManager.StartScreen();
        if (_inputHandler.ClickedEnter())
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game!");
            Thread.Sleep(300);
            Console.Clear();
        }
    }

    public void StopGame()
    {
        // Method to stop the game
        _inputHandler.Stop();
    }
}
