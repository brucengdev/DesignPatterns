namespace Bridge.Models;

public class FinancialReport
{
    public List<Expense> Expenses {get; set;} = new();
    public List<Income> Income {get; set;} = new();
}