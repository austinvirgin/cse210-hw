using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class Bird
{
    // This is the bird design
    public string birdLook =">";

    private Vector2 _position { get; set; }
    private Vector2 _velocity { get; set; }

    //This is the bird constructor it sets the position of the bird at 2x and 50y
    public Bird()
    {
        _position = new Vector2(15, 4);
        _velocity = new Vector2(2, 0);
    }

    public void Flap()
    {
        _velocity = new Vector2(0,-5); // I think we may want to actually add here let me know what you think.
    }

    public void Update()
    {
        _position += _velocity; // We need to account for gravity here so we may want to add that in here let me know.
    }


    public Vector2 GetPosition(){
        return _position;
    }

}
