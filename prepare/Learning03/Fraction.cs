using System;
public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator} / {_denominator}";
    }

    // public void SetFraction()
    // {
    //     Console.WriteLine("What is the numerator? \n >");
    //     _numerator = int.Parse(Console.ReadLine());
    //     Console.WriteLine("What is the denominator? \n >");
    //     _denominator = int.Parse(Console.ReadLine());
        
    // }

    public double GetDecimalValue()
    {
        //double num = _numerator % _denominator;
        return (double)_numerator / (double)_denominator;
    }

    public void ShowFractionString()
    {
        Console.WriteLine($"{_numerator} / {_denominator}");
    }





}