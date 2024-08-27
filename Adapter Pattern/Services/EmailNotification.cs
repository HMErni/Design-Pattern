using AdapterPattern.Interfaces;

namespace AdapterPattern.Services;

public class EmailNotification
{
    public void SendEmail(string recipient, string message)
    {
        Console.WriteLine($"To: {recipient}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("Sent via Email");
    }
}