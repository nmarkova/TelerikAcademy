// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class ArraySorting
{
    static void Main()
    {
        int[] array = { 32, 46, 41, 12, 52, 100, 9, 7, 65, 53, 0, 7, 89, 6, 24, 18, 20, 72};


        int startingPosition = 0;
        while (startingPosition <= array.Length - 1)
        {
            int currentMinIndex = 0;
            int currentMin = int.MaxValue;
            for (int i = startingPosition; i < array.Length; i++)
            {
                if (array[i] < currentMin)
                {
                    currentMin = array[i];
                    currentMinIndex = i;
                }
            }
            int temp = array[startingPosition];

            array[startingPosition] = currentMin;
            array[currentMinIndex] = temp;
            startingPosition++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0}: {1}", i, array[i]);
        }
    }
}