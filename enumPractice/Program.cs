using System;



// Define an enumeration for the days of the week

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please enter a number between 1 and 5:");
        int input = int.Parse(Console.ReadLine());
        //print the enum value of the input number
        Console.WriteLine("The enum value of the input number is: " + (WeekDays)input);
    }
}