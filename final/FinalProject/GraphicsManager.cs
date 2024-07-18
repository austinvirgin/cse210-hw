using System.Collections.Generic;

public class GraphicsManager
{
    public void DrawDisplay(UIManager uIManager, List<Obstacle> obstacles, Bird bird)
    {
        // Method to draw the game display
        uIManager.GameDisplay(obstacles, bird);
    }

    public void DrawBird(Bird bird)
    {
        // Method to draw the bird
    }

    public void DrawObstacle()
    {
        // Method to draw obstacles
    }

    public void MoveEverything(Bird bird, List<Obstacle> obstacles)
    {
        // Method to update the positions of all game elements
        foreach (Obstacle obstacle in obstacles)
        {
            obstacle.Update();
        }
        bird.Update();
    }
}
