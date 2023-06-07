public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public Reflection() : base()
    {
        _activityName = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("Think of a time when you did something really difficult. ");
        _prompts.Add("Think of a time when you helped someone in need. ");
        _prompts.Add("Think of a time when you did something truly selfless. ");
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");
    }
    public Reflection(int time) : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.", time)
    {

    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayWelcome();
        DisplayPrompt();
        Console.Clear();
        _start = DateTime.Now;
        do
        {
            DisplayQuestion();
            SpinnerAnimation(_long);
            Console.WriteLine();
        } while(TimeHandler(_start) != true);
        DisplayFinished();
    }
    public string GetRandomPrompt()
    {
        Random r = new Random();
        int i = r.Next(0,_prompts.Count);
        string stuff = _prompts[i];
        return stuff;
    }

    public string GetRandomQuestion()
    {
        Random r = new Random();
        int i = r.Next(0,_questions.Count);
        string stuff = _questions[i];
        return stuff;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" ---- {GetRandomPrompt()} ---- ");
        Console.WriteLine();
        Console.Write("Press enter when you are prepared to continue... ");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience. \nYou may begin in: ");
        CountDownAnimation();
    }

    public void DisplayQuestion()
    {
        //Console.WriteLine();
        Console.Write($" > {GetRandomQuestion()}");

    }

    // public void GetAnswer()
    // {

    // }
}