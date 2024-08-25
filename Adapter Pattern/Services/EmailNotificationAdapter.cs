using AdapterPattern.Interfaces;

namespace AdapterPattern.Services;

public class EmailNotificationAdapter : INotification
{

    private readonly EmailNotifactionService _emailNotifactionService;

    public EmailNotificationAdapter(EmailNotifactionService emailNotifactionService)
    {
        _emailNotifactionService = emailNotifactionService;
    }

    public void Notify(string recipient, string message)
    {
        string subject = "Email Notification";
        _emailNotifactionService.SendEmail(recipient, subject, message);
    }
}