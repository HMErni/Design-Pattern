using Facade_Pattern.Services;
using Facade_Pattern.Services.Facade;

namespace Facade_Pattern;

public class Program
{
    public static void Main()
    {

        var accountManager = new AccountManager();
        var loanManager = new LoanManager();
        var customerService = new CustomerService();

        var bankingFacade = new BankingFacade(accountManager, loanManager, customerService);

        bankingFacade.CreateAccount("John", "123456");
        bankingFacade.CheckBalance("123456");
        bankingFacade.ApplyForLoan("John", 69696.69);
        bankingFacade.CheckLoanStatus("John");
        bankingFacade.ProvideCustomerService("John");
    }
}