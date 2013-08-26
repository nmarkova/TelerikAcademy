// Write a program that finds in given array of integers a sequence of given sum S (if present). 

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter the desired sum (s): ");
        int sum = int.Parse(Console.ReadLine()); 
        int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
        int start = 0;
        int currentSum = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            currentSum += numbers[i];
            start = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                currentSum += numbers[j];
                if (currentSum == sum)
                {
                    for (int z = start; z <= j; z++)
                    {
                        Console.Write("{0} ", numbers[z]);
                    }
                    return;
                }
            }
            currentSum = 0;
        }
        Console.WriteLine("There is no such sum in this array");

    }
}











