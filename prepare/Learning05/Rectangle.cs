public class Rectangle : Shape 
{
    private double _length;
    private double _width;
    public Rectangle ()
    {

    }

    public Rectangle (string color, double one, double two) : base(color)
    {
        _length = one;
        _width = two;
    }

    public override double GetArea()
    {
        double area = _width * _length;
        return area;
    }




}