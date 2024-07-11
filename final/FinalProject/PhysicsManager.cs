public class PhysicsManager
{
    private const float Gravity = 9.8f;

    public void ApplyGravity(Bird bird)
    {
       // bird.Velocity = new System.Numerics.Vector2(bird.Velocity.X, bird.Velocity.Y + Gravity * 0.1f);
    }

    public void ApplyVelocity(Bird bird)
    {
       // bird.Position += bird.Velocity;
    }
}
