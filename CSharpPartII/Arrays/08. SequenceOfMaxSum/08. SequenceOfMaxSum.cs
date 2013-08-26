using System;

class MaxSumSeq
{
    static void Main()
    {
        int[] numbers = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int maxBegin = numbers[0];
        int maxEnd = numbers[0];
        int begin = 0;
        int begin_temp = 0;
        int end = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (maxEnd < 0)
            {
                maxEnd = numbers[i];
                begin_temp = i;
            }
            else
            {
                maxEnd += numbers[i];
            }
            
            if (maxEnd >= maxBegin)
            {
                maxBegin = maxEnd;
                begin = begin_temp;
                end = i;
            }
        }

        for (int i = begin; i <= end; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine("Sum = {0}", maxBegin);
    }
}