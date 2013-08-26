// 01. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Please enter two numbers\na= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        int c;
        Console.WriteLine("Entered values: a = {0}, b = {1}", a, b);
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Exchanged values: a = {0}, b = {1}", a, b);
        }
        else
        {
            Console.WriteLine("a is not greater than b");
        }
    }
}
