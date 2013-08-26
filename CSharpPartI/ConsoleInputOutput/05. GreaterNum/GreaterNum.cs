// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

    class GreaterNum
    {
        static void Main()
        {
            Console.Write("Number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Number b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The Greater number is {0}", (a + b + Math.Abs(a-b))/2);
        }
    }

