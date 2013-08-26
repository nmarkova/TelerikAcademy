// Write an expression that calculates trapezoid's area by given sides a and b and height h

using System;

    class Trapezoid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter trapezoid parameters to calculate its area:\nSide a:");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Side b:");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Height:");
            double height = int.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * height;
            Console.WriteLine("Trapezoid's area is: {0}", area);
        }
    }

