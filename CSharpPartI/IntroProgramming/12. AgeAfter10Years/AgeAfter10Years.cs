//Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine();
        int ageAfter = (int.Parse(age)) + 10;
        Console.WriteLine("After ten years you will be {0}", ageAfter);
    }
}