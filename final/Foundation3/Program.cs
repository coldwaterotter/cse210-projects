using System;

    
class Program
{
    static void DisplayEvent(Event e)
    {
        Console.WriteLine("\n~ Standard ~");
        Console.WriteLine(e.StandardDetails());
        Console.WriteLine("\n~ Full ~");
        Console.WriteLine(e.FullDetails());
        Console.WriteLine("\n~ Short ~");
        Console.WriteLine(e.ShortDetails());
        Console.WriteLine("~~~~~~~~~~~\n");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Foundation3 World!\n\n");

        Address address1 = new Address("235 W 4th S", "Rexburg", "Idaho", "usa");
        Address address2 = new Address("863 W Lenox Church Rd", "Kingsley", "Pennsylvania", "United States");
        Address address3 = new Address("1246 W 4401 N", "Pleasant Grove", "Utah", "usa");

        Lecture event1 = new Lecture("Lecture", "How to Eat Healthy", "A seminar on eating healthier as a college student given by a nutritionist", "July, 20th, 2023", "1:00pm", address1, "Mikayla Gneiting", 62);
        Reception event2 = new Reception("Reception", "Art Gallery", "Artworks created and displayed by Rachel", "Augsut 1st, 2023", "5:30pm", address2, "rachelmrak@gmail.com");
        Gathering event3 = new Gathering("Outdoor Gathering", "Wedding", "Come and celebrate the Wedding! It will be an outdoor ceremony so please plan accordingly.", "August 16th, 2023", "2:00pm", address3, "80 degrees & Sunny");


        Console.WriteLine("Event 1");
        DisplayEvent(event1);

        Console.WriteLine("Event 2");
        DisplayEvent(event2);
        
        Console.WriteLine("Event 3");
        DisplayEvent(event3);
        
    }
}

/*
Foundation 3 Design

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

public class Lecture : Event
~ Attributes 
string _speakerName
int _capacity

~ Constructor(Speaker, Capacity)

~ Methods
Override Base

public class Reception : Event
~ Attributes 
bool _isRSVP

~ Constructor(RSVVP)

~ Methods
void MakeReservation()
Override Base

public class Gathering : Event
~ Attributes 
string _weather

~ Constructor(Forecast)

~ Methods
Override Base

public class Address
~ Attributes
string _streetAddress
string _city
string _state/province
string _country

~ Constructor(Street, City, State, Country)

~ Methods
string NicePrint()
*/