// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        Console.WriteLine("Please enter a number to check if it can be divided by 5 and 7 at the same time.");
        int number = int.Parse(Console.ReadLine());

        if (number % 35 == 0) // or we can use logical operators: (number % 5 == 0) && (number % 7 == 0)
        {
            Console.WriteLine("This number can be divided by 5 and 7 at the same time!");
        }
        else
        {
            Console.WriteLine("This number can't be divided by 5 and 7 at the same time!");
        }
    }
}


