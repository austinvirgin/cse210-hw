class SimpleGoal:Goal
{
    protected bool _completed = false;

    public override void ScoreUp(){
        if (!_completed)
        {
            _score += _points;
            _completed = true;
        }
    }

    public override void Display(){
        if (_completed){
            Console.WriteLine($"[X] {_goalName} ({_desc})");
        }
        else
        {
            Console.WriteLine($"[ ] {_goalName} ({_desc})");
        }
    }

    public override void CreateGoal()
    {
        _goalName = GoalName();
        _desc = GoalDesc();
        _points = GoalPoints();
    }

    public string GoalName(){
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    public string GoalDesc(){
        Console.Write("What is a short description of it? ");
        string goalDesc = Console.ReadLine();
        return goalDesc;
    }

    public int GoalPoints(){
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        return points;
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"SimpleGoal:{_goalName},{_desc},{_points},{_completed},{_score}";
        return stringrep;
    }

    public override void SetGoal(string goalInfo)
    {
        string[] lines = goalInfo.Split(",");
        _goalName = lines[0];
        _desc = lines[1];
        _points = int.Parse(lines[2]);
        _completed = bool.Parse(lines[3]);
        _score = int.Parse(lines[4]);
    }
}