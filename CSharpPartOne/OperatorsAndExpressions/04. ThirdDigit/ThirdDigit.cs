// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true

using System;

    class ThirdDigit
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
           
            Console.WriteLine(Math.Abs((number / 100) % 10) == 7 ? "The third digit is 7" : "The third digit is Not 7");
        }
    }

// We use Math.Abs(); to get the absolute value of the entered number in case the user enter a negative number
