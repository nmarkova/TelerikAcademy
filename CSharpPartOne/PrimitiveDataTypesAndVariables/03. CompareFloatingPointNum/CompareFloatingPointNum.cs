// Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) > false;  (5.00000001 ; 5.00000003) > true

using System;

    class CompareFloatingPoinNum
    {
        static void Main()
        {
        decimal firstNumber = 5.3333333333333333333333333M;
        decimal secondNumber = 6.01M;
        decimal roundedOne = Math.Round(firstNumber, 6);
        decimal roundedTwo = Math.Round(secondNumber, 6);
        
            if (roundedOne == roundedTwo)
            {
            Console.WriteLine("The numbers are equal!");
            }
            else if (roundedOne > roundedTwo)
            {
            Console.WriteLine("The first number is greater than the second!");
            }
            else
            {
            Console.WriteLine("The second number is greater than the first!");
            }
    }
}



