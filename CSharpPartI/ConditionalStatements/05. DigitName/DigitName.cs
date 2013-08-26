//05. Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class DigitName
{
    static void Main()
    {
        Console.Write("Please enter a digit: ");
        byte input = byte.Parse(Console.ReadLine());

        switch (input)
        {
            case 0: Console.WriteLine("Digit name: Zero");
                break;
            case 1: Console.WriteLine("Digit name: One");
                break;
            case 2: Console.WriteLine("Digit name: Two");
                break;
            case 3: Console.WriteLine("Digit name: Three");
                break;
            case 4: Console.WriteLine("Digit name: Four");
                break;
            case 5: Console.WriteLine("Digit name: Five");
                break;
            case 6: Console.WriteLine("Digit name: Six");
                break;
            case 7: Console.WriteLine("Digit name: Seven");
                break;
            case 8: Console.WriteLine("Digit name: Eight");
                break;
            case 9: Console.WriteLine("Digit name: Nine");
                break;
            default: Console.WriteLine("Invalid input! Please enter a digit (0-9)");
                break;
        }
    }
}
