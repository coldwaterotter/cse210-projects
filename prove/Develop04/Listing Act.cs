public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private int _counter = 0;

    public Listing() : base()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes? ");
    }
    public Listing(int time) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", time)
    {
        
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayWelcome();
        DisplayPrompt();
        // Console.Write("Press enter when you are prepared to continue... ");
        // Console.ReadLine();
        _start = DateTime.Now;
        do
        {
            GetAnswer();
            _counter += 1;
        } while(TimeHandler(_start) != true);
        Console.WriteLine();
        Console.WriteLine($"Good job, you listed {_counter} items!");
        Console.WriteLine();
        DisplayFinished();

    }

    public string GetRandomPrompt()
    {
        Random r = new Random();
        int i = r.Next(0,_prompts.Count);
        string stuff = _prompts[i];
        return stuff;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following: ");
        Console.WriteLine($" ---- {GetRandomPrompt()} ---- ");
        SpinnerAnimation(_long);
        Console.Write("You may begin in: ");
        CountDownAnimation();
        Console.WriteLine();
    }


    public void GetAnswer()
    {
        Console.Write("  > ");
        Console.ReadLine();

    }
}