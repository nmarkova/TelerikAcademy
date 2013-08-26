// 04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        hexNum = hexNum.ToUpper(); 
        byte[] convertedHex = new byte[hexNum.Length];

        for (int i = 0; i < convertedHex.Length; i++)
        {
            switch (hexNum[i])
            {
                case 'A':
                    convertedHex[i] = 10;
                    break;
                case 'B':
                    convertedHex[i] = 11;
                    break;
                case 'C':
                    convertedHex[i] = 12;
                    break;
                case 'D':
                    convertedHex[i] = 13;
                    break;
                case 'E':
                    convertedHex[i] = 14;
                    break;
                case 'F':
                    convertedHex[i] = 15;
                    break;
                default:
                    convertedHex[i] = byte.Parse(Convert.ToString(hexNum[i]));
                    break;
            }
        }

        int decimalNum = 0;
        for (int i = 0, j = convertedHex.Length - 1; i < convertedHex.Length; i++, j--)
        {
            decimalNum += convertedHex[i] * (int)Math.Pow(16, j);
        }
        Console.WriteLine("Decimal representation: {0}", decimalNum);
    }
}