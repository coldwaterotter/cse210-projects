public class Product
{
    string _productName;
    int _productID;
    double _price;
    int _quantity = 1;

    public Product(string name, int ID, double price)
    {
        _productName = name;
        _productID = ID;
        _price = price;
    }

    public Product(string name, int ID, double price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public string PrintProductDetails()
    {
        return $" > {_productName} -- {_productID} -- ${_price} * ({_quantity})";
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double CalculateItemTotal()
    {
        double subtotal = _price * _quantity;

        return subtotal;
    }








}



/*
public class Product
~ Attributes
string _productName
int _productID
int _price
int _quantity

~ Constructor(Name, ID, Price)

~ Methods
void SetQuantity()
*/