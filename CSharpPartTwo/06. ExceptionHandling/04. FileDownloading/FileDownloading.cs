// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class FileDownloading
{
    static void Main()
    {
        Console.WriteLine("Enter the URL of the file you want to download");
        Uri uri = new Uri(Console.ReadLine());
        string fileName = System.IO.Path.GetFileName(uri.LocalPath);
        WebClient webClient = new WebClient();
        try
        {
            webClient.DownloadFile(uri, "../../" + fileName);
            Console.WriteLine("The file was successfully downloaded!");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid adress or empty file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}
