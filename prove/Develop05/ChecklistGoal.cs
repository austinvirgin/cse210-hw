class ChecklistGoal:Goal
{
    protected int _timesDone;
    protected int _timesNeeded;
    protected int _bonusPoints;
    protected bool _completed = false;

    public override void ScoreUp()
    {
        if (!_completed)
        {
            if (_timesDone == _timesNeeded - 1)
            {
                _completed = true;
                _score += _points;
                _score += _bonusPoints;
            }
            else
            {
                _timesDone += 1;
                _score += _points;
            }
            Console.WriteLine($"Congratulations! You have earned {_score} points!");
        }
    }
    public override void Display()
    {
       if (_completed)
       {
        Console.WriteLine($"[X] {_goalName} ({_desc}) -- Currently completed: {_timesDone}/{_timesNeeded}");
       }
       else
       {
        Console.WriteLine($"[ ] {_goalName} ({_desc}) -- Currently completed: {_timesDone}/{_timesNeeded}");
       } 
    }

    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _timesNeeded = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"ChecklistGoal:{_goalName},{_desc},{_points},{_score},{_timesDone},{_timesNeeded},{_bonusPoints},{_completed}";
        return stringrep;
    }

    public override void SetGoal(string goalInfo)
    {
        string[] lines = goalInfo.Split(",");
        _goalName = lines[0];
        _desc = lines[1];
        _points = int.Parse(lines[2]);
        _score = int.Parse(lines[3]);
        _timesDone = int.Parse(lines[4]);
        _timesNeeded = int.Parse(lines[5]);
        _bonusPoints = int.Parse(lines[6]);
        _completed = bool.Parse(lines[7]);
    }
}