// 03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;


class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        List<byte> hexNum = new List<byte>();

        while (n != 0)
        {
            hexNum.Add((byte)(n % 16));
            n /= 16;
        }
        Console.Write("Hexadecimal representation: ", n);
        for (int i = hexNum.Count - 1; i >= 0; i--)
        {
            switch (hexNum[i])
            {
                case 10:
                    Console.Write('A');
                    break;
                case 11:
                    Console.Write('B');
                    break;
                case 12:
                    Console.Write('C');
                    break;
                case 13:
                    Console.Write('D');
                    break;
                case 14:
                    Console.Write('E');
                    break;
                case 15:
                    Console.Write('F');
                    break;
                default:
                    Console.Write(hexNum[i]);
                    break;
            }
        }
        Console.WriteLine();
    }
}