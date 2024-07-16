using System.Numerics;
public class Obstacle
{
    public Vector2 PositionTop { get; private set; }
    public Vector2 PositionBottom { get; private set; }
    private int gapHeight; // Height of the gap between the top and bottom pipes
    private int pipeWidth; // Width of the pipes

    public Obstacle(int gapHeight, int pipeWidth)
    {
        this.gapHeight = gapHeight;
        this.pipeWidth = pipeWidth;
        CreateObstacle();
    }

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

    public bool IsOffScreen()
    {
        // Check if the pipes have moved off the screen
        return PositionTop.Y < 0;
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