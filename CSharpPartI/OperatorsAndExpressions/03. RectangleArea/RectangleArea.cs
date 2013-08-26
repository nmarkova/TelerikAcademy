// Write an expression that calculates rectangle’s area by given width and height

using System;

    class RectangleArea
    {
        static void Main()
        {
            Console.WriteLine("To calculate a rectangle's area, please enter rectangle's width:");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("and rectangle's height:");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Rectangle's area is: {0}", width * height);  
        }
    }

