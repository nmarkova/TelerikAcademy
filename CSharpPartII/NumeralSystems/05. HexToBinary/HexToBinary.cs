﻿// 05. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Text;

class HexToBinary
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        hexNum = hexNum.ToUpper(); 
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case '0': result.Append("0000"); break;
                case '1': result.Append("0001"); break;
                case '2': result.Append("0010"); break;
                case '3': result.Append("0011"); break;
                case '4': result.Append("0100"); break;
                case '5': result.Append("0101"); break;
                case '6': result.Append("0110"); break;
                case '7': result.Append("0111"); break;
                case '8': result.Append("1000"); break;
                case '9': result.Append("1001"); break;
                case 'A': result.Append("1010"); break;
                case 'B': result.Append("1011"); break;
                case 'C': result.Append("1100"); break;
                case 'D': result.Append("1101"); break;
                case 'E': result.Append("1110"); break;
                case 'F': result.Append("1111"); break;
            }
        }
        // Removing the zeros in front of the binary number:
        string finalBit = result.ToString().TrimStart('0');
        Console.WriteLine(finalBit);
    }
}