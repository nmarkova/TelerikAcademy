// 03. Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggestNum = 0;

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal!");
        }
        else
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                biggestNum = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                biggestNum = secondNumber;
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                biggestNum = thirdNumber;
            }
            
            Console.WriteLine("The biggest number is: {0}", biggestNum);
        }
    }
}