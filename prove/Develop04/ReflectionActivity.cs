using System.Collections.Specialized;

class ReflectionActivity : Activity
{
    public ReflectionActivity(string title, string desc) : base(title, desc){
        _title = title;
        _desc = desc;
    }

    public override void Interact(){
        Timer timer = new Timer(_duration);
        Console.Clear();
        while (!timer.TimerDone())
        {
            Console.WriteLine(GetRandomPrompt());
            spinner();
            Console.Clear();
        }
    }
    string GetRandomPrompt(){
        Random random = new Random();
        int randint = random.Next(0, prompts.Count());
        return prompts[randint];
    }

    List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you made a significant sacrifice for someone else.",
            "Think of a time when you forgave someone who wronged you.",
            "Think of a time when you worked hard to achieve a goal.",
            "Think of a time when you faced a major fear.",
            "Think of a time when you showed kindness to a stranger.",
            "Think of a time when you went out of your way to support a friend.",
            "Think of a time when you made a positive impact on someone’s life.",
            "Think of a time when you resolved a conflict peacefully.",
            "Think of a time when you shared your resources with others.",
            "Think of a time when you stood by your values despite opposition.",
            "Think of a time when you comforted someone during a tough time.",
            "Think of a time when you inspired others by your actions.",
            "Think of a time when you took responsibility for your actions.",
            "Think of a time when you volunteered for a community service.",
            "Think of a time when you learned something valuable from helping others.",
            "Think of a time when you showed resilience in the face of adversity."
        };
    void spinner(){
        for (int i = 0; i < 8; i++)
        {
            Console.Write("|");
            pause();
            Console.Write("/");
            pause();
            Console.Write("-");
            pause();
            Console.Write("|");
            pause();
            Console.Write("\\");
            pause(0);
        }
    }
    
    void pause(int time = 100){
        Thread.Sleep(time);
        Console.Write("\b \b");
    }
}