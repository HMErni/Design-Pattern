using AdapterPattern.Interfaces;
using AdapterPattern.Services;
using AdapterPattern.Services.Adapters;

public class Program
{
    public static void Main(string[] args)
    {

        var emailNotificationService = new EmailNotification();
        var smsNotificationService = new SMSNotification();
        var pushNotificationService = new PushNotification();

        var emailNotificationAdapter = new EmailNotificationAdapter(emailNotificationService);
        var pushNotificationAdapter = new PushNotificationAdapter(pushNotificationService);

        var smsClient = new NoficationClient(smsNotificationService);
        smsClient.Notify("+919876543210", "Hello World");
        Console.WriteLine();

        var emailClient = new NoficationClient(emailNotificationAdapter);
        emailClient.Notify("test@test.com", "Hello World");
        Console.WriteLine();

        var pushClient = new NoficationClient(pushNotificationAdapter);
        pushClient.Notify("Bruh's Device", "Hello World");
        Console.WriteLine();

    }
}