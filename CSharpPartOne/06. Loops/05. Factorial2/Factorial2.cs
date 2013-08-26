// 05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

class Factorial2
{
    static void Main()
    {
        Console.Write("Enter N: ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        decimal k = decimal.Parse(Console.ReadLine());

        // N!*K! / (K-N)! = N! * (K - (K - N))
        decimal nFact = 1;
        for (decimal i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }
        decimal result = 1;
        for (decimal i = 0; i < (k - (k - n)); i++)
        {
            result = result * (k - i);
        }
        Console.WriteLine(nFact * result);
        }
}

