using AdapterPattern.Interfaces;
using AdapterPattern.Services;

public class Program
{
    public static void Main(string[] args)
    {
        INotification smsNotification = new SMSNotificationService();
        smsNotification.Notify("+919876543210", "Hello World!");


        Console.WriteLine();

        EmailNotifactionService emailNotifactionService = new EmailNotifactionService();
        INotification emailNotifcation = new EmailNotificationAdapter(emailNotifactionService);
        emailNotifcation.Notify("test@gmail.com", "Hello World!");


    }
}