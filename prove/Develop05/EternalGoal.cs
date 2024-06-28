class EternalGoal:Goal
{
    public override void ScoreUp()
    {
       _score += _points;
    }
    public override void Display()
    {
        Console.WriteLine($"{_goalName} ({_desc})");
    }

    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description? ");
        _desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"EternalGoal:{_goalName},{_desc},{_points},{_score}";
        return stringrep;
    }
    public override void SetGoal(string goalInfo)
    {
        string[] lines = goalInfo.Split(",");
        _goalName = lines[0];
        _desc = lines[1];
        _points = int.Parse(lines[2]);
        _score = int.Parse(lines[3]);
    }
}