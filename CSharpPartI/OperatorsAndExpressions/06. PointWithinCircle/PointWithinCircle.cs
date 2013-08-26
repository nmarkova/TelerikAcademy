// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Please enter the coordinates (x,y) of the point:");

        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Please enter circle radius: "); 
        double circleRadius = double.Parse(Console.ReadLine()); ;

        if ((x * x + y * y) <= (circleRadius * circleRadius))
        {
            Console.WriteLine("The given point is within a circle with radius {0}!", circleRadius);
        }
        else
        {
            Console.WriteLine("The given point is not within a circle with radius {0}!", circleRadius);
        }
    }
}


