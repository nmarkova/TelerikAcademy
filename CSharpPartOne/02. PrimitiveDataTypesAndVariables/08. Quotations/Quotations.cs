// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties. Do the above in two different ways: with and without using quoted strings

using System;

    class Quotations
    {
        static void Main()
        {
            string string1 = "The \"use\" of quotations causes difficulties.";  // with quoted string
            string string2 = @"The ""use"" of quotations causes difficulties."; // without quoted string
            
            Console.WriteLine(string1);
            Console.WriteLine(string2);
        }
    }

