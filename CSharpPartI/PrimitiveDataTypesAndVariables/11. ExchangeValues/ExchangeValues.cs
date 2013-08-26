// Declare two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

    class ExchangeValues
    {
        static void Main()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before swap: x = {0} y = {1}", x, y);

            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
            Console.WriteLine("After swap: x = {0} y = {1}", x, y);
        }
    }

