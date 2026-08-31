using Builder.Builders;
using Builder.Models;

namespace Builder;

public class ReportMaker
{
    private IReportBuilder _builder;
    public ReportMaker(IReportBuilder builder)
    {
        _builder = builder;
    }

    internal void MakeReport(Report data)
    {
        foreach(var entry in data.Entries)
        {
            if(entry is Investment investment)
            {
                _builder.BuildInvestment(investment);
            }
            if(entry is Expense expense)
            {
                _builder.BuildExpense(expense);
            }
        }
    }
}