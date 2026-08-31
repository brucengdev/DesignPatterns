using Bridge.Models;

namespace Bridge.Implementation;

public class HTMLFormat : IDataFormat
{
    public string FormatExpense(Expense expense)
    {
        return $" <li>{expense.Category}: {expense.Amount}</li>\n";
    }

    public string FormatHeading(string heading)
    {
        return $"\n<h2>{heading}</h2>\n\n";
    }

    public string FormatIncome(Income income)
    {
        return $" <li>{income.Category}: +{income.Amount}</li>\n";
    }

    public string ListContainer(string itemsString)
    {
        return $"<ul>\n{itemsString}</ul>\n";
    }
}