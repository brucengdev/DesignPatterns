using Bridge.Models;

namespace Bridge.Implementation;

public interface IDataFormat
{
    string FormatExpense(Expense expense);
    string FormatHeading(string heading);
    string FormatIncome(Income income);

    string ListContainer(string itemsString);
}