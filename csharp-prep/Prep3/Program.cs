using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n Welcome to the number guessing game!");
        string playAgain = "y";
        do 
        {
        int answer = -1;
        int guesses = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        

            do
            {
                Console.Write("What is your guess? ");
                answer = int.Parse(Console.ReadLine());

                if (answer == magicNumber)
                {
                    Console.WriteLine("Good Job! You guessed the magic number! \n");
                }
                else if (answer > magicNumber)
                {
                    Console.WriteLine("Guess again, the magic number is smaller.");
                }
                else if (answer < magicNumber)
                {
                    Console.WriteLine("Guess again, the magic number is bigger.");
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't recognize that, try agin");
                }

                guesses += 1;
            
            } while (answer != magicNumber);
        Console.WriteLine($"It took you {guesses} guesses to solve the magic number!\n");
        Console.Write("Would you like to play again? (y/n) ");
        playAgain = Console.ReadLine();
        } while (playAgain == "y");
        Console.WriteLine();
    }
}