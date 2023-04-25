using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayGreeting();
        string UserName = InputUserName();
        int FavoriteNum = FavoriteNumber();
        int square = SquaredNumber(FavoriteNum);
        Result(square, UserName);
        Console.WriteLine();
    }
    static void DisplayGreeting()
    {
        Console.WriteLine($"\n Welcome to the Program!");
    }
    static string InputUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int FavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favorite = int.Parse(Console.ReadLine());
        return favorite;

    }
    static int SquaredNumber(int number)
    {   
        int square = number * number;
        return square;
    }

    static void Result(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}