// Write a program that prints to the console which day of the week is today. Use System.DateTime

using System;

class RandomValues
{
    static void Main()
    {
        Random randomvalue = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Random value {0}: {1}", i, randomvalue.Next(100, 200) + 1);
        }
    }
}