//02. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;
using System.Text;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Please input a value of N: ");
        int inputN = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();

        for (int i = 1; i <= inputN; i++)
        {
            if (i % 21 != 0)
            {
                builder.Append(i).Append(" ");
            }
        }

        Console.WriteLine("The numbers from 1 to {0} that are not divisible by 3 and 7 at the same time are: ", inputN);
        Console.WriteLine(builder);
    }
}

