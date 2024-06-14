using System.Formats.Asn1;

class ListerActivity : Activity
{
   string answer;
   public ListerActivity(string title, string desc) : base(title, desc){
    _title = title;
    _desc = desc;
    
   }

   public override void Interact(){
      Timer timer = new Timer(_duration);
      Console.Clear();
      string prompt = GetRandomPrompt();
      Console.Write("You may begin in: ");
      for (int i = 3; i >= 1 ; i--)
      {
         Countdown(i);
      }
      Console.WriteLine("\n");
      Console.WriteLine(prompt);
      int count = 0;
      while (!timer.TimerDone())
      {
         Console.Write("> ");
         answer = Console.ReadLine();
         count++;
      }
      Console.WriteLine($"You listed {count} items!\n");
   }
   string GetRandomPrompt(){
      Random random = new Random();
      int randint = random.Next(0, prompts.Count());
      return prompts[randint];
   }
   void Countdown(int i){
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
   }
   List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are things you are grateful for?",
            "What are some of your favorite memories?",
            "Who are people that inspire you?",
            "What are some goals you have for the future?",
            "What are some challenges you have overcome?",
            "Who are people that have influenced your life positively?",
            "What are some of your hobbies or interests?",
            "What are some acts of kindness you have witnessed?",
            "Who are some friends you cherish?",
            "What are some accomplishments you are proud of?",
            "What are some places you would like to visit?",
            "What are some lessons you have learned recently?",
            "Who are people you would like to reconnect with?",
            "What are some books or movies that have impacted you?",
            "What are some dreams or aspirations you have?"
        };
}