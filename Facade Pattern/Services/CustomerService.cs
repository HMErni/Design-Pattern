namespace Facade_Pattern.Services;

public class CustomerService
{
    public void ProvideCustomerService(string customerName)
    {
        Console.WriteLine($"Providing customer service for {customerName}");
    }
}