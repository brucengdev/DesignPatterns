using System.Text;
using Bridge.Implementation;
using Bridge.Models;

namespace Bridge;

public abstract class ReportExporter
{
    private IDataFormat _dataFormat;

    public ReportExporter(IDataFormat dataFormat)
    {
        _dataFormat = dataFormat;
    }

    protected string FormatHeading(string heading) => _dataFormat.FormatHeading(heading);
    protected string FormatExpense(Expense expense) => _dataFormat.FormatExpense(expense);
    protected string FormatIncome(Income income) => _dataFormat.FormatIncome(income);

    protected string ListContainer(string itemsString) => _dataFormat.ListContainer(itemsString);

    internal abstract string Export(FinancialReport report);

    internal void SetFormat(IDataFormat dataFormat)
    {
        _dataFormat = dataFormat;
    }
}