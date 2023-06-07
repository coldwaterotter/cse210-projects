public class Breathing : Activity
{

    public Breathing() : base()
    {
        //SetName("Breathing");
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
    }
    public Breathing(int time) : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", time)
    {
        
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayWelcome();
        _start = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(_timeDuration);
        // DateTime timeNow = CheckCurrentTime();
        do
        {
            BreathIn();
            CountDownAnimation();
            BreathOut();
            CountDownAnimation();
            Console.WriteLine();
            //timeNow = CheckCurrentTime();
        } while(TimeHandler(_start) != true); //timeNow < futureTime
        DisplayFinished();
    }

    public void BreathIn()
    {
        Console.Write($"Breath in...");
    }

    public void BreathOut()
    {
        Console.Write($"Now breathe out...");
    }
}