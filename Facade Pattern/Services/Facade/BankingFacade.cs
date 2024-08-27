namespace Facade_Pattern.Services.Facade;

public class BankingFacade
{
    private readonly AccountManager _accountManager;
    private readonly LoanManager _loanManager;
    private readonly CustomerService _customerService;

    public BankingFacade(AccountManager accountManager, LoanManager loanManager, CustomerService customerService)
    {
        _accountManager = accountManager;
        _loanManager = loanManager;
        _customerService = customerService;
    }

    public void CreateAccount(string username, string password)
    {
        _accountManager.CreateAccount(username, password);
    }

    public void CheckBalance(string accountNumber)
    {
        _accountManager.CheckBalance(accountNumber);
    }

    public void ApplyForLoan(string customerName, double amount)
    {
        _loanManager.ApplyForLoan(customerName, amount);
    }

    public void CheckLoanStatus(string customerName)
    {
        _loanManager.CheckLoanStatus(customerName);
    }

    public void ProvideCustomerService(string customerName)
    {
        _customerService.ProvideCustomerService(customerName);
    }
}