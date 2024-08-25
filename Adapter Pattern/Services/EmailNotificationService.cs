namespace AdapterPattern.Services;

public class EmailNotifactionService
{
    public void SendEmail(string recipient, string subject, string message)
    {
        Console.WriteLine($"To: {recipient}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
    }
}