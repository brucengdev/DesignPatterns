namespace AbstractFactory;

public class InMemAccountRepository : IAccountRepository
{
    private List<Account> Accounts = new();

    public void Create(string userName, string accountName)
    {
        Accounts.Add(new Account(userName, accountName));
    }

    public void Deposit(string username, string accountName, int amount)
    {
        var account = Accounts.FirstOrDefault(acc => acc.Username == username 
            && acc.AccountName == accountName);
        if(account == default) { return; }
        account.Balance += amount;
    }

    public Account? GetAccount(string username, string accountName)
    {
        return Accounts.FirstOrDefault(a => a.Username == username 
            && a.AccountName == accountName);
    }

    public IReadOnlyList<Account> GetAccounts(string userName)
    {
        return Accounts.Where(a => a.Username == userName)
            .OrderBy(a => a.Username)
            .ThenBy(a => a.AccountName)
            .ToList().AsReadOnly();
    }

    public void Update(Account account)
    {
        var index = Accounts.FindIndex(acc => acc.Username == account.Username
            && acc.AccountName == account.AccountName);
        if(index < 0) { return ;}
        Accounts[index] = account;
    }
}