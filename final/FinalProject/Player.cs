using System.ComponentModel.Design;
using System;
using System.Threading;
using System.Collections.Generic;

public class Player
{
  UIManager uIManager = new UIManager();
  Bird bird = new Bird();
  private InputHandler _inputHandler;
   // public Bird Bird {get: private set;}

  public void Start(){
    Bird bird = new Bird();
    CollisionManager collisionManager = new CollisionManager();
    List<Obstacle> obstacles = new List<Obstacle>();

    while (!collisionManager.CheckCollision(bird, obstacles))
    {
      Update();
      Thread.Sleep(16);
    }
  }
  public bool CheckSpacebar(){
    return true;
  }

    public void Update()
    {
      // if (_inputHandler.IsSpacebarPressed()){
      //   Jump();
      //}
      bird.Update();
    }

    public void Jump()
    {
      bird.Flap();
    }
}