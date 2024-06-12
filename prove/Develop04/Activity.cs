using System.Dynamic;

class Activity
{
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string title, string desc, int duration){
        _title = title;
        _desc = desc;
        _duration = duration;
    }

    public int GetDuration(){
        return _duration;
    }

    public void SetDuration(int duration){
        _duration = duration;
    }

    public bool EndActivity(){

    }
}