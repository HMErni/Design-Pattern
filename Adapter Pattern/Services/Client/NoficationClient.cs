using AdapterPattern.Interfaces;

namespace AdapterPattern.Services;

public class NoficationClient
{

    private readonly INotification _notification;

    public NoficationClient(INotification notification)
    {
        _notification = notification;
    }

    public void Notify(string recipient, string message)
    {
        _notification.Notify(recipient, message);
    }
}