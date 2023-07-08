public abstract class Activity
{
    DateTime _date;
    double _duration;

    public Activity(double duration)
    {
        _duration = duration;
        _date = DateTime.Now;
    }
    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;

    }

    public abstract string WorkoutSummaryKM();
    // Format: 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km

    public double RoundAnswer(double answer)
    {
        return Math.Round(answer, 2);
    }

    public string GetDate()
    {
        string date = _date.Date.ToString("dd MMM yyyy");
        return date;
    }

    public double GetDuration()
    {
        return _duration;
    }
    
    public double ConvertMilesIntoKM(double miles)
    {
        double km = miles / 0.62;
        return km;
    }

    public double ConvertKMIntoMiles(double km)
    {
        double miles = km * 0.62;
        return miles;
    }

    public virtual double Distance()
    {
        return 0;
    }

    public virtual double Speed()
    {
        return 0;
    }

    public double Pace(double speed)
    {
        return RoundAnswer(60 / speed);
    }


}

/*
public class Workout (base)
~ Attributes
int _date
int _duration

~ Constructor()w

~ Methods
virtual int Distance()
virtual int Speed()
virtual int Pace()
int CalculateSummary()
string DisplaySummary()
*/