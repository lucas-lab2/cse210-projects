using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            int MagicNumber = 7;
            int GuessCount = 0;

            Console.WriteLine("Hello Player! This is the Guess My Number game!");

            Console.WriteLine($"What is the Magic Number? {MagicNumber} ");

            Console.WriteLine("What is your guess?");
            int userNumber = int.Parse(Console.ReadLine());
            GuessCount++;

            while (userNumber != MagicNumber)
            {
                if (userNumber < MagicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userNumber > MagicNumber)
                {
                    Console.WriteLine("Lower");
                }
                GuessCount++;
                Console.WriteLine("What is your guess?");
                userNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Congratulations! You guessed the Magic Number {MagicNumber} in {GuessCount} tries!");
            Console.WriteLine("Would you like to play again? (Y/N)");
            response = Console.ReadLine().ToUpper();

            while (response != "Y" && response != "N")
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
                response = Console.ReadLine().ToUpper();
            }
        } while (response == "Y");
    }
}