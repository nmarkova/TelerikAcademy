//04. Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;
using System.Linq;

class NumberCount
{
    static void Main()
    {
        int[] numbers = { 8, 3, 4, 5, 8, 3, 4, 8, 7, 5, 1, 6, 8, 8 };
        int searchedNumber = 8;
        int asd = numbers.Max();

        int count = RecurrentNumCount(numbers, searchedNumber);
        Console.WriteLine(count);
    }

    static int RecurrentNumCount(int[] numbers, int searchedNumber)
    {
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchedNumber)
            {
                counter++;
            }
        }
        return counter;
    }
}