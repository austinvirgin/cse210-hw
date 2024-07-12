using System.ComponentModel.Design;

public class Player
{
  UIManager uIManager = new UIManager();
  Bird bird = new Bird();
   // public Bird Bird {get: private set;}

  public bool CheckSpacebar(){
    return true;
  }

    public void Update()
    {
      bird.Update();
    }

    public void Jump()
    {
      bird.Flap();
    }
}