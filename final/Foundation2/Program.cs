using System;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Foundation2 World!\n\n");

        Address address1 = new Address("235 W 4th S", "Rexburg", "Idaho", "usa");
        Address address2 = new Address("863 W Lenox Church Rd", "Kingsley", "PA", "United States");
        Address address3 = new Address("1246 W 4401 N", "Pleasant Grove", "Utah", "Mexico");

        Customer customer1 = new Customer("Collin Burt", address1);
        Customer customer2 = new Customer("Rachel Mrak", address2);
        Customer customer3 = new Customer("Yazmin Mera", address3);

        Product product1 = new Product("Bread Loaf", 1234, 4.59);
        Product product2 = new Product("Red Apple", 9761, 1.29, 4);
        Product product3 = new Product("5w-20 synthetic oil", 5432, 29.88);
        Product product4 = new Product("Diamond ring", 9991, 2499.99,1);
        Product product5 = new Product("Rotisserie Chicken", 3321, 5.49);

        Order order1 = new Order(customer1);
        order1.AddtoCart(product5);
        order1.AddtoCart(product3);
        order1.AddtoCart(product1);

        Order order2 = new Order(customer2);
        order2.AddtoCart(product2);
        order2.AddtoCart(product1);
        order2.AddtoCart(product5);

        

        List<Product> yazminsproducts = new List<Product>();
        yazminsproducts.Add(product1);
        yazminsproducts.Add(product4);
        yazminsproducts.Add(product2);
        yazminsproducts.Add(product5);

        Order order3 = new Order(customer3, yazminsproducts);

        product5.SetQuantity(2);
        order1.PrintOrder();
        product5.SetQuantity(1);
        product1.SetQuantity(2);
        order2.PrintOrder();
        product2.SetQuantity(6);
        order3.PrintOrder();


    }
}

/*
Foundation 2 Design

public class Product
~ Attributes
string _productName
int _productID
int _price
int _quantity

~ Constructor(Name, ID, Price)

~ Methods
void SetQuantity()

public class Customer
~ Attributes
string _name
string _address
bool _extraShipping

~ Constructor(Name, Address)

~ Methods
bool CheckAddress

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
string CreatShipping Label()

*/