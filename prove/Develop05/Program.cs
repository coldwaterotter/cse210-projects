using System;
using System.IO; 
class Program
{
    static List<Goal> _goals = new List<Goal>();
    private static string _newName;
    private static string _newDescription;
    private static bool _newBool = false;
    private static int _newValue;
    private static int _newStatus = 0;

    public static string CheckLevel(int points)
    {
        if (points < 1)
        {
            points = 1;
        }
        double level = (points / 1000);
        Math.Round(level);
        return $"-- \"Hero lvl {level}\"";
    }

    public static void createName()
    {
        Console.Write("What is the name of your goal? ");
        _newName = Console.ReadLine() ?? String.Empty;
    }
    public static void createDesc()
    {
        Console.Write("What is the description of your goal? ");
        _newDescription = Console.ReadLine() ?? String.Empty;
    }

    public static void createValue()
    {
        Console.Write("How many points is your goal worth? ");
        _newValue = int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        string response = "";
        int points = 1;
        while (response != "7")
        {
        Console.Clear();
        string hero = CheckLevel(points);
        Console.WriteLine($"\n  You have {points} points and you are a {hero}");
        Console.WriteLine("\n  Welcome to the Eternal Quest Program!\n");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Delete Goals");
        Console.WriteLine("  7. Quit");
        Console.WriteLine("Select a choice from the menu:");
        Console.Write(" >  ");
        response = Console.ReadLine() ?? String.Empty;

        switch(response)
        {
            case "1": // Create New Goal
                Console.WriteLine("What kind of goal would you like to create? ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                int createType = int.Parse(Console.ReadLine());

                if (createType == 1)
                {
                    createName();
                    createDesc();
                    createValue();
                    SimpleGoal goal = new SimpleGoal(createType, _newName, _newDescription, _newBool, _newValue);
                    _goals.Add(goal);
                }
                else if (createType == 2)
                {
                    createName();
                    createDesc();
                    createValue();
                    EternalGoal goal = new EternalGoal(createType, _newName, _newDescription, _newBool, _newValue);
                    _goals.Add(goal);
                }
                else if (createType == 3)
                {
                    createName();
                    createDesc();
                    createValue();
                    Console.Write("How many times would you like to repeat this goal? ");
                    int _newCount = int.Parse(Console.ReadLine());
                    Console.Write("How much bonus points would you like to receive for completing this goal? ");
                    int _newBonus = int.Parse(Console.ReadLine());
                    ChecklistGoal goal = new ChecklistGoal(createType, _newName, _newDescription, _newBool, _newValue, _newStatus, _newCount, _newBonus);
                    _goals.Add(goal);
                }
                Console.WriteLine("Goal successfully created.");
                Thread.Sleep(3000);
                Console.Clear();
                break;

            case "2": // List Goals
                Console.WriteLine("My goals are: ");
                int i = 0;
                foreach (Goal goal in _goals)
                {
                    i++;
                    Console.WriteLine($"{goal.DisplayGoal()}");
                }
                Console.ReadLine();
                Console.Clear();
                break;

            case "3": // Save Goals
                Console.WriteLine($"What is the filename for the goal file?\n For the default (goals.txt) enter 0");
                string savefilename = Console.ReadLine() ?? String.Empty;
                if (savefilename == "0")
                {
                    savefilename = "goals.txt";
                }
                Handler save = new Handler();
                save.SaveFile(_goals, savefilename, points);
                Console.WriteLine("File successfully saved.");
                Thread.Sleep(3000);
                Console.Clear();
                break;

            case "4": // Load Goals
                Console.WriteLine($"What is the filename for the goal file?\n For the default (goals.txt) enter 0");
                string loadfilename = Console.ReadLine() ?? String.Empty;
                if (loadfilename == "0")
                {
                    loadfilename = "goals.txt";
                }
                Handler load = new Handler();
                points = load.LoadPoints(loadfilename);
                _goals = load.LoadFile(loadfilename);
                Console.WriteLine("File successfully loaded.");
                Thread.Sleep(3000);
                Console.Clear();
                break;

            case "5": // Record Event
                Console.WriteLine("The Goals are: ");
                int num = 0;
                int add = 0;
                foreach (Goal goal in _goals)
                {
                    num ++;
                    Console.WriteLine($"{num}. {goal.GetGoalName()}");
                }
                Console.WriteLine("\n Which goal did you achieve? ");
                int index = int.Parse(Console.ReadLine());
                index --;
                Goal temp = _goals[index];
                add = temp.GoalAchieved();
                points += add;
                Console.WriteLine($"Congrats! You earned {add} points for completing that goal!");
                Thread.Sleep(3000);
                Console.Clear();
                break;

            case "6":
                Console.WriteLine("Do you want to [d]elete all goals or [r]emove one from list?");
                Console.Write(" >  ");
                response = Console.ReadLine().ToUpper() ?? String.Empty;
                switch(response)
                {
                    case "D":
                        _goals.Clear();
                        Console.WriteLine("All of the goals have been successfully removed from the list.");
                        Thread.Sleep(3000);
                        break;
                    
                    case "R":
                        Console.WriteLine("My goals are: ");
                        int remove = 0;
                        foreach (Goal goal in _goals)
                        {
                            remove++;
                            Console.WriteLine($"{remove}. {goal.DisplayGoal()}");
                        }
                        Console.WriteLine("\n Which goal would you like to remove? ");
                        remove = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine($"The goal -- \"{remove + 1}. {_goals[remove].GetGoalName()}\" -- has been removed from the list.");
                        _goals.Remove(_goals[remove]);
                        Thread.Sleep(3000);
                        break;
                }
                break;

            case "7": // Quit
                Console.Clear();
                Environment.Exit(0);
                break;

        }
        Console.Clear();
        }
    }
}

/* 
Designer Develop 05

Menu
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
    
    User
    Save/Load
    Display Score
    Level Up

~ Goal Handler
_score : int
_goalList <Goals> : Goal
ListGoals () : string
SaveGoals () : void
LoadGoals () : void
DisplayScore () : int

~ Goal (base)
_name : string
_description : string
_completed : bool
_points : int
Goal ()
Record Event () : int
IsComplete () : bool
SetName () : void
SetDescription () : void
SetPoints () : void
SetCompleted() : void
ShowComplete () : bool

~ SimpleGoal (derived)
SimpleGoal () : base ()

~ EternalGoal (derived)
_counter : int
_bonus : int
EternalGoal () : base ()

~ ChecklistGoal (derived)
_counter : int
_status : int
_bonus : int
ChecklistGoal () : base ()
ShowStatus () : string

*/