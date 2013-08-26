// 04. Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


using System;

class LargestNumber
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter element [{0}]", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter Searched value (K): ");
        int k = int.Parse(Console.ReadLine());
        
        Array.Sort(numbers);
        Console.WriteLine();

        // Printing the sorted array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0, 2} ", i);
        }
        Console.WriteLine(" :Indexes");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0, 2} ", numbers[i]);
        }
        Console.WriteLine(" :Values\n");

        int index = Array.BinarySearch(numbers, k);
        if (index == -1)
        {
            // We have 3 cases - 1) if K is lower than all the members in the array; 2) if K is larger than the members of the array; 3) if there is a member than is equal to K
            // 1) If the searched value (K) is lower than all the members in the array =>  there is no lower number
            Console.Write("There is no such number!");
        }
        else if (index < -1) // case 2)
        {
            int realIndex = ~index - 1; 
            Console.WriteLine("The largest number < than {0} is {1} with index of {2}", k, numbers[realIndex], realIndex);
        }
        else if (index >= 0) // case 3)
        {
            Console.WriteLine("Number {0} exists in the array and has index of {1}", numbers[index], index);
        }
    }
}