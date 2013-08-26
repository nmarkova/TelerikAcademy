// 05. Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class BiggerThanItsNeighbors
{
    static void Main()
    {
        int[] numbers = { 0, 2, 6, 10, 4, -8, 5, 3 };
        int index = 0; // change the index to test the program

        CheckNeighbors(numbers, index);
    }

    static void CheckNeighbors(int[] numbers, int index)
    {
        if (index - 1 < 0 || index + 1 > numbers.Length - 1)
        {
            Console.WriteLine("The element in {0} position doesn't have left or right neighbor", index);
        }
        else
        {
            if (numbers[index - 1] < numbers[index] && numbers[index + 1] < numbers[index])
            {
                Console.WriteLine("The element is bigger than its two neighbors!");
            }
            else
            {
                Console.WriteLine("The element is not bigger than its two neighbors!");
            }
        }
    }
}
