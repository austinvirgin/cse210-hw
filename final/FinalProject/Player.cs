using System.ComponentModel.Design;

public class Player
{
  UIManager uIManager = new UIManager();
  Bird bird = new Bird();
  private InputHandler _inputHandler = new InputHandler();
   // public Bird Bird {get: private set;}

  public bool CheckSpacebar(){
    return true;
  }

    public void Update()
    {
      if (_inputHandler.IsSpacebarPressed()){
        Jump();
      }
      bird.Update();
    }

    public void Jump()
    {
      bird.Flap();
    }
}
