public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string WorkoutSummaryKM()
    {
        return GetDate() + $" -- Cycling ({base.GetDuration()} min) -- Distance: {this.Distance()} kilometers, Speed: {_speed} kph, Pace: {base.Pace(_speed)} min per km" ;
    }

    public override double Distance()
    {
        return RoundAnswer(_speed * base.GetDuration() / 60);
    }



























    
}

/*
public class Cycling : Workout
~ Attributes
int _speed

~ Constructor() : 

~ Methods
override
*/