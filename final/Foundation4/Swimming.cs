public class Swimming : Activity
{
    private double _laps;
    private int _lapDistance = 50; // in km

    public Swimming(DateTime date, double duration, double laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override string WorkoutSummaryKM()
    {
        return GetDate() + $" -- Swimming ({base.GetDuration()} min) -- Distance: {this.Distance()} kilometers, Speed: {this.Speed()} kph, Pace: {base.Pace(this.Speed())} min per km" ;
    }
    public override double Distance() // distance in km
    {
        return RoundAnswer(_laps * _lapDistance / 1000);
    }

    public double DistanceMiles()
    {
        return RoundAnswer(Distance());
    }

    public override double Speed()
    {
        return RoundAnswer((this.Distance() / base.GetDuration()) * 60);
    }






    
}

/*
public class Swimming : Workout
~ Attributes
int _numberLaps

~ Constructor() : 

~ Methods
override
*/