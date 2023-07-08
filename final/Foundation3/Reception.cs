public class Reception : Event
{
    string _emailRSVP;

    public Reception(string type, string title, string description, string date, string time, Address address, string email) : base(type, title, description, date, time, address)
    {
        _emailRSVP = email;
    }

    public override string FullDetails()
    {
        return "Type: Reception \n" + base.StandardDetails() + "RSVP: " + _emailRSVP + "\n";
    }



}

/*
public class Reception : Event
~ Attributes 
bool _isRSVP

~ Constructor(RSVVP)

~ Methods
void MakeReservation()
Override Base
*/