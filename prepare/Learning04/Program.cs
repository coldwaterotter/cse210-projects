using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Collin Burt", "ECEN");
        MathAssignment test2 = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        WritingAssignment test3 = new WritingAssignment("Mary Waters", "European History", "The Causes of War");
        Console.WriteLine(test.GetSummary(),"\n");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}