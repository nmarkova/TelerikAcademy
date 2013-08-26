// Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class MyGender
{
    static void Main()
    {
        bool isFemale = true;
        switch (isFemale)
        {
            case true:
                Console.WriteLine("I am a Lady.");
                break;
            case false:
                Console.WriteLine("My gender is not: Male.");
                break;
        }
    }
}
