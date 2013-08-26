// 06. Write a program that enters the coefficients a, b and c of a quadratic equation and calculates and prints its real roots. 

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter the coefficients a, b and c\nEnter a:");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("This equation is not quadratic!");   // An equation is quadratic only if a>0
        }
        else
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant > 0)                                   // If the discriminant is > 0 - the equation has 2 roots - x1 and x2
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else
                if (discriminant == 0)                             // If the discriminant is = 0 the equation has only one root
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equation has only one root: {0}", x);
                }
                else if (discriminant < 0)                         // If the discriminant is < 0 - the equation doesn't have solution
                {
                    Console.WriteLine("This equation doesn't have solution!");

                }
        }
    }
}

