using System;

public class Program {
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Input. Please enter a valid year");
            return;
        }
        int year = int.Parse(input);
        if ((year % 4 == 0 & year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}