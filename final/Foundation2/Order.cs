public class Order
{
    List<Product> _cart = new List<Product>();
    Customer _customer;
    double _totalDue;
    string _packingLabel;
    string _shippingLabel;


    public Order(Customer customer)
    {
        _customer = customer;
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _cart = new List<Product>();
        _cart = products;
    }

    public void PrintOrder()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        CreatePackingLabel();
        CreatShippingLabel();
        Console.WriteLine($" Subtotal: ${CalculateSubtotal()} ~~ Shipping: ${_customer.GetShippingCost()}");
        Console.WriteLine($"Grand Total: == ${CalculateTotal()}\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    }
    public void CreatShippingLabel()
    {
        Address address = _customer.GetAddress();
        Console.WriteLine($"{_customer.GetName()}\n{address.PrintAddress()}\n");
        _shippingLabel = $"{_customer.GetName()}\n{address.PrintAddress()}\n";
    }

    public void CreatePackingLabel()
    {
        int list = 0;
        foreach (Product p in _cart)
        {
            list ++;
            Console.WriteLine($"{p.PrintProductDetails()}");
        }
        _packingLabel = $"\nYou have {list} items in your order.\n";
        Console.WriteLine($"\nYou have {list} items in your order.\n");

    }

    public void AddtoCart(Product product)
    {
        _cart.Add(product);
    }
    public double CalculateTotal()
    {
        double total = 0;
        foreach(Product p in _cart)
        {
            total += p.CalculateItemTotal();
        }
        total += _customer.GetShippingCost();
        _totalDue = total;
        return Math.Round(total,2);
    }

    public double CalculateSubtotal()
    {
        double subtotal = 0;
        foreach(Product p in _cart)
        {
            subtotal += p.CalculateItemTotal();
        }
        return Math.Round(subtotal,2);
    }



}




/*
public class Order
~ Attributes
int _totalBalance
string _packingLabel
string _shippingLabel

~ Constructor()

~ Methods
int CalculateTotal()
int CheckShippingAddress()
string CreatePackageLabel()
string CreatShippingLabel()
*/