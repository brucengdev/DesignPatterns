using System.Text;
using Builder.Models;

namespace Builder.Builders;

public class ExpenseHTMLBuilder : IReportBuilder
{
    private StringBuilder _result = new();

    public void BuildExpense(Expense expense)
    {
        _result.Append($"<td class='red'>{expense.Description}: {expense.Amount}</td>\n");
    }

    public void BuildInvestment(Investment investment)
    {
        //Since this is an expense report, investments are ignored
    }

    internal string GetHTMLResult()
    {
        return "<table>\n" + _result.ToString() + "</table>";
    }
}