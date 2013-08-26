// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class IntSum
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdNumber;
        
        Console.Write("Please enter three integer numbers to calculate their sum:\na= ");
        
        while
            (!int.TryParse(Console.ReadLine(), out firstNumber)) // We use int.TryParse method to convert strings into ints.This way we can handle the errors when pasing a number.
        {
            Console.Write("Invalid input. Try again please:"); 
        }
           Console.Write("b= "); 
        
        while 
            (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.Write("Invalid input. Try again please:");
            }
                Console.Write("c= ");

                while 
                    (!int.TryParse(Console.ReadLine(), out thirdNumber))
                {
                    Console.Write("Invalid input. Try again please:");
                }
         
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("a + b + c = {0}", sum);
    }
 }
