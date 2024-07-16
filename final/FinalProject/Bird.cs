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
        _position = new Vector2(15, 4);
        _velocity = new Vector2(1, 0);
    }

    public void Flap()
    {
        _velocity.X += 5; // I think we may want to actually add here let me know what you think.
    }

    public void Update()
    {
        _velocity.X += physicsManager.ApplyGravity(); // We need to account for gravity here so we may want to add that in here let me know.
        _position.X += _velocity.X;
    }


    public Vector2 GetPosition(){
        return _position;
    }

}
