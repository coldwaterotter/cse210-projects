public class Customer
{
    string _name;
    Address _address;
    int _shippingCost = 5;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public int GetShippingCost()
    {
        if ((_address.GetCountry().ToUpperInvariant() != "USA") & (_address.GetCountry().ToUpperInvariant() != "UNITED STATES"))
        {
            _shippingCost = 35;
            return _shippingCost;
        }
        else
            return _shippingCost;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

}





/*
public class Customer
~ Attributes
string _name
string _address
bool _extraShipping

~ Constructor(Name, Address)

~ Methods
bool CheckAddress
*/