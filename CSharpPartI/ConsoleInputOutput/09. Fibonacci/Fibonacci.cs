// Write a program to print the first 100 members of the sequence of Fibonacci.

using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        BigInteger member1 = 0;
        BigInteger member2 = 1;
        
        for (int counter = 0; counter < 100; counter++)
        {
            Console.WriteLine(member1);
            BigInteger sum = member1 + member2;
            member1 = member2;
            member2 = sum;
        }
    }
}
