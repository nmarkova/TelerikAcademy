// Write a program that can solve these tasks: Reverses the digits of a number; Calculates the average of a sequence of integers; Solves a linear equation a * x + b = 0

using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Please select a task to solve:\n1. Reverse the digits of a number\n2. Calculate Average\n3. Solve linear equation a * x + b = 0");

        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                ReverseInput();
                break;
            case 2:
                AverageInput();
                break;
            case 3:
                EquationInput();
                break;
            default:
                Console.WriteLine("Invalid input! Please select 1, 2 or 3");
                break;
        }
    }

    static void EquationInput()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("A must not be equal to Zero!");
        }
        else
        {
            Console.WriteLine("Equation result is: {0}", CalcEquation(a, b));
        }
    }

    static double CalcEquation(int a, int b)
    {
        return (double)-b / a;
    }

    static void AverageInput()
    {
        Console.WriteLine("Enter the size of the sequence: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("The sequence must have at least 1 or more elements!");
            return;
        }
        int[] sequence = new int[n];
        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write("Enter element {0}: ", i);
            sequence[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The average of the sequence is: {0}", CalcAverage(sequence));
    }

    static double CalcAverage(int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum / sequence.Length;
    }

    static void ReverseInput()
    {
        Console.Write("Enter n: ");
        string number = Console.ReadLine();
        if (int.Parse(number) > 0)
        {
            Console.WriteLine("The reversed n is: {0}", Reverse(number));
        }
        else
        {
            Console.WriteLine("The number must ne non-negative!");
        }
    }

    static int Reverse(string number)
    {
        int[] digits = new int[number.Length];
        int numberInt = int.Parse(number);
        int i = 0;
        while (numberInt > 0)
        {
            int lastDigit = numberInt % 10;
            numberInt /= 10;
            digits[i] = lastDigit;
            i++;
        }

        int finalNumber = 0;
        for (int j = 0; j < digits.Length; j++)
        {
            finalNumber = finalNumber * 10 + digits[j];
        }
        return finalNumber;
    }
}