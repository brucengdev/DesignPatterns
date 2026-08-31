using System.Collections.ObjectModel;

namespace Adapter.ExpenseManager;

public class ExpenseManager
{
    private List<User> _users = new();
    public ReadOnlyCollection<User> Users => _users.AsReadOnly();
    public void LogExpense(User user, float amount)
    {
        if(!_users.Contains(user)) { return; }
        user.AddExpense(amount);
    }

    public void Add(User user)
    {
        _users.Add(user);
    }

}