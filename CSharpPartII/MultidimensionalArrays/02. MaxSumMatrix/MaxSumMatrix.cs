// 02. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSumMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Enter Element[{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        Console.WriteLine("The matrix of the elements you entered is:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }

        int currentSum = 0;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int BestColumnumn = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                             matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = i;
                    BestColumnumn = j;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The square (3 x 3) that has maximal sum of its elements is:");
        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = BestColumnumn; j < BestColumnumn + 3; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }

    }
}

