// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Margarita";
            string middleName = "Todorova";
            string lastName = "Stoyanova";
            string bankName = "First Investment Bank";
            string IBAN = "BG13FINV91501111111111";
            string bicCode = "FINVBGSF";
            long firstCreditCard = 50845387108538246;
            long secondCreditCard = 29452715478345562;
            long thirdCreditCard = 76139567302544735;
            decimal balance = 3894.8M;
            object fullName = firstName + " " + middleName + " " + lastName;

            Console.WriteLine("Personal Information");
            Console.WriteLine(new string('-', 45));
            Console.WriteLine(fullName);
            Console.WriteLine(); 
            Console.WriteLine("Balance Information:");
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("{0} lv.", balance); 
            Console.WriteLine(); 
            Console.WriteLine("Credit Cards Information:");
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("First credit card number:  {0}\nSecond credit card number: {1}\nThird credit card number:  {2}", firstCreditCard, secondCreditCard, thirdCreditCard);
            Console.WriteLine();
            Console.WriteLine("Bank Information");
            Console.WriteLine(new string('-', 45));      
            Console.WriteLine("Bank name: {0}\nIBAN code: {2}\nBIC code: {3}", bankName, balance, IBAN, bicCode);

            
            
        }
    }

