using System.Numerics;

public class PowerUp
{
    public Vector2 Position { get; private set; }

    public PowerUp()
    {
        Position = new Vector2(100, 100); // Example position
    }

    public void ApplyEffect(Player player)
    {
        // Logic to apply power-up effect to player
    }
}
