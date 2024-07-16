using System.Collections.Generic;

public class CollisionManager
{
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
        if (bird.GetPosition().X == obstacle.PositionTop.X && bird.GetPosition().X == obstacle.PositionTop.X + 4){
            if (bird.GetPosition().Y >= obstacle.PositionTop.Y - 1 || bird.GetPosition().Y <= obstacle.PositionBottom.Y + 1 || bird.GetPosition().Y <= 1){
                return true;
            }
        }
        return false;
    }
}
