class GameController
 {
    Bird bird = new();
    private InputHandler _inputHandler;

    public GameController(){
        _inputHandler = new InputHandler(bird);
    }
     public void StartGame(){
         UIManager uIManager = new UIManager();
         uIManager.StartScreen();
        if (_inputHandler.ClickedEnter()){
            Console.Clear();
            Console.WriteLine("Welcome to the game!");
            Thread.Sleep(300);
            Console.Clear();
        }

    }

    public void StopGame(){
        _inputHandler.Stop();
    }
}
