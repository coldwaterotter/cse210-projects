using System;

class Car_Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test debugger Car program");
    
        Car bmw_m3 = new Car();

        bmw_m3.brand = "BMW";
        bmw_m3.miles = 10000;
        bmw_m3.color = "Red";
    
        bmw_m3.displayInfo();
        bmw_m3.move_forward();

        
    }
}