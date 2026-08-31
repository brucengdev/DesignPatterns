using Builder.Models;

namespace Builder.Builders;

public interface IReportBuilder
{
    void BuildExpense(Expense expense);
    void BuildInvestment(Investment investment);
}