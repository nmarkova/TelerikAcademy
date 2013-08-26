// 01. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        List<bool> binaryNum = new List<bool>();

        while (n != 0)
        {
            if (n % 2 == 0)
            {
                binaryNum.Add(false);
            }
            else
            {
                binaryNum.Add(true);
            }
            n /= 2;
        }
        for (int i = binaryNum.Count - 1; i >= 0; i--)
        {
            if (binaryNum[i])
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(0);
            }
        }
    }
}