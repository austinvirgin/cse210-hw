class Timer
{
    DateTime endingTime;
    DateTime time = DateTime.Now;
    public Timer(int duration){
        endingTime = time.AddSeconds(duration);
    }

    public bool TimerDone(){
        DateTime currentTime = DateTime.Now;
        if (currentTime >= endingTime)
        {
            return true;
        }
        
        else
        {
            return false;
        }
    }
}