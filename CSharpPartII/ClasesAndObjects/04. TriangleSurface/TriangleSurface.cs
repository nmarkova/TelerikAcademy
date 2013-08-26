// Write methods that calculate the surface of a triangle by given: Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math

using System;
using System.Globalization;


class TriangleSurface
{
    static void Main()
    {
        CultureInfo invC = CultureInfo.InvariantCulture;
        Console.WriteLine("Choose your way to calculate the area:");
        Console.WriteLine("1. Side and Altitude");
        Console.WriteLine("2. Three Sides");
        Console.WriteLine("3. Two Sides And Angle");

        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                SideAndAltitude();
                break;
            case 2:
                ThreeSides();
                break;
            case 3:
                TwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Invalid Input - Please Select 1, 2 or 3");
                break;
        }
    }

    private static void SideAndAltitude()
    {
        // case 1. Side and Altitude: Formula: (a * h) / 2
        Console.Write("Enter side 'a': ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude 'h': ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("S = {0}", (a * h) / 2);
    }

    private static void ThreeSides()
    {
        // case 2. Three Sides: Formula: S= sqrt{p(p-a)(p-b)(p-c)} where p = Perimeter / 2
        Console.Write("Enter side 'a': ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side 'b': ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side 'c': ");
        double c = double.Parse(Console.ReadLine());
        double Perimeter = a + b + c;
        double p = Perimeter / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("S = {0}", S);
    }

    private static void TwoSidesAndAngle()
    {
        // Case 3 Formula:
        // S = (a * b * sin(C)) / 2 ; where a and b are sides and C is the angle between them
        Console.WriteLine("Enter side 'a': ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side 'b': ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle (C) degrees: ");
        double c = double.Parse(Console.ReadLine());

        //We must convert the degrees to radians because Math.Sin accepts only radians. The formula is: Radians = (Degree * (PI / 180))
        double angleInRadians = c * Math.PI / 180;
        double S = (a * b * Math.Sin(angleInRadians)) / 2;
        Console.WriteLine("S = {0}", S);
    }
}