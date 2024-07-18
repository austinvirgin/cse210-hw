using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class Bird
{
    PhysicsManager physicsManager = new PhysicsManager();
    // This is the bird design
    public string birdLook =">";

    private Vector2 _position;
    private Vector2 _velocity;

    //This is the bird constructor it sets the position of the bird at 2x and 50y
    public Bird()
    {
        _position = new Vector2(4, 15);
        _velocity = new Vector2(0, -1);
    }

    public void Flap()
    {
        _velocity.Y = -1; // I think we may want to actually add here let me know what you think.
    }

    public void Update()
    {
        _velocity.Y += physicsManager.ApplyGravity(); // We need to account for gravity here so we may want to add that in here let me know.
        _position.Y += _velocity.Y;
        _position.Y = Math.Clamp(_position.Y, 0, 25);
    }


    public Vector2 GetPosition(){
        return _position;
    }

}
