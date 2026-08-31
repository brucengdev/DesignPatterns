using System.Text;
using Builder.Models;

namespace Builder.Builders;

public class InvestmentHTMLBuilder : IReportBuilder
{
    private StringBuilder _result = new();

    public void BuildExpense(Expense expense)
    {
        //Since this is an investment report, expenses are ignored
    }

    public void BuildInvestment(Investment investment)
    {
        _result.Append($"<td class='green'>{investment.Category.ToString()}: +{-investment.Amount}</td>\n");
    }

    internal string GetHTMLResult()
    {
        return "<table>\n" + _result.ToString() + "</table>";
    }
}