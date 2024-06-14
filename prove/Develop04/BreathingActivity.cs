using System.Reflection;
using Microsoft.VisualBasic;

class BreathingActivity : Activity
{
    public BreathingActivity(string title, string desc) : base(title, desc){
        _title = title;
        _desc = desc;
    }

    public override void Interact(){
        Timer timer = new Timer(_duration);
        Console.Clear();
        while (!timer.TimerDone())
        {
            BreatheIn();
            Console.Clear();
            BreatheOut();
            Console.Clear();
        }
    }
    void BreatheIn(){
        Console.WriteLine("Breathe in");
        for (int i = 0; i < 10; i++)
        {
            AnimationIn();
        }
    }
    void BreatheOut(){
        Console.WriteLine("Breathe out");
        Console.Write("- - - - - - - - - - ");
        for (int i = 0; i < 10; i++)
        {
            AnimationOut();
        }
    }
    void AnimationIn(){
        Console.Write("- ");
        Thread.Sleep(500);
    }
    void AnimationOut(){
        for (int i = 0; i < 2; i++)
        {
            Console.Write("\b \b");
        }
        Thread.Sleep(500);
    }
}