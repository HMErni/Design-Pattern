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
        _emailNotificationService.SendEmail(recipient, message);
    }
}
