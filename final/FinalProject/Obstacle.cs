using System.Numerics;

public class Obstacle
{
    public Vector2 PositionTop { get; private set; }
    public Vector2 PositionBottom { get; private set; }

    public void CreateObstacle(){
        Random random = new Random();
        int randInt = random.Next(11, 99);
        PositionTop = new Vector2(25, randInt);
        PositionBottom = new Vector2(25, randInt - 10);
    }

    public virtual void Update()
    {
        PositionTop = new Vector2(PositionTop.X - 2, PositionTop.Y); // Move to the left
        PositionBottom = new Vector2 (PositionBottom.X - 2, PositionBottom.Y);
    }

    public virtual void Draw()
    {
        // Drawing logic for the obstacle
    }
}
