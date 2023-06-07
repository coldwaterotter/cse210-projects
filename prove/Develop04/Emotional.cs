public class Emotional : Activity
{
    private List<string> _prompts = new List<string>();
    private int _counter;

    public Emotional() : base()
    {
        _activityName = "Emotional Resilience";
        _description = "This activity will help you reflect on the present moment by having you list as many things as you can related to your five senses.";
        _prompts.Add("What can you SEE ? ");
        _prompts.Add("What can you FEEL ? ");
        _prompts.Add("What can you HEAR ? ");
        _prompts.Add("What can you SMELL ? ");
        _prompts.Add("What can you TASTE ? ");
    }

    public Emotional(int time) : base("Emotional", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", time)
    {
        
    }
    /*
    5 see
    4 feel
    3 hear
    2 smell
    1 taste
    */

    public void RunActivity()
    {
        Console.Clear();
        DisplayWelcome();
        DisplayPrompt();
        _start = DateTime.Now;
        _counter = 5;
        foreach (string s in _prompts)
        {
            Console.WriteLine(s);
            
            for (int i = _counter; i > 0; i-- )
            {
                GetAnswer();
            }
            _counter -= 1;
        }
        Console.WriteLine();
        DisplayFinished();
        

    }


    public void DisplayPrompt()
    {
        Console.WriteLine("Prepare to list as many responses as you can to the following questions: ");
        Thread.Sleep(2000);
        Console.WriteLine("What 5 things can you SEE ? ");
        Thread.Sleep(2000);
        Console.WriteLine("What 4 things can you FEEL ? ");
        Thread.Sleep(2000);
        Console.WriteLine("What 3 things can you HEAR ? ");
        Thread.Sleep(2000);
        Console.WriteLine("What 2 things can you SMELL ? ");
        Thread.Sleep(2000);
        Console.WriteLine("What 1 things can you TASTE ? ");
        SpinnerAnimation(_long);
        Console.Write("You may begin in: ");
        CountDownAnimation();
        Console.Clear();
    }


    public void GetAnswer()
    {
        Console.Write("  > ");
        Console.ReadLine();

    }
}