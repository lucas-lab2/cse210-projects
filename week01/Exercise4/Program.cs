using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber;
        int soma = 0;
        do
        {
            Console.WriteLine("Please enter a number (0 to stop):");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                Console.WriteLine($"You entered: {userNumber}");
            }

        } while (userNumber != 0);
            foreach (int number in numbers)
            {
                soma += number;
            }
            Console.WriteLine($"The sum of the numbers entered is: {soma}");
    }
}