using System.Collections.Generic;
//GraphicsManager class
//public bool ClickedEnter(){
  //  Console.ReadLine();
    //return true;

public class GraphicsManager
{

    public void DrawDisplay(UIManager uIManager, List<Obstacle> obstacles, Bird bird){
        uIManager.GameDisplay(obstacles, bird);
    }
    public void DrawBird(Bird bird)
    {
        // Logic to draw bird
    }

    public void DrawObstacle()
    {
        Obstacle obstacle = new Obstacle();
        // Logic to draw obstacles
    }

    public void MoveEverything(Bird bird, List<Obstacle> obstacles){
        foreach (Obstacle obstacle in obstacles)
        {
            obstacle.Update();
        }
        bird.Update();
    }
}
