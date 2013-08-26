﻿// Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

    class NullVariable
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);

            a += null;
            b += 5; // NOTE - Adding value to null variable results null
            Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
        }
    }

