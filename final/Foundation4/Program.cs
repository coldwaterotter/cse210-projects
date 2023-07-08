using System;
using System.Linq;

class Program
{
    static string PrintDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.Date.ToString("dd MMMM yyyy");
        // int day = theCurrentTime.Day;
        // int year = theCurrentTime.Year;
        return date;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Hello Foundation4 World!");
        Console.WriteLine($"Today's Date is {PrintDate()}");

        Console.WriteLine("\n\n");

        Activity activity1 = new Running(new DateTime(2023,7,12), 24, 5);
        Activity activity2 = new Cycling(DateTime.Now, 35, 20);
        Activity activity3 = new Swimming(new DateTime(2023, 8, 22), 18, 17);

        List<Activity> _activities = new List<Activity>();
        _activities.Add(activity1);
        _activities.Add(activity2);
        _activities.Add(activity3);

        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.WorkoutSummaryKM());
            Console.WriteLine("~~~~~~~~\n");
        }
    }
}

/*
Foundation 4 Design

List<workout> _workouts

Distance (km) = swimming laps * 50 / 1000
Distance (miles) = swimming laps * 50 / 1000 * 0.62
Speed (mph or kph) = (distance / minutes) * 60
Pace (min per mile or min per km)= minutes / distance
Speed = 60 / pace
Pace = 60 / speed
*/