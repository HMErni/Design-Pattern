namespace Facade_Pattern.Services;

public class LoanManager
{
    public void ApplyForLoan(string customerName, double amount)
    {
        Console.WriteLine($"{customerName} applying for a loan of {amount}");
    }

    public void CheckLoanStatus(string customerName)
    {
        Console.WriteLine($"Checking loan status for {customerName}");
    }
}