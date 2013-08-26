// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("To calculate circle's perimeter and area, please enter circle's radius:\nr= ");

            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * r * Math.PI;
            double area = Math.Pow(r, 2) * Math.PI;
            
            Console.WriteLine("Circle's perimeter = {0:0.00}", perimeter);
            Console.WriteLine("Circle's area = {0:0.00}", area);
        }
    }

