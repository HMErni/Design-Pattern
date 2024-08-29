using AdapterPattern.Interfaces;

namespace AdapterPattern.Services.Adapters;

public class EmailNotificationAdapter : INotification
{

    private readonly EmailNotification _emailNotificationService;

    public EmailNotificationAdapter(EmailNotification emailNotificationService)
    {
        _emailNotificationService = emailNotificationService;
    }

    public void Notify(string recipient, string message)
    {
        string subject = "Notification";
        _emailNotificationService.SendEmail(recipient, subject, message);
    }
}
