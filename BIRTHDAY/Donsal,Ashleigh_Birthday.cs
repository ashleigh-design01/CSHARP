using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your birthday date (mm-dd): ");
        string input = Console.ReadLine();

        // It Parse the date that you input
        DateTime BirthdayDate = DateTime.Parse(input);

        // Getting the current date
        DateTime today = DateTime.Today;

        // You are calculating the difference of the dates
        TimeSpan difference = BirthdayDate - today;

        // Checking if the birthday is in the future or in the past
        if (difference.Days > 0)
        {
            Console.WriteLine($"Your Birthday is in {difference.Days} days.");
        }
        // Checking if the birthday has passed
        else if (difference.Days < 0)
        {
            Console.WriteLine($"Your birthday has already passed. It has been {Math.Abs(difference.Days)} days since your birthday.");
        }
        // It will check if the birthday is today
        else
        {
            Console.WriteLine("Your Birthday is today, Have a Blessed day!");
        }
    }
}