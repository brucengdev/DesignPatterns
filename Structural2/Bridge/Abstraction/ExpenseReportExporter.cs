using System.Text;
using Bridge;
using Bridge.Implementation;
using Bridge.Models;

public class ExpenseReportExporter : ReportExporter
{
    public ExpenseReportExporter(IDataFormat dataFormat) : base(dataFormat)
    {
    }

    internal override string Export(FinancialReport report)
    {
        var sb = new StringBuilder();
        sb.Append(FormatHeading("Expenses"));
        sb.Append(ListContainer(string.Join("", report.Expenses.Select(FormatExpense))));
        return sb.ToString();
    }
}