﻿// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class ReadFile
{
    static void Main()
    {
        Console.Write("Please enter the file's full path: ");
        string filePath = Console.ReadLine();
        PrintFileToConsole(filePath);
    }

    static void PrintFileToConsole(string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(fileContent);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please enter valid file path!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter a valid file path!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The file path must not be longer than 248 characters!");
        }
        catch (UnauthorizedAccessException accessError)
        {
            Console.WriteLine(accessError.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have permission to access this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid path!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}
