using AdapterPattern.Interfaces;

namespace AdapterPattern.Services.Adapters;

public class PushNotificationAdapter : INotification
{
    private readonly PushNotification _pushNotificationService;

    public PushNotificationAdapter(PushNotification pushNotificationService)
    {
        _pushNotificationService = pushNotificationService;
    }

    public void Notify(string recipient, string message)
    {
        _pushNotificationService.SendPushNotification(recipient, message);
    }
}