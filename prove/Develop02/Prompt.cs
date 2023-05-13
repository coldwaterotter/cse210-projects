public class Prompt
{
    //Attributes
    List <string> _prompts = new List<string>();
    public string _name;
    public string _text;

    //Constructor
public Prompt()
{
    _prompts.Add("How was your day?");
    _prompts.Add("Who was the most interesting person I interacted with today?");
    _prompts.Add("What was the best part of my day?");
    _prompts.Add("How did I see the hand of the Lord in my life today?");
    _prompts.Add("What was the strongest emotion I felt today?");
    _prompts.Add("If I had one thing I could do over today, what would it be?");
    _prompts.Add("What did you do for fun today?");
    _prompts.Add("What were you grateful for today?");
    _prompts.Add("What was the weather like today?");
    _prompts.Add("What is something you would want your future self to know about today?");

}

//Method
public string GetRandomPrompt()
{
    Random random = new Random();
    int index = random.Next(0,_prompts.Count);
    string prompt = _prompts[index];
    //Console.WriteLine($"{prompt}");
    return prompt;
}

public void MakePrompt(string text)
{
    string response = Console.ReadLine() ?? String.Empty;
    _prompts.Add(response);

}


}