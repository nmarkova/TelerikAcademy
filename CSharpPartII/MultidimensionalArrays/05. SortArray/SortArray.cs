// 05. You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

    class SortArray
    {
        static void Main()
        {
            string[] strings = { "aa", "bbb", "cc", "dddddd", "eeee", "ff" };
            SortingMethod(strings);
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        static void SortingMethod(string[] array)
        {
            int[] stringsLenghts = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                stringsLenghts[i] = array[i].Length;
            }
            Array.Sort(stringsLenghts, array);
            return;
        }
    }

