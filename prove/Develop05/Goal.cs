using System.Runtime.Intrinsics.X86;

public abstract class Goal
{
    protected string _desc;
    protected string _goalName;

    protected int _score = 0;

    protected int _points;

    public abstract void ScoreUp();

    public abstract void Display();

    public abstract void CreateGoal();

    public abstract string GetStringRepresentation();

    public abstract void SetGoal(string goalInfo);

    public int GetScore(){
        return _score;
    }
    public string GetGoalName(){
        return _goalName;
    }
}