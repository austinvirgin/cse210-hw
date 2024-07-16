public class PhysicsManager
{
    private const float Gravity = -9.8f;
    private const int targetFps = 120;
   private readonly float _timeStep = 1f / targetFps;

    public float ApplyGravity()
    {
      return Gravity * _timeStep;
    }

    public void ApplyVelocity(Bird bird)
    {
       // bird.Position += bird.Velocity;
    }
}
