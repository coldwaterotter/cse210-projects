using System.IO; 
public class Handler
{
    string _filename = "goals.txt";
    List<Goal> _goals = new List<Goal>();

    public Handler()
    {
        
    }

    public List<Goal> LoadFile(string filename)
    {
        _filename = filename;
        List<Goal> _goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(_filename);
        bool firstLine = true;
        foreach (string line in lines)
        {
            if(firstLine){
                // int points = line;
                firstLine = false;
            }
            else {
            string[] parts = line.Split('|');
            int type = int.Parse(parts[0]);
            bool complete;
            
            if (parts[3] == "True")
            {
                complete = true;
            }
            else   
                complete = false;
            
            switch(type)
            {
                case 1: // Create New Simple Goal
                    SimpleGoal newsimple = new SimpleGoal(int.Parse(parts[0]), parts[1], parts[2], complete, int.Parse(parts[4]));
                    _goals.Add(newsimple);
                    break;
                case 2: // Create New Eternal Goal
                    EternalGoal neweternal = new EternalGoal(int.Parse(parts[0]), parts[1], parts[2], complete, int.Parse(parts[4]));
                    _goals.Add(neweternal);
                    break;
                    
                case 3: // Create New Checklist Goal
                    ChecklistGoal newchecklist = new ChecklistGoal(int.Parse(parts[0]), parts[1], parts[2], complete, int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    _goals.Add(newchecklist);
                    break;

            }
            }
        }
        return _goals;
    }

    public int LoadPoints(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        int startPoints = int.Parse(lines[0]); 
        return startPoints;
    }

    public void SaveFile(List<Goal> _goals, string filename, int points)
    {
        _filename = filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        // You can add text to the file with the WriteLine method
        outputFile.WriteLine(points);
    
        // You can use the $ and include variables just like with Console.WriteLine
        foreach (Goal goal in _goals)
        {

            int type = goal.GetGoalType();
            switch (type)
            {
                case 1: // Write Simple Goal
                    outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetGoalName()}|{goal.GetGoalDesc()}|{goal.GetGoalBool()}|{goal.GetGoalPoints()}");
                    break;
                case 2: // Write Eternal Goal
                    outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetGoalName()}|{goal.GetGoalDesc()}|{goal.GetGoalBool()}|{goal.GetGoalPoints()}");
                    break;
                case 3: // Write Checklist Goal
                    outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetGoalName()}|{goal.GetGoalDesc()}|{goal.GetGoalBool()}|{goal.GetGoalPoints()}|{goal.GetStatus()}|{goal.GetCount()}|{goal.GetBonus()}");
                    break;
                
            }
        }
        }
        

    }





}
/* ~~~~~ Writing Text Files in C#

// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
...
string fileName = "myFile.txt";
using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
}
*/


/* ~~~~~ Reading Text Files in C#
string filename = "myFile.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
}
*/
