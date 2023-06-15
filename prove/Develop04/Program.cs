using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while(response != 5)
        {
            //int time = 0;
            Console.Clear();
            Console.WriteLine("\n  Welcome to the Mindfulness Program!\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start emotional resilience activity *Bonus*");
            Console.WriteLine("  5. Quit");
            Console.WriteLine("Select a choice from the menu:");
            Console.Write(" >  ");
            
            //time = GetTime();
            switch (response)
            {
                case 1:
                    Breathing breath = new Breathing();
                    breath.RunActivity();
                    break;

                case 2:
                    Reflection reflect = new Reflection();
                    reflect.RunActivity();
                    break;

                case 3:
                    Listing list = new Listing();
                    list.RunActivity();
                    break;

                case 4:
                    Emotional bonus = new Emotional();
                    bonus.RunActivity();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
            
        }
    }

    
}

/* 
MENU
1. BREATHING ACTIVITY - This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.
2. REFLECTING ACTIVITY - This activity will help you reflect on times in your life when you have shown strength and resilience. 
        This will help you recognize the power you have and how you can use it in other aspects of your life.
3. LISTING ACTIVITY - This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.
4. Bonus Activity - Emotional Resilience
5. QUIT 

Base Activity (Parent)

    string _activityName
    string _description
    int _timeDuration

    DisplayWelcome()
    DisplayFinished()
    SpinnerAnimation()
    CountDownAnimation()
    CheckTime()

BREATHING ACTIVITY (Derived): Base Activity

    BreathIn()
    BreathOut()

REFLECTING ACTIVITY (Derived): Base Activity

    List<string> _prompts
    List<string> _questions

    GetRandomPrompt()
    GetRandomQuestion()
    DisplayPrompt()
    DisplayQuestion()
    GetAnswer()

LISTING ACTIVITY (Derived): Base Activity

    List<string> _prompts
    int _counter

    GetRandomPrompt()
    DisplayPrompt()
    GetAnswer()
*/

// Thread.Sleep()
// Console.Write("\b \b"); // Erase the previous character
// DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(5);
// DateTime currentTime = DateTime.Now;
// if (currentTime < futureTime)