// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.

using System;

class BitPositionCheck
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter the bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << bitPosition;

        int addMask = number & mask;

        if (addMask != 0)
        {
            Console.WriteLine("The bit in position {0} is 1", bitPosition);
        }
        else
        {
            Console.WriteLine("The bit in position {0} is 0", bitPosition);

        }
    }
}
