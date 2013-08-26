// 02. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements

using System;

class SignOfProduct
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int negativeSign = 0;

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product of these three numbers is 0!");
        }
        else
        {
            if (firstNumber < 0)
            {
                negativeSign++;
            }
            if (secondNumber < 0)
            {
                negativeSign++;
            }
            if (thirdNumber < 0)
            {
                negativeSign++;
            }

            if (negativeSign == 1 || negativeSign == 3)
            {
                Console.WriteLine("The sign of the product of these numbers is \"-\"");
            }
            else
            {
                Console.WriteLine("The sign of the product of these numbers is \"+\"");
            }
        }
    }
}