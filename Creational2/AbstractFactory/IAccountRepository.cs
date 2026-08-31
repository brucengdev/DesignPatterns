using AbstractFactory;

public interface IAccountRepository
{
    void Create(string userName, string accountName);
    Account? GetAccount(string username, string accountName);
    IReadOnlyList<Account> GetAccounts(string userName);
    void Update(Account account1);
}