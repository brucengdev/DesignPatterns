using System.Text;
using Bridge;
using Bridge.Implementation;
using Bridge.Models;

public class ExpenseIncomeReportExporter : ReportExporter
{
    public ExpenseIncomeReportExporter(IDataFormat dataFormat) : base(dataFormat)
    {
    }

    internal override string Export(FinancialReport report)
    {
        var sb = new StringBuilder();
        sb.Append(FormatHeading("Expenses"));
        sb.Append(ListContainer(string.Join("", report.Expenses.Select(FormatExpense))));

        sb.Append(FormatHeading("Income"));

        sb.Append(ListContainer(string.Join("", report.Income.Select(FormatIncome))));
        return sb.ToString();
    }
}