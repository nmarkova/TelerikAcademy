// 13.* Write a program that calculates for given N how many trailing zeros present at the end of the number N. 

using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Please enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        int counterZero = 0;
        int divider = 5; // N! trailing zeros =  n/5 + n/25 + n/125 + n/625 + ... + ... + ...

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        Console.WriteLine("N! = {0}", factorialN);

        while (n >= divider)
        {
            counterZero += (n / divider);
            divider *= 5;
        }

        Console.WriteLine("There are {0} trailing zeroes at the end of (N!)", counterZero);
        }
}