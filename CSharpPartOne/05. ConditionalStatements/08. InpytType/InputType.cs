//08. Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

class InputType
{
    static void Main()
    {
       
        Console.WriteLine("Please choose type of the variable:\n For type \"Integer\" enter 1 \n For type \"Double\" enter 2 \n For type \"String\" enter 3 ");
       
       
        byte option = byte.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Please enter the value of the integer type variable: ");
                int optionInt = int.Parse(Console.ReadLine());
                Console.WriteLine("The value increased with 1: {0}", optionInt + 1);
                break;
            case 2:
                Console.Write("Please enter the value of the double type variable: ");
                double optionDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("The value increased with 1: {0}", optionDouble + 1);
                break;
            case 3:
                Console.Write("Please enter the value of the string type variable: ");
                string optionString = Console.ReadLine();
                Console.WriteLine("Adding \"*\" in the end of the given string: {0}", optionString + "*");
                break;
            default:
                Console.WriteLine("Invalid Input! You can use ONLY option numbers 1, 2 or 3 \n Please try again!");
                break;
        }
    }
}
