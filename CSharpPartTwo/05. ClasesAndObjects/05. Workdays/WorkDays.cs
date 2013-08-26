// Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array

using System;

class WorkDays
{
    static void Main()
    {
        Console.WriteLine("Enter future date in the following format: DD/MM/YYYY:");
        string[] futureDateStr = Console.ReadLine().Split('/');
        CalculateWorkDays(futureDateStr);
    }

    private static void CalculateWorkDays(string[] futureDateStr)
    {
        int day = int.Parse(futureDateStr[0]);
        int month = int.Parse(futureDateStr[1]);
        int year = int.Parse(futureDateStr[2]);

        DateTime startDate = DateTime.Today;
        DateTime futureDate = new DateTime(year, month, day);

        // Is the entered data a future date?
        if (futureDate < startDate)
        {
            Console.Write("Please enter a future date!");
            return;
        }

        int totalDays = (futureDate - startDate).Days;
        Console.WriteLine("Total Days: {0}", totalDays);
        
DateTime[] officialHolidays = 
        {
            new DateTime(2013, 1, 1), 
            new DateTime(2013, 3, 3), 
            new DateTime(2013, 5, 3),  
            new DateTime(2013, 5, 4), 
            new DateTime(2013, 5, 5), 
            new DateTime(2013, 5, 6),
            new DateTime(2013, 5, 1), 
            new DateTime(2013, 5, 6),
            new DateTime(2013, 5, 24),
            new DateTime(2013, 9, 6),
            new DateTime(2013, 9, 22),
            new DateTime(2013, 11, 1),
            new DateTime(2013, 12, 24), 
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26)
        };

        int workdayCounter = 0;
        bool isHolyday = false;

        for (int i = 0; i < totalDays; i++)
        {
            
            if (!(startDate.DayOfWeek == DayOfWeek.Saturday) && !(startDate.DayOfWeek == DayOfWeek.Sunday))
            {
                
                for (int j = 0; j < officialHolidays.Length; j++)
                {
                    if (startDate.Day == officialHolidays[j].Day && startDate.Month == officialHolidays[j].Month)
                    {
                        isHolyday = true;
                        break;
                    }
                }
                if (!isHolyday)
                {
                    workdayCounter++;
                }
                isHolyday = false;
            }
            startDate = startDate.AddDays(1);
        }

        Console.WriteLine("Workdays left until {0} : {1}", futureDate, workdayCounter);
    }
}