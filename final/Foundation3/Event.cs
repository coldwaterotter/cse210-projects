public abstract class Event //base
{
    string _type;
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        //standard details
        return $"Title: " + _title + "\nDescription: " + _description + "\nDate: " + _date + "\nTime: " + _time + "\nAddress: " + _address.PrintAddress() + "\n";
    }

    public abstract string FullDetails();

    public virtual string ShortDetails()
    {
        //short description
        return $"Type: " + _type + "\nTitle: " + _title + "\nDate: " + _date + "\n";
    }
    





}

/*
public class Event (base)
~ Attributes 
string _title
string _description
int _date
int _time
List<address> _address

~ Constructor()

~ Methods
abstract StandardDetails
abstract FullDetails
abstract ShortDescription
*/