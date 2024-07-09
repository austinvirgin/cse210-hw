using System.Collections.Generic;

public class CollisionManager
{
    public bool CheckCollision(Bird bird, List<Obstacle> obstacles)
    {
        foreach (var obstacle in obstacles)
        {
            if (IsColliding(bird, obstacle))
            {
                return true;
            }
        }
        return false;
    }

    private bool IsColliding(Bird bird, Obstacle obstacle)
    {
        // Simplified collision detection logic
        return false;
    }
}
