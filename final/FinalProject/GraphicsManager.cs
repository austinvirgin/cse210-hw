using System.Collections.Generic;

public class GraphicsManager
{
    public void DrawBird(Bird bird)
    {
        // Logic to draw bird
    }

    public void DrawObstacle()
    {
        Obstacle obstacle = new Obstacle();
        // Logic to draw obstacles
    }

    public void MoveEverything(Bird bird, List<Obstacle> obstacles){
        foreach (Obstacle obstacle in obstacles)
        {
            obstacle.Update();
        }
        bird.Update();
    }
}
