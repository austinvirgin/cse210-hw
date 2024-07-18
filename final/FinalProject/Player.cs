public class Player
{
    UIManager uIManager = new UIManager();
    Bird bird = new Bird();
    // public Bird Bird {get: private set;}

    public bool CheckSpacebar()
    {
        // Method to check if the spacebar was pressed
        return true;
    }

    public void Update()
    {
        // Method to update the player's state
        bird.Update();
    }

    public void Jump()
    {
        // Method to make the player jump
        bird.Flap();
    }
}
