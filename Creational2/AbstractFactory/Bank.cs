namespace AbstractFactory;
public class Bank
{
    private IAccountRepository _accountRepo;
    private IUserRepository _userRepo;
    public Bank(IRepoFactory factory)
    {
        _userRepo = factory.CreateUserRepository();
        _accountRepo = factory.CreateAccountRepository();
    }

    internal void CreateAccount(string userName, string accountName)
    {
        _accountRepo.Create(userName, accountName);
    }

    internal void CreateUser(string name, int age)
    {
        _userRepo.Create(name, age);
    }

    internal void Deposit(string username, string accountName, int amount)
    {
        var account = _accountRepo.GetAccount(username, accountName);
        if(account == null) { return; }
        account.Balance += amount;
        _accountRepo.Update(account);
    }

    internal IReadOnlyList<Account> GetAccounts(string userName)
    {
        return _accountRepo.GetAccounts(userName);
    }

    internal int GetBalance(string username, string accountName)
    {
        return _accountRepo.GetAccount(username, accountName)?.Balance ?? 0;
    }

    internal IList<User> GetUsers()
    {
        return _userRepo.GetUsers();
    }

    internal void Transfer(string username1, string accountName1, string username2, string accountName2, int amount)
    {
        var account1 = _accountRepo.GetAccount(username1, accountName1);
        var account2 = _accountRepo.GetAccount(username2, accountName2);
        if(account1 == null || account2 == null) { return; }
        account1.Balance -= amount;
        account2.Balance += amount;
        _accountRepo.Update(account1);
        _accountRepo.Update(account2);
    }
}