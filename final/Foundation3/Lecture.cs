public class Lecture : Event
{
    string _speaker;
    int _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return "Type: Lecture \n" + base.StandardDetails() + "Speaker: " + _speaker + $"\nCapacity: " + _capacity.ToString() + "\n";
    }





}

/*
public class Lecture : Event
~ Attributes 
string _speakerName
int _capacity

~ Constructor(Speaker, Capacity)

~ Methods
Override Base
*/