using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, type the grade percentage you received in the course:");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            Console.WriteLine("You received an A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("You received a B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("You received a C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("You received a D.");
        }
        else
        {
            Console.WriteLine("You received an F.");
        }
    }
}