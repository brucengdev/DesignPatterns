namespace Adapter.ExpenseManager;

public class User
{
    public string ID { get; set; }
    public string Occupation { get; set; }

    public virtual string ContactNumber {get; set;}

    private List<Expense> _expenses = new();
    public void AddExpense(float amount)
    {
        _expenses.Add(new()
        {
            Amount = amount
        });
    }
    public List<Expense> GetExpenses() => _expenses;
}