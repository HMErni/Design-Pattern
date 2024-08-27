namespace AdapterPattern.Services;

public class PushNotification
{
    public void SendPushNotification(string device, string message)
    {
        Console.WriteLine($"To: {device}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("Sent via Push Notification");
    }
}