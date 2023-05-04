public class Car
{
    //Instances or variables
    public string brand;
    public int miles;
    public string color;

    // Constructor
    public Car()
    {

    }

    // Methods (functions)
    public void move_forward()
    {
        Console.WriteLine("is running"); 
    }

    public void displayInfo()
    {
        Console.WriteLine($"Brand: {brand}, Mileage: {miles}, Color: {color}");
    } 
}