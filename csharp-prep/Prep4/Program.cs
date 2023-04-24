using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");
        int entry = -1;
        List<int> numbers;
        numbers = new List<int>();

        do 
        {
            Console.Write("Enter number: ");
            entry = int.Parse(Console.ReadLine());

            if (entry != 0)
            {
                numbers.Add(entry);
            }

        } while (entry != 0);

        int sum = 0;
        int largest = 0;
        int total = 0;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
            sum += num;
            total += 1;
        }
        
        float average = ((float)sum) / total;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        
        Console.WriteLine();
    }
}