using System.Collections.Generic;

public class CollisionManager
{
    private const int screenHeight = 25;
    public int obstacleWidth = 4;
    public bool CheckCollision(Bird bird, List<Obstacle> obstacles)
    {

        foreach (var obstacle in obstacles) // we go through each of the obstacles here
        {
            if (IsColliding(bird, obstacle)) // we then check if it will collide and if so we return true or false
            {
                return true;
            }
        }
        return false;
    }

    private bool IsColliding(Bird bird, Obstacle obstacle)
    {
        // Define obstacle boundaries
        float obstacleTopY = obstacle.GetPositionTop().Y;
        float obstacleBottomY = obstacle.GetPositionBottom().Y;
        float obstacleX = obstacle.GetPositionTop().X; // Assuming both top and bottom have the same X position

        // Get bird position
        int birdX = (int)bird.GetPosition().X;
        int birdY = (int)bird.GetPosition().Y;

        // Check for collision based on specific conditions
        bool xOverlap = birdX >= obstacleX && birdX <= obstacleX + obstacleWidth; // Assuming obstacleWidth is defined
        bool yOverlap = birdY >= obstacleTopY && birdY <= obstacleBottomY;

        // Check if there's an overlap in both x and y dimensions
        if (xOverlap && yOverlap)
        {
            return true;
        }
        else if (bird.GetPosition().Y <= 0 || bird.GetPosition().Y >= screenHeight){
            return true;
        }

        return false;
    }

}
