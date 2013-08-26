// Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;


class MaxIncreasingSequence
{
    static void Main()
    {
        int[] numbers = {3, 2, 3, 4, 2, 2, 4};
        int maxSequence = 0;
        int currentSequence = 0;
        int sequenceEnd = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] + 1 == numbers[i + 1])
            {
                currentSequence++;
            }
            else
            {
                if (currentSequence > maxSequence)
                {
                    sequenceEnd = numbers[i];
                    maxSequence = currentSequence;
                }
                currentSequence = 1;
            }
        }

        if (currentSequence > maxSequence)
        {
            maxSequence = currentSequence;
            sequenceEnd = numbers[numbers.Length - 1];
        }

        Console.WriteLine("The maximum increasing sequence is: ");
        for (int i = maxSequence - 1; i >= 0; i--)
        {
            Console.Write("{0} ", sequenceEnd - i);
        }
    }
}

