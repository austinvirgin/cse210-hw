public class Player
{
    public Bird Bird {get: private set;}

    public Player()
    {
        Bird bird= new Bird();

    }

    public void Update()
    {
        bird.Update();
    }

    public void Jump()
    {
        bird.Flap();
    }
}