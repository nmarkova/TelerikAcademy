// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

using System;

class NSum
{
    static void Main()
    {
        uint n;
        Console.Write("Enter the number of entries (n): ");
        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("invalid entry. Please try again: ");
        }
        int sum = 0;
        int counter;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0} :", i);
            while (!int.TryParse(Console.ReadLine(), out counter))
            {
                Console.Write("Invalid entry. Please try again: ");
            }
            sum = sum + counter;
        }
        Console.WriteLine("The sum of the numbers is {0}", sum);
    }
}