public class PhysicsManager
{
    private const float Gravity = 9.0f;
    private const int targetFps = 180;
    private readonly float _timeStep = 1f / targetFps;

    public float ApplyGravity()
    {
        // Method to apply gravity to an object
        return Gravity * _timeStep;
    }

    public void ApplyVelocity(Bird bird)
    {
        // Method to apply velocity to a bird
        // bird.Position += bird.Velocity;
    }
}
