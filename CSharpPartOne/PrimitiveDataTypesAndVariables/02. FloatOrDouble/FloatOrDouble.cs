// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

    class FloatOrDouble
    {
        static void Main()
        {
            float number1 = 12.345f;
            float number2 = 3456.091f;
            double number3 = 34.567839023;
            double number4 = 8923.1234567;

            Console.WriteLine("The following two values can be assigned to variables of float type: {0}, {1} and these two: {2}, {3} can be assigned to variables of type double", number1, number2, number3, number4);

        }
    }

