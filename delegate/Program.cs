using System;

public class Program
{
    // Declare a delegate
    public delegate void DisplayMessage(string message);

    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void ShowUppercaseMessage(string message)
    {
        Console.WriteLine(message.ToUpper());
    }

     public static void Main(string[] args)
    {
        // Instantiate the delegate
        DisplayMessage messageDelegate = ShowMessage;

        // Use the delegate to call the method
        messageDelegate("Hello, this is a delegate in action!");

        // Multicast: Adding another method
        messageDelegate += ShowUppercaseMessage;
        messageDelegate("Multicast delegate example");

        
        Worker w = new Worker();
        Manager m = new Manager();
        m.AssignWork(w.DoTask);
    }
}