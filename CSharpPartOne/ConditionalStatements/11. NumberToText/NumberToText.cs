//11. Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation

using System;
using System.Collections.Generic;
using System.Linq;

class NumberToText
{
    public static int[] digitArr(int n)
    {
        if (n == 0) return new int[1] { 0 };

        var digits = new List<int>();

        for (; n != 0; n /= 10)
            digits.Add(n % 10);

        var arr = digits.ToArray();
        Array.Reverse(arr);
        return arr;
    }

    static void Main()
    {
        Console.Write("Please, enter an integer number from 0 to 999: ");
        int number = int.Parse(Console.ReadLine());
        int[] splitedArray = digitArr(number);
        int arrayLength = splitedArray.Length;

        string[] ones = new String[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tens = new String[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] specialDigits = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };


        switch (arrayLength)
        {
            case 1: // 1-9
                if (splitedArray[0] == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine(ones[splitedArray[0]]);
                }
                break;
            case 2: // 10 - 99
                if (splitedArray[0] == 1)
                {
                    Console.WriteLine(specialDigits[splitedArray[1]]);
                }
                else
                {
                    Console.WriteLine(tens[splitedArray[0]] + " " + ones[splitedArray[1]]);
                }
                break;
            case 3: // 100 - 999

                if (splitedArray[1] == 1)
                {
                    Console.WriteLine(ones[splitedArray[0]] + " hundred and " + specialDigits[splitedArray[2]]);
                }
                else
                {
                    if (splitedArray[1] != 0 || splitedArray[2] != 0)
                    {
                        Console.WriteLine(ones[splitedArray[0]] + " hundred and " + tens[splitedArray[1]] + " " + ones[splitedArray[2]]);
                    }
                    else
                    {
                        Console.WriteLine(ones[splitedArray[0]] + " hundred " + tens[splitedArray[1]] + " " + ones[splitedArray[2]]);
                    }
                }
                break;
            default:
                break;
        }
    }
}
