// 02. Write a program to convert binary numbers to their decimal representation.

using System;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        byte[] binaryNum = Console.ReadLine().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();

        int decimalNum = 0;
        for (int i = 0, j = binaryNum.Length - 1; i < binaryNum.Length; i++, j--)
        {
            decimalNum += binaryNum[i] * (int)Math.Pow(2, j);
        }
        Console.WriteLine(decimalNum);
    }
}