namespace AbstractFactory;

public class Account
{
    private string _userName;
    public string Username => _userName;
    private string _accountName;
    public string AccountName => _accountName;
    public int Balance {get; set;} = 0;

    public Account(string userName, string accountName)
    {
        _userName = userName;
        _accountName = accountName;
    }
}