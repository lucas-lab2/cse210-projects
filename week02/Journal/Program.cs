using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true; // Variable to control the loop
        while (keepRunning)
        {
            Console.WriteLine("Welcome to the Journal Project.");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Save the Journal to a file");

            string choice = Console.ReadLine(); // Read user input


            // Process the user's choice
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose to write a new entry.");
                    break;
                case "2":
                    Console.WriteLine("You chose to display the Journal.");
                    break;
                case "3":
                    Console.WriteLine("You chose to load the Journal.");
                    break;
                case "4":
                    Console.WriteLine("You chose to save the JOurnal to a file.");
                    break;
                case "5":
                    keepRunning = false; // Exit the loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }


        }
        Console.WriteLine("Thank you for using the Journal Project. Goodbye!");
    }
}