// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime 

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year is leap!");
        }
        else
        {
            Console.WriteLine("The year is NOT leap!");
        }
    }
}