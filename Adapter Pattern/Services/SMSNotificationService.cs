using AdapterPattern.Interfaces;

namespace AdapterPattern.Services;

public class SMSNotificationService : INotification
{
    public void Notify(string recipient, string message)
    {
        Console.WriteLine($"To: {recipient}");
        Console.WriteLine($"Message: {message}");
    }
}