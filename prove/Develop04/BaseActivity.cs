public class Activity 
{
    protected DateTime _start;
    protected string _activityName;
    protected string _description;
    protected int _timeDuration;
    protected int _long = 10;
    protected int _medium = 7;
    protected int _short = 5;

    public Activity()
    {

    }

    public Activity(string name, string description, int time)
    {
        _activityName = name;
        _description = description;
        _timeDuration = time;

    }


    public void DisplayWelcome()
    {
        Console.WriteLine($" \nBeginning the {_activityName} Activity\n");
        Console.WriteLine($"{_description} \n");
        SetDuration();
        Console.Clear();
        Console.WriteLine("\nGet Ready... ");
        SpinnerAnimation(_medium);
    }

    public void DisplayFinished()
    {
        Console.WriteLine($"Well Done!\n");
        Console.WriteLine($"You have finished another {_timeDuration} seconds of the {_activityName} Activity");
        SpinnerAnimation(_medium);
        Console.Clear();
    }

    public void SpinnerAnimation(int time)
    {
        List<string> symbols = new List<string>();
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);
        int i = 0;

        while (DateTime.Now < end)
        {
            string s = symbols[i];
            Console.Write(s);
            Thread.Sleep(650);
            Console.Write("\b \b"); // Erase the previous character
            i++;
            if (i >= symbols.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    public void CountDownAnimation()
    {
        for (int i = 5; i >= 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(650);
            Console.Write("\b \b"); // Erase the previous character
            
        }
        Console.WriteLine();
    }

    public DateTime CheckCurrentTime()
    {
        DateTime time = DateTime.Now;
        return time;
    }

    public bool TimeHandler(DateTime start)
    {
        DateTime futureTime = start.AddSeconds(_timeDuration);
        DateTime timeNow = DateTime.Now;
        bool done = false;
        if (futureTime < timeNow)
        {
            done = true;
        }
       
        return done;
    }

    public void SetName(string name)
    {
        _activityName = name;

    }
    public void SetDescription(string stuff)
    {
        _description = stuff;

    }
    
    public void SetDuration()
    {
        Console.WriteLine($"How long, in seconds, would you like do the activity?");
        Console.Write($" >  ");
        _timeDuration = int.Parse(Console.ReadLine());
    }

    public string GetName()
    {
        string name = _activityName;
        return name;
    }

}