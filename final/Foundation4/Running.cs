public class Running : Activity
{
    private double _distance;
    

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string WorkoutSummaryKM()
    {
        return GetDate() + $" -- Running ({base.GetDuration()} min) -- Distance: {_distance} kilometers, Speed: {this.Speed()} kph, Pace: {base.Pace(this.Speed())} min per km" ;
    }

    public override double Speed()
    {
        return RoundAnswer(_distance / base.GetDuration() * 60);
    }



























    
}

/*
public class Running : Workout
~ Attributes
int _distance

~ Constructor() : 

~ Methods
override
*/