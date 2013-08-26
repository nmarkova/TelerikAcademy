//03. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

    class MinMax
    {
        static void Main()
        {
            // SOLUTION 1 - using an array
            Console.Write("Please input a value of N: ");
            int countNumbers = int.Parse(Console.ReadLine());

            int[] allNumbers = new int[countNumbers];

            for (int i = 0; i < countNumbers; i++)
            {
                Console.Write("Please enter a number: ");
                int inputNumber = int.Parse(Console.ReadLine());
                allNumbers[i] = inputNumber;
            }
            Array.Sort(allNumbers);
            Console.WriteLine("The minimal value in the given sequence is: {0}", allNumbers[0]);
            Console.WriteLine("The maximal value in the given sequence is: {0}", allNumbers[allNumbers.Length - 1]);
        }
    }

/* SOLUTION 2 - using if statements:
     Console.Write("Please enter the value of N ");
     int countOfNums = int.Parse(Console.ReadLine());
     int min, max, inputNum;
        
     Console.Write("Please enter your first number: ");
     inputNum = int.Parse(Console.ReadLine());
     min = max = inputNum;
     for (int i = 1; i <= countOfNums; i++)
     {
         Console.Write("Please enter your next number: ");
         inputNum = int.Parse(Console.ReadLine());

            if (inputNum > max)
            {
                max = inputNum;
            }
            if (inputNum < min)
            {
                min = inputNum;
            }
        }

        Console.WriteLine("The MIN value in the given sequence is: {0}", min);
        Console.WriteLine("The MAX value in the given sequence is: {0}", max);
*/