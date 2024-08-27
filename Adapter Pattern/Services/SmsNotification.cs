using AdapterPattern.Interfaces;

namespace AdapterPattern.Services;

public class SMSNotification : INotification
{
    public void Notify(string recipient, string message)
    {
        Console.WriteLine($"To: {recipient}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("Sent via SMS");
    }
}