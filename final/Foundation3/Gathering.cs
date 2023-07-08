public class Gathering : Event
{
    string _weatherForecast;

    public Gathering(string type, string title, string description, string date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weatherForecast = weather;
    }

    public override string FullDetails()
    {
        return "Type: Outdoor Gathering \n" + base.StandardDetails() + "Weather Forecast: " + _weatherForecast + "\n";
    }




}

/*
public class Gathering : Event
~ Attributes 
string _weather

~ Constructor(Forecast)

~ Methods
Override Base
*/