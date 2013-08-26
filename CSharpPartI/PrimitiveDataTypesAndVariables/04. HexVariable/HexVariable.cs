// Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.

using System;

    class HexVariable
    {
        static void Main()
        {
            int number = 254;
            int хNumber = 0xFE;

            Console.WriteLine("The hexademical equivalent of decimal {0} is {0:X}.", number, хNumber);
        }
    }

