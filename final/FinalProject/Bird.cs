using System.Numerics;

public class Bird : Entity
{
    PhysicsManager physicsManager = new PhysicsManager();
    // This is the bird design
    public string birdLook = ">";

    private Vector2 _position;
    private Vector2 _velocity;

    // This is the bird constructor it sets the position of the bird at 4x and 15y
    public Bird()
    {
        _position = new Vector2(4, 15);
        _velocity = new Vector2(0, -1);
    }

    public void Flap()
    {
        // Method to make the bird flap and move upwards
        _velocity.Y = -1; // I think we may want to actually add here let me know what you think.
    }

    public override void Update()
    {
        // Method to update the bird's position and velocity
        _velocity.Y += physicsManager.ApplyGravity(); // We need to account for gravity here so we may want to add that in here let me know.
        _position.Y += _velocity.Y;
        _position.Y = Math.Clamp(_position.Y, 0, 25);
    }

    public Vector2 GetPosition()
    {
        // Method to get the current position of the bird
        return _position;
    }
}
