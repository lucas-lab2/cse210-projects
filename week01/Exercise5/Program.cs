using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        DisplayResult(userName, userNumber);
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Welcome to the program.");
            return userName;
        }

        static int PromptUserNumber()
        {
            int userNumber;
            Console.WriteLine("Please, enter your favorite number:");
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your favorite number is {userNumber}.");
            return userNumber;
        }

        static void DisplayResult(string userName, int userNumber)
        {
            int squareNumber;
            squareNumber = userNumber * userNumber;
            Console.WriteLine($"Thank you, {userName}! the square of your number is {squareNumber}.");
        }
    }
}