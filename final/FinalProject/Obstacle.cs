using System.Numerics;

public class Obstacle
{
    public Vector2 PositionTop { get; private set; }
    public Vector2 PositionBottom { get; private set; }

    public void CreateObstacle(){
        Random random = new Random();
        int randInt = random.Next(11, 25);
        PositionTop = new Vector2(randInt, 96);
        PositionBottom = new Vector2(randInt - 10, 96);
    }

    public virtual void Update()
    {
        PositionTop = new Vector2(PositionTop.X, PositionTop.Y - 2); // Move to the left
        PositionBottom = new Vector2 (PositionBottom.X, PositionBottom.Y - 2);
    }

    public virtual void Draw()
    {
        // Drawing logic for the obstacle
    }

    public Vector2 GetPositionTop(){
        return PositionTop;
    }

    public Vector2 GetPositionBottom(){
        return PositionBottom;
    }
}
