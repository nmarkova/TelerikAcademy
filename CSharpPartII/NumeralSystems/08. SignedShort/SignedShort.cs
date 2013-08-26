// 08. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class SignedShort
{
    static string GetBinary(short s)
    {
        string b = String.Empty;

        for (int i = 0; i < 16; i++) b = (s >> i & 1) + b;

        return b;
    }

    static void Main()
    {
        Console.WriteLine(GetBinary(253));
    }
}