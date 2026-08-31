namespace AbstractFactory.FileSystemRepo;

public class FileSystemAccountRepository : IAccountRepository
{
    public void Create(string userName, string accountName)
    {
        WriteAccount(new Account(userName, accountName));
    }

    public Account? GetAccount(string username, string accountName)
    {
        var fileName = $"data{Path.DirectorySeparatorChar}{username}-{accountName}.txt";
        if(!File.Exists(fileName)) { return null; }
        return LoadAccount(fileName);
    }

    private Account LoadAccount(string filePath)
    {
        var parts = filePath.Split(Path.DirectorySeparatorChar).Last().Split(".")[0].Split("-");
        var username = parts[0];
        var accountName = parts[1];

        var content = File.ReadAllText(filePath);
        var acc = new Account(username, accountName)
        {
            Balance = Convert.ToInt32(content)
        };
        return acc;
    }

    public IReadOnlyList<Account> GetAccounts(string userName)
    {
        var files = Directory.GetFiles("data", $"{userName}-*.txt");
        return files.Select(LoadAccount).ToList().AsReadOnly();
    }

    public void Update(Account account)
    {
        WriteAccount(account);
    }

    private void WriteAccount(Account account)
    {
        var filePath = $"data{Path.DirectorySeparatorChar}{account.Username}-{account.AccountName}.txt";
        File.WriteAllText(filePath, account.Balance.ToString());
    }
}