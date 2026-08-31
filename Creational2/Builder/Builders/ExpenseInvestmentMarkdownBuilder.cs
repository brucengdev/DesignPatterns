using System.Text;
using Builder.Models;

namespace Builder.Builders;

public class ExpenseInvestmentMarkdownBuilder : IReportBuilder
{
    private StringBuilder _expense = new();
    private StringBuilder _investment = new();

    public void BuildExpense(Expense expense)
    {
        _expense.Append($" - {expense.Description}: {expense.Amount}\n");
    }

    public void BuildInvestment(Investment investment)
    {
        _investment.Append($" - {investment.Category.ToString()}: +{-investment.Amount}\n");
    }

    internal string GetMarkDownResult()
    {
        return "Expenses:\n" + _expense.ToString() + "\nInvestments:\n" + _investment.ToString();
    }
}