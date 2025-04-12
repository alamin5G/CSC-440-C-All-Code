using System;

public class Publisher
{
    // Declare an event using a delegate
    public delegate void NotifyHandler(string message);
    public event NotifyHandler Notify;

    public void RaiseEvent()
    {
        // Raise the event if there are any subscribers
        Notify?.Invoke("Event has been triggered!");
    }
}

public class Subscriber
{
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Subscriber received: {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Subscribe to the event
        publisher.Notify += subscriber.HandleEvent;

        // Trigger the event
        publisher.RaiseEvent();
    }
}