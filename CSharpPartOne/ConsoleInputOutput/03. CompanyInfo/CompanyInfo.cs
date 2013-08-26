// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyDetails
{
    static void Main()
    {
        Console.WriteLine("Please fill the following information about your company and its manager:");
        Console.Write("Company name: ");
        string company = Console.ReadLine();
        
        Console.Write("Company address: ");
        string address = Console.ReadLine();

        Console.Write("Company phone number: ");
        string companyPhone = Console.ReadLine();

        Console.Write("Company FAX number:");
        string companyFax = Console.ReadLine();

        Console.Write("Company website: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager's first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Manager's age: ");
        string age = Console.ReadLine();

        Console.Write("Manager's phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company: {0}", company);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Address: {0} \nPhone number: {1} FAX: {2} \nWebsite: {3}", address, companyPhone, companyFax, webSite);

        Console.WriteLine();
        Console.WriteLine("Manager: {0}", company);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: {0}\nPhone number: {1}", age, managerPhone);

    }
}
