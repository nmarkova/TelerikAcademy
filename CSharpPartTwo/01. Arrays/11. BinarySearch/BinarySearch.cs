﻿// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        int[] numbers = { 12, 22, 34, 47, 55, 67, 82, 98 };
        int searchValue = 82;
        Console.WriteLine("The index of {0} is {1}", searchValue, BinarySearchAlg(numbers, searchValue));
    }

    static int BinarySearchAlg(int[] numbers, int searchValue)
    {
        Array.Sort(numbers);
        int leftPoint = 0;
        int rightPoint = numbers.Length - 1;
        int midPoint = (leftPoint + rightPoint) / 2;

        while (leftPoint <= rightPoint)
        {
            midPoint = (leftPoint + rightPoint) / 2;
            if (numbers[midPoint] != searchValue)
            {
                if (searchValue > numbers[midPoint])
                {
                    leftPoint = midPoint + 1;
                }
                else if (searchValue < numbers[midPoint])
                {
                    rightPoint = midPoint - 1;
                }
            }
            else
            {
                return midPoint;
            }
        }
        return -1;
    }
}