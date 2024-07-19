using System.Numerics;

public class Obstacle : Entity
{
    private Vector2 PositionTop { get; set; }
    private Vector2 PositionBottom { get; set; }
    private int gapHeight; // Height of the gap between the top and bottom pipes

    public Obstacle(int gapHeight)
    {
        // Constructor for Obstacle
        this.gapHeight = gapHeight;
        CreateObstacle();
    }

    public void CreateObstacle()
    {
        // Method to create a new obstacle
        Random random = new Random();
        int randInt = random.Next(11, 25);
        PositionTop = new Vector2(96, randInt);
        PositionBottom = new Vector2(96, randInt - gapHeight);
    }

    public override void Update()
    {
        // Method to update the position of the obstacle
        PositionTop = new Vector2(PositionTop.X - 2, PositionTop.Y); // Move to the left
        PositionBottom = new Vector2(PositionBottom.X - 2, PositionBottom.Y);
    }

    public bool IsOffScreen()
    {
        // Method to check if the obstacle is off the screen
        return PositionTop.X < 0;
    }

    public virtual void Draw()
    {
        // Method to draw the obstacle
    }

    public Vector2 GetPositionTop()
    {
        // Method to get the position of the top part of the obstacle
        return PositionTop;
    }

    public Vector2 GetPositionBottom()
    {
        // Method to get the position of the bottom part of the obstacle
        return PositionBottom;
    }
}
