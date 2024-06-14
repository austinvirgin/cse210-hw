using System.Dynamic;

class Activity
{
    protected int _activityCount = 0;
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string title, string desc){
        _title = title;
        _desc = desc;
    }

    public int GetDuration(){
        return _duration;
    }

    public void SetDuration(int duration){
        _duration = duration;
    }

    public void StartProgram(){
        Console.WriteLine($"Welcome to the {_title}\n");
        Console.WriteLine($"{_desc}\n");
    }

    public void EndProgram(){
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title}.");
        Thread.Sleep(6000);
        Console.Clear();
    }

    public void ActivityCount(){
        _activityCount++;
    }

    public void PrintActivityCount(){
        Console.WriteLine($"You have done the {_title} {_activityCount} times this session!");
    }
}