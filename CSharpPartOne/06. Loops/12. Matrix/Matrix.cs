// 12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following.

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number N (N < 20) to print your matrix: \nN = ");
        int inputN = int.Parse(Console.ReadLine());
        int result;

        for (int i = 1; i <= inputN; i++)
        {
            for (int j = 0; j < inputN; j++)
            {
                result = i + j;
                Console.Write("{0}", result.ToString().PadRight(3));
            }

            Console.WriteLine();
        }
    }
}

