﻿// Write an expression that checks if given integer is odd or even.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");

        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

