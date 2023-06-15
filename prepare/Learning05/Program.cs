using System;

class Program
{
    public List<Shape> _shapes = new List<Shape>();
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Learning05 World!\n");
        Square square = new Square("Blue", 3);
        Console.WriteLine($"{square.GetColor()}, {square.GetArea()}");
        Console.WriteLine();

        Rectangle rectangle = new Rectangle("Blue", 3, 4);
        rectangle.SetColor("Red");
        Console.WriteLine($"{rectangle.GetColor()}, {rectangle.GetArea()}");
        Console.WriteLine();

        Circle circle = new Circle("Yellow", 2.5);
        Console.WriteLine($"{circle.GetColor()}, {circle.GetArea()}");
        Console.WriteLine();

        Console.WriteLine("Test List Functionality\n");
        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(circle);
        _shapes.Add(square);
        _shapes.Add(rectangle);

        foreach (Shape s in _shapes)
        {
            double area = s.GetArea();
            string color = s.GetColor();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}