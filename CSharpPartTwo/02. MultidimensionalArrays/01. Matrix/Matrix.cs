// 01. Write a program that fills and prints a matrix of size (n, n)

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix (n): ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;

        Console.WriteLine();
        Console.WriteLine("Matrix a):");
        for (int c = 0; c < n; c++)
        {
            for (int r = 0; r < n; r++)
            {
                matrix[r, c] = counter;
                counter++;
            }
        }

        Printing(n, matrix);

        counter = 1;
        Console.WriteLine();
        Console.WriteLine("Matrix b)");
        for (int c = 0; c < n; c++)
        {
            if (c % 2 == 0)
            {
                for (int r = 0; r < n; r++)
                {
                    matrix[r, c] = counter;
                    counter++;
                }
            }
            else
            {
                for (int r = n - 1; r >= 0; r--)
                {
                    matrix[r, c] = counter;
                    counter++;
                }
            }
        }

        Printing(n, matrix);

        counter = 1;
        Console.WriteLine();
        Console.WriteLine("Matrix c)");
        int row = n - 1;
        int column = 0;

        for (int i = 1; i < n * n; i++)
        {
            matrix[row, column] = counter;
            row++;
            column++;
            counter++;
            if (row == n || column == n)
            {
                row--;
                if (column == n)
                {
                    row--;
                    column--;
                }
                while (row - 1 >= 0 && column - 1 >= 0)
                {
                    row--;
                    column--;
                }
            }
        }

        Printing(n, matrix);
        int[,] newMatrix = new int[n, n];
        counter = 1;
        Console.WriteLine();
        Console.WriteLine("Matrix d)");
        row = 0;
        column = 0;
        string direction = "right";
        int maxRotations = n * n;


        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (column > n - 1 || newMatrix[row, column] != 0))
            {
                direction = "down";
                column--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || newMatrix[row, column] != 0))
            {
                direction = "left";
                row--;
                column--;
            }
            if (direction == "left" && (column < 0 || newMatrix[row, column] != 0))
            {
                direction = "up";
                column++;
                row--;
            }

            if (direction == "up" && row < 0 || newMatrix[row, column] != 0)
            {
                direction = "right";
                row++;
                column++;
            }

            newMatrix[row, column] = i;

            if (direction == "right")
            {
                column++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                column--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        Printing(n, newMatrix);
    }

    static void Printing(int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

