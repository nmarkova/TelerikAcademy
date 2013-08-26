//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

    class EmployeesRecord
    {
        static void Main()
        {
            string firstName = "Marina";
            string lastName = "Todorova";
            char gender = 'f';
            string idNumber = "8708167462"; // People born in 21st sentury have ID with leading "0", therefore it should be assigned to string type
            ushort employeeNumber = 5386;  // In order to save 2 bytes we can record only the last 4 digits of the number, because the first 4 are same for all employees or use 2756+employeeNumber

            Console.WriteLine("Employee {0} {1}:\nGender: {2}\nID Number: {3}\nEmployee numer: {4}", firstName, lastName, gender, idNumber, employeeNumber);
        }
    }

