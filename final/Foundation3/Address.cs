public class Address
{
    string _street;
    string _city;
    string _state;
    string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country.ToUpper();

    }

    public string PrintAddress()
    {
        return $"{_street} {_city + ", " + _state} {_country}";
    }

    public string GetCountry()
    {
        return _country;
    }

    



}


/*
public class Address
~ Attributes
string _streetAddress
string _city
string _state/province
string _country

~ Constructor(Street, City, State, Country)

~ Methods
void CheckCountry()
string NicePrint()
*/