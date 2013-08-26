// 01. Write a program that prints all the numbers from 1 to N 

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Please input a value of N: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}