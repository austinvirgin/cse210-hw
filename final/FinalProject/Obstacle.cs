using System.Numerics;

public class Obstacle
{
    public Vector2 Position { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Obstacle(Vector2 position, int width, int height)
    {
        Position = position;
        Width = width;
        Height = height;
    }

    public virtual void Update()
    {
        Position = new Vector2(Position.X - 2, Position.Y); // Move to the left
    }

    public virtual void Draw()
    {
        // Drawing logic for the obstacle
    }
}
