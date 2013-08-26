// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class DataTypes
{
    static void Main()
    {
        byte var1 = 97;
        sbyte var2 = -115;
        short var3 = -10000;
        ushort var4 = 52130;
        int var5 = 4825932;

        Console.WriteLine("The appropriate data type for the following values are: {0} - byte; {1} - sbyte; {2} - short; {3} - ushort; {4} - int.", var1, var2, var3, var4, var5);
    }
}
