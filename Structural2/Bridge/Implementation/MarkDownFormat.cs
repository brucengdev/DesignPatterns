using Bridge.Models;

namespace Bridge.Implementation;

public class MarkDownFormat : IDataFormat
{
    public string FormatExpense(Expense expense)
    {
        return $" - {expense.Category}: {expense.Amount}\n";
    }

    public string FormatHeading(string heading)
    {
        return $"\n## {heading}\n\n";
    }

    public string FormatIncome(Income income)
    {
        return $" - {income.Category}: +{income.Amount}\n";
    }

    public string ListContainer(string itemsString)
    {
        return itemsString;
    }
}