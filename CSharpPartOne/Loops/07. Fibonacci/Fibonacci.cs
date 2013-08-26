// 07. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci. 

using System;

class Fibonacci
{
        static void Main()
        {
            Console.Write("Enter N: ");
            ulong n = ulong.Parse(Console.ReadLine());

            ulong firstN = 1;
            ulong secondN = 0;
            ulong thirtN = 0;
            ulong sum = 0;

            for (ulong i = 0; i <= n; i++)
            {
                thirtN = firstN + secondN;
                firstN = secondN;
                secondN = thirtN;
                Console.WriteLine(i + ": " + thirtN);
                sum += thirtN;
            }
            Console.WriteLine("The Sum is: {0}", sum);
        }
    }

