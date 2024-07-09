using system.Numerics;
public class Bird
{
    birdLook =" ^/n"
    public Vector2 Position {get:private set; }
    public Vector2 Velocity {get: private set; }

    public bird()
    {
        Position = new Vector2(0,0);
        Velocity = new Vector2(0,0);
    }

    public void Flap()
    {
        Velocity = new Vector2(0,-5);
    }

    public void Update()
    {
        Position=+ Velocity;
    }
}