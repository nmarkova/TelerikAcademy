// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

    class NumDevidedBy5
    {
        static void Main()
        {
            uint a, b;      // I use uint because we have positive integer numbers
            Console.WriteLine("Please enter the first number: ");
            
            while
            (!uint.TryParse(Console.ReadLine(), out a)) 
            {
                Console.Write("Invalid input. Try again please:");
            } 
            Console.WriteLine("Please enter the second number:");
            
            while
            (!uint.TryParse(Console.ReadLine(), out b)) 
            {
                Console.Write("Invalid input. Try again please:");
            } 
            
            uint count = 0;
            for (uint i = a; i <= b; i++)
            {
                if (i % 5 == 0)       //Checking if the current number can be divided by 5 without a remainder
                {
                    count = count++;  //If the condition is true - we increment the count of numbers between a and b, that the reminder of the division by 5 is 0, by 1.
                }
            }
            Console.WriteLine(count);
        }
    }
