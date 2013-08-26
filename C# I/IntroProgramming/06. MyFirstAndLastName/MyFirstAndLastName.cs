//Create console application that prints your first and last name.

using System;

class MyFirsAndLastName
{
    static void Main()
    {
        string firstName = "Ivanka";
        string lastName = "Ivanova";
        Console.WriteLine("My first name is {0} and my last name is {1}.", firstName, lastName);
    }
}

/* Of course there are eaier ways such as:
1.
class MyFirsAndLastName
    {
        static void Main()
        {
            Console.WriteLine("Ivanka Ivanova");
        }
    }

 2.
 class MyFirsAndLastName
    {
        static void Main()
        {
           Console.Write("Ivanka"+" ");
            Console.WriteLine("Ivanova");
        }
    } */