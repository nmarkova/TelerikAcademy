//09. Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

using System;

class SortArray
{
    static void Main()
    {
        int[] numbers = { 5, 3, 34, 5, 7, 18, 4, 24, 67, 5, 9, 2, 98, 67, 45, 90, 78, 51, 6, 8, 1, 2, 63, 86, 45, 6, 54, 87, 75, 30, 11, 16, 86,
                        9, 17, 64, 80, 70, 30, 29};

        for (int i = 0; i < numbers.Length; i++)
        {
            int maxIndex = FindMax(numbers, i);
            int temp = numbers[i];
            numbers[i] = numbers[maxIndex];
            numbers[maxIndex] = temp;
        }

        Console.WriteLine("Descending Order: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 10 == 0)
            {
                Console.Write("\n");
            }
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine("\n\nAscending Order: ");
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 10 == 0)
            {
                Console.Write("\n");
            }
            Console.Write("{0} ", numbers[i]);
        }

    }

    private static int FindMax(int[] numbers, int startingIndex)
    {
        int currentMax = int.MinValue;
        int currentMaxIndex = startingIndex;
        for (int j = startingIndex; j < numbers.Length; j++)
        {
            if (numbers[j] > currentMax)
            {
                currentMax = numbers[j];
                currentMaxIndex = j;
            }
        }
        return currentMaxIndex;
    }
}