// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

    class CalcSum
    {
        static void Main()
        {
            double firstNumber = 1;
            double totalSum = 1;
            Console.WriteLine(firstNumber);
            for (double j = 2; j <= 1000; j++)
            {
                firstNumber = 1;
                if (j % 2 == 0)
                {
                    firstNumber = firstNumber / j;
                }
                else
                {
                    firstNumber = -(firstNumber / j);
                }
                Console.WriteLine(firstNumber);

                totalSum = totalSum + firstNumber;
            }
            Console.WriteLine("The Total sum of the numbers is: {0}", totalSum);
        }
    }
