// Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer number: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(n));
        }
        catch (ArgumentException)
        {

            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {

            Console.WriteLine("This is not an integer number! Please enter an integer number!");
        }
        catch (OverflowException)
        {

            Console.WriteLine("The number is too big!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
