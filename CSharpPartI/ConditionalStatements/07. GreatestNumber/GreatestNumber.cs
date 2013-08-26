//07. Write a program that finds the greatest of given 5 variables.

using System;

    class GreatestNumber
    {
        static void Main()
        {
            // SOLUTION 1 - using if statements:
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int biggestNumber = 0;

            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                biggestNumber += a;
            }
            if ((b > a) && (b > c) && (b > d) && (b > e))
            {
                biggestNumber += b;
            }
            if ((c > a) && (c > b) && (c > d) && (c > e))
            {
                biggestNumber += c;
            }
            if ((d > a) && (d > b) && (d > c) && (d > e))
            {
                biggestNumber += d;
            }
            if ((e > a) && (e > b) && (e > c) && (e > d))
            {
                biggestNumber += e;
            }

            Console.WriteLine("The biggest number is: {0}", biggestNumber);
        }
    }

/* SECOND SOLUTION - using arrays and loops - just initializing an array and sort the numbers in ascending order
   int[] biggestNum = new int[5];
 
   for (int index = 0; index < 5; index++)
   {
        Console.Write("number {0} = ", index + 1);
        biggestNum[index] = int.Parse(Console.ReadLine());
   }

   Array.Sort(biggestNum);
   Console.WriteLine("The biggest number is: {0}", biggestNum[4]);
*/ 