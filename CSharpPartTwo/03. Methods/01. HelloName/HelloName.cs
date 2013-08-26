// 01. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

class HelloName
{
    static void Main()
    {
        PrintName();
    }

    static void PrintName()
    {
        Console.Write("Please enter your name: ");
        Console.WriteLine("Hello, {0}!", Console.ReadLine());
    }
}