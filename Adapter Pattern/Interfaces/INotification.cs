namespace AdapterPattern.Interfaces
{
    public interface INotification
    {
        void Notify(string recipient, string message);
    }
}