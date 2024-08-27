namespace Facade_Pattern.Services;

public class AccountManager
{
    public void CreateAccount(string username, string password)
    {
        Console.WriteLine($"Creating account for {username}");
    }

    public void CheckBalance(string accountNumber)
    {
        Console.WriteLine($"Checking balance for {accountNumber}");
    }
}